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

            Figura d = new Figura();
        }
    }

    //Classe Retangulo At. 1 e 2.
    public class Retangulo
    { 
        int x = 0;
        int y =  0;
        int largura = 0;
        int altura = 0;
        private static int contador = 0;

        public Retangulo()
        { 
        }

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

        public static int LeContador()
        {
            return contador;
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

    //Classe Circulo At. 3
    public class Circulo
    {
        int x=0;
        int y=0;
        int raio=0;
        public Circulo(int x, int y, int raio)
        {
            this.x = x;
            this.y = y;
            this.raio = raio;
        }

        public Circulo()
        {
        }

        public String Imprime()
        {
            string retangulo;
            retangulo = "ciirculo[x:" + x + ",y:" + y + ",raio:" + raio + "]";
            Console.WriteLine("Dados do círculo:  " + retangulo);
            return retangulo;
        }
    }

    public class Figura
    {
        public int x;
        public int y;

        public virtual string Imprime()
        {
            return "[x: y: l: a: raio:]";
        }
    }
}
