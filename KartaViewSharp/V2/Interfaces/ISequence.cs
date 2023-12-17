using KartaViewSharp.V2;
using KartaViewSharp.V2.ResponseData;

namespace KartaViewSharp.V2.Interfaces;

public interface ISequence
{
    Task<SequenceResponse> RetrieveSequences(SequenceQueryFilters filters);

    Task<SequenceResponse> CreateANewSequence();

    Task<SequenceResponse> GetTheDetailsOfASequence();

    Task<SequenceResponse> UpdateTheDetailsOfASequence();

    Task<SequenceResponse> DeleteASequence();

    Task<SequenceResponse> RetrievePhotosBasedOnTheSequenceId();

    Task<SequenceResponse> RetrieveVideosBasedOnTheSequenceId();

    Task<SequenceResponse> RetrieveSequenceRawdatasBasedOnSequenceId();

    Task<SequenceResponse> RetrieveSequenceAttachmentsBasedOnSequenceId();

    Task<SequenceResponse> RetrieveSequenceBreakdownsBasedOnSequenceId();

    Task<SequenceResponse> RetrieveSequenceMetricsBasedOnSequenceId();

    Task<SequenceResponse> FindAndUpdateSequencesStatusWhenTheUploadIsFinished();

    Task<SequenceResponse> GetMapMatchedTracksDataWithDifferentOutput();

    Task<SequenceResponse> GetAListOfAllTracksBasedOnASpecificBoundingBox();
}