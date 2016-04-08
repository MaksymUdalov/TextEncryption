namespace TextSecurity
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mainControl = new System.Windows.Forms.TabControl();
            this.FirstPage = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butShowResult = new System.Windows.Forms.Button();
            this.labForAnimation = new System.Windows.Forms.Label();
            this.btnDecoding = new System.Windows.Forms.Button();
            this.btnCoding = new System.Windows.Forms.Button();
            this.btnShowKey = new System.Windows.Forms.Button();
            this.txtBKeyLength = new System.Windows.Forms.TextBox();
            this.labKeyLengthPageOne = new System.Windows.Forms.Label();
            this.SecondPage = new System.Windows.Forms.TabPage();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.butShowResultPage2 = new System.Windows.Forms.Button();
            this.labForAnimationPage2 = new System.Windows.Forms.Label();
            this.btnDecodingPage2 = new System.Windows.Forms.Button();
            this.btnCodingPage2 = new System.Windows.Forms.Button();
            this.txtBKeyLengthPage2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ThreethPage = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.butShowResultPage3 = new System.Windows.Forms.Button();
            this.labForAnimationPage3 = new System.Windows.Forms.Label();
            this.btnDecodingPage3 = new System.Windows.Forms.Button();
            this.btnCodingPage3 = new System.Windows.Forms.Button();
            this.btnShowKeyPage3 = new System.Windows.Forms.Button();
            this.txtBKeyLengthPage3 = new System.Windows.Forms.TextBox();
            this.labTextPage3 = new System.Windows.Forms.Label();
            this.FourthPage = new System.Windows.Forms.TabPage();
            this.labCurrentKey = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.butShowResultPage4 = new System.Windows.Forms.Button();
            this.labForAnimationPage4 = new System.Windows.Forms.Label();
            this.btnDecodingPage4 = new System.Windows.Forms.Button();
            this.btnCodingPage4 = new System.Windows.Forms.Button();
            this.btnShowKey4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.FifthPage = new System.Windows.Forms.TabPage();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labCurrentKeyPage5 = new System.Windows.Forms.Label();
            this.btnShowKey5 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.butShowResultPage5 = new System.Windows.Forms.Button();
            this.labForAnimationPage5 = new System.Windows.Forms.Label();
            this.btnDecodingPage5 = new System.Windows.Forms.Button();
            this.btnCodingPage5 = new System.Windows.Forms.Button();
            this.timerForAnimation = new System.Windows.Forms.Timer(this.components);
            this.mainControl.SuspendLayout();
            this.FirstPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SecondPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.ThreethPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.FourthPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.FifthPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // mainControl
            // 
            this.mainControl.Controls.Add(this.FirstPage);
            this.mainControl.Controls.Add(this.SecondPage);
            this.mainControl.Controls.Add(this.ThreethPage);
            this.mainControl.Controls.Add(this.FourthPage);
            this.mainControl.Controls.Add(this.FifthPage);
            this.mainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainControl.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mainControl.Location = new System.Drawing.Point(0, 0);
            this.mainControl.Margin = new System.Windows.Forms.Padding(0);
            this.mainControl.Multiline = true;
            this.mainControl.Name = "mainControl";
            this.mainControl.Padding = new System.Drawing.Point(0, 0);
            this.mainControl.SelectedIndex = 0;
            this.mainControl.Size = new System.Drawing.Size(787, 449);
            this.mainControl.TabIndex = 0;
            // 
            // FirstPage
            // 
            this.FirstPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FirstPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FirstPage.Controls.Add(this.pictureBox1);
            this.FirstPage.Controls.Add(this.butShowResult);
            this.FirstPage.Controls.Add(this.labForAnimation);
            this.FirstPage.Controls.Add(this.btnDecoding);
            this.FirstPage.Controls.Add(this.btnCoding);
            this.FirstPage.Controls.Add(this.btnShowKey);
            this.FirstPage.Controls.Add(this.txtBKeyLength);
            this.FirstPage.Controls.Add(this.labKeyLengthPageOne);
            this.FirstPage.Location = new System.Drawing.Point(4, 25);
            this.FirstPage.Margin = new System.Windows.Forms.Padding(0);
            this.FirstPage.Name = "FirstPage";
            this.FirstPage.Size = new System.Drawing.Size(779, 420);
            this.FirstPage.TabIndex = 0;
            this.FirstPage.Text = "Метод перестановок";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(536, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 196);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // butShowResult
            // 
            this.butShowResult.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butShowResult.Location = new System.Drawing.Point(210, 360);
            this.butShowResult.Name = "butShowResult";
            this.butShowResult.Size = new System.Drawing.Size(158, 32);
            this.butShowResult.TabIndex = 6;
            this.butShowResult.Text = "Открыть файл!";
            this.butShowResult.UseVisualStyleBackColor = true;
            this.butShowResult.Visible = false;
            this.butShowResult.Click += new System.EventHandler(this.butShowResult_Click);
            // 
            // labForAnimation
            // 
            this.labForAnimation.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labForAnimation.ForeColor = System.Drawing.Color.ForestGreen;
            this.labForAnimation.Location = new System.Drawing.Point(104, 237);
            this.labForAnimation.Name = "labForAnimation";
            this.labForAnimation.Size = new System.Drawing.Size(392, 102);
            this.labForAnimation.TabIndex = 5;
            this.labForAnimation.Text = "Процесс завершен. Файл создан.";
            this.labForAnimation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labForAnimation.Visible = false;
            // 
            // btnDecoding
            // 
            this.btnDecoding.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecoding.Location = new System.Drawing.Point(338, 158);
            this.btnDecoding.Name = "btnDecoding";
            this.btnDecoding.Size = new System.Drawing.Size(158, 32);
            this.btnDecoding.TabIndex = 4;
            this.btnDecoding.Tag = "labForAnimation";
            this.btnDecoding.Text = "Декодирование";
            this.btnDecoding.UseVisualStyleBackColor = true;
            this.btnDecoding.Visible = false;
            this.btnDecoding.Click += new System.EventHandler(this.btnCoding_Click);
            // 
            // btnCoding
            // 
            this.btnCoding.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCoding.Location = new System.Drawing.Point(45, 158);
            this.btnCoding.Name = "btnCoding";
            this.btnCoding.Size = new System.Drawing.Size(158, 32);
            this.btnCoding.TabIndex = 3;
            this.btnCoding.Tag = "labForAnimation";
            this.btnCoding.Text = "Кодирование";
            this.btnCoding.UseVisualStyleBackColor = true;
            this.btnCoding.Visible = false;
            this.btnCoding.Click += new System.EventHandler(this.btnCoding_Click);
            // 
            // btnShowKey
            // 
            this.btnShowKey.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowKey.Location = new System.Drawing.Point(347, 40);
            this.btnShowKey.Name = "btnShowKey";
            this.btnShowKey.Size = new System.Drawing.Size(75, 24);
            this.btnShowKey.TabIndex = 2;
            this.btnShowKey.Text = "ОК";
            this.btnShowKey.UseVisualStyleBackColor = true;
            this.btnShowKey.Click += new System.EventHandler(this.btnShowKey_Click);
            // 
            // txtBKeyLength
            // 
            this.txtBKeyLength.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBKeyLength.Location = new System.Drawing.Point(277, 41);
            this.txtBKeyLength.Name = "txtBKeyLength";
            this.txtBKeyLength.Size = new System.Drawing.Size(44, 27);
            this.txtBKeyLength.TabIndex = 1;
            this.txtBKeyLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // labKeyLengthPageOne
            // 
            this.labKeyLengthPageOne.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labKeyLengthPageOne.Location = new System.Drawing.Point(42, 42);
            this.labKeyLengthPageOne.Name = "labKeyLengthPageOne";
            this.labKeyLengthPageOne.Size = new System.Drawing.Size(215, 23);
            this.labKeyLengthPageOne.TabIndex = 0;
            this.labKeyLengthPageOne.Text = "Введите длину ключа :";
            // 
            // SecondPage
            // 
            this.SecondPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SecondPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SecondPage.Controls.Add(this.pictureBox2);
            this.SecondPage.Controls.Add(this.butShowResultPage2);
            this.SecondPage.Controls.Add(this.labForAnimationPage2);
            this.SecondPage.Controls.Add(this.btnDecodingPage2);
            this.SecondPage.Controls.Add(this.btnCodingPage2);
            this.SecondPage.Controls.Add(this.txtBKeyLengthPage2);
            this.SecondPage.Controls.Add(this.label1);
            this.SecondPage.Location = new System.Drawing.Point(4, 25);
            this.SecondPage.Name = "SecondPage";
            this.SecondPage.Padding = new System.Windows.Forms.Padding(3);
            this.SecondPage.Size = new System.Drawing.Size(779, 420);
            this.SecondPage.TabIndex = 1;
            this.SecondPage.Text = "Метод Цезаря";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(557, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(198, 254);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // butShowResultPage2
            // 
            this.butShowResultPage2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butShowResultPage2.Location = new System.Drawing.Point(191, 346);
            this.butShowResultPage2.Name = "butShowResultPage2";
            this.butShowResultPage2.Size = new System.Drawing.Size(158, 32);
            this.butShowResultPage2.TabIndex = 8;
            this.butShowResultPage2.Text = "Открыть файл!";
            this.butShowResultPage2.UseVisualStyleBackColor = true;
            this.butShowResultPage2.Visible = false;
            this.butShowResultPage2.Click += new System.EventHandler(this.butShowResult_Click);
            // 
            // labForAnimationPage2
            // 
            this.labForAnimationPage2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labForAnimationPage2.ForeColor = System.Drawing.Color.ForestGreen;
            this.labForAnimationPage2.Location = new System.Drawing.Point(87, 213);
            this.labForAnimationPage2.Name = "labForAnimationPage2";
            this.labForAnimationPage2.Size = new System.Drawing.Size(392, 102);
            this.labForAnimationPage2.TabIndex = 7;
            this.labForAnimationPage2.Text = "Процесс завершен. Файл создан.";
            this.labForAnimationPage2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labForAnimationPage2.Visible = false;
            // 
            // btnDecodingPage2
            // 
            this.btnDecodingPage2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecodingPage2.Location = new System.Drawing.Point(321, 132);
            this.btnDecodingPage2.Name = "btnDecodingPage2";
            this.btnDecodingPage2.Size = new System.Drawing.Size(158, 32);
            this.btnDecodingPage2.TabIndex = 5;
            this.btnDecodingPage2.Tag = "labForAnimationPage2";
            this.btnDecodingPage2.Text = "Декодирование";
            this.btnDecodingPage2.UseVisualStyleBackColor = true;
            this.btnDecodingPage2.Click += new System.EventHandler(this.btnCodingPage2_Click);
            // 
            // btnCodingPage2
            // 
            this.btnCodingPage2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCodingPage2.Location = new System.Drawing.Point(45, 132);
            this.btnCodingPage2.Name = "btnCodingPage2";
            this.btnCodingPage2.Size = new System.Drawing.Size(158, 32);
            this.btnCodingPage2.TabIndex = 4;
            this.btnCodingPage2.Tag = "labForAnimationPage2";
            this.btnCodingPage2.Text = "Кодирование";
            this.btnCodingPage2.UseVisualStyleBackColor = true;
            this.btnCodingPage2.Click += new System.EventHandler(this.btnCodingPage2_Click);
            // 
            // txtBKeyLengthPage2
            // 
            this.txtBKeyLengthPage2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBKeyLengthPage2.Location = new System.Drawing.Point(242, 41);
            this.txtBKeyLengthPage2.Name = "txtBKeyLengthPage2";
            this.txtBKeyLengthPage2.Size = new System.Drawing.Size(43, 27);
            this.txtBKeyLengthPage2.TabIndex = 1;
            this.txtBKeyLengthPage2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите смещение:";
            // 
            // ThreethPage
            // 
            this.ThreethPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ThreethPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ThreethPage.Controls.Add(this.pictureBox3);
            this.ThreethPage.Controls.Add(this.butShowResultPage3);
            this.ThreethPage.Controls.Add(this.labForAnimationPage3);
            this.ThreethPage.Controls.Add(this.btnDecodingPage3);
            this.ThreethPage.Controls.Add(this.btnCodingPage3);
            this.ThreethPage.Controls.Add(this.btnShowKeyPage3);
            this.ThreethPage.Controls.Add(this.txtBKeyLengthPage3);
            this.ThreethPage.Controls.Add(this.labTextPage3);
            this.ThreethPage.Location = new System.Drawing.Point(4, 25);
            this.ThreethPage.Name = "ThreethPage";
            this.ThreethPage.Size = new System.Drawing.Size(779, 420);
            this.ThreethPage.TabIndex = 2;
            this.ThreethPage.Text = "Шифр Виженера";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(547, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(207, 211);
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // butShowResultPage3
            // 
            this.butShowResultPage3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butShowResultPage3.Location = new System.Drawing.Point(206, 357);
            this.butShowResultPage3.Name = "butShowResultPage3";
            this.butShowResultPage3.Size = new System.Drawing.Size(158, 32);
            this.butShowResultPage3.TabIndex = 13;
            this.butShowResultPage3.Text = "Открыть файл!";
            this.butShowResultPage3.UseVisualStyleBackColor = true;
            this.butShowResultPage3.Visible = false;
            this.butShowResultPage3.Click += new System.EventHandler(this.butShowResult_Click);
            // 
            // labForAnimationPage3
            // 
            this.labForAnimationPage3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labForAnimationPage3.ForeColor = System.Drawing.Color.ForestGreen;
            this.labForAnimationPage3.Location = new System.Drawing.Point(100, 234);
            this.labForAnimationPage3.Name = "labForAnimationPage3";
            this.labForAnimationPage3.Size = new System.Drawing.Size(392, 102);
            this.labForAnimationPage3.TabIndex = 12;
            this.labForAnimationPage3.Text = "Процесс завершен. Файл создан.";
            this.labForAnimationPage3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labForAnimationPage3.Visible = false;
            // 
            // btnDecodingPage3
            // 
            this.btnDecodingPage3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecodingPage3.Location = new System.Drawing.Point(334, 155);
            this.btnDecodingPage3.Name = "btnDecodingPage3";
            this.btnDecodingPage3.Size = new System.Drawing.Size(158, 32);
            this.btnDecodingPage3.TabIndex = 11;
            this.btnDecodingPage3.Tag = "labForAnimationPage3";
            this.btnDecodingPage3.Text = "Декодирование";
            this.btnDecodingPage3.UseVisualStyleBackColor = true;
            this.btnDecodingPage3.Visible = false;
            this.btnDecodingPage3.Click += new System.EventHandler(this.btnCodingPage3_Click);
            // 
            // btnCodingPage3
            // 
            this.btnCodingPage3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCodingPage3.Location = new System.Drawing.Point(41, 155);
            this.btnCodingPage3.Name = "btnCodingPage3";
            this.btnCodingPage3.Size = new System.Drawing.Size(158, 32);
            this.btnCodingPage3.TabIndex = 10;
            this.btnCodingPage3.Tag = "labForAnimationPage3";
            this.btnCodingPage3.Text = "Кодирование";
            this.btnCodingPage3.UseVisualStyleBackColor = true;
            this.btnCodingPage3.Visible = false;
            this.btnCodingPage3.Click += new System.EventHandler(this.btnCodingPage3_Click);
            // 
            // btnShowKeyPage3
            // 
            this.btnShowKeyPage3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowKeyPage3.Location = new System.Drawing.Point(343, 37);
            this.btnShowKeyPage3.Name = "btnShowKeyPage3";
            this.btnShowKeyPage3.Size = new System.Drawing.Size(75, 24);
            this.btnShowKeyPage3.TabIndex = 9;
            this.btnShowKeyPage3.Text = "ОК";
            this.btnShowKeyPage3.UseVisualStyleBackColor = true;
            this.btnShowKeyPage3.Click += new System.EventHandler(this.btnShowKeyPage3_Click);
            // 
            // txtBKeyLengthPage3
            // 
            this.txtBKeyLengthPage3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBKeyLengthPage3.Location = new System.Drawing.Point(273, 38);
            this.txtBKeyLengthPage3.Name = "txtBKeyLengthPage3";
            this.txtBKeyLengthPage3.Size = new System.Drawing.Size(44, 27);
            this.txtBKeyLengthPage3.TabIndex = 8;
            this.txtBKeyLengthPage3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBKeyLengthPage3_KeyPress);
            // 
            // labTextPage3
            // 
            this.labTextPage3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labTextPage3.Location = new System.Drawing.Point(38, 39);
            this.labTextPage3.Name = "labTextPage3";
            this.labTextPage3.Size = new System.Drawing.Size(215, 23);
            this.labTextPage3.TabIndex = 7;
            this.labTextPage3.Text = "Введите длину ключа :";
            // 
            // FourthPage
            // 
            this.FourthPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FourthPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FourthPage.Controls.Add(this.labCurrentKey);
            this.FourthPage.Controls.Add(this.pictureBox4);
            this.FourthPage.Controls.Add(this.butShowResultPage4);
            this.FourthPage.Controls.Add(this.labForAnimationPage4);
            this.FourthPage.Controls.Add(this.btnDecodingPage4);
            this.FourthPage.Controls.Add(this.btnCodingPage4);
            this.FourthPage.Controls.Add(this.btnShowKey4);
            this.FourthPage.Controls.Add(this.label2);
            this.FourthPage.Location = new System.Drawing.Point(4, 25);
            this.FourthPage.Name = "FourthPage";
            this.FourthPage.Padding = new System.Windows.Forms.Padding(3);
            this.FourthPage.Size = new System.Drawing.Size(779, 420);
            this.FourthPage.TabIndex = 3;
            this.FourthPage.Text = "Одноразовый блокнот";
            // 
            // labCurrentKey
            // 
            this.labCurrentKey.AutoSize = true;
            this.labCurrentKey.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labCurrentKey.ForeColor = System.Drawing.Color.ForestGreen;
            this.labCurrentKey.Location = new System.Drawing.Point(58, 83);
            this.labCurrentKey.Name = "labCurrentKey";
            this.labCurrentKey.Size = new System.Drawing.Size(359, 23);
            this.labCurrentKey.TabIndex = 18;
            this.labCurrentKey.Text = "Текущий ключ :  <отсутствует>";
            this.labCurrentKey.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::TextSecurity.Properties.Resources.images;
            this.pictureBox4.Location = new System.Drawing.Point(579, 26);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(182, 194);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            // 
            // butShowResultPage4
            // 
            this.butShowResultPage4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butShowResultPage4.Location = new System.Drawing.Point(211, 328);
            this.butShowResultPage4.Name = "butShowResultPage4";
            this.butShowResultPage4.Size = new System.Drawing.Size(158, 32);
            this.butShowResultPage4.TabIndex = 15;
            this.butShowResultPage4.Text = "Открыть файл!";
            this.butShowResultPage4.UseVisualStyleBackColor = true;
            this.butShowResultPage4.Visible = false;
            this.butShowResultPage4.Click += new System.EventHandler(this.butShowResult_Click);
            // 
            // labForAnimationPage4
            // 
            this.labForAnimationPage4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labForAnimationPage4.ForeColor = System.Drawing.Color.ForestGreen;
            this.labForAnimationPage4.Location = new System.Drawing.Point(105, 205);
            this.labForAnimationPage4.Name = "labForAnimationPage4";
            this.labForAnimationPage4.Size = new System.Drawing.Size(392, 102);
            this.labForAnimationPage4.TabIndex = 14;
            this.labForAnimationPage4.Text = "Процесс завершен. Файл создан.";
            this.labForAnimationPage4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labForAnimationPage4.Visible = false;
            // 
            // btnDecodingPage4
            // 
            this.btnDecodingPage4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecodingPage4.Location = new System.Drawing.Point(372, 133);
            this.btnDecodingPage4.Name = "btnDecodingPage4";
            this.btnDecodingPage4.Size = new System.Drawing.Size(158, 32);
            this.btnDecodingPage4.TabIndex = 6;
            this.btnDecodingPage4.Tag = "labForAnimationPage4";
            this.btnDecodingPage4.Text = "Декодирование";
            this.btnDecodingPage4.UseVisualStyleBackColor = true;
            this.btnDecodingPage4.Visible = false;
            this.btnDecodingPage4.Click += new System.EventHandler(this.btnCodingPage4_Click);
            // 
            // btnCodingPage4
            // 
            this.btnCodingPage4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCodingPage4.Location = new System.Drawing.Point(79, 133);
            this.btnCodingPage4.Name = "btnCodingPage4";
            this.btnCodingPage4.Size = new System.Drawing.Size(158, 32);
            this.btnCodingPage4.TabIndex = 5;
            this.btnCodingPage4.Tag = "labForAnimationPage4";
            this.btnCodingPage4.Text = "Кодирование";
            this.btnCodingPage4.UseVisualStyleBackColor = true;
            this.btnCodingPage4.Visible = false;
            this.btnCodingPage4.Click += new System.EventHandler(this.btnCodingPage4_Click);
            // 
            // btnShowKey4
            // 
            this.btnShowKey4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowKey4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowKey4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShowKey4.Image = ((System.Drawing.Image)(resources.GetObject("btnShowKey4.Image")));
            this.btnShowKey4.Location = new System.Drawing.Point(350, 26);
            this.btnShowKey4.Name = "btnShowKey4";
            this.btnShowKey4.Size = new System.Drawing.Size(50, 42);
            this.btnShowKey4.TabIndex = 2;
            this.btnShowKey4.UseVisualStyleBackColor = false;
            this.btnShowKey4.Click += new System.EventHandler(this.btnShowKey4_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(58, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Выберите файл-ключ :\r\n";
            // 
            // FifthPage
            // 
            this.FifthPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.FifthPage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.FifthPage.Controls.Add(this.pictureBox5);
            this.FifthPage.Controls.Add(this.labCurrentKeyPage5);
            this.FifthPage.Controls.Add(this.btnShowKey5);
            this.FifthPage.Controls.Add(this.label5);
            this.FifthPage.Controls.Add(this.butShowResultPage5);
            this.FifthPage.Controls.Add(this.labForAnimationPage5);
            this.FifthPage.Controls.Add(this.btnDecodingPage5);
            this.FifthPage.Controls.Add(this.btnCodingPage5);
            this.FifthPage.Location = new System.Drawing.Point(4, 25);
            this.FifthPage.Name = "FifthPage";
            this.FifthPage.Padding = new System.Windows.Forms.Padding(3);
            this.FifthPage.Size = new System.Drawing.Size(779, 420);
            this.FifthPage.TabIndex = 4;
            this.FifthPage.Text = "Гаммирование";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(512, 112);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(245, 285);
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // labCurrentKeyPage5
            // 
            this.labCurrentKeyPage5.AutoSize = true;
            this.labCurrentKeyPage5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labCurrentKeyPage5.ForeColor = System.Drawing.Color.ForestGreen;
            this.labCurrentKeyPage5.Location = new System.Drawing.Point(35, 94);
            this.labCurrentKeyPage5.Name = "labCurrentKeyPage5";
            this.labCurrentKeyPage5.Size = new System.Drawing.Size(352, 23);
            this.labCurrentKeyPage5.TabIndex = 22;
            this.labCurrentKeyPage5.Text = "Текущий ключ : <отсутствует>";
            this.labCurrentKeyPage5.Visible = false;
            // 
            // btnShowKey5
            // 
            this.btnShowKey5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnShowKey5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowKey5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnShowKey5.Image = ((System.Drawing.Image)(resources.GetObject("btnShowKey5.Image")));
            this.btnShowKey5.Location = new System.Drawing.Point(533, 33);
            this.btnShowKey5.Name = "btnShowKey5";
            this.btnShowKey5.Size = new System.Drawing.Size(50, 42);
            this.btnShowKey5.TabIndex = 21;
            this.btnShowKey5.UseVisualStyleBackColor = false;
            this.btnShowKey5.Click += new System.EventHandler(this.btnShowKey5_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.ForestGreen;
            this.label5.Location = new System.Drawing.Point(35, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(492, 31);
            this.label5.TabIndex = 20;
            this.label5.Text = "Выберите файл-ключ для декодирования :\r\n";
            // 
            // butShowResultPage5
            // 
            this.butShowResultPage5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.butShowResultPage5.Location = new System.Drawing.Point(171, 347);
            this.butShowResultPage5.Name = "butShowResultPage5";
            this.butShowResultPage5.Size = new System.Drawing.Size(158, 32);
            this.butShowResultPage5.TabIndex = 19;
            this.butShowResultPage5.Text = "Открыть файл!";
            this.butShowResultPage5.UseVisualStyleBackColor = true;
            this.butShowResultPage5.Visible = false;
            this.butShowResultPage5.Click += new System.EventHandler(this.butShowResult_Click);
            // 
            // labForAnimationPage5
            // 
            this.labForAnimationPage5.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labForAnimationPage5.ForeColor = System.Drawing.Color.ForestGreen;
            this.labForAnimationPage5.Location = new System.Drawing.Point(65, 224);
            this.labForAnimationPage5.Name = "labForAnimationPage5";
            this.labForAnimationPage5.Size = new System.Drawing.Size(392, 102);
            this.labForAnimationPage5.TabIndex = 18;
            this.labForAnimationPage5.Text = "Процесс завершен. Файл создан.";
            this.labForAnimationPage5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labForAnimationPage5.Visible = false;
            // 
            // btnDecodingPage5
            // 
            this.btnDecodingPage5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecodingPage5.Location = new System.Drawing.Point(332, 152);
            this.btnDecodingPage5.Name = "btnDecodingPage5";
            this.btnDecodingPage5.Size = new System.Drawing.Size(158, 32);
            this.btnDecodingPage5.TabIndex = 17;
            this.btnDecodingPage5.Tag = "labForAnimationPage5";
            this.btnDecodingPage5.Text = "Декодирование";
            this.btnDecodingPage5.UseVisualStyleBackColor = true;
            this.btnDecodingPage5.Visible = false;
            this.btnDecodingPage5.Click += new System.EventHandler(this.btnCodingPage5_Click);
            // 
            // btnCodingPage5
            // 
            this.btnCodingPage5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCodingPage5.Location = new System.Drawing.Point(39, 152);
            this.btnCodingPage5.Name = "btnCodingPage5";
            this.btnCodingPage5.Size = new System.Drawing.Size(158, 32);
            this.btnCodingPage5.TabIndex = 16;
            this.btnCodingPage5.Tag = "labForAnimationPage5";
            this.btnCodingPage5.Text = "Кодирование";
            this.btnCodingPage5.UseVisualStyleBackColor = true;
            this.btnCodingPage5.Click += new System.EventHandler(this.btnCodingPage5_Click);
            // 
            // timerForAnimation
            // 
            this.timerForAnimation.Interval = 400;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(787, 449);
            this.Controls.Add(this.mainControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TextSecurity";
            this.Load += new System.EventHandler(this.Load_Form);
            this.mainControl.ResumeLayout(false);
            this.FirstPage.ResumeLayout(false);
            this.FirstPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SecondPage.ResumeLayout(false);
            this.SecondPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ThreethPage.ResumeLayout(false);
            this.ThreethPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.FourthPage.ResumeLayout(false);
            this.FourthPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.FifthPage.ResumeLayout(false);
            this.FifthPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl mainControl;
        private System.Windows.Forms.TabPage FirstPage;
        private System.Windows.Forms.TabPage SecondPage;
        private System.Windows.Forms.TabPage ThreethPage;
        private System.Windows.Forms.TabPage FourthPage;
        private System.Windows.Forms.TabPage FifthPage;
        private System.Windows.Forms.Label labKeyLengthPageOne;
        private System.Windows.Forms.TextBox txtBKeyLength;
        private System.Windows.Forms.Button btnShowKey;
        private System.Windows.Forms.Button btnCoding;
        private System.Windows.Forms.Button btnDecoding;
        private System.Windows.Forms.Label labForAnimation;
        private System.Windows.Forms.Timer timerForAnimation;
        private System.Windows.Forms.Button butShowResult;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBKeyLengthPage2;
        private System.Windows.Forms.Button btnCodingPage2;
        private System.Windows.Forms.Button btnDecodingPage2;
        private System.Windows.Forms.Button butShowResultPage2;
        private System.Windows.Forms.Label labForAnimationPage2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button butShowResultPage3;
        private System.Windows.Forms.Label labForAnimationPage3;
        private System.Windows.Forms.Button btnDecodingPage3;
        private System.Windows.Forms.Button btnCodingPage3;
        private System.Windows.Forms.Button btnShowKeyPage3;
        private System.Windows.Forms.TextBox txtBKeyLengthPage3;
        private System.Windows.Forms.Label labTextPage3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnShowKey4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDecodingPage4;
        private System.Windows.Forms.Button btnCodingPage4;
        private System.Windows.Forms.Button butShowResultPage4;
        private System.Windows.Forms.Label labForAnimationPage4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labCurrentKey;
        private System.Windows.Forms.Label labCurrentKeyPage5;
        private System.Windows.Forms.Button btnShowKey5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button butShowResultPage5;
        private System.Windows.Forms.Label labForAnimationPage5;
        private System.Windows.Forms.Button btnDecodingPage5;
        private System.Windows.Forms.Button btnCodingPage5;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}

