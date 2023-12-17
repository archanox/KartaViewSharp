using KartaViewSharp.V2.ResponseData;

namespace KartaViewSharp.V2.Interfaces;

public interface IPhoto
{
    Task<SequenceResponse> RetrievePhotos();

    Task<SequenceResponse> CreateANewPhoto(string authToken);

    Task<SequenceResponse> GetTheDetailsOfAPhoto(int photoId);

    Task<SequenceResponse> UpdateTheDetailsOfAPhoto(int photoId, string authToken);

    Task<SequenceResponse> DeleteAPhoto(int photoId);

    Task<SequenceResponse> RetrieveAllPhotoPartsBasedOnThePhotoId(int photoId);
}