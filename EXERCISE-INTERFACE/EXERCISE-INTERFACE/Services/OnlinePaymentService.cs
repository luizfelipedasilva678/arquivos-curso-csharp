﻿namespace EXERCISE_INTERFACE.Services
{
    interface OnlinePaymentService
    {
        double PaymentFee(double amount);
        double Interest(double amount, int months);
    }
}
