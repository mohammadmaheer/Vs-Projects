using OneToManyCrudOper.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OneToManyCrudOper.Controllers
{
    public class FileUploadController : Controller
    {
        // GET: FileUpload.
        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase image)
        {
            if (Request.Files.Count > 0)
            {
                //var file = Request.Files[0];

                if (image != null && image.ContentLength > 0)
                {
                    var fileName = Path.GetFileName(image.FileName);
                    var path = Path.Combine(Server.MapPath("~/App_Data/"), fileName);//c:\users\mohd.maheer\
                    image.SaveAs(path);
                }

            }
            return View();
        }
    }
}