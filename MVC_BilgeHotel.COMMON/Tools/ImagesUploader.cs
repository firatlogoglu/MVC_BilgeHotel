using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;

namespace MVC_BilgeHotel.COMMON.Tools
{
    public class ImagesUploader
    {
        public static string UploadSingleImage(string sverPath, HttpPostedFileBase imgFile)
        {
            if (imgFile != null)
            {
                sverPath = sverPath.Replace("~", string.Empty);
                string[] imgFileArray = imgFile.FileName.Split('.');
                string imgFileExtension = imgFileArray[imgFileArray.Length - 1].ToLower();
                string imgFileName = Guid.NewGuid() + "." + imgFileExtension;

                if (imgFileExtension == "jpg" || imgFileExtension == "jpeg" || imgFileExtension == "gif" || imgFileExtension == "png")
                {
                    if (File.Exists(HttpContext.Current.Server.MapPath(sverPath + imgFileName)))
                    {
                        return "Bu dosya mevcut";
                    }
                    else
                    {
                        var imgFilePath = HttpContext.Current.Server.MapPath(sverPath + imgFileName);
                        imgFile.SaveAs(imgFilePath);
                        return sverPath + imgFileName;
                    }
                }
                else
                {
                    return "Dosya türü yanlış!";
                }
            }
            else
            {
                return "/Uploads/Img/noimage.jpg";
            }

        }
    }
}
