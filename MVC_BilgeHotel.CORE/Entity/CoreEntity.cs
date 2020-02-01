using MVC_BilgeHotel.CORE.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MVC_BilgeHotel.CORE.Entity
{
    public class CoreEntity : IEntity<Guid>
    {
        public CoreEntity()
        {
            this.GeneralStatus = GeneralStatus.Active;

            this.CreatedDate = DateTime.Now;
            this.CreatedComputerName = Environment.MachineName;
            this.CreatedComputerUsername = WindowsIdentity.GetCurrent().Name;

            // Eklendi using System.Security.Principal;

            this.CreatedIP = "192.168.1.1";
            this.CreatedUserID = 1;
        }


        public Guid ID { get; set; }

        [Display(Name = "Genel Durum")]
        public GeneralStatus GeneralStatus { get; set; }

        [Display(Name = "Oluşturma Tarihi")]
        public DateTime? CreatedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]

        [Display(Name = "Değiştirme Tarihi")]
        public DateTime? ModifiedDate { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd-MMM-yyyy}", ApplyFormatInEditMode = true)]

        [Display(Name = "Oluşturulan PC'nin Adı")]
        public string CreatedComputerName { get; set; }

        [Display(Name = "Değiştirilen PC'nin Adı")]
        public string ModifiedComputerName { get; set; }


        public string CreatedIP { get; set; }
        public string ModifiedIP { get; set; }

        public string CreatedComputerUsername { get; set; }
        public string ModifiedComputerUsername { get; set; }

        public int? CreatedUserID { get; set; }        
        public int? ModifiedUserID { get; set; }
    }
}
