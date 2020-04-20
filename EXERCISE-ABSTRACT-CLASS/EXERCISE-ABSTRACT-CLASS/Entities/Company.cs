namespace EXERCISE_ABSTRACT_CLASS.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company()
        {
        }

        public Company(string nome, double anualIcome, int numberOfEmployees) : base(nome, anualIcome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double tax()
        {
            if(NumberOfEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }

    }
}
