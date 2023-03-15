using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibrarieClase
{
    public class Produs
    {
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';

        private int idProdus;
        public string nume_produs;
        public string tip;
        public string data_expirare;

        public Produs()
        {
            nume_produs = tip = data_expirare = string.Empty;
            idProdus = 0;
        }
        public Produs(int idProdus, string Nume, string Tip, string Data_expirare)
        {
            this.idProdus = idProdus;
            this.nume_produs = Nume;
            this.tip = Tip;
            this.data_expirare = Data_expirare;


        }

        public Produs(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            idProdus = Convert.ToInt32(dateFisier[0]);
            nume_produs = dateFisier[1];
            tip = dateFisier[2];
            data_expirare = dateFisier[3];
        }

        public string ConversieLaSir_PentruFisier()
        {
            string obiectProdusPentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                idProdus,
                nume_produs,
                tip,
                data_expirare);

            return obiectProdusPentruFisier;
        }

        public void SetIdProdus(int idProdus)
        {
            this.idProdus = idProdus;
        }

        public int GetIdProdus()
        {
            return idProdus;
        }


        public string Get_nume()
        {
            return nume_produs;
        }

        public string Get_tip()
        {
            return tip;
        }
        public string Get_data_expirare()
        {
            return data_expirare;
        }

    }
}
