using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuAttributi
{
    enum Sesso
    {
        maschio,
        femmina
    }
    enum StatoCivile
    {
        celibe,
        nubile,
        coniugato,
        divorziato,
        separato
    }
    class Program
    {
        struct Persona
        {
            public string nome;
            public string cognome;
            public DateTime dataNascita;
            public Sesso sesso;
            public StatoCivile statoCivile;
            public string cittadinanza;
            public string codiceFiscale;//MLMNCL06B01H620E
            //public override string ToString()
            //{
            //    return string.Format($"{nome,-15}{cognome,-15}{dataNascita.ToString(),-15}{sesso.ToString(), -10}{statoCivile.ToString(), -10}{cittadinanza, -10}");
            //}
        }
        //testo esercizio: inserire all'interno dell'anagrafe del comune di Rovigo delle persone
        // verificando che l'archivio non sia pieno e che la persona non sia già presente (verificando il codice fiscale)
        //utilizzare il menù per la selezione del sesso e dello stato civile
        //fare solo inserimento e visualizzazzione
        static void Main(string[] args)
        {
            const int npersone = 3;
            const int numeriSesso = 2;
            Persona[] anagRovigo = new Persona[npersone];
            Inserimento(anagRovigo, npersone, numeriSesso);

            Console.ReadLine();
        }
        static void Menu()
        {

        }
        static void Inserimento(Persona[] anagRovigo, int npersone, int numeriSesso)
        {
            bool dataOk;
            int genereOk;
            for (int i = 0; i < npersone; i++)
            {
                Console.WriteLine($"Inserire il nome della persona {i + 1}");
                anagRovigo[i].nome = Console.ReadLine();
                Console.WriteLine($"Inserire il cognome della persona {i + 1}");
                anagRovigo[i].cognome = Console.ReadLine();
                do
                {
                    Console.WriteLine($"Inserire la data di nascita della persona {i + 1}");
                    if (!(dataOk = DateTime.TryParse(Console.ReadLine(), out anagRovigo[i].dataNascita)))
                    {
                        Console.WriteLine("Non hai inserito un numero");
                    }
                } while (!dataOk);
                Console.WriteLine(anagRovigo[i].dataNascita);
                do
                {
                    Console.WriteLine("Menu per la scelta del genere inserire un numero");
                    genereOk = Menu(anagRovigo, numeriSesso);
                    switch (genereOk)
                    {
                        case 1:
                            Menu2();
                            break;
                        case 2:
                            Menu2();
                            break;
                        default:
                            break;
                    }
                } while (genereOk == -1);
            }
        }
        static int Menu(Persona[] anagRovigo, int numeriSesso)
        {
            bool esiste;
            int scelta;
            do
            {
                Console.WriteLine("Scelta sesso");
                Console.WriteLine($"1 - {Sesso.maschio}");
                Console.WriteLine($"2 - {Sesso.femmina}");
                esiste = int.TryParse(Console.ReadLine(), out scelta);
                if (!esiste)
                {
                    Console.WriteLine("Hai inserito un valore che non è un numero");
                }
            } while (!esiste);
            if (scelta < 1 || scelta > 2)
            {
                return -1;
            }
            return scelta;
            //int scelta = Convert.ToInt32(Console.ReadLine());
        }
        static int Menu2()
        {
            int scelta;
            bool esiste;
            int maxScelta = 5;
            do
            {
                Console.WriteLine("Stato civile");
                Console.WriteLine($"1 - {StatoCivile.celibe}");
                Console.WriteLine($"2 - {StatoCivile.nubile}");
                Console.WriteLine($"3 - {StatoCivile.coniugato}");
                Console.WriteLine($"4 - {StatoCivile.divorziato}");
                Console.WriteLine($"{maxScelta} - {StatoCivile.separato}");
                esiste = int.TryParse(Console.ReadLine(), out scelta);
                if (!esiste)
                {
                    Console.WriteLine("Hai inserito un valore che non è un numero");
                }
            } while (!esiste);
            if (scelta < 1 || scelta > maxScelta)
            {
                return -1;
            }
            return scelta;
        }
        static void Visualizzazione()
        {

        }
    }
}
