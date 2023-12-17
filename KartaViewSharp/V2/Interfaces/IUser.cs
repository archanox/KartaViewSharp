﻿using KartaViewSharp.V2.ResponseData;

namespace KartaViewSharp.V2.Interfaces;

public interface IUser
{
    Task<SequenceResponse> RetrieveUsers();

    Task<SequenceResponse> GetTheDetailsOfAUser(string userId);

    Task<SequenceResponse> DeleteAUser(string userId);

    Task<SequenceResponse> GetTheMetricsDetailsOfAUser(string userId);
}