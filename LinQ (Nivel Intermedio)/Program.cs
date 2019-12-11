using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQ__Nivel_Intermedio_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lst = new List<Persona>()
            {
                new Persona() { Edad = 40, Nombre = "Itxaso" },
                new Persona() { Edad = 20, Nombre = "Raul" },
                new Persona() { Edad = 50, Nombre = "Paco" },
                new Persona() { Edad = 35, Nombre = "Imanol"},
                new Persona() { Edad = 18, Nombre = "Arrate" },

            };

          
            List<string> lstOrdenadosSoloNombres = (from d in lst
                                                    orderby d.Nombre
                                                    select d.Nombre).Skip(2).Take(2).ToList();


            // Take(2) - De la lista te coje dos resultados. Los dos primeros pero por edad . Aqui serian Arrate y Raul
            // Skip(2) - Tiene que ir obligatoriamente delante del Take. Se salta los dos primeros resultados por edad 
            // y te da los dos siguintes Imanol e Itxaso y a Paco no le incluye porque 2 de Skip y 2 de Take


            foreach (var Nombre in lstOrdenadosSoloNombres)
            {
                Console.WriteLine(Nombre);
            }


            List<string> lstSoloTexto = new List<string>()
            {
                "30 - Hector", "15 - Gabriel", "20 - Fernando",

            };

            // Con el Union uniriamos las dos listas "lstOrdenadosSoloNombres" y "lstSoloTexto"

            List<string> lstOrdenadosSoloNombres1 = (from d in lst
                                                    orderby d.Nombre
                                                    select d.Nombre).Union(lstSoloTexto).ToList();

            foreach (var Nombre in lstOrdenadosSoloNombres1)
            {
                Console.WriteLine(Nombre);
            }


        }

        public class Persona 
        {
            public int Edad { get; set; }
            public string Nombre { get; set; }
        }
    }
}
