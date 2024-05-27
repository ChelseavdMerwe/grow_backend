using System.Net;

namespace grow_api_v1.Exceptions;

public class NotFoundException : BaseException
{
    public NotFoundException() : base(HttpStatusCode.NotFound)
    {
    }

    public NotFoundException(string message) : base(HttpStatusCode.NotFound, message)
    {
    }
}