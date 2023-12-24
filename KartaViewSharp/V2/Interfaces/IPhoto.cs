﻿using KartaViewSharp.V2.ResponseData;

namespace KartaViewSharp.V2.Interfaces;

public interface IPhoto
{
    Task<PhotoResponse> RetrievePhotos(PhotoQueryFilters filters);

    Task<PhotoResponse> CreateANewPhoto(string authToken);

    Task<PhotoResponse> GetTheDetailsOfAPhoto(int photoId);

    Task<PhotoResponse> UpdateTheDetailsOfAPhoto(int photoId, string authToken);

    Task<PhotoResponse> DeleteAPhoto(int photoId);

    Task<PhotoResponse> RetrieveAllPhotoPartsBasedOnThePhotoId(int photoId);
}