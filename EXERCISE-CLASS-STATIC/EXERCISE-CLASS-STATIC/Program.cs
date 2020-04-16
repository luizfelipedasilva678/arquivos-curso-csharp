using System;

namespace EXERCISE_CLASS_STATIC
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  EXERCISE - 1
                Pessoa pessoa1;
                pessoa1 = new Pessoa();
                Pessoa pessoa2;
                pessoa2 = new Pessoa();

                pessoa1.Nome = Console.ReadLine();
                pessoa1.Idade = int.Parse(Console.ReadLine());

                pessoa2.Nome = Console.ReadLine(); ;
                pessoa2.Idade = int.Parse(Console.ReadLine());

                Console.WriteLine(pessoa1);
                Console.WriteLine("-------------");
                Console.WriteLine(pessoa2);
                Console.WriteLine("-------------");

                if(pessoa1.Idade > pessoa2.Idade)
                {
                    Console.WriteLine("Mais velho: "+pessoa1.Nome);
                }
                else
                {
                    Console.WriteLine("Mais velho: " + pessoa2.Nome);
                }
            */

            /* Exercise 2
                Funcionario func1 = new Funcionario();
                Funcionario func2 = new Funcionario();
            
                Console.WriteLine("Digite os dados do Funcionário: ");
                Console.WriteLine("Nome: ");
                func1.setName(Console.ReadLine());
                Console.WriteLine("Salário: ");

                func1.setSalary(double.Parse(Console.ReadLine()));
            
                Console.WriteLine("-------------------------------");
           
                Console.WriteLine("Digite os dados do Funcionário: ");
                Console.WriteLine("Nome: ");
                func2.setName(Console.ReadLine());
                Console.WriteLine("Salário: ");
                func2.setSalary(double.Parse(Console.ReadLine()));

                Console.WriteLine(func1+"\n"+func2+"\n"+"Média dos Salários: "+((func1.getSalary()+func2.getSalary())/2));
            */


            /*
                Retangulo retangulo = new Retangulo();

                retangulo.Largura = double.Parse(Console.ReadLine());
                retangulo.Altura = double.Parse(Console.ReadLine());

                Console.WriteLine(retangulo);
           */


            /*
                Func2 func;
                func = new Func2();
                func.Salario = 6000.00;
                func.Imposto = 1000.00;

                Console.WriteLine(func);
                func.AumentarSalario(double.Parse(Console.ReadLine()));
                Console.WriteLine(func.Salario);
            */

            Aluno aluno = new Aluno();

            aluno.Nome = "João";
            aluno.Nota1 = 32.00;
            aluno.Nota2 = 31.00;
            aluno.Nota3 = 27.00;

            Console.WriteLine(aluno.NotaFinal());


        }
    }
}
