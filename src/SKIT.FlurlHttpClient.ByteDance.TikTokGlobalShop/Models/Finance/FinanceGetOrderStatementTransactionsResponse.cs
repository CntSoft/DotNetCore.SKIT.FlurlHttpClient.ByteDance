namespace SKIT.FlurlHttpClient.ByteDance.TikTokGlobalShop.Models
{
    /// <summary>
    /// <para>表示 [GET] /finance/{version}/orders/{order_id}/statement_transactions 接口的响应。</para>
    /// </summary>
    public class FinanceGetOrderStatementTransactionsResponse : TikTokShopResponse<FinanceGetOrderStatementTransactionsResponse.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Transaction
                    {
                        public static class Types
                        {
                            public class SKUTransaction
                            {
                                /// <summary>
                                /// 获取或设置 SKU ID。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_id")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                                public string SKUId { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置 SKU 名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sku_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("sku_name")]
                                public string SKUName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置产品名称。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("product_name")]
                                [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                                public string ProductName { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置数量。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("quantity")]
                                [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                                public int Quantity { get; set; }

                                /// <summary>
                                /// 获取或设置币种。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("currency")]
                                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                                public string Currency { get; set; } = default!;

                                /// <summary>
                                /// 获取或设置结算金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("settlement_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("settlement_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SettlementAmount { get; set; }

                                /// <summary>
                                /// 获取或设置净销售金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("net_sales_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("net_sales_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? NetSalesAmount { get; set; }

                                /// <summary>
                                /// 获取或设置毛销售金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("gross_sales_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("gross_sales_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? GrossSalesAmount { get; set; }

                                /// <summary>
                                /// 获取或设置毛销售退款金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("gross_sales_refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("gross_sales_refund_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? GrossSalesRefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置卖家优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_discount_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? SellerDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置卖家优惠退款金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_discount_refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_discount_refund_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? SellerDiscountRefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置收入金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("revenue_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("revenue_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RevenueAmount { get; set; }

                                /// <summary>
                                /// 获取或设置费用金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal FeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置违约金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("adjustment_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("adjustment_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal AdjustmentAmount { get; set; }

                                /// <summary>
                                /// 获取或设置买家支付金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("customer_payment_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("customer_payment_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal CustomerPaymentAmount { get; set; }

                                /// <summary>
                                /// 获取或设置卖家折扣后小计金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("after_seller_discounts_subtotal_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("after_seller_discounts_subtotal_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal AfterSellerDiscountsSubtotalAmount { get; set; }

                                /// <summary>
                                /// 获取或设置增值税金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sales_tax_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("sales_tax_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SalesTaxAmount { get; set; }

                                /// <summary>
                                /// 获取或设置增值税支付金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sales_tax_payment_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("sales_tax_payment_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SalesTaxPaymentAmount { get; set; }

                                /// <summary>
                                /// 获取或设置增值税退款金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("sales_tax_refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("sales_tax_refund_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SalesTaxRefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_discount_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PlatformDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台优惠退款金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_discount_refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_discount_refund_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PlatformDiscountRefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置买家订单退款金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("customer_order_refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("customer_order_refund_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal CustomerOrderRefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置买家退款金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("customer_refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("customer_refund_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal CustomerRefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台退款补贴金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_refund_subsidy_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_refund_subsidy_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PlatformRefundSubsidyAmount { get; set; }

                                /// <summary>
                                /// 获取或设置运输费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ShippingFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置运输费补贴金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_fee_subsidy_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_subsidy_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ShippingFeeSubsidyAmount { get; set; }

                                /// <summary>
                                /// 获取或设置买家运输金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("customer_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("customer_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal CustomerShippingFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台运输费优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_shipping_fee_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_shipping_fee_discount_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PlatformShippingFeeDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置运输费实际金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("actual_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("actual_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ActualShippingFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置退单运输费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("return_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("return_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ReturnShippingFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置退单运输费实际金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("actual_return_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("actual_return_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ActualReturnShippingFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置零售配送费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("retail_delivery_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("retail_delivery_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RetailDeliveryFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置零售配送费支付金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("retail_delivery_fee_payment_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("retail_delivery_fee_payment_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RetailDeliveryFeePaymentAmount { get; set; }

                                /// <summary>
                                /// 获取或设置零售配送费退款金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("retail_delivery_fee_refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("retail_delivery_fee_refund_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RetailDeliveryFeeRefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置平台佣金金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("platform_commission_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("platform_commission_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PlatformCommissionAmount { get; set; }

                                /// <summary>
                                /// 获取或设置联盟佣金金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("affiliate_commission_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("affiliate_commission_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal AffiliateCommissionAmount { get; set; }

                                /// <summary>
                                /// 获取或设置联盟广告佣金金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("affiliate_ads_commission_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("affiliate_ads_commission_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal AffiliateAdsCommissionAmount { get; set; }

                                /// <summary>
                                /// 获取或设置附属合作伙伴佣金金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("affiliate_partner_commission_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("affiliate_partner_commission_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal AffiliatePartnerCommissionAmount { get; set; }

                                /// <summary>
                                /// 获取或设置联盟佣金税前金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("affiliate_commission_before_pit")]
                                [System.Text.Json.Serialization.JsonPropertyName("affiliate_commission_before_pit")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal AffiliateCommissionAmountBeforePit { get; set; }

                                /// <summary>
                                /// 获取或设置个人所得税金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("pit_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("pit_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PitAmount { get; set; }

                                /// <summary>
                                /// 获取或设置交易费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("transaction_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("transaction_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal TransactionFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置转介费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("referral_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("referral_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ReferralFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置退款管理费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_administration_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_administration_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RefundAdministrationFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置运费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_cost_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_cost_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ShippingCostAmount { get; set; }

                                /// <summary>
                                /// 获取或设置 TikTok 运费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fbm_shipping_cost_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("fbm_shipping_cost_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal FBMShippingCostAmount { get; set; }

                                /// <summary>
                                /// 获取或设置 TikTok 平台运费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fbt_shipping_cost_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("fbt_shipping_cost_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal FBTShippingCostAmount { get; set; }

                                /// <summary>
                                /// 获取或设置 TikTok 配送费用金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fbt_fulfillment_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("fbt_fulfillment_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal FBTFulfillmentFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置 TikTok 运费优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_cost_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_cost_discount_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ShippingCostDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置 TikTok 退货运费优惠金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_shipping_cost_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_shipping_cost_discount_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal RefundShippingCostDiscountAmount { get; set; }

                                /// <summary>
                                /// 获取或设置客户支付的运费金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("customer_paid_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("customer_paid_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal CustomerPaidShippingFeeAmount { get; set; }

                                /// <summary>
                                /// 获取或设置客户支付的运费退款金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("customer_paid_shipping_fee_refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("customer_paid_shipping_fee_refund_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal CustomerPaidShippingFeeRefundAmount { get; set; }

                                /// <summary>
                                /// 获取或设置客户运费补偿金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("customer_shipping_fee_offset_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("customer_shipping_fee_offset_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal CustomerShippingFeeOffsetAmount { get; set; }

                                /// <summary>
                                /// 获取或设置运费保险费用金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_insurance_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_insurance_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ShippingInsuranceFeetAmount { get; set; }

                                /// <summary>
                                /// 获取或设置物流激励金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("promo_shipping_incentive_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("promo_shipping_incentive_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal PromoShippingIncentiveAmount { get; set; }

                                /// <summary>
                                /// 获取或设置签字确认费用金额。
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("signature_confirmation_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("signature_confirmation_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal SignatureConfirmationFeeAmount { get; set; }
                            }
                        }

                        /// <summary>
                        /// 获取或设置交易 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("id")]
                        [System.Text.Json.Serialization.JsonPropertyName("id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string TransactionId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置交易状态。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("status")]
                        [System.Text.Json.Serialization.JsonPropertyName("status")]
                        public string Status { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算单 ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("statement_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("statement_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string StatementId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算时间戳。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("statement_time")]
                        [System.Text.Json.Serialization.JsonPropertyName("statement_time")]
                        public long StatementTimestamp { get; set; }

                        /// <summary>
                        /// 获取或设置币种。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("currency")]
                        [System.Text.Json.Serialization.JsonPropertyName("currency")]
                        public string Currency { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置结算金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settlement_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("settlement_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SettlementAmount { get; set; }

                        /// <summary>
                        /// 获取或设置净销售金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("net_sales_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("net_sales_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal? NetSalesAmount { get; set; }

                        /// <summary>
                        /// 获取或设置毛销售金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gross_sales_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("gross_sales_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal? GrossSalesAmount { get; set; }

                        /// <summary>
                        /// 获取或设置毛销售退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("gross_sales_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("gross_sales_refund_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal? GrossSalesRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置卖家优惠金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_discount_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal? SellerDiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置卖家优惠退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("seller_discount_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("seller_discount_refund_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal? SellerDiscountRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置收入金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("revenue_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("revenue_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal RevenueAmount { get; set; }

                        /// <summary>
                        /// 获取或设置费用金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal FeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置违约金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("adjustment_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("adjustment_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal AdjustmentAmount { get; set; }

                        /// <summary>
                        /// 获取或设置买家支付金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_payment_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_payment_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal CustomerPaymentAmount { get; set; }

                        /// <summary>
                        /// 获取或设置卖家折扣后小计金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("after_seller_discounts_subtotal_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("after_seller_discounts_subtotal_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal AfterSellerDiscountsSubtotalAmount { get; set; }

                        /// <summary>
                        /// 获取或设置增值税金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales_tax_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales_tax_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SalesTaxAmount { get; set; }

                        /// <summary>
                        /// 获取或设置增值税支付金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales_tax_payment_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales_tax_payment_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SalesTaxPaymentAmount { get; set; }

                        /// <summary>
                        /// 获取或设置增值税退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sales_tax_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("sales_tax_refund_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SalesTaxRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置平台优惠金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_discount_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal PlatformDiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置平台优惠退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_discount_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_discount_refund_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal PlatformDiscountRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置买家订单退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_order_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_order_refund_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal CustomerOrderRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置买家退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_refund_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal CustomerRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置平台退款补贴金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_refund_subsidy_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_refund_subsidy_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal PlatformRefundSubsidyAmount { get; set; }

                        /// <summary>
                        /// 获取或设置运输费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ShippingFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置运输费补贴金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_fee_subsidy_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_subsidy_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ShippingFeeSubsidyAmount { get; set; }

                        /// <summary>
                        /// 获取或设置买家运输金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal CustomerShippingFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置平台运输费优惠金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_shipping_fee_discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_shipping_fee_discount_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal PlatformShippingFeeDiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置运输费实际金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("actual_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("actual_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ActualShippingFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置退单运输费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("return_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("return_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ReturnShippingFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置退单运输费实际金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("actual_return_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("actual_return_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ActualReturnShippingFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置零售配送费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("retail_delivery_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("retail_delivery_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal RetailDeliveryFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置零售配送费支付金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("retail_delivery_fee_payment_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("retail_delivery_fee_payment_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal RetailDeliveryFeePaymentAmount { get; set; }

                        /// <summary>
                        /// 获取或设置零售配送费退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("retail_delivery_fee_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("retail_delivery_fee_refund_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal RetailDeliveryFeeRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置平台佣金金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("platform_commission_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("platform_commission_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal PlatformCommissionAmount { get; set; }

                        /// <summary>
                        /// 获取或设置联盟佣金金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("affiliate_commission_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("affiliate_commission_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal AffiliateCommissionAmount { get; set; }

                        /// <summary>
                        /// 获取或设置联盟广告佣金金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("affiliate_ads_commission_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("affiliate_ads_commission_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal AffiliateAdsCommissionAmount { get; set; }

                        /// <summary>
                        /// 获取或设置附属合作伙伴佣金金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("affiliate_partner_commission_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("affiliate_partner_commission_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal AffiliatePartnerCommissionAmount { get; set; }

                        /// <summary>
                        /// 获取或设置联盟佣金税前金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("affiliate_commission_before_pit")]
                        [System.Text.Json.Serialization.JsonPropertyName("affiliate_commission_before_pit")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal AffiliateCommissionAmountBeforePit { get; set; }

                        /// <summary>
                        /// 获取或设置个人所得税金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("pit_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("pit_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal PitAmount { get; set; }

                        /// <summary>
                        /// 获取或设置交易费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("transaction_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("transaction_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal TransactionFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置转介费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("referral_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("referral_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ReferralFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置退款管理费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_administration_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_administration_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal RefundAdministrationFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置运费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_cost_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_cost_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ShippingCostAmount { get; set; }

                        /// <summary>
                        /// 获取或设置 TikTok 运费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fbm_shipping_cost_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("fbm_shipping_cost_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal FBMShippingCostAmount { get; set; }

                        /// <summary>
                        /// 获取或设置 TikTok 平台运费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fbt_shipping_cost_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("fbt_shipping_cost_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal FBTShippingCostAmount { get; set; }

                        /// <summary>
                        /// 获取或设置 TikTok 配送费用金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fbt_fulfillment_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("fbt_fulfillment_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal FBTFulfillmentFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置 TikTok 运费优惠金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_cost_discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_cost_discount_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ShippingCostDiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置 TikTok 退货运费优惠金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("refund_shipping_cost_discount_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("refund_shipping_cost_discount_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal RefundShippingCostDiscountAmount { get; set; }

                        /// <summary>
                        /// 获取或设置客户支付的运费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_paid_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_paid_shipping_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal CustomerPaidShippingFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置客户支付的运费退款金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_paid_shipping_fee_refund_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_paid_shipping_fee_refund_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal CustomerPaidShippingFeeRefundAmount { get; set; }

                        /// <summary>
                        /// 获取或设置客户运费补偿金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("customer_shipping_fee_offset_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("customer_shipping_fee_offset_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal CustomerShippingFeeOffsetAmount { get; set; }

                        /// <summary>
                        /// 获取或设置运费保险费用金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_insurance_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_insurance_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ShippingInsuranceFeetAmount { get; set; }

                        /// <summary>
                        /// 获取或设置物流激励金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("promo_shipping_incentive_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("promo_shipping_incentive_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal PromoShippingIncentiveAmount { get; set; }

                        /// <summary>
                        /// 获取或设置签字确认费用金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("signature_confirmation_fee_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("signature_confirmation_fee_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SignatureConfirmationFeeAmount { get; set; }

                        /// <summary>
                        /// 获取或设置 SKU 交易列表。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_statement_transactions")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_statement_transactions")]
                        public Types.SKUTransaction[] SKUTransactionList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("order_create_time")]
                public long OrderCreateTimestamp { get; set; }

                /// <summary>
                /// 获取或设置交易列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("statement_transactions")]
                [System.Text.Json.Serialization.JsonPropertyName("statement_transactions")]
                public Types.Transaction[] TransactionList { get; set; } = default!;
            }
        }
    }
    public class FinanceGetOrderStatementTransactions2501Response : TikTokShopResponse<FinanceGetOrderStatementTransactions2501Response.Types.Data>
    {
        public static class Types
        {
            public class Data
            {
                public static class Types
                {
                    public class Transaction
                    {
                        public static class Types
                        {
                            public class RevenueBreakdown
                            {
                                [Newtonsoft.Json.JsonProperty("subtotal_before_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("subtotal_before_discount_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal ? SubtotalBeforeDiscountAmount { get; set; }
                                /// <summary>
                                /// seller_discount_amount
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_discount_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? SellerDiscountAmount { get; set; }
                                /// <summary>
                                /// refund_subtotal_before_discount_amount
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_subtotal_before_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_subtotal_before_discount_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? RefundSubtotalBeforeDiscountAmount { get; set; }
                                /// <summary>
                                /// seller_discount_refund_amount
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("seller_discount_refund_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("seller_discount_refund_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? SellerDiscountRefundAmount { get; set; }
                                /// <summary>
                                /// cod_service_fee_amount
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("cod_service_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("cod_service_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? CodServiceFeeAmount { get; set; }
                                /// <summary>
                                /// refund_cod_service_fee_amount
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("refund_cod_service_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("refund_cod_service_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? RefundCodServiceFeeAmount { get; set; }
                            }
                            public class ShippingCostBreakdown
                            {
                                [Newtonsoft.Json.JsonProperty("actual_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("actual_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? ActualShippingFeeAmount { get; set; }
                                /// <summary>
                                /// shipping_fee_discount_amount
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_fee_discount_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_fee_discount_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? ShippingFeeDiscountAmount { get; set; }
                                /// <summary>
                                /// customer_paid_shipping_fee_amount
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("customer_paid_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("customer_paid_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? CustomerPaidShippingFeeAmount { get; set; }
                                /// <summary>
                                /// return_shipping_fee_amount
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("return_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("return_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? ReturnShippingFeeAmount { get; set; }
                                /// <summary>
                                /// replacement_shipping_fee_amount
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("replacement_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("replacement_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? ReplacementShippingFeeAmount { get; set; }
                                /// <summary>
                                /// exchange_shipping_fee_amount
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("exchange_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("exchange_shipping_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? ExchangeShippingFeeAmount { get; set; }
                                /// <summary>
                                /// signature_confirmation_fee_amount
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("signature_confirmation_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("signature_confirmation_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? SignatureConfirmationFeeAmount { get; set; }
                                /// <summary>
                                /// shipping_insurance_fee_amount
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("shipping_insurance_fee_amount")]
                                [System.Text.Json.Serialization.JsonPropertyName("shipping_insurance_fee_amount")]
                                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                public decimal? ShippingInsuranceFeeAmount { get; set; }
                            }
                            public class FeeTaxBreakdown
                            {
                                public static class Types
                                {
                                    public class fee
                                    {
                                        [Newtonsoft.Json.JsonProperty("platform_commission_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("platform_commission_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? platform_commission_amount { get; set; }
                                        /// <summary>
                                        /// referral_fee_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("referral_fee_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("referral_fee_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? referral_fee_amount { get; set; }
                                        /// <summary>
                                        /// refund_administration_fee_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("refund_administration_fee_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("refund_administration_fee_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? refund_administration_fee_amount { get; set; }
                                        /// <summary>
                                        /// transaction_fee_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("transaction_fee_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("transaction_fee_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? transaction_fee_amount { get; set; }
                                        /// <summary>
                                        /// credit_card_handling_fee_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("credit_card_handling_fee_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("credit_card_handling_fee_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? credit_card_handling_fee_amount { get; set; }
                                        /// <summary>
                                        /// affiliate_commission_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("affiliate_commission_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("affiliate_commission_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? affiliate_commission_amount { get; set; }
                                        /// <summary>
                                        /// affiliate_commission_amount_before_pit
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("affiliate_commission_amount_before_pit")]
                                        [System.Text.Json.Serialization.JsonPropertyName("affiliate_commission_amount_before_pit")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? affiliate_commission_amount_before_pit { get; set; }
                                        /// <summary>
                                        /// affiliate_partner_commission_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("affiliate_partner_commission_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("affiliate_partner_commission_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? affiliate_partner_commission_amount { get; set; }
                                        /// <summary>
                                        /// affiliate_ads_commission_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("affiliate_ads_commission_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("affiliate_ads_commission_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? affiliate_ads_commission_amount { get; set; }
                                        /// <summary>
                                        /// sfp_service_fee_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sfp_service_fee_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sfp_service_fee_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? sfp_service_fee_amount { get; set; }
                                        /// <summary>
                                        /// live_specials_fee_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("live_specials_fee_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("live_specials_fee_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? live_specials_fee_amount { get; set; }
                                        /// <summary>
                                        /// bonus_cashback_service_fee_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("bonus_cashback_service_fee_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("bonus_cashback_service_fee_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? bonus_cashback_service_fee_amount { get; set; }
                                        /// <summary>
                                        /// mall_service_fee_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("mall_service_fee_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("mall_service_fee_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? mall_service_fee_amount { get; set; }
                                        /// <summary>
                                        /// voucher_xtra_service_fee_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("voucher_xtra_service_fee_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("voucher_xtra_service_fee_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? voucher_xtra_service_fee_amount { get; set; }
                                        /// <summary>
                                        /// flash_sales_service_fee_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("flash_sales_service_fee_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("flash_sales_service_fee_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? flash_sales_service_fee_amount { get; set; }
                                        /// <summary>
                                        /// cofunded_promotion_service_fee_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("cofunded_promotion_service_fee_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("cofunded_promotion_service_fee_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? cofunded_promotion_service_fee_amount { get; set; }
                                    }
                                    public class tax
                                    {
                                        [Newtonsoft.Json.JsonProperty("vat_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("vat_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? vat_amount { get; set; }
                                        /// <summary>
                                        /// import_vat_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("import_vat_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("import_vat_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? import_vat_amount { get; set; }
                                        /// <summary>
                                        /// customs_duty_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("customs_duty_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("customs_duty_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? customs_duty_amount { get; set; }
                                        /// <summary>
                                        /// customs_clearance_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("customs_clearance_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("customs_clearance_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? customs_clearance_amount { get; set; }
                                        /// <summary>
                                        /// sst_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("sst_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("sst_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? sst_amount { get; set; }
                                        /// <summary>
                                        /// gst_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("gst_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("gst_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? gst_amount { get; set; }
                                        /// <summary>
                                        /// iva_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("iva_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("iva_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? iva_amount { get; set; }
                                        /// <summary>
                                        /// isr_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("isr_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("isr_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? isr_amount { get; set; }
                                        /// <summary>
                                        /// anti_dumping_duty_amount
                                        /// </summary>
                                        [Newtonsoft.Json.JsonProperty("anti_dumping_duty_amount")]
                                        [System.Text.Json.Serialization.JsonPropertyName("anti_dumping_duty_amount")]
                                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                                        public decimal? anti_dumping_duty_amount { get; set; }
                                    }
                                }
                                /// <summary>
                                /// fee
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("fee")]
                                [System.Text.Json.Serialization.JsonPropertyName("fee")]
                                public Types.fee FeeList { get; set; } = default!;
                                /// <summary>
                                /// tax
                                /// </summary>
                                [Newtonsoft.Json.JsonProperty("tax")]
                                [System.Text.Json.Serialization.JsonPropertyName("tax")]
                                public Types.tax TaxList { get; set; } = default!;
                                //
                            }
                        }
                        /// <summary>
                        /// 获取或设置 SKU ID。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_id")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_id")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                        public string SKUId { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置 SKU 名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("sku_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("sku_name")]
                        public string SKUName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置产品名称。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("product_name")]
                        [System.Text.Json.Serialization.JsonPropertyName("product_name")]
                        public string ProductName { get; set; } = default!;

                        /// <summary>
                        /// 获取或设置数量。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("quantity")]
                        [System.Text.Json.Serialization.JsonPropertyName("quantity")]
                        public int Quantity { get; set; }
                        /// <summary>
                        /// 获取或设置结算金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("settlement_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("settlement_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal SettlementAmount { get; set; }

                        /// <summary>
                        /// 获取或设置收入金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("revenue_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("revenue_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal RevenueAmount { get; set; }
                        /// <summary>
                        /// 获取或设置运费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_cost_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_cost_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal ShippingCostAmount { get; set; }
                        /// <summary>
                        /// 获取或设置运费金额。
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fee_tax_amount")]
                        [System.Text.Json.Serialization.JsonPropertyName("fee_tax_amount")]
                        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                        public decimal FeeTaxAmount { get; set; }
                        /// <summary>
                        /// revenue_breakdown
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("revenue_breakdown")]
                        [System.Text.Json.Serialization.JsonPropertyName("revenue_breakdown")]
                        public Types.RevenueBreakdown RevenueBreakdownList { get; set; } = default!;
                        /// <summary>
                        /// shipping_cost_breakdown
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("shipping_cost_breakdown")]
                        [System.Text.Json.Serialization.JsonPropertyName("shipping_cost_breakdown")]
                        public Types.ShippingCostBreakdown ShippingCostBreakdownList { get; set; } = default!;
                        /// <summary>
                        /// fee_tax_breakdown
                        /// </summary>
                        [Newtonsoft.Json.JsonProperty("fee_tax_breakdown")]
                        [System.Text.Json.Serialization.JsonPropertyName("fee_tax_breakdown")]
                        public Types.FeeTaxBreakdown FeeTaxBreakdownList { get; set; } = default!;
                    }
                }

                /// <summary>
                /// 获取或设置订单 ID。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_id")]
                [System.Text.Json.Serialization.JsonPropertyName("order_id")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.NumericalStringReadOnlyConverter))]
                public string OrderId { get; set; } = default!;

                /// <summary>
                /// 获取或设置订单创建时间戳。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("order_create_time")]
                [System.Text.Json.Serialization.JsonPropertyName("order_create_time")]
                public long OrderCreateTimestamp { get; set; }

                [Newtonsoft.Json.JsonProperty("currency")]
                [System.Text.Json.Serialization.JsonPropertyName("currency")]
                public string Currency { get; set; } = default!;

                [Newtonsoft.Json.JsonProperty("revenue_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("revenue_amount")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal RevenueAmount { get; set; }
                [Newtonsoft.Json.JsonProperty("fee_and_tax_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("fee_and_tax_amount")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal fee_and_tax_amount { get; set; }
                [Newtonsoft.Json.JsonProperty("shipping_cost_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("shipping_cost_amount")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal shipping_cost_amount { get; set; }
                [Newtonsoft.Json.JsonProperty("settlement_amount")]
                [System.Text.Json.Serialization.JsonPropertyName("settlement_amount")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public decimal settlement_amount { get; set; }
                /// <summary>
                /// 获取或设置交易列表。
                /// </summary>
                [Newtonsoft.Json.JsonProperty("sku_transactions")]
                [System.Text.Json.Serialization.JsonPropertyName("sku_transactions")]
                public Types.Transaction[] TransactionList { get; set; } = default!;

                [Newtonsoft.Json.JsonProperty("total_count")]
                [System.Text.Json.Serialization.JsonPropertyName("total_count")]
                [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.Common.TextualNumberReadOnlyConverter))]
                public long total_count { get; set; }
            }
        }
    }
}
