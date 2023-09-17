using System.ComponentModel.Design;

public class Ejercicio11
{
    static void Main(string[] args)
    {
        /* Construir un algoritmo que pida N números por pantalla,
        cuando el usuario ingrese un número negativo, el programa debe finalizar y mostrar en consola
        la cantidad total de números positivos que ingresó hasta antes de ingresarse el número negativo. */


        int contador = 0;
        int n, num;

        Console.WriteLine("Ingrese la cantidad de números que desea evaluar:  ");
        n = Convert.ToInt32(Console.ReadLine());

        do
        {
            Console.WriteLine("Ingrese un número:  ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num >= 0)
            {
                contador++;

            }
            else
            {
                break;
            }
        
        } while (contador < n);
        Console.WriteLine(String.Format("La cantidad de números positivos ingresados es de {0}", contador));




    }




}