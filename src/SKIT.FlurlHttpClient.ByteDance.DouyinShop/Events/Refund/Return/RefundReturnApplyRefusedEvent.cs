namespace SKIT.FlurlHttpClient.ByteDance.DouyinShop.Events
{
    /// <summary>
    /// <para>表示 doudian_refund_ReturnApplyRefused 消息的数据。</para>
    /// <para>
    /// REF: <br/>
    /// <![CDATA[ https://op.jinritemai.com/docs/message-docs/31/120 ]]>
    /// </para>
    /// </summary>
    public class RefundReturnApplyRefusedEvent : DouyinShopEvent<RefundReturnApplyRefusedEvent.Types.Data>
    {
        public static class Types
        {
            public class Data : RefundRefusedEvent.Types.Data
            {
            }
        }
    }
}
