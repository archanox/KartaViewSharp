using NetTopologySuite.Geometries;

namespace KartaViewSharp.V1.Interfaces;

/// <summary>
/// Photo methods provide access to information and operations relating to the photos.
/// Photos are stored ordered by sequenceIndex.
/// For each photo, is generated a thumbnail and a large thumbnail.
/// After video spliting, all photos are processed.
/// There are several processing statuses:
/// NEW: Photo isn't processed yet.
/// PROCESSING: Photo is processing.
/// FINISHED: photo processing is running.
/// </summary>
internal interface IPhoto
{
    /// <summary>
    /// Upload the sequence's photo.
    /// </summary>
    /// <param name="sequenceId"></param>
    /// <param name="sequenceIndex"></param>
    /// <param name="coordinate">Coordinates where the photo was taken.</param>
    /// <param name="photo"></param>
    /// <param name="accessToken"></param>
    /// <returns></returns>
    Task<object> UploadPhoto(int sequenceId, int sequenceIndex, Coordinate coordinate, byte[] photo, string accessToken);

    /// <summary>
    /// Remove a photo by specifying photo ID.
    /// </summary>
    /// <param name="photoId"></param>
    /// <param name="accessToken"></param>
    /// <returns></returns>
    Task<object> RemovePhoto(int photoId, string accessToken);
}