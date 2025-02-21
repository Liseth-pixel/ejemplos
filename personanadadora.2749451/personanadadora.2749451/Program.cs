using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personanadadora._2749451


{
    public class personanadadora
    {
        static void Main(string[] args)
        {
            PersonaNadadora personal = new PersonaNadadora("verdes", "187", "85", "v");
            Console.WriteLine("descripcion de la persona");
            Console.WriteLine("ojos:" + personal.ojos);
            Console.WriteLine("altura:" + personal.altura);
            Console.WriteLine("peso:" + personal.peso);
            Console.WriteLine("sexo:" + personal.sexo);
            personal.Hablar("me llamo borja");
            Console.WriteLine("color de mis ojos" + personal.ojos);
            personal.correr(1000);
            Console.WriteLine("mi peso actual es"+ personal.peso);
            personal.Nadar();
            Console.WriteLine("tras nadar peso:"+ personal.peso);

            Console.ReadKey();
        }
    }
}