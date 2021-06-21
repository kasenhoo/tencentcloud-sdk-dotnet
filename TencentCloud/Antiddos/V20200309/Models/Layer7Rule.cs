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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Layer7Rule : AbstractModel
    {
        
        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 转发类型列表
        /// </summary>
        [JsonProperty("ProxyTypeList")]
        public ProxyTypeInfo[] ProxyTypeList{ get; set; }

        /// <summary>
        /// 源站列表
        /// </summary>
        [JsonProperty("RealServers")]
        public SourceServer[] RealServers{ get; set; }

        /// <summary>
        /// 规则所属的资源实例
        /// </summary>
        [JsonProperty("InstanceDetails")]
        public InstanceRelation[] InstanceDetails{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArrayObj(map, prefix + "ProxyTypeList.", this.ProxyTypeList);
            this.SetParamArrayObj(map, prefix + "RealServers.", this.RealServers);
            this.SetParamArrayObj(map, prefix + "InstanceDetails.", this.InstanceDetails);
        }
    }
}

