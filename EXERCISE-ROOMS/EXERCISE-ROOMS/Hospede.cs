

namespace EXERCISE_ROOMS
{
    class Hospede
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public Hospede(string nome,string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

    }
}
