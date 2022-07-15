using System;

namespace V2ex
{
    public class V2exClient
    {
        protected HttpClient Client { get; }

        public V2exClient(HttpClient client)
        {
            Client = client;
        }

        
    }
}
