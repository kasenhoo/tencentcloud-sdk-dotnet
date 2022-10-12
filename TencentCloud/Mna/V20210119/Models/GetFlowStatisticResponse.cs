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

namespace TencentCloud.Mna.V20210119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetFlowStatisticResponse : AbstractModel
    {
        
        /// <summary>
        /// 流量详细信息
        /// </summary>
        [JsonProperty("NetDetails")]
        public NetDetails[] NetDetails{ get; set; }

        /// <summary>
        /// 查找时间段流量使用最大值（单位：bit）
        /// </summary>
        [JsonProperty("MaxValue")]
        public float? MaxValue{ get; set; }

        /// <summary>
        /// 查找时间段流量使用平均值（单位：bit）
        /// </summary>
        [JsonProperty("AvgValue")]
        public float? AvgValue{ get; set; }

        /// <summary>
        /// 查找时间段流量使用总量（单位：bit）
        /// </summary>
        [JsonProperty("TotalValue")]
        public float? TotalValue{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "NetDetails.", this.NetDetails);
            this.SetParamSimple(map, prefix + "MaxValue", this.MaxValue);
            this.SetParamSimple(map, prefix + "AvgValue", this.AvgValue);
            this.SetParamSimple(map, prefix + "TotalValue", this.TotalValue);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}
