/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudSubOrderReturn : AbstractModel
    {
        
        /// <summary>
        /// 子订单号
        /// </summary>
        [JsonProperty("SubOutTradeNo")]
        public string SubOutTradeNo{ get; set; }

        /// <summary>
        /// 米大师计费SubAppId，代表子商户
        /// </summary>
        [JsonProperty("SubAppId")]
        public string SubAppId{ get; set; }

        /// <summary>
        /// 子订单商品名称
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 子订单商品详情
        /// </summary>
        [JsonProperty("ProductDetail")]
        public string ProductDetail{ get; set; }

        /// <summary>
        /// 子订单平台应收金额，单位：分
        /// </summary>
        [JsonProperty("PlatformIncome")]
        public long? PlatformIncome{ get; set; }

        /// <summary>
        /// 子订单结算应收金额，单位：分
        /// </summary>
        [JsonProperty("SubMchIncome")]
        public long? SubMchIncome{ get; set; }

        /// <summary>
        /// 子订单支付金额
        /// </summary>
        [JsonProperty("Amt")]
        public long? Amt{ get; set; }

        /// <summary>
        /// 子订单原始金额
        /// </summary>
        [JsonProperty("OriginalAmt")]
        public long? OriginalAmt{ get; set; }

        /// <summary>
        /// 核销状态，1表示核销，0表示未核销
        /// </summary>
        [JsonProperty("SettleCheck")]
        public long? SettleCheck{ get; set; }

        /// <summary>
        /// 结算信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SettleInfo")]
        public CloudSettleInfo SettleInfo{ get; set; }

        /// <summary>
        /// 透传字段，由开发者在调用米大师下单接口的时候下发
        /// </summary>
        [JsonProperty("Metadata")]
        public string Metadata{ get; set; }

        /// <summary>
        /// 附加项信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttachmentInfoList")]
        public CloudAttachmentInfo AttachmentInfoList{ get; set; }

        /// <summary>
        /// 渠道方应答的订单号，透传处理
        /// </summary>
        [JsonProperty("ChannelExternalSubOrderId")]
        public string ChannelExternalSubOrderId{ get; set; }

        /// <summary>
        /// 微信子商户号
        /// </summary>
        [JsonProperty("WxSubMchId")]
        public string WxSubMchId{ get; set; }

        /// <summary>
        /// 米大师侧渠道子订单号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChannelSubPayOrderId")]
        public string ChannelSubPayOrderId{ get; set; }

        /// <summary>
        /// 物品ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SubOutTradeNo", this.SubOutTradeNo);
            this.SetParamSimple(map, prefix + "SubAppId", this.SubAppId);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "ProductDetail", this.ProductDetail);
            this.SetParamSimple(map, prefix + "PlatformIncome", this.PlatformIncome);
            this.SetParamSimple(map, prefix + "SubMchIncome", this.SubMchIncome);
            this.SetParamSimple(map, prefix + "Amt", this.Amt);
            this.SetParamSimple(map, prefix + "OriginalAmt", this.OriginalAmt);
            this.SetParamSimple(map, prefix + "SettleCheck", this.SettleCheck);
            this.SetParamObj(map, prefix + "SettleInfo.", this.SettleInfo);
            this.SetParamSimple(map, prefix + "Metadata", this.Metadata);
            this.SetParamObj(map, prefix + "AttachmentInfoList.", this.AttachmentInfoList);
            this.SetParamSimple(map, prefix + "ChannelExternalSubOrderId", this.ChannelExternalSubOrderId);
            this.SetParamSimple(map, prefix + "WxSubMchId", this.WxSubMchId);
            this.SetParamSimple(map, prefix + "ChannelSubPayOrderId", this.ChannelSubPayOrderId);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
        }
    }
}

