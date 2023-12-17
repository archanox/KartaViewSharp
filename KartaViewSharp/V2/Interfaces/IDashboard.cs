using KartaViewSharp.V2.ResponseData;

namespace KartaViewSharp.V2.Interfaces;

public interface IDashboard
{
    Task<SequenceResponse> GetUserTypeMetricIntervalData();

    Task<SequenceResponse> GetPlatformMetricIntervalData(PlatformMatric platformMetrics);

    Task<SequenceResponse> GetUniqueDistanceMetricIntervalData();

    Task<SequenceResponse> GetTotalDistanceMetricIntervalData();

    Task<SequenceResponse> GetPlatformMetricIntervalData(PhotosCountMetric photosCountMetrics);

    Task<SequenceResponse> GetMetricsDataBasedOnMetricType();

    Task<SequenceResponse> GetTheDetailsOfASequence(int dashboardSequenceId);

    Task<SequenceResponse> RetrieveSequences();

    Task<SequenceResponse> GetTheDetailsOfAUser(int dashboardUserId);

    Task<SequenceResponse> RetrieveUsers();

    Task<SequenceResponse> GetTheDetailsOfAnIssue(int dashboardIssueId);

    Task<SequenceResponse> RetrieveIssues();

    Task<SequenceResponse> GetTheDetailsOfARegion(int dashboardRegionId);

    Task<SequenceResponse> RetrieveVisibleRegions();
}

[Flags]
public enum PhotosCountMetric
{
    unitPhotosCount,
    intervalPhotosCount,
    totalPhotosCount,
    unitMatchedPhotosCount,
    intervalMatchedPhotosCount,
    totalMatchedPhotosCount,
    unitUnmatchedPhotosCount,
    intervalUnmatchedPhotosCount,
    totalUnmatchedPhotosCount,
    unitActivePhotosCount,
    unitDeletedPhotosCount,
    intervalActivePhotosCount,
    intervalDeletedPhotosCount,
    totalActivePhotosCount,
    totalDeletedPhotosCount,
    uploadingPhotosCount,
    processingPhotosCount,
    totalUploadingPhotosCount,
    totalProcessingPhotosCount,
}

[Flags]
public enum PlatformMatric
{
    unitIOSPhotos,
    unitAndroidPhotos,
    unitWaylensPhotos,
    unitGoProPhotos,
    unitOtherPhotos,
    intervalIOSPhotos,
    intervalAndroidPhotos,
    intervalWaylensPhotos,
    intervalGoProPhotos,
    intervalOtherPhotos,
    totalIOSPhotos,
    totalAndroidPhotos,
    totalWaylensPhotos,
    totalGoProPhotos,
    totalOtherPhotos,
}