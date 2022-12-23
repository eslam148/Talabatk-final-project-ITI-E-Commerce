using E_Commerce_Back_End.Models;
using E_CommerceDB;

namespace E_Commerce_Back_End.Services
{
    public class UserPaymentServices : IuserPayment
    {
        private readonly LibraryContext db;
        public UserPaymentServices(LibraryContext _db)
        {
            db = _db;
        }

        public void AddUserPayment(UserPaymentCreateModel userPaymentModel)
        {
            UserPayment userPayment = new UserPayment()
            {
                user_id = userPaymentModel.User_id,
                paymenr_type = userPaymentModel.Payment_Type,
                provider = userPaymentModel.Provider,
                account_no = userPaymentModel.Account_No,
                expire_date = userPaymentModel.Expire_Date,
                IsDeleted = false,
            };
        //    db.UserPayment.Add(userPayment);
            db.SaveChanges();
        }
    }
}
