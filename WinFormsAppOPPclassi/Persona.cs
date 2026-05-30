using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsAppOPPclassi
{
    public class Persona
    {
        private string _nome;
        private string _cognome;
        private double _altezza;

        public Persona(string nome,string cognome,double altezza)
        { 

            _nome = nome;
            _cognome = cognome;
            _altezza = altezza;

        }

        //metodi generali
        public void Cresci(double incremento)
        {
            _altezza = _altezza + incremento;
            if (_altezza>=220)
            {
                _altezza = 220;
            }
        }


        // questo sono proprieta

        public string Nome
        {
            get { return _nome; }
        }
        public string Cognome
        {
            get { return _cognome; }
        }
        public double Altezza
        {
            get { return _altezza; }         
        }
        public string Descrizione
        {
            get {
                string risposta;
                risposta= "Nome" + "Cognome" + "+Altezza.ToString()" + "cm";
                
                return risposta; 
            
            }
        }



    }
}
