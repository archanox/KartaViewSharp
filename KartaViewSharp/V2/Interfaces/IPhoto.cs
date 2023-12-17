using KartaViewSharp.V2.ResponseData;

namespace KartaViewSharp.V2.Interfaces;

public interface IPhoto
{
    Task<SequenceResponse> RetrievePhotos();

    Task<SequenceResponse> CreateANewPhoto();

    Task<SequenceResponse> GetTheDetailsOfAPhoto();

    Task<SequenceResponse> UpdateTheDetailsOfAPhoto();

    Task<SequenceResponse> DeleteAPhoto();

    Task<SequenceResponse> RetrieveAllPhotoPartsBasedOnThePhotoId();
}