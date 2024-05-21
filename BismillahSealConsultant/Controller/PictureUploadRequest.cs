namespace BismillahSealConsultant.Controller
{
    public class PictureUploadRequest
    {
        public Guid EmployeeId { get; set; }
        public string PictureBase64 { get; set; }
    }
}
