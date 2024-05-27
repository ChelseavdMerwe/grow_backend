using System.Net;

namespace grow_api_v1.DTOs.System;

public class Meta
{
    public bool Success { get; set; }
    public int Code { get; set; }
    public string Message { get; set; }
    public int? ErrorCode { get; set; }

    public Meta()
    {
    }

    public Meta(bool success, HttpStatusCode code, string message = default, int? errorCode = default)
    {
        Success = success;
        Code = (int)code;
        Message = message;
        ErrorCode = errorCode;
    }
}