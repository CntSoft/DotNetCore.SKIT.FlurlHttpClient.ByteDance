﻿namespace SKIT.FlurlHttpClient.ByteDance.DouyinOpen.Models
{
    /// <summary>
    /// <para>表示 [POST] /xigua/video/data 接口的响应。</para>
    /// </summary>
    public class XiguaVideoDataResponse : DouyinOpenResponse<XiguaVideoDataResponse.Types.Data>
    {
        public static class Types
        {
            public class Data : DouyinOpenResponseData
            {
                public static class Types
                {
                    public class Video : XiguaVideoListResponse.Types.Data.Types.Video
                    {
                    }
                }

                /// <summary>
                /// 获取或设置视频列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("list")]
                [System.Text.Json.Serialization.JsonPropertyName("list")]
                public Types.Video[] VideoList { get; set; } = default!;
            }
        }
    }
}
