﻿using System.Collections.Generic;

/* @codestyle-disable no-jsonable-property-in-get */
namespace SKIT.FlurlHttpClient.ByteDance.OceanEngine.Models
{
    /// <summary>
    /// <para>表示 [GET] /2/advertiser/budget/get 接口的请求。</para>
    /// </summary>
    public class AdvertiserBudgetGetRequest : OceanEngineRequest
    {
        /// <summary>
        /// 获取或设置广告主 ID 列表。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("advertiser_ids")]
        [System.Text.Json.Serialization.JsonPropertyName("advertiser_ids")]
        public IList<long> AdvertiserIdList { get; set; } = new List<long>();
    }
}
