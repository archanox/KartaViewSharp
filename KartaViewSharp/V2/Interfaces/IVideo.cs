using KartaViewSharp.V2.ResponseData;

namespace KartaViewSharp.V2.Interfaces;

public interface IVideo
{
    Task<SequenceResponse> RetrieveVideos();

    Task<SequenceResponse> CreateANewVideo();

    Task<SequenceResponse> UpdateTheDetailsOfAVideo();

    Task<SequenceResponse> GetTheDetailsOfAVideo();

    Task<SequenceResponse> DeleteAVideo();
}