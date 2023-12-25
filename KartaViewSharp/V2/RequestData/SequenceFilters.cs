using KartaViewSharp.V2.Enums;
using RestSharp;

namespace KartaViewSharp.V2.RequestData;

internal static class SequenceFilters
{
	internal static void AddSequenceFilters(this SequenceQueryFilters filters, RestRequest request)
	{
		filters.AddCommonFilters(request);

		if (filters.UserIds is { Length: > 0 })
			request.AddQueryParameter("userId", string.Join(',', filters.UserIds));

		if (filters.TopLeft is { IsValid: true })
			request.AddQueryParameter("tLeft", filters.TopLeft.X + ',' + filters.TopLeft.Y);

		if (filters.BottomRight is { IsValid: true })
			request.AddQueryParameter("bRight", filters.BottomRight.X + ',' + filters.BottomRight.Y);

		if (filters.WithAttachments.HasValue)
			request.AddQueryParameter("withAttachments", filters.WithAttachments.Value);

		if (filters.WithPhotos.HasValue)
			request.AddQueryParameter("withPhotos", filters.WithPhotos.Value);

		if (filters.CountryCode != null)
			request.AddQueryParameter("countryCode", filters.CountryCode.TwoLetterCode);

		if (filters.StartDate != null)
			request.AddQueryParameter("startDate", filters.StartDate.Value);

		if (filters.EndDate != null)
			request.AddQueryParameter("endDate", filters.EndDate.Value);

		if (filters.SequenceStatus != null)
		{
			var sequenceStatus = filters.SequenceStatus switch
			{
				SequenceStatus.Public => "public",
				SequenceStatus.Uploading => "uploading",
				SequenceStatus.Processing => "processing",
				SequenceStatus.Failed => "failed",
				SequenceStatus.Deleted => "deleted",
				_ => throw new ArgumentOutOfRangeException(nameof(filters.SequenceStatus))
			};
			request.AddQueryParameter("sequenceStatus", sequenceStatus);
		}

		if (filters.Platform != null)
		{
			var platform = filters.Platform switch
			{
				Platform.IOS => "ios",
				Platform.Android => "android",
				Platform.Waylens => "waylens",
				Platform.GoPro => "gopro",
				Platform.Other => "other",
				_ => throw new ArgumentOutOfRangeException(nameof(filters.Platform))
			};
			request.AddQueryParameter("platform", platform);
		}

		if (filters.UserType != null)
		{
			var userType = filters.UserType switch
			{
				UserType.Regular => "regular",
				UserType.Driver => "driver",
				UserType.Byod => "byod",
				UserType.Dedicated => "dedicated",
				UserType.Internal => "internal",
				_ => throw new ArgumentOutOfRangeException(nameof(filters.UserType))
			};
			request.AddQueryParameter("userType", userType);
		}

		if (filters.SequenceType != null)
		{
			var sequenceType = filters.SequenceType switch
			{
				SequenceType.Vdb => "vdb",
				SequenceType.Video => "video",
				SequenceType.Photo => "photo",
				_ => throw new ArgumentOutOfRangeException(nameof(filters.SequenceType))
			};
			request.AddQueryParameter("sequenceType", sequenceType);
		}

		if (filters.Region is { Length: > 0 })
			request.AddQueryParameter("region", string.Join(',', filters.Region));
	}
}