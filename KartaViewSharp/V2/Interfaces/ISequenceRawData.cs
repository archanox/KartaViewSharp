using KartaViewSharp.V2.Response.Resources.Sequence;

namespace KartaViewSharp.V2.Interfaces;

public interface ISequenceRawData
{
    Task<SequenceResponse> RetrieveSequenceRawdatas();

    Task<SequenceResponse> CreateANewSequenceRawdata(string authToken);

    Task<SequenceResponse> UpdateTheDetailsOfASequenceRawdata(int sequenceRawDataId, string authToken);

    Task<SequenceResponse> GetTheDetailsOfASequenceRawdata(int sequenceRawDataId);

    Task<SequenceResponse> DeleteASequenceRawdata(int sequenceRawDataId);
}