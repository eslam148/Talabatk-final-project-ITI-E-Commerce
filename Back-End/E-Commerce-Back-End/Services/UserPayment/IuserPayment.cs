using E_Commerce_Back_End.Models;

namespace E_Commerce_Back_End.Services
{
    public interface IuserPayment
    {
        public void AddUserPayment(UserPaymentCreateModel userPaymentModel);
    }
}
