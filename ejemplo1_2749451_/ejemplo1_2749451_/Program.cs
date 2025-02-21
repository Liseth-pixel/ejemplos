using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1_2749451_
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instanciar la clase
            Persona personal=new Persona("Verdes", "187", "85", "V");
            
            Console.WriteLine("descripcion de la persona");
            Console.WriteLine("ojos: " + personal.ojos);
            Console.WriteLine("altura:" + personal.altura);
            Console.WriteLine("peso:" + personal.peso);
            Console.WriteLine("sexo:" + personal.sexo);

            personal.Hablar("me llamo borja");
            Console.WriteLine("color de mis ojos:"+ personal.ojos);
            personal.correr(1000);
            Console.WriteLine("mi oeso actual es:" + personal.peso);
            Console.ReadKey();
        }
    }
}
