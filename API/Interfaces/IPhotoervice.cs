using CloudinaryDotNet.Actions;

namespace API.Interfaces
{
    public interface IPhotoervice
    {
        Task<ImageUploadResult> AddPhotoAsync(IFormFile file);
        Task<DeletionResult> DeletePhotoAsync(string publicId);
    }
}
