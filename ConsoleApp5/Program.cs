using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp5
{
    class Program
    {
         static void Main(string[] args)
        {   //Methode ohne Rückgabewert
            //Aufruf der Methode Rechnung1 mit Variable ergebnis und Parameterübergabe
            Rechnung1(12.55, 144.897);
            Console.WriteLine();
        
            // ----------------------------------------------

            //Methode mit Rückgabewert
            //Aufruf der Methode Rechnung2 mit Variable ergebnis und Parameterübergabe
            double ergebnis = Rechnung2(12.55, 144.897);
            // Der Returnwert (hier addieren) wird in die Varibable ergebnis übergeben

            //Ausgabe der Varibale ergebnis
            Console.WriteLine(ergebnis);
        

            //Alternativer Aufruf der Methode mit Rückgabewert

            Console.WriteLine(Rechnung2(12.55, 144.897));
            Console.WriteLine();
            Console.ReadKey();



        }
        // Methode Rechnung1 ohne Rückgabewert

        static void Rechnung1(double zahl1, double zahl2)
        {
            double subtrahieren = (zahl1 + zahl2);
            Console.WriteLine(subtrahieren);
        } 

            


        // Methode Rechnung2 mit Rückgabewert
        // Übernahme der Parameter in Variable zahl3 und zahl4 
        static double Rechnung2(double zahl3, double zahl4)
        {
            
            double addieren = (zahl3 + zahl4);
           
            return addieren;
        }
    }   
}
