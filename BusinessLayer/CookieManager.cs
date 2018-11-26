using System;
using Microsoft.AspNetCore.Http;

namespace WebEditor.BusinessLayer {
    public static class CookieManager {
        public static HttpContext http_context;
        /// <summary>
        /// 设置本地cookie
        /// </summary>
        /// <param name="key">键</param>
        /// <param name="value">值</param>  
        /// <param name="minutes">过期时长，单位：分钟</param>      
        public static void SetCookies (string key, string value) {
            http_context.Response.Cookies.Append (key, value, new CookieOptions {
                //Expires = DateTime.Now.AddMinutes (minutes)
                Expires = DateTime.MaxValue
            });
        }
        /// <summary>
        /// 删除指定的cookie
        /// </summary>
        /// <param name="key">键</param>
        public static void DeleteCookies (string key) {
            http_context.Response.Cookies.Delete (key);
        }

        /// <summary>
        /// 获取cookies
        /// </summary>
        /// <param name="key">键</param>
        /// <returns>返回对应的值</returns>
        public static string GetCookies (string key) {
            http_context.Request.Cookies.TryGetValue (key, out string value);
            if (string.IsNullOrEmpty (value))
                value = string.Empty;
            return value;
        }

        public static void SetSession (string key, string value) {
            http_context.Session.SetString (key, value);
        }
    }
}