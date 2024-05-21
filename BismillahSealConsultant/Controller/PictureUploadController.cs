using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Text.RegularExpressions;
using BismillahSealConsultant.DataContext;
using BismillahSealConsultant.DataModels;
using Microsoft.EntityFrameworkCore;

namespace BismillahSealConsultant.Controller
{
    [Route("picUploader")]
    [ApiController]
    public class PictureUploadController : ControllerBase
    {
        [HttpPost]
        public async Task <IActionResult> UploadEmployeePicture([FromBody] PictureUploadRequest request)
        {
            // Extract the MIME type and convert it to a file extension
            var match = Regex.Match(request.PictureBase64, @"^data:(image\/(png|jpeg|jpg|gif));base64,");
            if (!match.Success)
            {
                return BadRequest("Invalid image format.");
            }

            string mimeType = match.Groups[2].Value;
            string extension = mimeType switch
            {
                "jpeg" => "jpg",
                "jpg" => "jpg",
                "png" => "png",
                "gif" => "gif",
                _ => throw new ArgumentException("Unsupported image type.")
            };

            // Remove the data URI scheme from the base64 string
            string base64Data = request.PictureBase64.Substring(match.Length);

            // Decode the base64 string to get the picture bytes
            byte[] pictureBytes = Convert.FromBase64String(base64Data);

            // Define a file name with the detected extension
            string fileName = $"{request.EmployeeId}.{extension}";

            // Get the path to the wwwroot/Photos folder
            string wwwRootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Photos");

            // Ensure the wwwroot/Photos directory exists
            if (!Directory.Exists(wwwRootPath))
            {
                Directory.CreateDirectory(wwwRootPath);
            }

            using (sealConsultantContext dbcontext = new sealConsultantContext())
            {
                Employee? e = await dbcontext.Employees.FirstOrDefaultAsync(x => x.Id == request.EmployeeId);
                if (e!=null)
                {
                    e.Photo = fileName;

                    dbcontext.Employees.Update(e);

                    await dbcontext.SaveChangesAsync();
                    // Combine the wwwroot/Photos path with the file name to get the full path
                    string filePath = Path.Combine(wwwRootPath, fileName);

                    // Write the picture bytes to the file
                    await System.IO.File.WriteAllBytesAsync(filePath, pictureBytes);

                    // Return success response
                    return Ok();

                }
                else
                {
                    return BadRequest();
                }

            }


          
        }
    }
}
