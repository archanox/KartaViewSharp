using KartaViewSharp.ResponseData;

namespace KartaViewSharp.Interfaces;

public interface ISimulate
{
	Task<Response> TestTheBlurImagesFunctionalityIncludingTheApolloDetectionsPipeline();

	Task<Response> TestTheBlurImagesFunctionalityIgnoringDetections();

	Task<Response> NotifyApolloWhenASequenceHasBeenProcessed();
}