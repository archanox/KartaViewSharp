using KartaViewSharp.V2.Request;
using KartaViewSharp.V2.Response.Resources.Sequence;
using NetTopologySuite.Geometries;

namespace KartaViewSharp.V2.Interfaces;

public interface ISequence
{
    Task<SequenceResponse> RetrieveSequences(SequenceQueryFilters filters);

    Task<SequenceResponse> CreateANewSequence();

    Task<SequenceResponse> GetTheDetailsOfASequence(int sequenceId);

    Task<SequenceResponse> UpdateTheDetailsOfASequence(int sequenceId, string authToken);

    Task<SequenceResponse> DeleteASequence(int sequenceId);

    Task<SequenceResponse> RetrievePhotosBasedOnTheSequenceId(int sequenceId);

    Task<SequenceResponse> RetrieveVideosBasedOnTheSequenceId(int sequenceId);

    Task<SequenceResponse> RetrieveSequenceRawdatasBasedOnSequenceId(int sequenceId);

    Task<SequenceResponse> RetrieveSequenceAttachmentsBasedOnSequenceId(int sequenceId);

    Task<SequenceResponse> RetrieveSequenceBreakdownsBasedOnSequenceId(int sequenceId);

    Task<SequenceResponse> RetrieveSequenceMetricsBasedOnSequenceId(int sequenceId);

    Task<SequenceResponse> FindAndUpdateSequencesStatusWhenTheUploadIsFinished(int sequenceId);

    Task<SequenceResponse> GetMapMatchedTracksDataWithDifferentOutput(int tileX, int tileY, int zoomLevel);

    Task<SequenceResponse> GetAListOfAllTracksBasedOnASpecificBoundingBox(Coordinate topLeft, Coordinate bottomRight, int zoomLevel);
}