using KartaViewSharp.ResponseData;

namespace KartaViewSharp.Interfaces;

public interface IUser
{
	Task<Response> RetrieveUsers();

	Task<Response> GetTheDetailsOfAUser(string userId);

	Task<Response> DeleteAUser();

	Task<Response> GetTheMetricsDetailsOfAUser();
}