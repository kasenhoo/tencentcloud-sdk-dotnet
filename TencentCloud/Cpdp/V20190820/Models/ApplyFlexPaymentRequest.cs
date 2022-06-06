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

    public class ApplyFlexPaymentRequest : AbstractModel
    {
        
        /// <summary>
        /// 收款用户ID
        /// </summary>
        [JsonProperty("PayeeId")]
        public string PayeeId{ get; set; }

        /// <summary>
        /// 收入类型
        /// LABOR:劳务所得
        /// OCCASION:偶然所得
        /// </summary>
        [JsonProperty("IncomeType")]
        public string IncomeType{ get; set; }

        /// <summary>
        /// 税前金额
        /// </summary>
        [JsonProperty("AmountBeforeTax")]
        public string AmountBeforeTax{ get; set; }

        /// <summary>
        /// 外部订单ID
        /// </summary>
        [JsonProperty("OutOrderId")]
        public string OutOrderId{ get; set; }

        /// <summary>
        /// 资金账户信息
        /// </summary>
        [JsonProperty("FundingAccountInfo")]
        public FlexFundingAccountInfo FundingAccountInfo{ get; set; }

        /// <summary>
        /// 提现备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PayeeId", this.PayeeId);
            this.SetParamSimple(map, prefix + "IncomeType", this.IncomeType);
            this.SetParamSimple(map, prefix + "AmountBeforeTax", this.AmountBeforeTax);
            this.SetParamSimple(map, prefix + "OutOrderId", this.OutOrderId);
            this.SetParamObj(map, prefix + "FundingAccountInfo.", this.FundingAccountInfo);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

