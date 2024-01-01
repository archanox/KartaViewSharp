namespace KartaViewSharp.V1.Interfaces;

/// <summary>
/// Video methods provide access to information and operations relating to the videos.
/// All the sequence's photos are recorded into a video.
/// The video is uploaded to the server, splited into photos, and processed.
/// During processing time, the video has several processing statuses:
/// NEW: video isn't processed yet.
/// SPLIT_FINISH: video split is finished.
/// </summary>
internal interface IVideo
{
    /// <summary>
    /// The video contains all the recorded sequences'photos.
    /// After being uploaded to the server, the video is splited into photos, and then processed.
    /// During the video processing, the video has the following processing statuses:
    /// NEW: the video isn't uploaded yet.
    /// SPLIT_FINISHED: the video split is finished.
    /// </summary>
    /// <param name="sequenceId"></param>
    /// <param name="sequenceIndex"></param>
    /// <param name="video"></param>
    /// <param name="accessToken"></param>
    /// <returns></returns>
    Task<object> UploadVideoToSpecificSequence(int sequenceId, int sequenceIndex, byte[] video, string accessToken);
}