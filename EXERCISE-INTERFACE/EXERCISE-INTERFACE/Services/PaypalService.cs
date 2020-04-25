namespace EXERCISE_INTERFACE.Services
{
    class PaypalService : OnlinePaymentService
    {
        public double PaymentFee(double amount)
        {
            return amount + (amount * 0.02);
        }

        public double Interest(double amount, int months)
        {
            double porcent = 0.01;
            return amount + ((amount * porcent) * months); 
        }
    }
}
