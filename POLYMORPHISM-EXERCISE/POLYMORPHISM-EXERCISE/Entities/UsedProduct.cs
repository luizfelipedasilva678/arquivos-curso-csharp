using System;
namespace POLYMORPHISM_EXERCISE.Entities
{
    class UsedProduct : Product
    {
        public DateTime  ManufactureDate { get; set; }

        public UsedProduct()
        {
        }

        public UsedProduct(string nome, double price, DateTime manuFactureDate) : base(nome, price)
        {
            ManufactureDate = manuFactureDate;
        }

        public override string priceTag()
        {
            return base.priceTag() + " " + $"(Manufacture date: {ManufactureDate.ToString("dd/MM/yyyy")})";
        }
    }
}
