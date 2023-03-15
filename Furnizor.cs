using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClase
{
    public class Furnizori
    {

        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        public string nume_furnizori;
        public string adresa_furnizori;
        public string numar_telefon;



        public Furnizori(string Nume_Furnizori, string Adresa_Furnizori, string Numar_Telefon)
        {
            this.nume_furnizori = Nume_Furnizori;
            this.adresa_furnizori = Adresa_Furnizori;
            this.numar_telefon = Numar_Telefon;
        }


        
        public Furnizori(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            nume_furnizori = dateFisier[0];
            adresa_furnizori = dateFisier[1];
            numar_telefon = dateFisier[2];
           
        }
        public string GetNumeFurnizori()
        {
            return nume_furnizori;
        }
        public string GetAdresaFurnizori()
        {
            return adresa_furnizori;
        }
        public string GetNumarTelefon()
        {
            return numar_telefon;
        }

        public Furnizori()
        {
            nume_furnizori = adresa_furnizori = numar_telefon = string.Empty;
        }


        public string ConversieLaSir_PentruFisier()
        {
            string obiectFurnizorPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                nume_furnizori ,
                adresa_furnizori,
                numar_telefon);

            return obiectFurnizorPentruFisier;
        }
    }
}
