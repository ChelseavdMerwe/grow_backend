using System.Net;

namespace grow_api_v1.DTOs.System;

public class ApiResponse : BaseResponse
{
    public ApiResponse() : base()
    {
    }

    public ApiResponse(bool success, HttpStatusCode code, string message = default, int? errorCode = default) : base(success, code, message, errorCode)
    {
    }
}

public class ApiResponse<TEntity> : ApiResponse
{
    public TEntity Data { get; set; }

    public ApiResponse(TEntity data, bool success, HttpStatusCode code, string message = default, int? errorCode = default) : base(success, code, message, errorCode)
    {
        Data = data;
    }
}
