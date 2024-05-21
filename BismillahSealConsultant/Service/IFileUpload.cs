using BlazorInputFile;

namespace BismillahSealConsultant.Service
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry file, string FileName, string root);
    }
}
