using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.ExtendedSDK.Legacy.Interceptors
{
    [Obsolete("此类型专为旧版 API 设计，将于 2024-12-31 下线。")]
    internal class TikTokShopLegacyRequestSigningInterceptor : HttpInterceptor
    {
        private readonly string _baseUrl;
        private readonly string _appSecret;

        public TikTokShopLegacyRequestSigningInterceptor(string baseUrl, string appSecret)
        {
            _baseUrl = baseUrl.TrimEnd('/');
            _appSecret = appSecret;
        }

        public override Task BeforeCallAsync(HttpInterceptorContext context, CancellationToken cancellationToken = default)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));
            if (context.FlurlCall.Completed) throw new TikTokShopException("Failed to sign request. This interceptor must be called before request completed.");

            string requestUrl = context.FlurlCall.HttpRequestMessage.RequestUri?.ToString() ?? string.Empty;
            if (!requestUrl.StartsWith(_baseUrl, StringComparison.OrdinalIgnoreCase))
            {
                // 非基地址的请求跳过签名（如 Auth API）
                return Task.CompletedTask;
            }

            IList<string> ignoreQueryNames = new List<string>();
            string signText;

            try
            {
                var queryParams = new QueryParamCollection(context.FlurlCall.HttpRequestMessage.RequestUri!.Query);
                queryParams.Remove("access_token");
                queryParams.Remove("sign");

                string msgText = string.Format(
                    "{0}{1}{2}{3}",
                     _appSecret,
                    context.FlurlCall.HttpRequestMessage.RequestUri.AbsolutePath,
                     string.Join(string.Empty, queryParams
                        .ToDictionary(k => k.Name, v => v.Value.ToString())
                        .OrderBy(k => k.Key, StringComparer.Ordinal)
                        .Where(e =>
                        {
                            if (string.IsNullOrEmpty(e.Value))
                            {
                                // 过滤空参数，空参数不参与签名
                                ignoreQueryNames.Add(e.Key);
                                return false;
                            }

                            return true;
                        })
                        .Select(e => $"{e.Key}{e.Value}")
                    ),
                      _appSecret
                );
                signText = Utilities.HMACUtility.HashWithSHA256(_appSecret, msgText).Value!;
            }
            catch (Exception ex)
            {
                throw new TikTokShopException("Failed to sign request. Please see the inner exception for more details.", ex);
            }

            context.FlurlCall.Request.SetQueryParam("sign", signText.ToLower());
            context.FlurlCall.Request.RemoveQueryParams(ignoreQueryNames);
            return Task.CompletedTask;
        }
    }
}
