﻿using System.Net;

namespace StudentManagement.API.AppResult
{
    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T resultObject)
        {
            StatusCode = HttpStatusCode.OK;
            Succeeded = true;
            ResultObject = resultObject;
        }
        public ApiSuccessResult()
        {
            StatusCode = HttpStatusCode.OK;
            Succeeded = true;
        }
    }
}