using KartaViewSharp.V2.Enums;
using KartaViewSharp.V2.Request;
using KartaViewSharp.V2.Response.Resources.Sequence;
using NetTopologySuite.Geometries;

namespace KartaViewSharp.V2.Interfaces;

internal interface ISequence
{
    Task<SequenceResponse> RetrieveSequences(SequenceQueryFilters filters);

    Task<SequenceResponse> CreateANewSequence(string authToken);

	Task<SequenceDetailsResponse> GetTheDetailsOfASequence(int sequenceId, SequenceJoinResource[]? join);

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