using KartaViewSharp.V2.ResponseData.Resources.Sequence;

namespace KartaViewSharp.V2.Interfaces;

public interface IVideo
{
    Task<SequenceResponse> RetrieveVideos();

    Task<SequenceResponse> CreateANewVideo(string authToken);

    Task<SequenceResponse> UpdateTheDetailsOfAVideo(int videoId, string authToken);

    Task<SequenceResponse> GetTheDetailsOfAVideo(int videoId);

    Task<SequenceResponse> DeleteAVideo(int videoId);
}