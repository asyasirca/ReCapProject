using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages //new'lememek için sabit olacak olan yerleri static yaparız
    {
        public static string CarAdded = "Ürün eklendi";
        public static string CarsListed = "Ürünler listelendi";


        public static string MaintenanceTime = "Sistem bakımda";

        public static string DailyPriceListed = "Günlük ücret listelendi";

        public static string BrandNameInvalid = "Ürün ismi geçersiz";
        public static string BrandNameValid = "Model ismi en az 2 karakter olmalıdır.";
        public static string BrandAdded = "Araba modeli eklendi";
        public static string BrandDeleted = "Model adı silindi";
        public static string BrandsListed = "Araba modelleri listelendi";
        public static string BrandUpdated = "Model güncellendi";



        public static string RentalInvalid = "Araba teslim edilmedi,kiralanamaz";
        public static string RentalAdded = "Kiralama eklendi";

        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserNameInvalid = "Kullanıcı adı hatalı,en az 2 karakter içermeli";
        public static string UserDeleted = "Kullanıcı silindi";
    }
}
