using E_CommerceDB;
using Microsoft.AspNetCore.Mvc;
using NuGet.ContentModel;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace E_Commerce_Admin_Dashboard_MVC.Controllers
{
    [Route("MVC/[controller]")]
    [ApiController]
    public class ProductAPIController : ControllerBase
    {

        private readonly IProductServices services;
        private readonly ISubcategory subcategory;
        public ProductAPIController(IProductServices services, ISubcategory subcategory)
        {
            this.services = services;
            this.subcategory = subcategory;
        }
        [HttpPost]
        [Route("~/MVC/AddProduct")]
         public IActionResult uploudProductImages([FromBody] ProductsVM product)
        {
         
            if (product.Files != null)
            {
                List<IFormFile> Images = new List<IFormFile>();

                foreach (var File in product.Files)
                {
                 
                    File.FileAsBase64 = File.FileAsBase64.Substring(File.FileAsBase64.IndexOf(",") + 1);
               

                    File.FileAsByteArray = Convert.FromBase64String(File.FileAsBase64);

                    var filePathName = Path.GetFileNameWithoutExtension(File.FileName)
                        +Path.GetExtension(File.FileName);
                    var ms = new MemoryStream(File.FileAsByteArray);

                    IFormFile fromFile = new FormFile(ms, 0, ms.Length,
                        Path.GetFileNameWithoutExtension(filePathName),
                        Path.GetFileName(filePathName));

                        //{
                        //    Headers = new HeaderDictionary(),
                        //    ContentDisposition=$"form-data; name='Images'; filename='{File.FileName}'",
                        //    ContentType = "image/png"
                        //};
                        //fromFile.ContentDisposition;
                        //fromFile.ContentType
                        //'form-data; name="Images"; filename="code1.png"';
                        //image/png

                        Images.Add(fromFile);
                    
                }
                product.Progress = 0;
                   product.Images = Images;
                services.AddProdcut(product);


                return Ok(product);
            }
            else
            {
                return BadRequest(product);
            }
        }
            
    }
}

