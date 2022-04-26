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

    public class QueryOpenBankOrderDetailReceiptInfoRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道商户ID
        /// </summary>
        [JsonProperty("ChannelMerchantId")]
        public string ChannelMerchantId{ get; set; }

        /// <summary>
        /// 渠道子商户ID
        /// </summary>
        [JsonProperty("ChannelSubMerchantId")]
        public string ChannelSubMerchantId{ get; set; }

        /// <summary>
        /// 渠道名称，目前只支持ALIPAY
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 支付方式，目前只支持SAFT_ISV
        /// </summary>
        [JsonProperty("PaymentMethod")]
        public string PaymentMethod{ get; set; }

        /// <summary>
        /// 外部回单申请ID，与渠道回单申请ID二者选填其一
        /// </summary>
        [JsonProperty("OutApplyId")]
        public string OutApplyId{ get; set; }

        /// <summary>
        /// 渠道回单申请ID，与外部回单申请ID二者选填其一
        /// </summary>
        [JsonProperty("ChannelApplyId")]
        public string ChannelApplyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelMerchantId", this.ChannelMerchantId);
            this.SetParamSimple(map, prefix + "ChannelSubMerchantId", this.ChannelSubMerchantId);
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamSimple(map, prefix + "PaymentMethod", this.PaymentMethod);
            this.SetParamSimple(map, prefix + "OutApplyId", this.OutApplyId);
            this.SetParamSimple(map, prefix + "ChannelApplyId", this.ChannelApplyId);
        }
    }
}

