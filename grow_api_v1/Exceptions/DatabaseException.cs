using System;
using System.Net;

namespace grow_api_v1.Exceptions;

[Serializable]
public class DatabaseException : BaseException
{
    public DatabaseException() : base(HttpStatusCode.InternalServerError)
    {
    }

    public DatabaseException(string message) : base(HttpStatusCode.InternalServerError, message)
    {
    }

    public DatabaseException(Exception inner, string message) : base(HttpStatusCode.InternalServerError, message, inner)
    {
    }
}