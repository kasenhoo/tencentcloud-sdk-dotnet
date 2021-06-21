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

    public class DeleteBlackWhiteIpListRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// IP列表
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }

        /// <summary>
        /// IP类型，取值[black(黑名单IP), white(白名单IP)]
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
            this.SetParamSimple(map, prefix + "Type", this.Type);
        }
    }
}

