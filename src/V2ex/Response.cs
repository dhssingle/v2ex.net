namespace V2ex
{
#nullable disable
    public class Response<T> where T : class
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public T Result { get; set; }
    }
}
