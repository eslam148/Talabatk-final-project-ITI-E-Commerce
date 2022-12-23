using E_Commerce_Back_End.Models;
using E_CommerceDB;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Metrics;
using System.Net;
using System.Reflection;

namespace E_Commerce_Back_End.Services
{
    public class UserAddressServices : Iaddress
    {
        private readonly LibraryContext db;
        public UserAddressServices(LibraryContext _db)
        {
            db = _db;

        }
        public void AddAddress(UserAddressCreateModel address)
        {
            UserAddress userAddress = new UserAddress()
            {
                address_line1 = address.Address_line1,
                country = address.Country,
                city = address.City,
                postal_code = address.Postal_Code,
                mobile = address.Mobile,
                IsDeleted = false,
                user_id= address.User_id
            };
            db.UserAddress.Add(userAddress);
            db.SaveChanges();
        }

    }
}
