namespace KartaViewSharp.V2.Interfaces;

internal interface ISequenceRawData
{
    Task<object> RetrieveSequenceRawdatas();

    Task<object> CreateANewSequenceRawdata(string authToken);

    Task<object> UpdateTheDetailsOfASequenceRawdata(int sequenceRawDataId, string authToken);

    Task<object> GetTheDetailsOfASequenceRawdata(int sequenceRawDataId);

    Task<object> DeleteASequenceRawdata(int sequenceRawDataId);
}