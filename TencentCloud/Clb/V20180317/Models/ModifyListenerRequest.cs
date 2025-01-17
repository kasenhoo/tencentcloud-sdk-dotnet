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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyListenerRequest : AbstractModel
    {
        
        /// <summary>
        /// 负载均衡实例ID。
        /// </summary>
        [JsonProperty("LoadBalancerId")]
        public string LoadBalancerId{ get; set; }

        /// <summary>
        /// 负载均衡监听器ID。
        /// </summary>
        [JsonProperty("ListenerId")]
        public string ListenerId{ get; set; }

        /// <summary>
        /// 新的监听器名称。
        /// </summary>
        [JsonProperty("ListenerName")]
        public string ListenerName{ get; set; }

        /// <summary>
        /// 会话保持时间，单位：秒。可选值：30~3600，默认 0，表示不开启。此参数仅适用于TCP/UDP监听器。
        /// </summary>
        [JsonProperty("SessionExpireTime")]
        public long? SessionExpireTime{ get; set; }

        /// <summary>
        /// 健康检查相关参数，此参数仅适用于TCP/UDP/TCP_SSL监听器。
        /// </summary>
        [JsonProperty("HealthCheck")]
        public HealthCheck HealthCheck{ get; set; }

        /// <summary>
        /// 证书相关信息，此参数仅适用于HTTPS/TCP_SSL监听器；此参数和MultiCertInfo不能同时传入。
        /// </summary>
        [JsonProperty("Certificate")]
        public CertificateInput Certificate{ get; set; }

        /// <summary>
        /// 监听器转发的方式。可选值：WRR、LEAST_CONN
        /// 分别表示按权重轮询、最小连接数， 默认为 WRR。
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// 是否开启SNI特性，此参数仅适用于HTTPS监听器。注意：未开启SNI的监听器可以开启SNI；已开启SNI的监听器不能关闭SNI。
        /// </summary>
        [JsonProperty("SniSwitch")]
        public long? SniSwitch{ get; set; }

        /// <summary>
        /// 后端目标类型，NODE表示绑定普通节点，TARGETGROUP表示绑定目标组。
        /// </summary>
        [JsonProperty("TargetType")]
        public string TargetType{ get; set; }

        /// <summary>
        /// 是否开启长连接，此参数仅适用于HTTP/HTTPS监听器。
        /// </summary>
        [JsonProperty("KeepaliveEnable")]
        public long? KeepaliveEnable{ get; set; }

        /// <summary>
        /// 解绑后端目标时，是否发RST给客户端，此参数仅适用于TCP监听器。
        /// </summary>
        [JsonProperty("DeregisterTargetRst")]
        public bool? DeregisterTargetRst{ get; set; }

        /// <summary>
        /// 会话保持类型。NORMAL表示默认会话保持类型。QUIC_CID表示根据Quic Connection ID做会话保持。QUIC_CID只支持UDP协议。
        /// </summary>
        [JsonProperty("SessionType")]
        public string SessionType{ get; set; }

        /// <summary>
        /// 证书信息，支持同时传入不同算法类型的多本服务端证书；此参数仅适用于未开启SNI特性的HTTPS监听器。此参数和Certificate不能同时传入。
        /// </summary>
        [JsonProperty("MultiCertInfo")]
        public MultiCertInfo MultiCertInfo{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LoadBalancerId", this.LoadBalancerId);
            this.SetParamSimple(map, prefix + "ListenerId", this.ListenerId);
            this.SetParamSimple(map, prefix + "ListenerName", this.ListenerName);
            this.SetParamSimple(map, prefix + "SessionExpireTime", this.SessionExpireTime);
            this.SetParamObj(map, prefix + "HealthCheck.", this.HealthCheck);
            this.SetParamObj(map, prefix + "Certificate.", this.Certificate);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "SniSwitch", this.SniSwitch);
            this.SetParamSimple(map, prefix + "TargetType", this.TargetType);
            this.SetParamSimple(map, prefix + "KeepaliveEnable", this.KeepaliveEnable);
            this.SetParamSimple(map, prefix + "DeregisterTargetRst", this.DeregisterTargetRst);
            this.SetParamSimple(map, prefix + "SessionType", this.SessionType);
            this.SetParamObj(map, prefix + "MultiCertInfo.", this.MultiCertInfo);
        }
    }
}

