//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore.Http;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Linq;
//using System.Threading.Tasks;

//namespace ErpOnClick.Recruitment.Utilities
//{
//    public static   class  FileHandling
//    {
//        public static async Task<string> UploadFile(IWebHostEnvironment _HostEnvironment, IFormFile ufile)
//        {
//            string filePath = String.Empty;
//            string wwwRootPath = _HostEnvironment.WebRootPath;
//            if (ufile != null)
//            {
//                try
//                {
//                    var filePathDirectory = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\Files");
//                    if (!Directory.Exists(filePathDirectory))
//                    {
//                        Directory.CreateDirectory(filePathDirectory);
//                    }

//                    string fileNameInsurance = Path.GetFileNameWithoutExtension(ufile.FileName);
//                    string extensionInsurance = Path.GetExtension(ufile.FileName);
//                    filePath = fileNameInsurance = fileNameInsurance + DateTime.Now.ToString("yymmssfff") + extensionInsurance;
//                    string pathInsurance = Path.Combine(wwwRootPath + "/Files/" + fileNameInsurance);
//                    using (var fileStream = new FileStream(pathInsurance, FileMode.Create))
//                    {
//                        await ufile.CopyToAsync(fileStream);
//                    }
//                }
//                catch (Exception ex)
//                {


//                }
//                return filePath;
//            }
//            else
//            {
//                return filePath;
//            }
         
            
//        }
//        public static async Task<IFormFile> DownloadFile(IWebHostEnvironment _HostEnvironment, string filePath)
//        {
//            var docDel = Path.Combine(_HostEnvironment.WebRootPath, "Files", filePath);
//            FileInfo fiDoc = new FileInfo(docDel);
//            IFormFile file = null;
//            try
//            {
//                using (var stream = File.OpenRead(docDel))
//                {
//                     file = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name))
//                    {
//                        Headers = new HeaderDictionary(),
//                        ContentType = "application/pdf"
//                    };
//                }
//            }
//            catch (Exception ex)
//            {


//            }
//            return file;
//        }
//        public static bool DeleteFile(IWebHostEnvironment _HostEnvironment, string pathOfFile)
//        {
//            try
//            {
//                var docDel = Path.Combine(_HostEnvironment.WebRootPath, "Files", pathOfFile);
//                FileInfo fiDoc = new FileInfo(docDel);
           
//                if (fiDoc != null)
//                {
//                    System.IO.File.Delete(docDel);
//                    fiDoc.Delete();
//                }
//                return true;
//            }
//            catch (Exception ex)
//            {


//            }
//            return false;
//        }
//    }
//}
