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

    public class RuleAction : AbstractModel
    {
        
        /// <summary>
        /// 常规功能操作，选择该类型的功能项有：
        /// <li> 访问URL 重写（AccessUrlRedirect）；</li>
        /// <li> 回源 URL 重写 （UpstreamUrlRedirect）；</li>
        /// <li> QUIC（QUIC）；</li>
        /// <li> WebSocket （WebSocket）；</li>
        /// <li> 视频拖拽（VideoSeek）；</li>
        /// <li> Token 鉴权（Authentication）；</li>
        /// <li> 自定义CacheKey（CacheKey）；</li>
        /// <li> 节点缓存 TTL （Cache）；</li>
        /// <li> 浏览器缓存 TTL（MaxAge）；</li>
        /// <li> 离线缓存（OfflineCache）；</li>
        /// <li> 智能加速（SmartRouting）；</li>
        /// <li> 分片回源（RangeOriginPull）；</li>
        /// <li> HTTP/2 回源（UpstreamHttp2）；</li>
        /// <li> Host Header 重写（HostHeader）；</li>
        /// <li> 强制 HTTPS（ForceRedirect）；</li>
        /// <li> 回源 HTTPS（OriginPullProtocol）；</li>
        /// <li> 缓存预刷新（CachePrefresh）；</li>
        /// <li> 智能压缩（Compression）；</li>
        /// <li> Hsts；</li>
        /// <li> ClientIpHeader；</li>
        /// <li> TlsVersion；</li>
        /// <li> OcspStapling。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NormalAction")]
        public RuleNormalAction NormalAction{ get; set; }

        /// <summary>
        /// 带有请求头/响应头的功能操作，选择该类型的功能项有：
        /// <li> 修改 HTTP 请求头（RequestHeader）；</li>
        /// <li> 修改HTTP响应头（ResponseHeader）。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RewriteAction")]
        public RuleRewriteAction RewriteAction{ get; set; }

        /// <summary>
        /// 带有状态码的功能操作，选择该类型的功能项有：
        /// <li> 自定义错误页面（ErrorPage）；</li>
        /// <li> 状态码缓存 TTL（StatusCodeCache）。</li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeAction")]
        public RuleCodeAction CodeAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "NormalAction.", this.NormalAction);
            this.SetParamObj(map, prefix + "RewriteAction.", this.RewriteAction);
            this.SetParamObj(map, prefix + "CodeAction.", this.CodeAction);
        }
    }
}

