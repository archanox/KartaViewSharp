namespace KartaViewSharp.V2.Interfaces;

internal interface IVideo
{
    Task<object> RetrieveVideos();

    Task<object> CreateANewVideo(string authToken);

    Task<object> UpdateTheDetailsOfAVideo(int videoId, string authToken);

    Task<object> GetTheDetailsOfAVideo(int videoId);

    Task<object> DeleteAVideo(int videoId);
}