using KartaViewSharp.ResponseData;

namespace KartaViewSharp.Interfaces;

public interface IPhotoPart
{
	Task<Response> RetrievePhotoParts();

	Task<Response> CreateANewPhotoPart();

	Task<Response> UpdateTheDetailsOfAPhotoPart();

	Task<Response> GetTheDetailsOfAPhotoPart();

	Task<Response> DeleteAPhotoPart();
}