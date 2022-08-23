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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDDosAttackTopDataRequest : AbstractModel
    {
        
        /// <summary>
        /// 开始时间。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 结束时间。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 统计指标列表，取值有：
        /// <li>ddos_attackFlux_protocol ：攻击总流量协议类型分布排行 ；</li>
        /// <li>ddos_attackPackageNum_protocol ：攻击总包量协议类型分布排行 ；</li>
        /// <li>ddos_attackNum_attackType ：攻击总次数攻击类型分布排行 ；</li>
        /// <li>ddos_attackNum_sregion ：攻击总次数攻击源地区分布排行 ；</li>
        /// <li>ddos_attackFlux_sip ：攻击总流量攻击源ip分布排行 ；</li>
        /// <li>ddos_attackFlux_sregion ：攻击总流量攻击源地区分布排行 。</li>
        /// </summary>
        [JsonProperty("MetricName")]
        public string MetricName{ get; set; }

        /// <summary>
        /// 查询前多少个，传值为0返回全量。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 站点id集合，不填默认选择全部站点。
        /// </summary>
        [JsonProperty("ZoneIds")]
        public string[] ZoneIds{ get; set; }

        /// <summary>
        /// ddos策略组id 集合，不填默认选择全部策略id。
        /// </summary>
        [JsonProperty("PolicyIds")]
        public long?[] PolicyIds{ get; set; }

        /// <summary>
        /// 端口号。
        /// </summary>
        [JsonProperty("Port")]
        public long? Port{ get; set; }

        /// <summary>
        /// 协议类型，取值有：
        /// <li>tcp ；</li>
        /// <li>udp ；</li>
        /// <li>all 。</li>
        /// </summary>
        [JsonProperty("ProtocolType")]
        public string ProtocolType{ get; set; }

        /// <summary>
        /// 攻击类型，取值有：
        /// <li>flood ；</li>
        /// <li>icmpFlood ；</li>
        /// <li>all 。</li>
        /// </summary>
        [JsonProperty("AttackType")]
        public string AttackType{ get; set; }

        /// <summary>
        /// 数据归属地区，取值有：
        /// <li>overseas ：全球（除中国大陆地区）数据 ；</li>
        /// <li>mainland ：中国大陆地区数据 。</li>不填默认查询overseas。
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "MetricName", this.MetricName);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArraySimple(map, prefix + "ZoneIds.", this.ZoneIds);
            this.SetParamArraySimple(map, prefix + "PolicyIds.", this.PolicyIds);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "ProtocolType", this.ProtocolType);
            this.SetParamSimple(map, prefix + "AttackType", this.AttackType);
            this.SetParamSimple(map, prefix + "Area", this.Area);
        }
    }
}

