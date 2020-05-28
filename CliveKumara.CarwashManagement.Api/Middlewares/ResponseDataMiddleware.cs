using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace CliveKumara.CarwashManagement.Api.Middlewares
{
    public class ResponseDataMiddleware
    {
        private readonly RequestDelegate _next;

        public ResponseDataMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            await _next(context);

            var code = context.Response.StatusCode;
            if (code == (int)HttpStatusCode.OK)
            {
                //context.Response.

            }

        }
    }

   
}
