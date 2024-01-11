using KartaViewSharp.V2.Enums;
using KartaViewSharp.V2.Request;

namespace KartaViewSharp.V2.Interfaces;

/// <summary>
/// Dashboard tool used for metric charts, coverage, tracks, users leaderboard, issues, tagged roads and dedicated campaigns.
/// </summary>
internal interface IDashboard
{
    Task<object> GetUserTypeMetricIntervalData(UserTypeMetric[] userTypeMetrics, DashboardQueryFilters filters);

    Task<object> GetPlatformMetricIntervalData(PlatformMetric[] platformMetrics);

    Task<object> GetUniqueDistanceMetricIntervalData();

    Task<object> GetTotalDistanceMetricIntervalData();

    Task<object> GetPlatformMetricIntervalData(PhotosCountMetric[] photosCountMetrics);

    Task<object> GetMetricsDataBasedOnMetricType();

    Task<object> GetTheDetailsOfASequence(int dashboardSequenceId);

    Task<object> RetrieveSequences();

    Task<object> GetTheDetailsOfAUser(int dashboardUserId);

    Task<object> RetrieveUsers();

    Task<object> GetTheDetailsOfAnIssue(int dashboardIssueId);

    Task<object> RetrieveIssues();

    Task<object> GetTheDetailsOfARegion(int dashboardRegionId);

    Task<object> RetrieveVisibleRegions();
}