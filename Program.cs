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
Il fatto di dover scrivere lo stesso metodo per tipi di parametro diversi applica nella pratica uno dei principi di programmazione ad oggetti che abbiamo visto oggi…Quale? Scrivetelo in un commento all’interno del codice! :faccia_nerd:
Testate tutti i metodi della vostra classe di helper (con un esempio per ogni casistica).

 **BONUS**:
Aggiungete il metodo per l’elevamento a potenza che prende come parametri due numeri interi (base ed esponente) e ritorna la base elevata all’esponente. Occhio che sia la base che l’esponente potrebbero essere uguali a zero oppure numeri negativi!
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


            int numberUser,num1,num2;

            double numF1,numF2;



            // Esempi di utilizzo dei metodi della classe CalcoliHelper
            Console.WriteLine("Esempi di utilizzo dei metodi della classe CalcoliHelper:");

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
                    Console.WriteLine("\n Inserire primo numero");
                    while (int.TryParse(Console.ReadLine(), out num1) == false)
                    {
                        Console.WriteLine("Sintassi errata. Inserisci numero");
                    }

                    Console.WriteLine("\n Inserire secondo numero");
                    while (int.TryParse(Console.ReadLine(), out num2) == false)
                    {
                        Console.WriteLine("Sintassi errata. Inserisci numero");
                    }

                    Console.WriteLine("\nSomma sarà: " + CalcoliHelper.Somma(num1, num2));

                break;
                case 2:
                    Console.WriteLine("\n Inserire primo numero");
                    while (double.TryParse(Console.ReadLine(), out numF1) == false)
                    {
                        Console.WriteLine("Sintassi errata. Inserisci numero");
                    }

                    Console.WriteLine("\n Inserire secondo numero");
                    while (double.TryParse(Console.ReadLine(), out numF2) == false)
                    {
                        Console.WriteLine("Sintassi errata. Inserisci numero");
                    }

                    Console.WriteLine("\nSomma sarà: " + CalcoliHelper.Somma(numF1, numF2));

                break;
                case 3:
                    Console.WriteLine("\n Inserire primo numero");
                    while (int.TryParse(Console.ReadLine(), out num1) == false)
                    {
                        Console.WriteLine("Sintassi errata. Inserisci numero");
                    }

                    Console.WriteLine("\n Inserire secondo numero");
                    while (int.TryParse(Console.ReadLine(), out num2) == false)
                    {
                        Console.WriteLine("Sintassi errata. Inserisci numero");
                    }

                    Console.WriteLine("\nSomma sarà: " + CalcoliHelper.Differenza(num1, num2));

                    break;
                case 4:
                    Console.WriteLine("\n Inserire primo numero");
                    while (double.TryParse(Console.ReadLine(), out numF1) == false)
                    {
                        Console.WriteLine("Sintassi errata. Inserisci numero");
                    }

                    Console.WriteLine("\n Inserire secondo numero");
                    while (double.TryParse(Console.ReadLine(), out numF2) == false)
                    {
                        Console.WriteLine("Sintassi errata. Inserisci numero");
                    }

                    Console.WriteLine("\nSomma sarà: " + CalcoliHelper.Differenza(numF1, numF2));

                    break;


                default: Console.WriteLine("Valore inserito non valido");
                break;
            }

            // Esempi di utilizzo dei metodi della classe CalcoliHelper
            Console.WriteLine("Esempi di utilizzo dei metodi della classe CalcoliHelper:");

            // Somma
            
            Console.WriteLine("Somma di due double: " + CalcoliHelper.Somma(5.5, 3.2));

            // Differenza
            Console.WriteLine("Differenza di due interi: " + CalcoliHelper.Differenza(8, 3));
            Console.WriteLine("Differenza di due double: " + CalcoliHelper.Differenza(8.5, 3.2));

            // Moltiplicazione
            Console.WriteLine("Moltiplicazione di due interi: " + CalcoliHelper.Moltiplicazione(5, 3));
            Console.WriteLine("Moltiplicazione di due double: " + CalcoliHelper.Moltiplicazione(5.5, 3.2));

            // Valore assoluto
            int valore = CalcoliHelper.ValoreAssoluto(-5);
            Console.WriteLine("Valore assoluto di un intero: " + valore);
            //Console.WriteLine("Valore assoluto di un double: " + CalcoliHelper.ValoreAssoluto(-5.5));

            // Minimo
            Console.WriteLine("Minimo tra due interi: " + CalcoliHelper.Minimo(5, 3));
            Console.WriteLine("Minimo tra due double: " + CalcoliHelper.Minimo(5.5, 3.2));

            // Massimo
            Console.WriteLine("Massimo tra due interi: " + CalcoliHelper.Massimo(5, 3));
            Console.WriteLine("Massimo tra due double: " + CalcoliHelper.Massimo(5.5, 3.2));

            // Potenza
            Console.WriteLine("Elevamento a potenza di due interi: " + CalcoliHelper.Potenza(2, 3));


            Console.ReadKey();
        }
    }
}
