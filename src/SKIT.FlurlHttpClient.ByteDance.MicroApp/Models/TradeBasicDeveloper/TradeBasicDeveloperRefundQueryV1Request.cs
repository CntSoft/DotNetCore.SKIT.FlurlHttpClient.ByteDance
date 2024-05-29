namespace SKIT.FlurlHttpClient.ByteDance.MicroApp.Models
{
    /// <summary>
    /// <para>表示 [POST] /api/trade_basic/v1/developer/refund_query/ 接口的请求。</para>
    /// </summary>
    public class TradeBasicDeveloperRefundQueryV1Request : DouyinMicroAppRequest
    {
        /// <summary>
        /// 获取或设置订单号。与字段 <see cref="OutRefundNumber"/>、<see cref="RefundId"/> 三选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("order_id")]
        [System.Text.Json.Serialization.JsonPropertyName("order_id")]
        public string? OrderId { get; set; }

        /// <summary>
        /// 获取或设置开发者退款单号。与字段 <see cref="OrderId"/>、<see cref="RefundId"/> 三选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_refund_no")]
        [System.Text.Json.Serialization.JsonPropertyName("out_refund_no")]
        public string? OutRefundNumber { get; set; }

        /// <summary>
        /// 获取或设置退款单号。与字段 <see cref="OrderId"/>、<see cref="OutRefundNumber"/> 三选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("refund_id")]
        [System.Text.Json.Serialization.JsonPropertyName("refund_id")]
        public string? RefundId { get; set; }
    }
}
