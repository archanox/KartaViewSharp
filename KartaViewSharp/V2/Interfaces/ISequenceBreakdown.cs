namespace KartaViewSharp.V2.Interfaces;

internal interface ISequenceBreakdown
{
    Task<object> GetTheBreakdownDetailsOfASequence(int sequenceId);

    Task<object> RetrieveSequenceBreakdowns();
}