﻿using System.Net;

namespace StudentManagement.ConsoleApp.AppResult
{
    public class ApiResult<T>
    {
        public HttpStatusCode StatusCode { get; set; }
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public T ResultObject { get; set; }

    }
}