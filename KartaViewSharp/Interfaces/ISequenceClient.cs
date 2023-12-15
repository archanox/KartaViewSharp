using KartaViewSharp.ResponseData;

namespace KartaViewSharp.Interfaces;

public interface ISequenceClient
{
    Task<Response> RetrieveSequences(QueryFilters filters);

    Task<Response> CreateANewSequence();

    Task<Response> GetTheDetailsOfASequence();

    Task<Response> UpdateTheDetailsOfASequence();

    Task<Response> DeleteASequence();

    Task<Response> RetrievePhotosBasedOnTheSequenceId();

    Task<Response> RetrieveVideosBasedOnTheSequenceId();

    Task<Response> RetrieveSequenceRawdatasBasedOnSequenceId();

    Task<Response> RetrieveSequenceAttachmentsBasedOnSequenceId();

    Task<Response> RetrieveSequenceBreakdownsBasedOnSequenceId();

    Task<Response> RetrieveSequenceMetricsBasedOnSequenceId();

    Task<Response> FindAndUpdateSequencesStatusWhenTheUploadIsFinished();

    Task<Response> GetMapMatchedTracksDataWithDifferentOutput();

    Task<Response> GetAListOfAllTracksBasedOnASpecificBoundingBox();
}