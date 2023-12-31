using KartaViewSharp.V2.Enums;
using KartaViewSharp.V2.Request;
using KartaViewSharp.V2.Response.Resources.Sequence;

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