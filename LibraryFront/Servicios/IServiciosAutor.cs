namespace LibraryFront.Servicios
{
    public interface IServiciosAutor
    {
        Task<HttpResponseWrapper<T>> GetAutor<T>(string url);
        Task<HttpResponseWrapper<object>> PostAutor<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PostAutor<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> PutAutor<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PutAutor<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> DeleteAutor(string url);
        Task<HttpResponseWrapper<TActionResponse>> DeleteAutor<TActionResponse>(string url);

    }

    public interface IServiciosLibro
    {
        Task<HttpResponseWrapper<T>> GetLibro<T>(string url);
        Task<HttpResponseWrapper<object>> PostLibro<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PostLibro<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> PutLibro<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PutLibro<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> DeleteLibro(string url);
        Task<HttpResponseWrapper<TActionResponse>> DeleteLibro<TActionResponse>(string url);

    }

    public interface IServiciosPrestamo
    {
        Task<HttpResponseWrapper<T>> GetPrestamo<T>(string url);
        Task<HttpResponseWrapper<object>> PostPrestamo<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PostPrestamo<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> PutPrestamo<T>(string url, T model);
        Task<HttpResponseWrapper<TActionResponse>> PutPrestamo<T, TActionResponse>(string url, T model);
        Task<HttpResponseWrapper<object>> DeletePrestamo(string url);
        Task<HttpResponseWrapper<TActionResponse>> DeletePrestamo<TActionResponse>(string url);

    }
}
