namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /match/v2/taskbox/query_bill_link/ 接口的请求。</para>
    /// </summary>
    public class MatchTaskBoxQueryBillLinkV2Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置计费日期字符串（格式：yyyy-MM-dd）。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("bill_date")]
        [System.Text.Json.Serialization.JsonPropertyName("bill_date")]
        public string BillDateString { get; set; } = string.Empty;
    }
}
