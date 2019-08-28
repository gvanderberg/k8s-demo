using System;
using Microsoft.AspNetCore.Http;

namespace DemoGreen.Web.Models
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel(HttpContext httpContext)
        {
            _httpContext = httpContext;
        }

        private readonly HttpContext _httpContext;

        public string Accept => _httpContext.Request.Headers["Accept"];

        public string AcceptEncoding => _httpContext.Request.Headers["Accept-Encoding"];

        public string AcceptLanguage => _httpContext.Request.Headers["Accept-Language"];

        public string Host => _httpContext.Request.Headers["Host"];

        public string UserAgent => _httpContext.Request.Headers["User-Agent"];

        public string HostName { get; set; } = Environment.MachineName;

        public string OSVersion { get; set; } = Environment.OSVersion.VersionString;

        public string ProcessorCount { get; set; } = Environment.ProcessorCount.ToString();

        public string CurrentDirectory { get; set; } = Environment.CurrentDirectory;
    }
}