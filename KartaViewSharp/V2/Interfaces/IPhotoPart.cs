using KartaViewSharp.V2.ResponseData;

namespace KartaViewSharp.V2.Interfaces;

public interface IPhotoPart
{
    Task<SequenceResponse> RetrievePhotoParts();

    Task<SequenceResponse> CreateANewPhotoPart();

    Task<SequenceResponse> UpdateTheDetailsOfAPhotoPart();

    Task<SequenceResponse> GetTheDetailsOfAPhotoPart();

    Task<SequenceResponse> DeleteAPhotoPart();
}