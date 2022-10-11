using System;

namespace ejerc_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            float temperaturaDiaria=0f, temperaturaMinima =80f, temperaturaMaxima=0f;
            int diaMax=0, diaMin=0;

            
            Console.WriteLine(". . . REGISTRO DE TEMPERATURA . . . ");

           for(int i=1; i <8; i++){

            Console.WriteLine("Ingrese temperatura, dia N° " + i);
            temperaturaDiaria=Convert.ToInt32(Console.ReadLine());

            if (temperaturaDiaria > temperaturaMaxima ){
                temperaturaMaxima=temperaturaDiaria;
                diaMax=i;
            }
            if (temperaturaDiaria < temperaturaMinima) {
                temperaturaMinima=temperaturaDiaria;
                diaMin=i;
            }
           }
           Console.WriteLine("La temperatura MAXIMA es: " + temperaturaMaxima + " Registrado el dia: " + diaMax);
           Console.WriteLine("La temperatura MINIMA es: " + temperaturaMinima + " Registrado el dia: " + diaMin);
        }
    }
}
