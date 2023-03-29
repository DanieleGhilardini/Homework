using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esercizio
{
    internal class Carta_ID
    {
        public string Cognome {
            get
            {
                return Cognome;
            }
            set
            {
                if(hasNumber(Cognome))
                {
                    Cognome = value;
                }
                else
                {
                    throw new Exception("Ci sono numeri, il cognome è invalido");
                }
            }
        }
        public string Nome 
        {
            get
            {
                return Nome;
            }
            set
            {
                if (hasNumber(Nome))
                {
                    Nome = value;
                }
                else
                {
                    throw new Exception("Ci sono numeri, il nome è invalido");
                }
            }
        }
        public string CittaResidenza 
        {
            get
            {
                return CittaResidenza;
            }
            set
            {
                if (hasNumber(CittaResidenza))
                {
                    CittaResidenza = value;
                }
                else
                {
                    throw new Exception("Ci sono numeri, la città di residenza è invalida");
                }
            }
        }
        public DateTime DataNascita
        {
            get
            {
                return DataNascita;
            }
            set
            {
                DateTime limite = new DateTime(1900, 1, 1);
                int compare = DateTime.Compare(DataNascita, limite);
                if (compare >= 0)
                {
                    DataNascita = value;
                }
                else
                {
                    throw new Exception("La data di nascita è invalida");
                }
            }
        }
        public char Sesso { get; set; }
        public int Statura { get; set; }

        private bool hasNumber(string stringa)
        {
            bool number = false;
            for(int i = 0; i < stringa.Length; i++) {
                if (Char.IsDigit(stringa[i])) {
                    number = true;
                }
            }
            return number;
        }
    }
}
