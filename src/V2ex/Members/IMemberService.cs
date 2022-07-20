namespace V2ex.Members;

public interface IMemberService
{
    Task<ProfileResponse?> GetAsync();
}

