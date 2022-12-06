using E_Commerce_Back_End.Models;

namespace E_Commerce_Back_End.Services
{
    public interface Ipayment
    {
        public void AddPayment(PaymentDetailsCreateModel paymentDetailsModel);
    }
}
