using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animale
{
    class Program
    {
        struct Animali
        {
            public string razza;
            public string specie;
            public override string ToString()
            {
                return String.Format($"{razza, -10}{specie,-10} ");
            }


        }
        static void Main(string[] args)
        {
            Animali creature = new Animali() {razza = "Elefante", specie = "Mammifero" };
            Animali[] zoo = { new Animali { razza = "Delfino", specie = "Mammifero" }, new Animali { razza = "Coccodrillo", specie = "Rettile" } };
            Console.WriteLine($"Variabile prima del cambio {creature.ToString()}");
            Console.WriteLine($"Array prima del cambio {zoo[0].ToString()}");
            Cambia(ref creature, zoo);
            Console.WriteLine($"Variabile dopo del cambio {creature.ToString()}");
            Console.WriteLine($"Array dopo del cambio {zoo[0].ToString()}");
            Console.ReadLine();
        }
        static void Cambia(ref Animali var, Animali[] arr)
        {
            var.razza = "serpente";
            var.specie = "rettile";
            arr[0].razza = "scimmia";
            arr[0].specie = "mammifero";
        }
    }
}
