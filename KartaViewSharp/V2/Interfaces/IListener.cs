﻿using KartaViewSharp.V2.ResponseData;

namespace KartaViewSharp.V2.Interfaces;

public interface IListener
{
    Task<SequenceResponse> CreateTasksToBlurPhotosWhenDetectionsArePresent();

    Task<SequenceResponse> RetrieveMaintenances();
}