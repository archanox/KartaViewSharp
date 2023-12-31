using KartaViewSharp.V2.Enums;
using RestSharp;

namespace KartaViewSharp.V2.Request;

internal static class PhotoFilters
{
	internal static void AddPhotoFilters(this PhotoQueryFilters filters, RestRequest request)
	{
		filters.AddCommonFilters(request);

		if (filters.Join is { Length: > 0 })
		{
			request.AddQueryParameter("join", string.Join(',', filters.Join.Select(x => x.ToString().ToLower())));
		}

		if (filters.SequenceId.HasValue)
		{
			request.AddQueryParameter("sequenceId", filters.SequenceId.Value);
		}

		if (filters.SequenceIndex.HasValue)
		{
			request.AddQueryParameter("sequenceIndex", filters.SequenceIndex.Value);
		}

		if (filters.SearchSequenceType != null)
		{
			var searchSequenceType = filters.SearchSequenceType switch
			{
				SequenceType.Vdb => "vdb",
				SequenceType.Video => "video",
				SequenceType.Photo => "photo",
				_ => throw new ArgumentOutOfRangeException(nameof(filters.SearchSequenceType))
			};
			request.AddQueryParameter("searchSequenceType", searchSequenceType);
		}

		if (filters.SearchPlatform != null)
		{
			var searchPlatform = filters.SearchPlatform switch
			{
				Platform.IOS => "ios",
				Platform.Android => "android",
				Platform.Waylens => "waylens",
				Platform.GoPro => "gopro",
				Platform.Other => "other",
				_ => throw new ArgumentOutOfRangeException(nameof(filters.SearchPlatform))
			};
			request.AddQueryParameter("searchPlatform", searchPlatform);
		}

		if (filters.SearchFieldOfView != null)
		{
			var searchFieldOfView = filters.SearchFieldOfView switch
			{
				FieldOfView.Plane => "plane",
				FieldOfView._180 => "180",
				FieldOfView._360 => "360",
				FieldOfView.DualFisheye => "dual_fisheye",
				_ => throw new ArgumentOutOfRangeException(nameof(filters.SearchFieldOfView))
			};
			request.AddQueryParameter("searchFieldOfView", searchFieldOfView);
		}

		if (filters.UserIds is { Length: > 0 })
		{
			request.AddQueryParameter("userId", string.Join(',', filters.UserIds));
		}

		if (filters.VideoIndex.HasValue)
		{
			request.AddQueryParameter("videoIndex", filters.VideoIndex.Value);
		}

		if (filters.Projection != null)
		{
			var projection = filters.Projection switch
			{
				Projection.Plane => "PLANE",
				Projection.Cylinder => "CYLINDER",
				Projection.Sphere => "SPHERE",
				Projection.Fisheye => "FISHEYE",
				Projection.Cube => "CUBE",
				_ => throw new ArgumentOutOfRangeException(nameof(filters.Projection))
			};
			request.AddQueryParameter("projection", projection);
		}

		if (filters.ProjectionYaw.HasValue)
		{
			request.AddQueryParameter("projectionYaw", filters.ProjectionYaw.Value);
		}

		if (filters.FieldOfView != null)
		{
			var fieldOfView = filters.FieldOfView switch
			{
				FieldOfView.Plane => "plane",
				FieldOfView._180 => "180",
				FieldOfView._360 => "360",
				FieldOfView.DualFisheye => "dual_fisheye",
				_ => throw new ArgumentOutOfRangeException(nameof(filters.FieldOfView))
			};
			request.AddQueryParameter("fieldOfView", fieldOfView);
		}

		if (filters.Location != null)
		{
			request.AddQueryParameter("lat", filters.Location.X);
			request.AddQueryParameter("lng", filters.Location.Y);
		}

		if (filters.Radius != null)
		{
			request.AddQueryParameter("radius", filters.Radius);
		}

		if (filters.ZoomLevel.HasValue && filters.ZoomLevel.Value != 18)
		{
			request.AddQueryParameter("zoomLevel", filters.ZoomLevel.Value);
		}
	}


}