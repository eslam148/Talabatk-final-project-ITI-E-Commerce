using System.ComponentModel.DataAnnotations;

namespace E_Commerce_Admin_Dashboard_MVC
{
    public class ImageFilter : ValidationAttribute
    {

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            string[] supportedTypes = new[] { "jpg", "jpeg", "jfif","pjpeg","pjp" };
            List<IFormFile> files = (List<IFormFile>)value;
            //bool []flags = new bool[files.Count] ;
            foreach (IFormFile file in files)
            {
                
                var filename = file.FileName.Split(".");
                string ext = filename.Last();
                if (!supportedTypes.Contains(ext))
                {
                    
                    // flags.Append(false);// = false;
                    return new ValidationResult("file extension is not valid");
                }

            }
          
            return ValidationResult.Success;
        }
    }
}
