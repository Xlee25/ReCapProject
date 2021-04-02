using Core.Entities.Concrete;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Buisness.Constans.Messages
{
    public static class Messages
    {
        public static string CarAdded = "Car Added";
        public static string CarDeleted = "Car Deleted";
        public static string CarsListed = "Cars Listed";
        public static string CarNameInvalid = "Car Name is invalid";
        public static string CarUpdated = "Car Updated";
        public static string CarIdListed = "Car Id Listed";
        public static string GetErrorCarMessage = "Araba mesai eklenemedi";
        public static string GetSuccessCarMessage = "Araba mesaji basariyla eklendi";

        public static string BrandAdded = "Brand Added";
        public static string BrandDeleted = "Brand Deleted";
        public static string BrandsListed = "Brands Listed";
        public static string BrandNameInvalid = "Brand Name is invalid";
        public static string BrandUpdated = "Brand Updated";
        public static string BrandsGetById = "Brand id si getirildi";

        public static string ColorAdded = "Color Added";
        public static string ColorDeleted = "Color Deleted";
        public static string ColorListed = "Color Listed";
        public static string ColorNameInvalid = "Color Name is invalid";
        public static string ColorUpdated = "Color Updated";
        public static string ColorGetById = "Color Id'si Getirildi";

        public static string CategoryAdded = "Category Added";
        public static string CategoryDeleted = "Category Deleted";
        public static string CategoriesListed = "Categories Listed";
        public static string CategoryNameInvalid = "Category Name is invalid";
        public static string CategoryUpdated = "Category Updated";
        public static string GetCustomerById = "Customer listed by id";

        public static string AddCustomerMessage = "Musteri mesaji ekle";
        public static string DeleteCustomerMessages = "Musteri mesaji sil";
        public static string UpdateCustomerMessages = "Musteri mesaji guncelle";
        public static string GetSuccessCustomerMessage = "Musteri mesaji eklendi";
        public static string GetErrorCustomerMessage = "Musteri mesaji eklenemedi";

        public static string RentalAdded = "Rental Added";
        public static string RentalNotAdded = "Rental Not Added !";
        public static string RentalDeleted = "Rental Deleted";
        public static string RentalListed = "Rental Listed";
        public static string RentalNameInvalid = "Rental Name is invalid";
        public static string RentalUpdated = "Rental Updated";

        public static string UserAdded = "User Added";
        public static string UserlNotAdded = "User Not Added !";
        public static string UserDeleted = "User Deleted";
        public static string UserListed = "User Listed";
        public static string UserNameInvalid = "User Name is invalid";
        public static string UserUpdated = "User Updated";
        public static string CarImageLimitExceded = "Maximum image limit";


        public static string AuthorizationDenied= "Yetkiniz Yok";
        public static string UserRegisterd = "Sisteme Kayit Oldunuz";
        public static string UserNotFound = "Kullanici Isminiz Bulunamadi";
        public static string PasswordError = "Sifreniz Yanlis";
        public static string SuccessfulLogin ="Login Isleminiz Basarili";
        public static string UserAlreadyExists ="Hali Hazirda Boyle Kullanici Adi Var";
        public static string AccessTokenCreated ="Anahtariniz Olusturuldu";

        public static string InsufficientBalance = "Yetersiz bakiye";
        public static string PaymentCompleted = "Odeme tamamlandi";
        internal static string CustomerUpdated;
    }
}
