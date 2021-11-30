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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ApmAgentInfo : AbstractModel
    {
        
        /// <summary>
        /// Agent下载地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AgentDownloadURL")]
        public string AgentDownloadURL{ get; set; }

        /// <summary>
        /// Collector上报地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CollectorURL")]
        public string CollectorURL{ get; set; }

        /// <summary>
        /// Token信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Token")]
        public string Token{ get; set; }

        /// <summary>
        /// 外网上报地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicCollectorURL")]
        public string PublicCollectorURL{ get; set; }

        /// <summary>
        /// 自研VPC上报地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InnerCollectorURL")]
        public string InnerCollectorURL{ get; set; }

        /// <summary>
        /// 内网上报地址(Private Link上报地址)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrivateLinkCollectorURL")]
        public string PrivateLinkCollectorURL{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentDownloadURL", this.AgentDownloadURL);
            this.SetParamSimple(map, prefix + "CollectorURL", this.CollectorURL);
            this.SetParamSimple(map, prefix + "Token", this.Token);
            this.SetParamSimple(map, prefix + "PublicCollectorURL", this.PublicCollectorURL);
            this.SetParamSimple(map, prefix + "InnerCollectorURL", this.InnerCollectorURL);
            this.SetParamSimple(map, prefix + "PrivateLinkCollectorURL", this.PrivateLinkCollectorURL);
        }
    }
}

