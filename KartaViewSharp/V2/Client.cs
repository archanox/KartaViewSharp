using System.Text.Json;
using System.Text.Json.Serialization;
using KartaViewSharp.V2.Interfaces;
using KartaViewSharp.V2.ResponseData;
using RestSharp;
using RestSharp.Serializers.Json;

namespace KartaViewSharp.V2
{
    public class Client : ISequence
    {
	    private const string _baseUri = "https://api.openstreetcam.org/2.0";

		

        private static void AddFilters(SequenceQueryFilters filters, RestRequest request)
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

            if(filters.OrderDirection == OrderDirection.Descending)
	            request.AddQueryParameter("orderDirection", "desc");

            if (filters.Units == Units.Imperial)
	            request.AddQueryParameter("units", "imperial");

			if (filters.Join is { Length: > 0 })
				request.AddQueryParameter("join", string.Join(',', filters.Join));

            if(filters.UserIds is { Length: > 0 })
	            request.AddQueryParameter("userId", string.Join(',', filters.UserIds));

            if(filters.TopLeft is { IsValid: true })
	            request.AddQueryParameter("tLeft", filters.TopLeft.X + ',' + filters.TopLeft.Y);

            if (filters.BottomRight is { IsValid: true })
	            request.AddQueryParameter("bRight", filters.BottomRight.X + ',' + filters.BottomRight.Y);

            if(filters.WithAttachments.HasValue)
	            request.AddQueryParameter("withAttachments", filters.WithAttachments.Value);

            if (filters.WithPhotos.HasValue)
	            request.AddQueryParameter("withPhotos", filters.WithPhotos.Value);

            if(filters.CountryCode != null)
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

        public async Task<SequenceResponse> RetrieveSequences(SequenceQueryFilters filters)
        {


	        JsonSerializerOptions options = new()
	        {
		        ReferenceHandler = ReferenceHandler.Preserve,
	        };

	        // Use your custom options to initialize a context instance.
	        MyJsonContext context = new(options);


         RestClient _client = new(_baseUri,
			 configureSerialization: s => s.UseSystemTextJson(new JsonSerializerOptions { TypeInfoResolver = context })
			 );

			var request = new RestRequest("/sequence/");

            AddFilters(filters, request);

            var response = await _client.ExecuteGetAsync<SequenceResponse>(request);
            return response.Data;
        }

        public async Task<SequenceResponse> CreateANewSequence()
        {
            throw new NotImplementedException();
        }

        public async Task<SequenceResponse> GetTheDetailsOfASequence()
        {
            throw new NotImplementedException();
        }

        public async Task<SequenceResponse> UpdateTheDetailsOfASequence()
        {
            throw new NotImplementedException();
        }

        public async Task<SequenceResponse> DeleteASequence()
        {
            throw new NotImplementedException();
        }

        public async Task<SequenceResponse> RetrievePhotosBasedOnTheSequenceId()
        {
            throw new NotImplementedException();
        }

        public async Task<SequenceResponse> RetrieveVideosBasedOnTheSequenceId()
        {
            throw new NotImplementedException();
        }

        public async Task<SequenceResponse> RetrieveSequenceRawdatasBasedOnSequenceId()
        {
            throw new NotImplementedException();
        }

        public async Task<SequenceResponse> RetrieveSequenceAttachmentsBasedOnSequenceId()
        {
            throw new NotImplementedException();
        }

        public async Task<SequenceResponse> RetrieveSequenceBreakdownsBasedOnSequenceId()
        {
            throw new NotImplementedException();
        }

        public async Task<SequenceResponse> RetrieveSequenceMetricsBasedOnSequenceId()
        {
            throw new NotImplementedException();
        }

        public async Task<SequenceResponse> FindAndUpdateSequencesStatusWhenTheUploadIsFinished()
        {
            throw new NotImplementedException();
        }

        public async Task<SequenceResponse> GetMapMatchedTracksDataWithDifferentOutput()
        {
            throw new NotImplementedException();
        }

        public async Task<SequenceResponse> GetAListOfAllTracksBasedOnASpecificBoundingBox()
        {
            throw new NotImplementedException();
        }

        public async Task<SequenceResponse> GetTheDetailsOfAUser(string userId)
        {
	        RestClient _client = new(_baseUri);
			var request = new RestRequest("/user/{userId}");
            request.AddUrlSegment("userId", userId);
            var response = await _client.ExecuteGetAsync<SequenceResponse>(request);
            return response.Data;
        }
    }
}
