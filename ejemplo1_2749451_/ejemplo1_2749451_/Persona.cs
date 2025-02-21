using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo1_2749451_
{
    public class Persona
    {
        public Persona(string ojos, string altura, string peso, string sexo)
        {
            this.ojos = ojos;
            this.altura = altura;
            this.peso = peso;
            this.sexo = sexo;
        }
        public string ojos;
        public string altura;
        public string peso;
        public string sexo;
        public void Hablar(string texto)
        {
            Console.WriteLine("voy a decir:" + texto);
        }
        public void comer(double calorias)
        {
            Console.WriteLine("Ganando" + calorias + "calorias");
            this.peso += calorias / 1000;
        }
        public void correr(double calorias)
        {
            Console.WriteLine(" perdiendo" + calorias + "calorias");
            this.peso = Convert.ToString(calorias / 1000);
        }
    }
}
