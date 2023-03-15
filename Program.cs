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

    }

}
