using KartaViewSharp.V2.Enums;
using KartaViewSharp.V2.ResponseData.Resources.Sequence;
using NetTopologySuite.DataStructures;

namespace KartaViewSharp.V2.Interfaces;

public interface IDashboard
{
    Task<SequenceResponse> GetUserTypeMetricIntervalData(UserTypeMetric[] userTypeMetrics, DashboardQueryFilters filters);

    Task<SequenceResponse> GetPlatformMetricIntervalData(PlatformMatric[] platformMetrics);

    Task<SequenceResponse> GetUniqueDistanceMetricIntervalData();

    Task<SequenceResponse> GetTotalDistanceMetricIntervalData();

    Task<SequenceResponse> GetPlatformMetricIntervalData(PhotosCountMetric[] photosCountMetrics);

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

public class DashboardQueryFilters
{
	/// <summary>
	/// Retrieve data based on one of the intervals.
	/// </summary>
	public Interval Interval { get; set; }

	/// <summary>
	/// The starting point of the date interval.
	/// </summary>
	public DateTime StartDate { get; set; }

	/// <summary>
	/// The ending point of the date interval.
	/// </summary>
	public DateTime EndDate { get; set; }

	/// <summary>
	/// The platform of the device that recorded the file.
	/// </summary>
	public Platform Platform { get; set; }

	/// <summary>
	/// Type of the user.
	/// </summary>
	public UserType UserType { get; set; }

	/// <summary>
	/// Unique identifier representing a specific region. Multiple regions can be provided.
	/// </summary>
	public Region[] Region { get; set; } = [];

	/// <summary>
	/// The field of view type.
	/// </summary>
	public FieldOfView FieldOfView { get; set; }

	/// <summary>
	/// The type of the distance measurement.
	/// </summary>
	public Units Units { get; set; }
}

public enum Interval
{
	Daily,
    Weekly,
	Monthly,
}

public enum UserTypeMetric
{
	UnitRegularUserPhotos,
	UnitByodUserPhotos,
	UnitDedicatedUserPhotos,
	UnitInternalUserPhotos,
	IntervalRegularUserPhotos,
	IntervalByodUserPhotos,
	IntervalDedicatedUserPhotos,
	IntervalInternalUserPhotos,
	TotalRegularUserPhotos,
	TotalByodUserPhotos,
	TotalDedicatedUserPhotos,
	TotalInternalUserPhotos
}

public enum PhotosCountMetric
{
    UnitPhotosCount,
    IntervalPhotosCount,
    TotalPhotosCount,
    UnitMatchedPhotosCount,
    IntervalMatchedPhotosCount,
    TotalMatchedPhotosCount,
    UnitUnmatchedPhotosCount,
    IntervalUnmatchedPhotosCount,
    TotalUnmatchedPhotosCount,
    UnitActivePhotosCount,
    UnitDeletedPhotosCount,
    IntervalActivePhotosCount,
    IntervalDeletedPhotosCount,
    TotalActivePhotosCount,
    TotalDeletedPhotosCount,
    UploadingPhotosCount,
    ProcessingPhotosCount,
    TotalUploadingPhotosCount,
    TotalProcessingPhotosCount,
}

public enum PlatformMatric
{
    UnitIosPhotos,
    UnitAndroidPhotos,
    UnitWaylensPhotos,
    UnitGoProPhotos,
    UnitOtherPhotos,
    IntervalIosPhotos,
    IntervalAndroidPhotos,
    IntervalWaylensPhotos,
    IntervalGoProPhotos,
    IntervalOtherPhotos,
    TotalIosPhotos,
    TotalAndroidPhotos,
    TotalWaylensPhotos,
    TotalGoProPhotos,
    TotalOtherPhotos,
}