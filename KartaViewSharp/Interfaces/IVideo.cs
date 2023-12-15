using KartaViewSharp.ResponseData;

namespace KartaViewSharp.Interfaces;

public interface IVideo
{
	Task<Response> RetrieveVideos();

	Task<Response> CreateANewVideo();

	Task<Response> UpdateTheDetailsOfAVideo();

	Task<Response> GetTheDetailsOfAVideo();

	Task<Response> DeleteAVideo();
}