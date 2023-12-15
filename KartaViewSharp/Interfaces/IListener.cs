using KartaViewSharp.ResponseData;

namespace KartaViewSharp.Interfaces;

public interface IListener
{
    Task<Response> CreateTasksToBlurPhotosWhenDetectionsArePresent();

    Task<Response> RetrieveMaintenances();
}