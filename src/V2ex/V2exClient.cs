using System.Text.Json;
using System.Text.Json.Serialization;

namespace V2ex;

public class V2exClient : IV2exClient
{
    protected HttpClient Client { get; }

    public V2exClient(HttpClient client)
    {
        Client = client;
    }

    public async Task<Response<T>?> SendAsync<T>(HttpRequestMessage requestMessage)
    {
        var responseMessage = await Client.SendAsync(requestMessage);

        var resultJson = await responseMessage.Content.ReadAsStringAsync();

        return JsonSerializer.Deserialize<Response<T>>(resultJson, new JsonSerializerOptions(JsonSerializerDefaults.Web)
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            
        });
    }
}

