using BlazorInputFile;

namespace BismillahSealConsultant.Service
{
    public class FileUpload : IFileUpload
    {

        private readonly IWebHostEnvironment _enviournment;

        public FileUpload(IWebHostEnvironment environment)
        {
            _enviournment = environment;
        }

        public async Task UploadAsync(IFileListEntry fileEntry, string fileName, string route)
        {
            var basePath = Path.Combine("wwwroot", route.ToString());

            var path = Path.Combine(_enviournment.ContentRootPath, basePath, fileName);
            var ms = new MemoryStream();

            await fileEntry.Data.CopyToAsync(ms);

            using (FileStream file = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                ms.WriteTo(file);
            }

        }


    }
}
