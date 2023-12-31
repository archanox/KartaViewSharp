using KartaViewSharp.V2.Response.Resources.Sequence;

namespace KartaViewSharp.V2.Interfaces;

public interface IListener
{
    Task<SequenceResponse> CreateTasksToBlurPhotosWhenDetectionsArePresent();

    Task<SequenceResponse> RetrieveMaintenances();
}