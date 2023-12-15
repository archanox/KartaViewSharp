using KartaViewSharp.ResponseData;

namespace KartaViewSharp.Interfaces;

public interface IDashboard
{
	Task<Response> GetUserTypeMetricIntervalData();

	Task<Response> GetPlatformMetricIntervalData(PlatformMatric platformMetrics);

	Task<Response> GetUniqueDistanceMetricIntervalData();

	Task<Response> GetTotalDistanceMetricIntervalData();

	Task<Response> GetPlatformMetricIntervalData(PhotosCountMetric photosCountMetrics);

	Task<Response> GetMetricsDataBasedOnMetricType();

	Task<Response> GetTheDetailsOfASequence();

	Task<Response> RetrieveSequences();

	Task<Response> GetTheDetailsOfAUser();

	Task<Response> RetrieveUsers();

	Task<Response> GetTheDetailsOfAnIssue();

	Task<Response> RetrieveIssues();

	Task<Response> GetTheDetailsOfARegion();

	Task<Response> RetrieveVisibleRegions();
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