using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace poo__paint
{
    class Program
    {
        static void Main(string[] args)
        {
            AreaDeDesenho area = new AreaDeDesenho();
            area.AdicionaFigura(new Retangulo(3, 4, 20, 50));
            area.AdicionaFigura(new Circulo(150, 45, 20));
            Application.Run(area);

            Figura d = new Figura();
        }
    }

    //Classe Retangulo At. 1 e 2.
    public class Retangulo : Figura
    {
        private int plargura;
        private int paltura;
        static int Fcontador;

        public Retangulo(int x, int y, int largura, int altura)
        {
            xF = x;
            yF = y;
            plargura = largura;
            paltura = altura;

            Fcontador += 1;
        }

        public override string Imprime()
        {
            return "retangulo[x:" + xF + ",y:" + yF + ",l:" + plargura + ",a:" + paltura + "]";
        }

        public static void ZeraContador()
        {
            Fcontador = 0;
        }

        public static int LeContador()
        {
            return Fcontador;
        }

        public override void Desenha(Graphics g)
        {
            g.DrawRectangle(Pens.Black, xF, yF, plargura, paltura);
        }
    }

    //Classe Circulo At. 3
    public class Circulo : Figura
    {
        private int Fraio;
        static int Fcontador;

        public Circulo(int x, int y, int raio)
        {
            xF = x;
            yF = y;
            Fraio = raio;

            Fcontador += 1;
        }

        public override string Imprime()
        {
            return "circulo[x:" + xF + ",y:" + yF + ",raio:" + Fraio + "]";
        }

        public static void ZeraContador()
        {
            Fcontador = 0;
        }

        public static int LeContador()
        {
            return Fcontador;
        }

        public override void Desenha(Graphics g)
        {
            g.DrawEllipse(Pens.Black, xF, yF, Fraio * 2, Fraio * 2);
        }
    }

    public class Figura
    {
        protected int xF;
        protected int yF;

        public virtual string Imprime()
        {
            return "figura[x:" + xF + ",y:" + yF + "]";
        }

        public virtual void Desenha(Graphics g)
        {
        }
    }
}