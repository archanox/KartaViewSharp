using KartaViewSharp.V2.ResponseData.Sequence;
using KartaViewSharp.V2.ResponseData.Shared;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace KartaViewSharp.V2.ResponseData.Photo
{
	public sealed class PhotoData
	{
		[JsonPropertyName("")]
		public string autoImgProcessingResult { get; set; }

		[JsonPropertyName("")]
		public string autoImgProcessingStatus { get; set; }

		[JsonPropertyName("cameraParameters")]
		public CameraParameter CameraParameters { get; set; }

		[JsonPropertyName("dateAdded")]
		[JsonConverter(typeof(StringAsDateTimeJsonConverter))]
		public DateTime DateAdded { get; set; }

		[JsonPropertyName("dateProcessed")]
		[JsonConverter(typeof(StringAsNullableDateTimeJsonConverter))]
		public DateTime? DateProcessed { get; set; }

		[JsonPropertyName("distance")]
		[JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
		public double? Distance { get; set; }

		[JsonPropertyName("fieldOfView")]
		[JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
		public double? FieldOfView { get; set; }

		[JsonPropertyName("filepath")]
		public string filepath { get; set; }

		[JsonPropertyName("filepathLTh")]
		public string filepathLTh { get; set; }

		[JsonPropertyName("filepathProc")]
		public string filepathProc { get; set; }

		[JsonPropertyName("filepathTh")]
		public string filepathTh { get; set; }

		[JsonPropertyName("fileurl")]
		public Uri fileurl { get; set; }

		[JsonPropertyName("fileurlLTh")]
		public Uri fileurlLTh { get; set; }

		[JsonPropertyName("fileurlProc")]
		public Uri fileurlProc { get; set; }

		[JsonPropertyName("fileurlTh")]
		public Uri fileurlTh { get; set; }

		[JsonPropertyName("from")]
		public string from { get; set; }

		[JsonPropertyName("gpsAccuracy")]
		public string gpsAccuracy { get; set; }

		[JsonPropertyName("hasObd")]
		public string hasObd { get; set; }

		[JsonPropertyName("headers")]
		public string headers { get; set; }

		[JsonPropertyName("heading")]
		public string heading { get; set; }

		[JsonPropertyName("height")]
		public string height { get; set; }

		[JsonPropertyName("id")]
		[JsonConverter(typeof(StringAsIntJsonConverter))]
		public int Id { get; set; }

		[JsonPropertyName("imagePartProjection")]
		public string imagePartProjection { get; set; }

		[JsonPropertyName("isUnwrapped")]
		public string isUnwrapped { get; set; }

		[JsonPropertyName("isWrapped")]
		public string isWrapped { get; set; }

		[JsonPropertyName("lat")]
		[JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
		public double? Latitude { get; set; }

		[JsonPropertyName("lng")]
		[JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
		public double? Longitude { get; set; }

		[JsonIgnore]
		public Coordinate? Location
		{
			get => Latitude is not null && Longitude is not null ? new Coordinate(Latitude.Value, Longitude.Value) : null;
			set
			{
				Latitude = value?.X;
				Longitude = value?.Y;
			}
		}

		[JsonPropertyName("matchLat")]
		[JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
		public double? matchLat { get; set; }

		[JsonPropertyName("matchLng")]
		[JsonConverter(typeof(StringAsNullableDoubleJsonConverter))]
		public double? matchLng { get; set; }

		[JsonIgnore]
		public Coordinate? MatchLocation
		{
			get => matchLat is not null && matchLng is not null ? new Coordinate(matchLat.Value, matchLng.Value) : null;
			set
			{
				matchLat = value?.X;
				matchLng = value?.Y;
			}
		}

		[JsonPropertyName("matchSegmentId")]
		public string matchSegmentId { get; set; }

		[JsonPropertyName("name")]
		public string name { get; set; }

		[JsonPropertyName("orgCode")]
		public string orgCode { get; set; }

		[JsonPropertyName("projection")]
		public string projection { get; set; }

		[JsonPropertyName("projectionYaw")]
		public string projectionYaw { get; set; }

		[JsonPropertyName("qualityDetails")]
		public QualityDetail[] qualityDetails { get; set; }

		[JsonPropertyName("qualityLevel")]
		public string qualityLevel { get; set; }

		[JsonPropertyName("qualityStatus")]
		public string qualityStatus { get; set; }

		[JsonPropertyName("rawDataId")]
		public string rawDataId { get; set; }

		[JsonPropertyName("sequenceId")]
		public string sequenceId { get; set; }

		[JsonPropertyName("sequenceIndex")]
		public string sequenceIndex { get; set; }

		[JsonPropertyName("shotDate")]
		public string shotDate { get; set; }

		[JsonPropertyName("status")]
		public string status { get; set; }

		[JsonPropertyName("storage")]
		public string storage { get; set; }

		[JsonPropertyName("to")]
		public string to { get; set; }

		[JsonPropertyName("unwrapVersion")]
		public string unwrapVersion { get; set; }

		[JsonPropertyName("videoId")]
		public string videoId { get; set; }

		[JsonPropertyName("videoIndex")]
		public string videoIndex { get; set; }

		[JsonPropertyName("visibility")]
		public string visibility { get; set; }

		[JsonPropertyName("wayId")]
		public string wayId { get; set; }

		[JsonPropertyName("width")]
		public string width { get; set; }

		[JsonPropertyName("wrapVersion")]
		public string wrapVersion { get; set; }
	}
}
