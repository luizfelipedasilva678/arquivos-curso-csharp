using System;

namespace EXERCISE_CLASS_STATIC
{
    class Func2
    {
        public double Imposto;
        public double Salario;
        public string Nome;

        public double SalarioLiquido()
        {
            return Salario - Imposto;
        }

        public void AumentarSalario(double porcent)
        {
            Salario = SalarioLiquido() * (1+(porcent/100));
        }

        public override string ToString()
        {
            return "Nome: " + Nome + "\n" +"Salário Líquido: " + SalarioLiquido();
        }

    }
}
