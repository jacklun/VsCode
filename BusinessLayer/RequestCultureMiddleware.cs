using System;
using System.Globalization;
using System.Security.Cryptography;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Session;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;

namespace WebEditor.BusinessLayer {
    public class RequestCultureMiddleware {
        private static readonly RandomNumberGenerator CryptoRandom = RandomNumberGenerator.Create ();
        private static readonly Func<bool> ReturnTrue = () => false;
        private ILoggerFactory _Factory;
        private readonly IDistributedCache dcache;

        private readonly RequestDelegate _next;

        public RequestCultureMiddleware (RequestDelegate next, IDistributedCache pamDCache, ILoggerFactory factory) {
            _next = next;

            dcache = pamDCache;
            _Factory = factory;
        }

        public async Task InvokeAsync (HttpContext context) {
            TimeSpan t1 = new TimeSpan (2, 3, 4);
            TimeSpan t2 = new TimeSpan (3, 4, 5);
            var isNewSessionKey = true;
            Func<bool> tryEstablishSession = ReturnTrue;
            var guidBytes = new byte[16];
            CryptoRandom.GetBytes (guidBytes);
            //string sss = System.Text.Encoding.ASCII.GetString(guidBytes);
            string sessionKey = new Guid (guidBytes).ToString ();
            DistributedSession distributedSession = new DistributedSession (dcache, sessionKey, t1, t2, ReturnTrue, _Factory, isNewSessionKey);
            //distributedSession.SetString ("key1", "ok");
            //string s = distributedSession.GetString ("key1");
            string s = distributedSession.Id;
            //string s1 = context.Session.Id;

            var cultureQuery = context.Request.Query["culture"];
            if (!string.IsNullOrWhiteSpace (cultureQuery)) {
                var culture = new CultureInfo (cultureQuery);

                CultureInfo.CurrentCulture = culture;
                CultureInfo.CurrentUICulture = culture;

            }

            // Call the next delegate/middleware in the pipeline
            await _next (context);
        }
    }

    public static class RequestCultureMiddlewareExtensions {
        public static IApplicationBuilder UseRequestCulture (
            this IApplicationBuilder builder) {
            return builder.UseMiddleware<RequestCultureMiddleware> ();
        }
    }

    public class GuidSessionIDManagerMiddleware { }

    public static class GuidSessionIDManagerMiddlewareExtensions {
        public static IApplicationBuilder UseGuidSessionIDManager (
            this IApplicationBuilder builder) {
            return builder.UseMiddleware<GuidSessionIDManagerMiddleware> ();
        }
    }
}