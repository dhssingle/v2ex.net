using System.Text.Json;

namespace V2ex
{
    public class V2exClient : IV2exClient
    {
        protected HttpClient Client { get; }

        public V2exClient(HttpClient client)
        {
            Client = client;
        }

        public async Task<TResponse?> SendAsync<TResponse>(HttpRequestMessage requestMessage)
        {
            var responseMessage = await Client.SendAsync(requestMessage);

            var resultJson = await responseMessage.Content.ReadAsStringAsync();

            return JsonSerializer.Deserialize<TResponse>(resultJson, new JsonSerializerOptions(JsonSerializerDefaults.Web));
        }
    }
}
