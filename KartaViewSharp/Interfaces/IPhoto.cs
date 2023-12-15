using KartaViewSharp.ResponseData;

namespace KartaViewSharp.Interfaces;

public interface IPhoto
{
	Task<Response> RetrievePhotos();

	Task<Response> CreateANewPhoto();

	Task<Response> GetTheDetailsOfAPhoto();

	Task<Response> UpdateTheDetailsOfAPhoto();

	Task<Response> DeleteAPhoto();

	Task<Response> RetrieveAllPhotoPartsBasedOnThePhotoId();
}