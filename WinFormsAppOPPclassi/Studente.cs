using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppOPPclassi
{
    public class Studente: Persona
    {
        string _sezione;
        byte _anno;

        public Studente(string sezione, string nome, string cognome, double altezza, DateTime datadinascita) : base(nome, cognome, altezza, datadinascita)
        {
            _sezione = sezione;
            _anno = 1;
        }

        public byte promuovi(byte anno)
            { return _anno;
        
        
        }


    }
}
