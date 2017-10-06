using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace KH_Template
{
    public static class Paths
    {
        public static string Gallery = "~/images/GalleryForm/";
        public static string Calendar = "~/images/CalendarForm/";
        public static bool UploadImage(string imgPath, FileUpload fileUpload)
        {
            if (fileUpload.HasFile)
            {
                //Check File is available in Fileupload control and then upload to server path
                string getext = Path.GetExtension(fileUpload.PostedFile.FileName);
                string filename = Path.GetFileNameWithoutExtension(fileUpload.PostedFile.FileName);
                if (getext != ".JPEG" && getext != ".jpeg" && getext != ".JPG" && getext != ".jpg" && getext != ".png")
                {
                    return false;
                }
                else
                {
                    fileUpload.SaveAs(imgPath);
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public static void DeleteImage(string imgpath)
        {
            System.IO.File.Delete(imgpath);
        }
    }
}