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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDBSecurityGroupsResponse : AbstractModel
    {
        
        /// <summary>
        /// 安全组规则。
        /// </summary>
        [JsonProperty("Groups")]
        public SecurityGroup[] Groups{ get; set; }

        /// <summary>
        /// 安全组生效内网地址。
        /// </summary>
        [JsonProperty("VIP")]
        public string VIP{ get; set; }

        /// <summary>
        /// 安全组生效内网端口。
        /// </summary>
        [JsonProperty("VPort")]
        public string VPort{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "Groups.", this.Groups);
            this.SetParamSimple(map, prefix + "VIP", this.VIP);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

