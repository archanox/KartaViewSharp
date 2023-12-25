using KartaViewSharp.V2.ResponseData.Resources.Sequence;

namespace KartaViewSharp.V2.Interfaces;

public interface ISimulate
{
    Task<SequenceResponse> TestTheBlurImagesFunctionalityIncludingTheApolloDetectionsPipeline();

    Task<SequenceResponse> TestTheBlurImagesFunctionalityIgnoringDetections();

    Task<SequenceResponse> NotifyApolloWhenASequenceHasBeenProcessed();
}