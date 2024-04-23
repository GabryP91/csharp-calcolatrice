using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{

    public static class CalcoliHelper
    {
        // Metodo statico per la somma di due numeri interi
        public static int Somma(int a, int b)
        {
            return a + b;
        }

        // Metodo statico per la somma di due numeri double
        public static double Somma(double a, double b)
        {
            return a + b;
        }

        // Metodo statico per la differenza tra due numeri interi
        public static int Differenza(int a, int b)
        {
            return a - b;
        }

        // Metodo statico per la differenza tra due numeri double
        public static double Differenza(double a, double b)
        {
            return a - b;
        }

        // Metodo statico per la moltiplicazione di due numeri interi
        public static int Moltiplicazione(int a, int b)
        {
            return a * b;
        }

        // Metodo statico per la moltiplicazione di due numeri double
        public static double Moltiplicazione(double a, double b)
        {
            return a * b;
        }

        // Metodo statico per il valore assoluto di un numero intero
        public static int ValoreAssoluto(int a)
        {
            if (a < 0) return  a * -1;
            
            else return a;
            
        }

        // Metodo statico per il valore assoluto di un numero double
        public static double ValoreAssoluto(double a)
        {
            if (a < 0) return a * -1;

            else return a;
        }

        // Metodo statico per il minimo tra due numeri interi
        public static int Minimo(int a, int b)
        {

            if (a < b) return a;

            else return b;

        }

        // Metodo statico per il minimo tra due numeri double
        public static double Minimo(double a, double b)
        {
            if (a < b) return a;

            else return b;
        }

        // Metodo statico per il massimo tra due numeri interi
        public static int Massimo(int a, int b)
        {
            if (a > b) return a;

            else return b;
        }

        // Metodo statico per il massimo tra due numeri double
        public static double Massimo(double a, double b)
        {
            if (a > b) return a;

            else return b;
        }

        // Metodo statico per l'elevamento a potenza di due numeri interi
        public static double Potenza(int baseNum, int esponente)
        {
            //se esponente minore di 0
            if (esponente < 0)
            {
                // ritorna il reciproco del numero elevato alla stessa potenza
                return 1.0 / PowerPositive(baseNum, -esponente);
            }
            else
            {
                return PowerPositive(baseNum, esponente);
            }
        }

        private static double PowerPositive(int baseNum, int esponente)
        {
            double risultato = 1.0;
            for (int i = 0; i < esponente; i++)
            {
                risultato *= baseNum;
            }
            return risultato;
        }
    }
}
