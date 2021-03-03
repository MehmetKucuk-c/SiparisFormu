using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiparisFormu
{
    public class Rnd
    {
        Random rastgele = new Random();
        StringBuilder sb = new StringBuilder();
        StringBuilder say = new StringBuilder();
        public string random(int ilk,int son,int lenght)
        {
            for (int i = 0; i < lenght; i++)
            {
                int ascii = rastgele.Next(ilk, son);
                string karakter = ascii.ToString();
                sb.Append(karakter);
            }
            return sb.ToString();
        }
        public string sayi(int ilk ,int son,int lengt)
        {
            for (int i = 0; i < lengt; i++)
            {
                int ascii = rastgele.Next(ilk, son);
                string karakter = ascii.ToString();
                say.Append(karakter);
            }
            return say.ToString();
        }
    }
}

