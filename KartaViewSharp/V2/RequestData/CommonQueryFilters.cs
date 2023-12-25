using KartaViewSharp.V2.Enums;
using RestSharp;

namespace KartaViewSharp.V2.RequestData;

static class CommonQueryFilters
{
	internal static void AddCommonFilters(this QueryFilters filters, RestRequest request)
	{
		if (filters.Id?.Length > 0)
			request.AddQueryParameter("id", string.Join(',', filters.Id));

		if (filters.IdInterval.HasValue)
			request.AddQueryParameter("idInterval", $"{filters.IdInterval.Value.Start}-{filters.IdInterval.Value.End}");

		if (filters.Page.HasValue)
			request.AddQueryParameter("page", filters.Page.Value);

		if (filters.ItemsPerPage != 40)
			request.AddQueryParameter("itemsPerPage", filters.ItemsPerPage);

		if (!string.IsNullOrWhiteSpace(filters.OrderBy))
			request.AddQueryParameter("orderBy", filters.OrderBy);

		if (filters.OrderDirection == OrderDirection.Descending)
			request.AddQueryParameter("orderDirection", "desc");

		if (filters.Units == Units.Imperial)
			request.AddQueryParameter("units", "imperial");

		if (filters.Join is { Length: > 0 })
			request.AddQueryParameter("join", string.Join(',', filters.Join));
	}
}