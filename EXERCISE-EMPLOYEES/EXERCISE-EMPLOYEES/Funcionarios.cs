namespace EXERCISE_EMPLOYEES
{
    class Funcionarios
    {
        public int Id { get; private set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }
        
        public Funcionarios(int id, string nome, double salario)
        {
            Id = id;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double porcentagem)
        {
            Salario = Salario * (1+(porcentagem) / 100);
        }

    }
}
