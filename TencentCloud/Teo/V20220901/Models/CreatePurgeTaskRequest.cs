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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreatePurgeTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 站点ID。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 清除缓存类型，取值有：
        /// <li>purge_url：URL；</li>
        /// <li>purge_prefix：前缀；</li>
        /// <li>purge_host：Hostname；</li>
        /// <li>purge_all：全部缓存。</li>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 要刷新的资源列表，每个元素格式依据Type而定：
        /// 1) Type = purge_host 时：
        /// 形如：www.example.com 或 foo.bar.example.com。
        /// 2) Type = purge_prefix 时：
        /// 形如：http://www.example.com/example。
        /// 3) Type = purge_url 时：
        /// 形如：https://www.example.com/example.jpg。
        /// 4）Type = purge_all 时：
        /// Targets可为空，不需要填写。
        /// </summary>
        [JsonProperty("Targets")]
        public string[] Targets{ get; set; }

        /// <summary>
        /// 若有编码转换，仅清除编码转换后匹配的资源。
        /// 若内容含有非 ASCII 字符集的字符，请开启此开关进行编码转换（编码规则遵循 RFC3986）。
        /// </summary>
        [JsonProperty("EncodeUrl")]
        public bool? EncodeUrl{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "Targets.", this.Targets);
            this.SetParamSimple(map, prefix + "EncodeUrl", this.EncodeUrl);
        }
    }
}

