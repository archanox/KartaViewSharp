namespace KartaViewSharp.V2.Interfaces;

internal interface ISimulate
{
    Task<object> TestTheBlurImagesFunctionalityIncludingTheApolloDetectionsPipeline();

    Task<object> TestTheBlurImagesFunctionalityIgnoringDetections();

    Task<object> NotifyApolloWhenASequenceHasBeenProcessed();
}