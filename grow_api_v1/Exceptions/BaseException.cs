using System;
using System.Net;

namespace grow_api_v1.Exceptions;

[Serializable]
public abstract class BaseException : Exception
{
    public HttpStatusCode StatusCode { get; }

    protected BaseException(HttpStatusCode statusCode)
    {
        StatusCode = statusCode;
    }

    protected BaseException(HttpStatusCode statusCode, string message) : base(message)
    {
        StatusCode = statusCode;
    }
    
    protected BaseException(HttpStatusCode statusCode, string message, Exception inner) : base(message, inner)
    {
        StatusCode = statusCode;
    }
}