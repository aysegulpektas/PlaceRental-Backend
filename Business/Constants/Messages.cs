
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string PlaceAdded = "Mekan eklendi";
        public static string PlaceDeleted = "Mekan silindi";
        public static string PlaceUpdated = "Mekan güncellendi";
        public static string PlaceNameInvalid = "Mekan ismi geçersiz";
        public static string PlacesListed = "Mekanlar listelendi";


        public static string CardNumberInvalid = "Kart Numarası geçersiz";
        public static string CardAdded = "Kart eklendi";
        public static string CardDeleted = "Kart silindi";
        public static string CardUpdated = "Kart güncellendi";
        public static string CardsListed = "Kartlar listelendi";


        public static string CategoryAdded = "Kategori eklendi";
        public static string CategoryDeleted = "Kategori silindi";
        public static string CategoryUpdated = "Kategori güncellendi";
        public static string CategorysListed = "Kategoriler listelendi";


        public static string RentalAdded = "Rental eklendi";
        public static string RentalDeleted = "Rental silindi";
        public static string RentalUpdated = "Rental güncellendi";
        public static string RentalsListed = "Rental listelendi"; //


        public static string CustomerAdded = "Müşteri eklendi"; 
        public static string CustomerDeleted = "Müşteri silindi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomersListed = "Müşteriler listelendi";


        public static string MaintenanceTime = "Sistem bakımda";
        public static string PlaceNameAlreadyExists = "Bu isimde başka bir ürün var";
        public static string CategoryLimitExceded = "İzin verilen kategori limiti aşıldı";
        public static string AuthorizationDenied = "Yetkiniz yok";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string UserRegistered = "Kayıt oldu";
        public static string PasswordError = "Parola hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
