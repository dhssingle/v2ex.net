namespace V2ex.Members
{
    public class MemberService : IMemberService
    {
        protected IV2exClient V2exClient { get; }

        public MemberService(IV2exClient v2exClient)
        {
            V2exClient = v2exClient;
        }

        public async Task<Response<ProfileResponse>?> GetAsync()
        {
            var path = "api/v2/member";

            return await V2exClient.SendAsync<ProfileResponse>(new HttpRequestMessage(HttpMethod.Get, path));
        }
    }
}
