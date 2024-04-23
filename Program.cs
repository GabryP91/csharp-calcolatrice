/*
 
Creare una classe di helper CalcoliHelper.
Come visto a lezione, strutturare la classe in modo che non possa essere istanziata e che presenti i seguenti metodi `static`:
- Somma di due numeri interi
- Somma di due numeri double
- Differenza tra due numeri interi
- Differenza tra due numeri double
- Moltiplicazione di due numeri interi
- Moltiplicazione di due numeri double
- Valore assoluto di un numero intero
- Valore assoluto di un numero double
- Minimo tra due numeri interi
- Minimo tra due numeri double
- Massimo tra due numeri interi
- Massimo tra due numeri double
Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale? 
Scrivetelo in un commento all’interno del codice! :faccia_nerd:
Testate tutti i metodi della vostra classe di helper (con un esempio per ogni casistica).

 **BONUS**:
Aggiungete il metodo per l’elevamento a potenza che prende come parametri due numeri interi (base ed esponente) e ritorna la base elevata all’esponente. 
Occhio che sia la base che l’esponente potrebbero essere uguali a zero oppure numeri negativi!
(caso esponente = 0 e base = 0 anche se in matematica sarebbe un numero indefinito usiamo l’approccio informatico che lo calcola come 1)
Buon lavoro!
 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_calcolatrice
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int numberUser, num1, num2;

            double numF1, numF2;



            // Esempi di utilizzo dei metodi della classe CalcoliHelper
            Console.WriteLine("\n\n*****Funzionalità classe statica:CalcoliHelper*****\n\n");

            Console.WriteLine("Caso [1]: Somma di due numeri interi");
            Console.WriteLine("Caso [2]: Somma di due numeri con la virgola");
            Console.WriteLine("Caso [3]: Differenza di due numeri interi");
            Console.WriteLine("Caso [4]: Differenza di due numeri con la virgola");
            Console.WriteLine("Caso [5]: Moltiplicazione di due numeri interi");
            Console.WriteLine("Caso [6]: Moltiplicazione di due numeri con la virgola");
            Console.WriteLine("Caso [7]: Calcolo valore assoluto di un intero");
            Console.WriteLine("Caso [8]: Calcolo valore assoluto di un numero con la virgola");
            Console.WriteLine("Caso [9]: Minimo di due numeri interi");
            Console.WriteLine("Caso [10]: Minimo di due numeri con la virgola");
            Console.WriteLine("Caso [11]: Massimo di due numeri interi");
            Console.WriteLine("Caso [12]: Massimo di due numeri con la virgola");
            Console.WriteLine("Caso [13]: Potenza di un intero");

            Console.WriteLine("\n\n*********DIGITARE UN NUMERO:*********");

            //controllo sull'input dell'utente, se quello che è stato digitato non è un numero darà errore
            while (int.TryParse(Console.ReadLine(), out numberUser) == false)
            {
                Console.WriteLine("Sintassi errata. Inserisci numero");
            }

            switch (numberUser)
            {
                case 1:

                     num1 = CheckInt("Inserire primo numero");
                     num2 = CheckInt("Inserire secondo numero");

                    Console.WriteLine("\nLa somma sarà uguale a: " + CalcoliHelper.Somma(num1, num2));

                    break;
                case 2:

                    numF1 = CheckFloat("Inserire primo numero");
                    numF2 = CheckFloat("Inserire secondo numero");

                    Console.WriteLine("\nLa somma sarà uguale a: " + CalcoliHelper.Somma(numF1, numF2));

                    break;
                case 3:

                    num1 = CheckInt("Inserire primo numero");
                    num2 = CheckInt("Inserire secondo numero");

                    Console.WriteLine("\nLa differenza sarà uguale a: " + CalcoliHelper.Differenza(num1, num2));

                    break;
                case 4:

                    numF1 = CheckFloat("Inserire primo numero");
                    numF2 = CheckFloat("Inserire secondo numero");

                    Console.WriteLine("\nLa differenza sarà uguale a: " + CalcoliHelper.Differenza(numF1, numF2));

                    break;
                case 5:

                    num1 = CheckInt("Inserire primo numero");
                    num2 = CheckInt("Inserire secondo numero");

                    Console.WriteLine("\nLa moltiplicazione sarà uguale a: " + CalcoliHelper.Moltiplicazione(num1, num2));

                    break;
                case 6:

                    numF1 = CheckFloat("Inserire primo numero");
                    numF2 = CheckFloat("Inserire secondo numero");

                    Console.WriteLine("\nLa moltiplicazione sarà uguale a: " + CalcoliHelper.Moltiplicazione(numF1, numF2));

                    break;
                case 7:

                    num1 = CheckInt("Inserire numero");
                    
                    Console.WriteLine("\nIl valore assoluto sarà uguale a: " + CalcoliHelper.ValoreAssoluto(num1));

                    break;
                case 8:

                    numF1 = CheckFloat("Inserire numero");

                    Console.WriteLine("\nIl valore assoluto sarà uguale a: " + CalcoliHelper.ValoreAssoluto(numF1));

                    break;
                case 9:

                    num1 = CheckInt("Inserire primo numero");
                    num2 = CheckInt("Inserire secondo numero");

                    Console.WriteLine("\nIl minimo sarà uguale a: " + CalcoliHelper.Minimo(num1, num2));

                    break;
                case 10:

                    numF1 = CheckFloat("Inserire primo numero");
                    numF2 = CheckFloat("Inserire secondo numero");

                    Console.WriteLine("\nIl minimo sarà uguale a: " + CalcoliHelper.Minimo(numF1, numF2));

                    break;
                case 11:

                    num1 = CheckInt("Inserire primo numero");
                    num2 = CheckInt("Inserire secondo numero");

                    Console.WriteLine("\nIl massimo sarà uguale a: " + CalcoliHelper.Massimo(num1, num2));

                    break;
                case 12:

                    numF1 = CheckFloat("Inserire primo numero");
                    numF2 = CheckFloat("Inserire secondo numero");

                    Console.WriteLine("\nIl massimo sarà uguale a: " + CalcoliHelper.Massimo(numF1, numF2));

                    break;
                case 13:

                    num1 = CheckInt("Inserire primo numero (base)");
                    num2 = CheckInt("Inserire secondo numero (esponenete)");

                    Console.WriteLine($"\nLa potenza di {num1} sarà uguale a: " + CalcoliHelper.Potenza(num1, num2));

                    break;

                //caso errore
                default: Console.WriteLine("Valore inserito non valido");
                    break;
            }

           
            Console.ReadKey();
        }


        static int CheckInt(string message)
        {
            int num;
            Console.WriteLine(message);
            while (!int.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero intero");
                Console.WriteLine(message);
            }
            return num;
             
        }

        static double CheckFloat(string message)
        {
            double num;
            Console.WriteLine(message);
            while (!double.TryParse(Console.ReadLine(), out num))
            {
                Console.WriteLine("Sintassi errata. Inserisci un numero double");
                Console.WriteLine(message);
            }
            return num;

        }
    }
}
