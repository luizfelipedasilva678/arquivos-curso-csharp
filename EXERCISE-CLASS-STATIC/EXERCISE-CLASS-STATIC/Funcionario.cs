using System;

namespace EXERCISE_CLASS_STATIC
{
    class Funcionario
    {
        private string Name;
        private double Salary;

        public string getName()
        {
            return Name;
        }

        public void setName(string nome)
        {
            Name = nome;
        }

        public double getSalary()
        {
            return Salary;
        }

        public void setSalary(double salary)
        {
            Salary = salary;
        }

        public override string ToString()
        {
            return "Salário do " + Name + ": " + Salary;
        }

    }
}
