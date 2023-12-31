using System.Net;
using JetBrains.Annotations;
using Xunit;
using KartaViewSharp.V2.Response.Resources.Sequence;
using System.Text.Json.Serialization;
using System.Text.Json;

namespace KartaViewSharp.Tests.V2;

[TestSubject(typeof(SequenceResponse))]
public class SequenceResponseTest
{
	private readonly JsonSerializerOptions _jsonSerializerOptions = new()
	{
		ReferenceHandler = ReferenceHandler.Preserve,
		TypeInfoResolver = new SequenceResponseContext()
	};

	[Fact]
	public void TestRetrieveSequences()
	{
		var result = JsonSerializer.Deserialize<SequenceResponse>(JsonResources.TestRetrieveSequences, _jsonSerializerOptions);

		Assert.Equal(600, result.Status.ApiCode);
		Assert.Equal(HttpStatusCode.OK, result.Status.HttpCode);
		Assert.NotNull(result);
	}

	[Fact]
	public void TestRetrieveSequencesWithUser()
	{
		var result = JsonSerializer.Deserialize<SequenceResponse>(JsonResources.TestRetrieveSequencesWithUser, _jsonSerializerOptions);

		Assert.Equal(600, result.Status.ApiCode);
		Assert.Equal(HttpStatusCode.OK, result.Status.HttpCode);
		Assert.NotNull(result);
		Assert.NotNull(result.Result.Data[0].User);
	}

	[Fact]
	public void TestRetrieveSequencesWithPhoto()
	{
		var result = JsonSerializer.Deserialize<SequenceResponse>(JsonResources.TestRetrieveSequencesWithPhoto, _jsonSerializerOptions);

		Assert.Equal(600, result.Status.ApiCode);
		Assert.Equal(HttpStatusCode.OK, result.Status.HttpCode);
		Assert.NotNull(result);
		Assert.NotNull(result.Result.Data[0].Photo);
		Assert.NotNull(result.Result.Data[0].Photo.QualityDetails);
		Assert.Null(result.Result.Data[0].Photo.CameraParameters);
	}

	[Fact]
	public void TestRetrieveSequencesWithPhotos()
	{
		var result = JsonSerializer.Deserialize<SequenceResponse>(JsonResources.TestRetrieveSequencesWithPhotos, _jsonSerializerOptions);

		Assert.Equal(600, result.Status.ApiCode);
		Assert.Equal(HttpStatusCode.OK, result.Status.HttpCode);
		Assert.NotNull(result);
		Assert.Single(result.Result.Data);
		Assert.NotNull(result.Result.Data[0].Photos);
	}

	//[Fact]
	//public void TestRetrieveSequencesWithAttachment()
	//{
	//	var result = System.Text.Json.JsonSerializer.Deserialize<SequenceResponse>(JsonResources.TestRetrieveSequencesWithAttachment, _jsonSerializerOptions);

	//	Assert.Equal(600, result.Status.ApiCode);
	//	Assert.Equal(HttpStatusCode.OK, result.Status.HttpCode);
	//	Assert.NotNull(result);
	//	//Assert.NotNull(result.Result.Data[0].Attachment);
	//}

	//[Fact]
	//public void TestRetrieveSequencesWithAttachments()
	//{
	//	var result = System.Text.Json.JsonSerializer.Deserialize<SequenceResponse>(JsonResources.TestRetrieveSequencesWithAttachments, _jsonSerializerOptions);

	//	Assert.Equal(600, result.Status.ApiCode);
	//	Assert.Equal(HttpStatusCode.OK, result.Status.HttpCode);
	//	Assert.NotNull(result);
	//	//Assert.NotNull(result.Result.Data[0].Attachments);
	//}
}