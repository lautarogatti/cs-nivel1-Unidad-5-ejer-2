using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.*//
            
            int actual, mayor = 0;

            for (int i = 0; i < 10; i++)
            {
                if(i == 0){
                    Console.WriteLine("Por favor ingrese un número:");
                    actual = int.Parse(Console.ReadLine());
                    mayor = actual;
                } else {
                    Console.WriteLine("Por favor ingrese un número:");
                    actual = int.Parse(Console.ReadLine());
                    if(actual > mayor){
                        mayor = actual;
                    }
                }
            }

            Console.WriteLine("El mayor número ingresado fue:" + mayor);
        }
    }
}
