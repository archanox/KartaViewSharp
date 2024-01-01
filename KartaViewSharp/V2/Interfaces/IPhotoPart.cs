namespace KartaViewSharp.V2.Interfaces;

internal interface IPhotoPart
{
    Task<object> RetrievePhotoParts();

    Task<object> CreateANewPhotoPart(string authToken);

    Task<object> UpdateTheDetailsOfAPhotoPart(int photoPartId, string authToken);

    Task<object> GetTheDetailsOfAPhotoPart(int photoPartId);

    Task<object> DeleteAPhotoPart(int photoPartId);
}