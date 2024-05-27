using System;
using System.Net;

namespace grow_api_v1.Exceptions;

[Serializable]
public class ValidationException : BaseException
{
    public ValidationException() : base(HttpStatusCode.BadRequest)
    {
    }

    public ValidationException(string message) : base(HttpStatusCode.BadRequest, message)
    {
    }
}