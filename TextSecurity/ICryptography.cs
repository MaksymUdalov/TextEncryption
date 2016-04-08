using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextSecurity
{
    interface ICryptography
    {

        string Encrypt();
        string Decrypt();
    }
}
