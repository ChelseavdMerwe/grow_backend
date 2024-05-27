using System.Net;

namespace grow_api_v1.DTOs.System;

public abstract class BaseResponse
{
    public Meta Meta { get; set; }

    public BaseResponse()
    {
    }

    protected BaseResponse(bool success, HttpStatusCode code, string message = default, int? errorCode = default)
    {
        Meta = new Meta(success, code, message, errorCode);
    }
}