﻿using Microsoft.AspNetCore.Http;

namespace WebApplication_kaler.Extensions
{
    public static class RequestExtensions
    {
        public static bool IsAjaxRequest(this HttpRequest request)
        {
            return request
           .Headers["x-requested-with"]
           .Equals("XMLHttpRequest");
        }
    }
}
