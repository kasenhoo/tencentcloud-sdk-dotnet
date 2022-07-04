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

    public class QueryFlexOrderSummaryListRequest : AbstractModel
    {
        
        /// <summary>
        /// 汇总日期:yyyy-MM-dd
        /// </summary>
        [JsonProperty("SummaryDate")]
        public string SummaryDate{ get; set; }

        /// <summary>
        /// 分页
        /// </summary>
        [JsonProperty("PageNumber")]
        public Paging PageNumber{ get; set; }

        /// <summary>
        /// 汇总订单类型:FREEZE, SETTLEMENT,PAYMENT
        /// </summary>
        [JsonProperty("OrderType")]
        public string OrderType{ get; set; }

        /// <summary>
        /// 收款用户ID
        /// </summary>
        [JsonProperty("PayeeId")]
        public string PayeeId{ get; set; }

        /// <summary>
        /// 环境类型
        /// __release__:生产环境
        /// __sandbox__:沙箱环境
        /// __test__:测试环境
        /// 缺省默认为生产环境
        /// </summary>
        [JsonProperty("Environment")]
        public string Environment{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SummaryDate", this.SummaryDate);
            this.SetParamObj(map, prefix + "PageNumber.", this.PageNumber);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "PayeeId", this.PayeeId);
            this.SetParamSimple(map, prefix + "Environment", this.Environment);
        }
    }
}

