using E_Commerce_Back_End.Models;
using E_CommerceDB;

namespace E_Commerce_Back_End.Services
{
    public class PaymentServices : Ipayment
    {
        private readonly LibraryContext db;
        public PaymentServices(LibraryContext _db)
        {
            db = _db;
        }

        public void AddPayment(PaymentDetailsCreateModel paymentDetailsModel)
        {
            PaymentDetails paymentDetails = new PaymentDetails()
            {
                Amount = paymentDetailsModel.Amount,
                Provider = paymentDetailsModel.Provider,
                Status = paymentDetailsModel.Provider,
                created_at = paymentDetailsModel.Created_at,
                modified_at = paymentDetailsModel.Modified_at
            };
          //  db.Payment_Details.Add(paymentDetails);
            db.SaveChanges();
        }
    }
}
