using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class szemely
    {
        string nev, email, jelszo;
        int kor;

        public szemely(string nev, string email, string jelszo, int kor)
        {
            this.nev = nev;
            this.email = email;
            this.jelszo = jelszo;
            this.kor = kor;
        }

        public string Nev { get => nev; set => nev = value; }
        public string Email { get => email; set => email = value; }
        public string Jelszo { get => jelszo; set => jelszo = value; }
        public int Kor { get => kor; set => kor = value; }
    }
}
