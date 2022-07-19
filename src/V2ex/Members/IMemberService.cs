using System;

namespace V2ex.Members
{
    public interface IMemberService
    {
        Task<Response<ProfileResponse>?> GetAsync();
    }
}
