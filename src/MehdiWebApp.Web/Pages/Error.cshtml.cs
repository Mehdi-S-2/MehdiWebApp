using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace MehdiWebApp.Web.Pages
{
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public class ErrorModel : PageModel
    {
        public string RequestId { get; set; }
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
        public string ExceptionMessage { get; set; }
        public string ErrorStatusCode { get; set; }
        //private readonly ILogger _logger;
        //public ErrorModel(ILogger<ErrorModel> logger)
        //{
        //    _logger = logger;
        //}
        public void OnGet(string code)
        {
            RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            ErrorStatusCode = code;
            ExceptionMessage = "خطایی در برنامه رخ داده است. مشکل پس از بررسی توسط مدیر سیستم برطرف خواهد شد";
            

            if (!string.IsNullOrEmpty(ErrorStatusCode))
            {
                switch (code)
                {
                    case "403":
                        ExceptionMessage = "این بخش برای شما قابل دسترسی نیست";
                        //_logger.LogWarning("تلاش برای ورود به بخش غیرقابل دسترس");
                        break;
                    case "404":
                        ExceptionMessage = "صفحه مورد نظر یافت نشد";
                        break;
                }
            }
            //else
            //{
            //    if (exceptionHandlerPathFeature?.Error is System.exception)
            //    {
            //        ExceptionMessage = "File error thrown";
            //    }
            //    if (exceptionHandlerPathFeature?.Path == "/index")
            //    {
            //        ExceptionMessage += " from home page";
            //    }
            //}
        }
    }
}