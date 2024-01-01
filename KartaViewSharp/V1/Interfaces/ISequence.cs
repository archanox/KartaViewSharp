using KartaViewSharp.V1.Request;
using KartaViewSharp.V1.Response.Resources.MyList;

namespace KartaViewSharp.V1.Interfaces;

/// <summary>
/// Sequence methods provide access to information and operations related to OSV sequences.
/// A sequence is composed by multiple photos, recorded during one trip.
/// Each sequence taken with the OSV apps has a metadata file associated.
/// Metadata file contains information like: photo timestamp, photo position(lat, long), elevation, GPS speed, OBD2 speed, sensors information, etc.
/// After creating the sequence and uploading the video, all the data is processed, so the sequence has several processing statuses:
/// NEW: Sequence data isn't processed yet.
/// VIDEO_SPLIT: the uploaded video is spliting.
/// UPLOAD_FINISHED: the video upload is finished.
/// PROCESSING_FINISHED: data processing is finished.
/// PROCESSING_FAILED: data processing failed.
/// </summary>
internal interface ISequence
{
    /// <summary>
    /// Get Sequence details.
    /// </summary>
    /// <param name="sequenceId"></param>
    /// <returns></returns>
    Task<object> GetSequenceDetails(int sequenceId);

    /// <summary>
    /// On sequence creation, the metadata file is required.
    /// </summary>
    /// <param name="accessToken"></param>
    /// <returns></returns>
    Task<object> CreateSequence(string accessToken);

    /// <summary>
    /// Each sequence has a collection of photos ordered by sequenceIndex.
    /// </summary>
    /// <param name="sequenceId"></param>
    /// <param name="accessToken"></param>
    /// <returns></returns>
    Task<object> GetSequencesPhotoList(string sequenceId, string accessToken);

    /// <summary>
    /// Remove the sequence by specifying its ID. The sequence and all its data will be removed.
    /// </summary>
    /// <param name="sequenceId"></param>
    /// <param name="accessToken"></param>
    /// <returns></returns>
    Task<object> RemoveSequence(string sequenceId, string accessToken);

    /// <summary>
    /// After uploading the video, the server should be notified that the uploading is finished. So the sequence processing status is changed from NEW to UPLOAD_FINISHED.
    /// </summary>
    /// <param name="sequenceId"></param>
    /// <param name="accessToken"></param>
    /// <returns></returns>
    Task<object> NotifyTheServerThatTheUploadingHasBeenFinished(string sequenceId, string accessToken);

	/// <summary>
	/// Get the list of sequences.
	/// </summary>
	/// <param name="accessToken"></param>
	/// <param name="queryFilters"></param>
	/// <returns></returns>
	Task<MyListResponse> ListOfSequences(string accessToken, QueryFilters queryFilters);
}