using System.Net;

namespace MyCarProject.SPA
{
    public enum ResponseStatusCodeEnum
    {
        OK = HttpStatusCode.OK,
        BadRequest = HttpStatusCode.BadRequest,
        Unauthorized = HttpStatusCode.Unauthorized,
        NotFound = HttpStatusCode.NotFound,
        ServerError = HttpStatusCode.InternalServerError,
    }
}
