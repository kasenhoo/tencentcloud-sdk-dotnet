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

    public class ApplicationProxyRule : AbstractModel
    {
        
        /// <summary>
        /// 协议，取值有：
        /// <li>TCP：TCP协议；</li>
        /// <li>UDP：UDP协议。</li>
        /// </summary>
        [JsonProperty("Proto")]
        public string Proto{ get; set; }

        /// <summary>
        /// 端口，支持格式：
        /// 单个端口，如：80。
        /// 端口段，如：81-82。表示81，82两个端口。
        /// 注意：一条规则最多可填写20个端口。
        /// </summary>
        [JsonProperty("Port")]
        public string[] Port{ get; set; }

        /// <summary>
        /// 源站类型，取值有：
        /// <li>custom：手动添加；</li>
        /// <li>origins：源站组。</li>
        /// </summary>
        [JsonProperty("OriginType")]
        public string OriginType{ get; set; }

        /// <summary>
        /// 源站信息：
        /// 当OriginType=custom时，表示一个或多个源站，如：
        /// OriginValue=["8.8.8.8:80","9.9.9.9:80"]
        /// OriginValue=["test.com:80"]；
        /// 当OriginType=origins时，要求有且仅有一个元素，表示源站组ID，如：
        /// OriginValue=["origin-537f5b41-162a-11ed-abaa-525400c5da15"]。
        /// </summary>
        [JsonProperty("OriginValue")]
        public string[] OriginValue{ get; set; }

        /// <summary>
        /// 规则ID。
        /// </summary>
        [JsonProperty("RuleId")]
        public string RuleId{ get; set; }

        /// <summary>
        /// 状态，取值有：
        /// <li>online：启用；</li>
        /// <li>offline：停用；</li>
        /// <li>progress：部署中；</li>
        /// <li>stopping：停用中；</li>
        /// <li>fail：部署失败/停用失败。</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 传递客户端IP，取值有：
        /// <li>TOA：TOA（仅Proto=TCP时可选）；</li>
        /// <li>PPV1：Proxy Protocol传递，协议版本V1（仅Proto=TCP时可选）；</li>
        /// <li>PPV2：Proxy Protocol传递，协议版本V2；</li>
        /// <li>OFF：不传递。</li>
        /// </summary>
        [JsonProperty("ForwardClientIp")]
        public string ForwardClientIp{ get; set; }

        /// <summary>
        /// 是否开启会话保持，取值有：
        /// <li>true：开启；</li>
        /// <li>false：关闭。</li>
        /// </summary>
        [JsonProperty("SessionPersist")]
        public bool? SessionPersist{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Proto", this.Proto);
            this.SetParamArraySimple(map, prefix + "Port.", this.Port);
            this.SetParamSimple(map, prefix + "OriginType", this.OriginType);
            this.SetParamArraySimple(map, prefix + "OriginValue.", this.OriginValue);
            this.SetParamSimple(map, prefix + "RuleId", this.RuleId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ForwardClientIp", this.ForwardClientIp);
            this.SetParamSimple(map, prefix + "SessionPersist", this.SessionPersist);
        }
    }
}

