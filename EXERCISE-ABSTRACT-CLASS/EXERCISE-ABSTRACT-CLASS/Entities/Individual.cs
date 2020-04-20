namespace EXERCISE_ABSTRACT_CLASS.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditudes { get; set; }

        public Individual()
        {
        }

        public Individual(string nome, double anualIcome, double healthExpenditudes) : base(nome,anualIcome)
        {
            HealthExpenditudes = healthExpenditudes;
        }

        public override double tax()
        {
            if(AnualIncome < 20000.00)
            {
                return AnualIncome * 0.15;
            }else if (HealthExpenditudes > 0)
            {
                return (AnualIncome * 0.25) - (HealthExpenditudes * 0.5);
            }
            else
            {
                return AnualIncome * 0.25;
            }
        }
    }
}
