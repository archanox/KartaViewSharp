using KartaViewSharp.V2.ResponseData;

namespace KartaViewSharp.V2.Interfaces;

public interface ISequenceRawData
{
    Task<SequenceResponse> RetrieveSequenceRawdatas();

    Task<SequenceResponse> CreateANewSequenceRawdata();

    Task<SequenceResponse> UpdateTheDetailsOfASequenceRawdata();

    Task<SequenceResponse> GetTheDetailsOfASequenceRawdata();

    Task<SequenceResponse> DeleteASequenceRawdata();
}