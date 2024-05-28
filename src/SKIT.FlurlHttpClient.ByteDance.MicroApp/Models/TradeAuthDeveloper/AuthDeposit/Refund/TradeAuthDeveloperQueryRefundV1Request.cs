namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_auth/v1/developer/query_refund/ 接口的请求。</para>
    /// </summary>
    public class TradeAuthDeveloperQueryRefundV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置开发者退款单号。与字段 <see cref="PayRefundId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_pay_refund_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_pay_refund_no")]
        public string? OutPayRefundNumber { get; set; }

        /// <summary>
        /// 获取或设置退款单 ID。与字段 <see cref="OutPayRefundNumber"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("pay_refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("pay_refund_id")]
        public string? PayRefundId { get; set; }
    }
}
