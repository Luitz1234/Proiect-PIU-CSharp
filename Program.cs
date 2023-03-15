using System;
using System.Configuration;
using Administrare_produs;
using LibrarieClase;

namespace Supermarket_bun
{
    class Program
    {
        static void Main(string[] args)
        {

            string optiune;
            do
            {
                Console.WriteLine("C. Citire produs de la tastatura");
                Console.WriteLine("D. Citire furnizor de la tastatura");
                Console.WriteLine("A. Cautare produs dupa nume");
                Console.WriteLine("V. Cautare furnizor dupa nume");
                Console.WriteLine("F. Afisare produselor din fisier");
                Console.WriteLine("W. Afisare furnizorilor din fisier");
                Console.WriteLine("S. Salvare produs in fisier");
                Console.WriteLine("M. Salvare furnizor in fisier");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "C":
                        produsNou = CitireProdusTastatura();

                        break;

                    case "D":
                        furnizorNou = CitireFurnizorTastatura();

                        break;

                    case "A":
                        Console.Write("Dati numele produsului cautat: ");
                        string produs_cautat = Console.ReadLine();
                        Produs[] lista = adminProduse.GetProduse(out nrProduse);
                        cautareProdusNume(lista, nrProduse, produs_cautat);

                        break;

                    case "V":
                        Console.Write("Dati numele furnizorului cautat: ");
                        string furnizor_cautat = Console.ReadLine();
                        Furnizori[] listaf = adminFurnizori.GetFurnizori(out nrFurnizori);
                        cautareFurnizorNume(listaf, nrFurnizori, furnizor_cautat);

                        break;



                    case "F":
                        Produs[] lista_produse = adminProduse.GetProduse(out nrProduse);
                        AfisareProduse(lista_produse, nrProduse);

                        break;

                    case "W":
                        Furnizori[] lista_furnizori = adminFurnizori.GetFurnizori(out nrFurnizori);
                        AfisareFurnizori(lista_furnizori, nrFurnizori);

                        break;





                    case "S":
                        int idProdus = nrProduse + 1;
                        produsNou.SetIdProdus(idProdus);
                        adminProduse.AddProdus(produsNou);

                        nrProduse = nrProduse + 1;

                        break;

                    case "M":
                        int furniz = nrFurnizori + 1;
                        adminFurnizori.AddFurnizor(furnizorNou);

                        nrFurnizori = nrFurnizori + 1;

                        break;





                    case "X":
                        return;
                    default:
                        Console.WriteLine("Optiune inexistenta");
                        break;
                }
            } while (optiune.ToUpper() != "X");

            Console.ReadKey();


        }
        
     //Citire produs de la tastatura
     
     public static Produs CitireProdusTastatura()
     {
        Console.WriteLine("Introduceti numele produsului:");
        string nume = Console.Readline();
        Console.WriteLine("Introduceti tipul produsului:");
        string tip_produs = Console.ReadLine();
        Console.WriteLine("Introduceti data de expirare :");
        string data_exp = Console.ReadLine();
        Produs produs = new Produs(0,nume,tip_produs,data_exp);
        
        return produs;
      }
       
       
      //Citire furnizor de la tastatura
      
        public static Furnizori CitireFurnizorTastatura()
        {
            Console.WriteLine("Introduceti numele furnizorului:");
            string nume_fur = Console.ReadLine();
            Console.WriteLine("Introduceti adresa furnizorului :");
            string adresa_fur = Console.ReadLine();
            Console.WriteLine("Introduceti numarul de telefon :");
            string nr_tel = Console.ReadLine();
            Furnizori furnizori = new Furnizori(nume_fur, adresa_fur, nr_tel);

            return furnizori;
        }
        //Afisare produs
        public static void AfisareProdus(Produs produs)
        {
            string infoProdus = string.Format("Id: {0}, Denumire: {1}, Tip: {2}, Data expirare: {3}",
                   produs.GetIdProdus(),
                   produs.Get_nume() ?? " Necunoscut ",
                   produs.Get_tip() ?? " Necunoscut ",
                   produs.Get_data_expirare() ?? " Necunoscut ");

            Console.WriteLine(infoProdus);
        }

        public static void AfisareProduse(Produs[] lista_produse,int nrProduse)
        {
            Console.WriteLine("Produsele sunt: ");
            for (int contor = 0; contor < nrProduse; contor++)
                AfisareProdus(lista_produse[contor]);
        }

        //Afisare furnizor
        public static void AfisareFurnizor(Furnizori furnizori)
        {
            string infoFurnizori = string.Format("Nume: {0}, Adresa: {1}, Numar de telefon: {2}",
                   furnizori.GetNumeFurnizori() ?? "Necunoscut",
                   furnizori.GetAdresaFurnizori() ?? " Necunoscut ",
                   furnizori.GetNumarTelefon() ?? " Necunoscut ");

            Console.WriteLine(infoFurnizori);
        }

        public static void AfisareFurnizori(Furnizori[] lista_furnizori, int nrFurnizori)
        {
            Console.WriteLine("Furnizorii sunt: ");
            for (int contor = 0; contor < nrFurnizori; contor++)
                AfisareFurnizor(lista_furnizori[contor]);
        }

    }

}
