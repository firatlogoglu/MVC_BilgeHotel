using MVC_BilgeHotel.CORE.Enums.Person;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.CORE.Entity
{
    public class PersonEntity : CoreEntity
    {

        [Required(ErrorMessage = "Lütfen T.C numaranızı girin"), Display(Name = "TC Kimlik No")]
        public string TCNO { get; set; }

        [Required(ErrorMessage = "Lütfen adınızı girin"), Display(Name = "Adı")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı girin"), Display(Name = "Soyadı")]
        public string SurName { get; set; }

        [Required(ErrorMessage = "Email boş bırakılamaz"), Display(Name = "E-Posta Adresi")]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" + @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" + @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Email adresi geçersiz")]
        public string EmailAddress { get; set; }

        [Display(Name = "Adres")]
        public string Address { get; set; }

        [Display(Name = "Tel No")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Şifre")]
        public string Password { get; set; }

        [Display(Name = "Doğum Yeri")]
        public string BirthPlace { get; set; }

        [Display(Name = "Doğum Tarihi")]
        public DateTime BirthDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]

        [Display(Name = "Cinsiyet")]
        public Gender Gender { get; set; }
    }
}
