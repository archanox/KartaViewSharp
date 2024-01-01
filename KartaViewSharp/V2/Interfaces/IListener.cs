namespace KartaViewSharp.V2.Interfaces;

internal interface IListener
{
    Task<object> CreateTasksToBlurPhotosWhenDetectionsArePresent();

    Task<object> RetrieveMaintenances();
}