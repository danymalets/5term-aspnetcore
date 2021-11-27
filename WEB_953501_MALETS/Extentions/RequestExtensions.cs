using Microsoft.AspNetCore.Http;

namespace WEB_953501_MALETS.Extensions
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