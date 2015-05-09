using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo__paint
{
    class Program
    {
        static void Main(string[] args)
        {
           Retangulo a = new Retangulo(34, 20, 300, 40);
           Retangulo b = new Retangulo(34, 20, 30, 40);
           Retangulo c = new Retangulo(34, 20, 3, 40);
           a.Imprime();
           c.Contador();
           c.Zera_Contador();
           c.Contador();
           Console.ReadKey(false);
        }
    }

    public class Retangulo
    { 
        int x = 0;
        int y =  0;
        int largura = 0;
        int altura = 0;
        static int contador = 0;

        public Retangulo(int x, int y, int largura, int altura)
        {
            this.x = x;
            this.y = y;
            this.largura = largura;
            this.altura = altura;
            contador++;
        }

        public String Imprime()
        {
            string retangulo;
            retangulo = "retangulo[x:" + x + ",y:" + y + ",l:" + largura + ",a:" + altura + "]";
            Console.WriteLine("Dados do retângulo:  " + retangulo);
            return retangulo;           
        }

        public void Contador()
        {
            Console.WriteLine("Objetos criados = " + contador);
                
        }

        public void Zera_Contador()
        {
            contador = 0;
        }
    }
}
