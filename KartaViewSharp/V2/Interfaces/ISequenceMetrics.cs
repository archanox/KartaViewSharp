namespace KartaViewSharp.V2.Interfaces;

internal interface ISequenceMetrics
{
    Task<object> GetTheBreakdownDetailsOfASequence(int sequenceId);
}