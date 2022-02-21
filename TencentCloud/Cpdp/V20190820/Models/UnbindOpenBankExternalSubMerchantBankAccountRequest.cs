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

    public class UnbindOpenBankExternalSubMerchantBankAccountRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道商户ID。
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 渠道子商户ID。
        /// </summary>
        [JsonProperty("ChannelSubMerchantId")]
        public string ChannelSubMerchantId{ get; set; }

        /// <summary>
        /// 渠道名称。
        /// __TENPAY__: 商企付
        /// __WECHAT__: 微信支付
        /// __ALIPAY__: 支付宝
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 支付方式。
        /// __EBANK_PAYMENT__: ebank支付
        /// __OPENBANK_PAYMENT__: openbank支付
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public string PaymentMethod{ get; set; }

        /// <summary>
        /// 绑卡序列号。
        /// </summary>
        [JsonProperty("BindSerialNo")]
        public string BindSerialNo{ get; set; }

        /// <summary>
        /// 外部申请编号。
        /// </summary>
        [JsonProperty("OutApplyId")]
        public string OutApplyId{ get; set; }

        /// <summary>
        /// 通知地址。
        /// </summary>
        [JsonProperty("NotifyUrl")]
        public string NotifyUrl{ get; set; }

        /// <summary>
        /// 环境类型。
        /// __release__:生产环境
        /// __sandbox__:沙箱环境
        /// _不填默认为生产环境_
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelMerchantId", this.ChannelMerchantId);
            this.SetParamSimple(map, prefix + "ChannelSubMerchantId", this.ChannelSubMerchantId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "PaymentMethod", this.PaymentMethod);
            this.SetParamSimple(map, prefix + "BindSerialNo", this.BindSerialNo);
            this.SetParamSimple(map, prefix + "OutApplyId", this.OutApplyId);
            this.SetParamSimple(map, prefix + "NotifyUrl", this.NotifyUrl);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

