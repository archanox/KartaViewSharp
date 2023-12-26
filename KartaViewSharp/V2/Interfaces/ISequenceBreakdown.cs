﻿using KartaViewSharp.V2.ResponseData.Resources.Sequence;

namespace KartaViewSharp.V2.Interfaces;

public interface ISequenceBreakdown
{
    Task<SequenceResponse> GetTheBreakdownDetailsOfASequence(int sequenceId);

    Task<SequenceResponse> RetrieveSequenceBreakdowns();
}