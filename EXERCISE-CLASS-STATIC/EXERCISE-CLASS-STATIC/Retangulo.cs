using System;

namespace EXERCISE_CLASS_STATIC
{
    class Retangulo
    {
        public double Altura;
        public double Largura;

        private double Area()
        {
            return Largura * Altura;
        }

        private double Perimetro()
        {
            return Altura + Altura + Largura + Largura;
        }

        private double  Diagonal()
        {
            return Math.Sqrt(Largura * Largura + Altura * Altura);
        }

        public override string ToString()
        {
            return "Área: " + Area() + "\n" + "Perímetro: " + Perimetro() +"\n"+ "Diagonal: " + Diagonal();
        }

    }
}
