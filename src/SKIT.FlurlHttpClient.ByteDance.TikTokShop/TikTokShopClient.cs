﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Flurl.Http;
using Flurl.Http.Configuration;

namespace SKIT.FlurlHttpClient.ByteDance.TikTokShop
{
    /// <summary>
    /// 一个抖店开放平台 API HTTP 客户端。
    /// </summary>
    public class TikTokShopClient : CommonClientBase, IByteDanceClient
    {
        /// <summary>
        /// 获取当前客户端使用的抖店开放平台凭证。
        /// </summary>
        public Settings.Credentials Credentials { get; }

        /// <summary>
        /// 用指定的配置项初始化 <see cref="TikTokShopClient"/> 类的新实例。
        /// </summary>
        /// <param name="options">配置项。</param>
        public TikTokShopClient(TikTokShopClientOptions options)
            : base()
        {
            if (options == null) throw new ArgumentNullException(nameof(options));

            Credentials = new Settings.Credentials(options);

            FlurlClient.BaseUrl = options.Endpoints ?? TikTokShopEndpoints.DEFAULT;
            FlurlClient.WithTimeout(TimeSpan.FromMilliseconds(options.Timeout));

            Interceptors.Add(new Interceptors.TikTokShopMarshalJsonInterceptor());
            Interceptors.Add(new Interceptors.TikTokShopSignInterceptor(
                signMethod: options.SignAlgorithm,
                appKey: options.AppKey,
                appSecret: options.AppSecret
            ));
        }

        /// <summary>
        /// 用指定的抖店开放平台应用 Key、抖店开放平台应用密钥初始化 <see cref="TikTokShopClient"/> 类的新实例。
        /// </summary>
        /// <param name="appKey">抖店开放平台应用 Key。</param>
        /// <param name="appSecret">抖店开放平台 。</param>
        public TikTokShopClient(string appKey, string appSecret)
            : this(new TikTokShopClientOptions() { AppKey = appKey, AppSecret = appSecret })
        {
        }

        /// <summary>
        /// 使用当前客户端生成一个新的 <see cref="IFlurlRequest"/> 对象。
        /// </summary>
        /// <param name="request"></param>
        /// <param name="method"></param>
        /// <param name="urlSegments"></param>
        /// <returns></returns>
        public IFlurlRequest CreateRequest(TikTokShopRequest request, HttpMethod method, params object[] urlSegments)
        {
            IFlurlRequest flurlRequest = FlurlClient.Request(urlSegments).WithVerb(method);

            if (request.Timeout.HasValue)
            {
                flurlRequest.WithTimeout(TimeSpan.FromMilliseconds(request.Timeout.Value));
            }

            flurlRequest.SetQueryParam("v", request.ApiVersion);
            flurlRequest.SetQueryParam("method", request.GetApiMethod());

            return flurlRequest;
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="httpContent"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestAsync<T>(IFlurlRequest flurlRequest, HttpContent? httpContent = null, CancellationToken cancellationToken = default)
            where T : TikTokShopResponse, new()
        {
            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestAsync(flurlRequest, httpContent, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(flurlResponse).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new TikTokShopException(ex.Message, ex);
            }
        }

        /// <summary>
        /// 异步发起请求。
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="flurlRequest"></param>
        /// <param name="data"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<T> SendRequestWithJsonAsync<T>(IFlurlRequest flurlRequest, object? data = null, CancellationToken cancellationToken = default)
            where T : TikTokShopResponse, new()
        {
            try
            {
                using IFlurlResponse flurlResponse = await base.SendRequestWithJsonAsync(flurlRequest, data, cancellationToken).ConfigureAwait(false);
                return await GetResposneAsync<T>(flurlResponse).ConfigureAwait(false);
            }
            catch (FlurlHttpException ex)
            {
                throw new TikTokShopException(ex.Message, ex);
            }
        }

        private async Task<T> GetResposneAsync<T>(IFlurlResponse flurlResponse)
            where T : TikTokShopResponse, new()
        {
            string contentType = flurlResponse.Headers.GetAll("Content-Type").FirstOrDefault() ?? string.Empty;
            string contentDisposition = flurlResponse.Headers.GetAll("Content-Disposition").FirstOrDefault() ?? string.Empty;
            bool contentTypeIsNotJson = flurlResponse.StatusCode != (int)HttpStatusCode.OK;

            T result = contentTypeIsNotJson ? new T() : await flurlResponse.GetJsonAsync<T>().ConfigureAwait(false);
            result.RawStatus = flurlResponse.StatusCode;
            result.RawHeaders = new ReadOnlyDictionary<string, string>(
                flurlResponse.Headers
                    .GroupBy(e => e.Name)
                    .ToDictionary(
                        k => k.Key,
                        v => string.Join(", ", v.Select(e => e.Value))
                    )
            );
            result.RawBytes = await flurlResponse.ResponseMessage.Content.ReadAsByteArrayAsync().ConfigureAwait(false);
            return result;
        }
    }
}
