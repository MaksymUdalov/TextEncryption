using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace TextSecurity
{
    public partial class Form1 : Form
    {
        string notebookPath = string.Empty;
        DataGridView dgv = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Load_Form(object sender, EventArgs e)
        {
            txtBKeyLength.MaxLength = 1;
            txtBKeyLengthPage2.MaxLength = 2;
            txtBKeyLengthPage3.MaxLength = 1;
            timerForAnimation.Tick += delegate (object sen, EventArgs eArg)
            {
                Label currentLabel = ((sen as Timer).Tag as Label);
                currentLabel.Visible = !currentLabel.Visible;
            };
        }

        private new void KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 59 || e.KeyChar <= 47) && e.KeyChar != 8)
                e.Handled = true;

        }
        private DataGridView CreateDataGridView(TextBox textBKey)
        {
            if (dgv != null)
                dgv.Dispose();
            dgv = new DataGridView();
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AllowUserToOrderColumns = false;
            dgv.AllowDrop = true;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            for (int i = 0; i < int.Parse(textBKey.Text); i++)
            {
                dgv.Columns.Add(string.Format("Col{0}", i), i.ToString());
            }
            dgv.Size = new Size(int.Parse(textBKey.Text) * 50, 45);
            //позиция
            dgv.Location = new Point(45, 92);
            dgv.Rows.Add(1);
            return dgv;
        }
        private void Dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(Dgv_KeyPress);
        }
        private void Dgv_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = e.KeyChar == 8 ? false : ((sender as TextBox).Text.Length < 1 && char.IsDigit(e.KeyChar) && (dgv.ColumnCount > int.Parse(e.KeyChar.ToString()))) ? false : true;
        }
        private void butShowResult_Click(object sender, EventArgs e)
        {
           FileManager.ShowFile((sender as Button).Tag.ToString());
        }


        #region PermitionPage
        private void btnShowKey_Click(object sender, EventArgs e)
        {
            if (txtBKeyLength.Text == string.Empty)
            {
                MessageBox.Show("Значение должно быть в диапазоне [3,9]", "Не правльные данные");
                return;
            }

            if (int.Parse(txtBKeyLength.Text) >= 3)
            {
                DataGridView dgv = CreateDataGridView(txtBKeyLength);
                FirstPage.Controls.Add(dgv);
                dgv.EditingControlShowing += Dgv_EditingControlShowing;
                btnCoding.Visible = true;
                btnDecoding.Visible = true;
            }
            else
                MessageBox.Show("Значение должно быть в диапазоне [3,9]", "Не правельные данные");
            butShowResult.Visible = false;
            timerForAnimation.Enabled = false;
            labForAnimation.Visible = false;
        }
        private void btnCoding_Click(object sender, EventArgs e)
        {
            butShowResult.Visible = false;
            timerForAnimation.Enabled = false;
            labForAnimation.Visible = false;
            List<byte> key = new List<byte>();
            bool goodKey = true;
            try
            {
                for (int i = 0; i < dgv.ColumnCount; i++)
                {
                    key.Add(byte.Parse(dgv.CurrentRow.Cells[i].Value.ToString()));
                    if (key.Count(x => key[i] == x) >= 2)
                        goodKey = false;
                }
            }
            catch { goodKey = false; }
            if (!goodKey)
                MessageBox.Show("Заполните все ячейки разными значениями", "Не правльные данные");
            else
            {
                TranspositionCoding currentCoding = new TranspositionCoding(key);
                string resultSource = string.Empty;
                try
                {
                    resultSource = ((sender as Button).Text == "Кодирование") ? currentCoding.Encrypt() : currentCoding.Decrypt();
                }
                catch (NotImplementedException) { return; }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                foreach (var label in FirstPage.Controls.OfType<Label>())
                            if (label.Name == (sender as Button).Tag.ToString())
                                timerForAnimation.Tag = label;

                        timerForAnimation.Enabled = true;
                        butShowResult.Visible = true;
                        butShowResult.Tag = resultSource;
            }
        }
        #endregion

        #region CaeserPage
        private void btnCodingPage2_Click(object sender, EventArgs e)
        {
            timerForAnimation.Enabled = false;
            butShowResultPage2.Visible = false;
            labForAnimationPage2.Visible = false;
            if (int.Parse(txtBKeyLengthPage2.Text) > 0 && int.Parse(txtBKeyLengthPage2.Text) <= 32)
            {
                CaeserCoding caeser = new CaeserCoding(int.Parse(txtBKeyLengthPage2.Text));
                string resultSource = string.Empty;
                try
                {
                     resultSource = ((sender as Button).Text == "Кодирование") ? caeser.Encrypt() :
                                caeser.Decrypt();
                }
                catch (NotImplementedException) { return; }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                    labForAnimationPage2.Visible = true;

                    foreach (var label in SecondPage.Controls.OfType<Label>())
                        if (label.Name == (sender as Button).Tag.ToString())
                            timerForAnimation.Tag = label;

                    timerForAnimation.Enabled = true;
                    butShowResultPage2.Visible = true;
                    butShowResultPage2.Tag = resultSource;
            }
            else
                MessageBox.Show("Значение должно быть в диапазоне [1,32]", "Не правльные данные");
        }
        #endregion

        #region VigenerePage
        private void btnShowKeyPage3_Click(object sender, EventArgs e)
        {
            if (txtBKeyLengthPage3.Text == string.Empty)
            {
                MessageBox.Show("Значение должно быть в диапазоне [2,9]", "Не правльные данные");
                return;
            }
            if (int.Parse(txtBKeyLengthPage3.Text) >= 2)
            {
                DataGridView dgvPage3 = CreateDataGridView(txtBKeyLengthPage3);
                this.ThreethPage.Controls.Add(dgvPage3);

                dgvPage3.EditingControlShowing += (sen, eArg) =>
                {
                    TextBox tb = (TextBox)eArg.Control;
                    tb.KeyPress += new KeyPressEventHandler(Dgv_KeyPressPage3);
                };
                btnDecodingPage3.Visible = true;
                btnCodingPage3.Visible = true;
            }
            else
                MessageBox.Show("Значение должно быть в диапазоне [2,9]", "Не правильные данные");
            butShowResultPage3.Visible = false;
            timerForAnimation.Enabled = false;
            labForAnimationPage3.Visible = false;
        }
        private void txtBKeyLengthPage3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = (e.KeyChar >= 59 || e.KeyChar <= 47) && e.KeyChar != 8 ? true : false;
        }
        private void Dgv_KeyPressPage3(object sender, KeyPressEventArgs e)
        {

            e.Handled = (sender as TextBox).Text.Length < 1 ? false : e.KeyChar == 8 ? false : true;
        }
        private void btnCodingPage3_Click(object sender, EventArgs e)
        {
            butShowResultPage3.Visible = false;
            timerForAnimation.Enabled = false;
            labForAnimationPage3.Visible = false;
            List<char> key = new List<char>();
            bool goodKey = true;
            try
            {
                for (int i = 0; i < dgv.ColumnCount; i++)
                    key.Add(dgv.CurrentRow.Cells[i].Value.ToString().First());
            }
            catch { goodKey = false; }
            if (!goodKey)
            {
                MessageBox.Show("Заполните все ячейки разными значениями", "Не правильные данные");
                labForAnimation.Visible = false;
            }
            else
            {
                VigenereCoding vigenere = new VigenereCoding(key);
                string resultSource = null;
                try
                {
                    resultSource = ((sender as Button).Text == "Кодирование") ? vigenere.Encrypt() : vigenere.Decrypt();
                }
                catch (NotImplementedException) { return; }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                foreach (var label in this.ThreethPage.Controls.OfType<Label>())
                        if (label.Name == (sender as Button).Tag.ToString())
                            timerForAnimation.Tag = label;

                    timerForAnimation.Enabled = true;
                    butShowResultPage3.Visible = true;
                    butShowResultPage3.Tag = resultSource;
            }
        }
        #endregion

        #region NotebookPage
        private void btnShowKey4_Click(object sender, EventArgs e)
        {
            butShowResultPage4.Visible = false;
            timerForAnimation.Enabled = false;
            labForAnimationPage4.Visible = false;
            try
            {
                notebookPath = FileManager.OpenFile();
            }
            catch (NotImplementedException) { return; }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
            labCurrentKey.Text = string.Format("Текущий ключ : {0}", new FileInfo(notebookPath).Name);
            labCurrentKey.Visible = true;
            btnCodingPage4.Visible = true;
            btnDecodingPage4.Visible = true;
        }
        private void btnCodingPage4_Click(object sender, EventArgs e)
        {
            butShowResultPage4.Visible = false;
            timerForAnimation.Enabled = false;
            labForAnimationPage4.Visible = false;

            NotebookCoding notebook = new NotebookCoding(notebookPath);
            string resultSource = string.Empty;
            try
            {
                resultSource = ((sender as Button).Text == "Кодирование") ? notebook.Encrypt() : notebook.Decrypt();
            }
            catch (NotImplementedException) { return; }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            foreach (var label in this.FourthPage.Controls.OfType<Label>())
                if (label.Name == (sender as Button).Tag.ToString())
                    timerForAnimation.Tag = label;

            timerForAnimation.Enabled = true;
            butShowResultPage4.Visible = true;
            butShowResultPage4.Tag = resultSource;
        }
        #endregion

        #region XORPage
        private void btnCodingPage5_Click(object sender, EventArgs e)
        {
            butShowResultPage5.Visible = false;
            timerForAnimation.Enabled = false;
            labForAnimationPage5.Visible = false;

            XORCoding xor = new XORCoding();
            xor.KeyPath = notebookPath != null ? notebookPath : string.Empty;
            string resultSource = string.Empty;
            try
            {
                resultSource = ((sender as Button).Text == "Декодирование" && notebookPath != string.Empty) ? xor.Decrypt() : xor.Encrypt();
            }
            catch (NotImplementedException) { return; }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
                foreach (var label in this.FifthPage.Controls.OfType<Label>())
                    if (label.Name == (sender as Button).Tag.ToString())
                        timerForAnimation.Tag = label;

                timerForAnimation.Enabled = true;
                butShowResultPage5.Visible = true;
                butShowResultPage5.Tag = resultSource;
        }
        private void btnShowKey5_Click(object sender, EventArgs e)
        {
            butShowResultPage5.Visible = false;
            timerForAnimation.Enabled = false;
            labForAnimationPage5.Visible = false;

            try
            {
                notebookPath = FileManager.OpenFile();
            }
            catch (NotImplementedException) { return; }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            labCurrentKeyPage5.Text = string.Format("Текущий ключ : {0}", new FileInfo(notebookPath).Name);
            labCurrentKeyPage5.Visible = true;
            btnDecodingPage5.Visible = true;
        }
        #endregion
    }
}
