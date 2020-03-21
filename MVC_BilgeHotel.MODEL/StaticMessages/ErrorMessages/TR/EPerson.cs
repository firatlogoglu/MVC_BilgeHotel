using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.MODEL.StaticMessages.ErrorMessages.TR
{
    /// <summary>
    /// Bu kütüphane tüm kullancılarla ilgi statik hata mesajları içerir.
    /// </summary>
    public class EPerson
    {
        /// <summary>
        /// Lüften E-Posta Adresiniz ve/veya Şifrenizi Kontrol Ediniz
        /// </summary>
        public static string EmailAdrresPasswordWrongTR { get { return "Lüften E-Posta Adresiniz ve/veya Şifrenizi Kontrol Ediniz"; } }

        /// <summary>
        /// Lüften E-Posta Adresiniz ve/veya Şifrenizi Kontrol Ediniz ve/veya Yekiniz Yok
        /// </summary>
        public static string EmailAdrresPasswordAuthorizationWrongTR { get { return "Lüften E-Posta Adresiniz ve/veya Şifrenizi Kontrol Ediniz ve/veya Yekiniz Yok"; } }
    }
}
