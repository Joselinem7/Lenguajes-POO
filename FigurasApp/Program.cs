using System;
using System.Collections.Generic;

namespace FigurasApp
{
    abstract class Figura
    {
        private string nombre;

        protected Figura(string nombre)
        {
            this.nombre = nombre;
        }

        public string ObtenerNombre()
        {
            return nombre;
        }

        public abstract double CalcularArea();

        public string Describir()
        {
            return ObtenerNombre() + " con área " + CalcularArea().ToString("F2");
        }
    }

    class Circulo : Figura
    {
        private double radio;

        public Circulo(double radio) : base("Círculo")
        {
            if (radio <= 0)
            {
                throw new ArgumentException("El radio debe ser positivo.");
            }

            this.radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * radio * radio;
        }
    }

    class Rectangulo : Figura
    {
        private double baseFigura;
        private double altura;

        public Rectangulo(double baseFigura, double altura) : base("Rectángulo")
        {
            if (baseFigura <= 0 || altura <= 0)
            {
                throw new ArgumentException("La base y la altura deben ser positivas.");
            }

            this.baseFigura = baseFigura;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return baseFigura * altura;
        }
    }

    class Triangulo : Figura
    {
        private double baseFigura;
        private double altura;

        public Triangulo(double baseFigura, double altura) : base("Triángulo")
        {
            if (baseFigura <= 0 || altura <= 0)
            {
                throw new ArgumentException("La base y la altura deben ser positivas.");
            }

            this.baseFigura = baseFigura;
            this.altura = altura;
        }

        public override double CalcularArea()
        {
            return baseFigura * altura / 2;
        }
    }

    class Lenguajes
    {
        static void Main(string[] args)
        {
            List<Figura> figuras = new List<Figura>();

            figuras.Add(new Circulo(2));
            figuras.Add(new Rectangulo(3, 4));
            figuras.Add(new Triangulo(3, 4));

            foreach (Figura figura in figuras)
            {
                Console.WriteLine(figura.Describir());
            }

            Console.ReadKey();
        }
    }
}


