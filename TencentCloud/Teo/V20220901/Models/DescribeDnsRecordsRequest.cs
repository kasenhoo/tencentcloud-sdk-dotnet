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

    public class DescribeDnsRecordsRequest : AbstractModel
    {
        
        /// <summary>
        /// DNS记录所属站点ID。不填写该参数默认返回所有站点下的记录。
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 过滤条件，Filters.Values的上限为20。详细的过滤条件如下：
        /// <li>record-id<br>   按照【<strong>DNS记录id</strong>】进行过滤。DNS记录ID形如：record-1a8df68z。<br>   类型：String<br>   必选：否
        /// <li>record-name<br>   按照【<strong>DNS记录名称</strong>】进行过滤。<br>   类型：String<br>   必选：否
        /// <li>record-type<br>   按照【<strong>DNS记录类型</strong>】进行过滤。<br>   类型：String<br>   必选：否<br>   可选项：<br>   A：将域名指向一个外网 IPv4 地址，如 8.8.8.8<br>   AAAA：将域名指向一个外网 IPv6 地址<br>   CNAME：将域名指向另一个域名，再由该域名解析出最终 IP 地址<br>   TXT：对域名进行标识和说明，常用于域名验证和 SPF 记录（反垃圾邮件）<br>   NS：如果需要将子域名交给其他 DNS 服务商解析，则需要添加 NS 记录。根域名无法添加 NS 记录<br>   CAA：指定可为本站点颁发证书的 CA<br>   SRV：标识某台服务器使用了某个服务，常见于微软系统的目录管理<br>   MX：指定收件人邮件服务器。
        /// <li>mode<br>   按照【<strong>代理模式</strong>】进行过滤。<br>   类型：String<br>   必选：否<br>   可选项：<br>   dns_only：仅DNS解析<br>   proxied：代理加速
        /// <li>ttl<br>   按照【<strong>解析生效时间</strong>】进行过滤。<br>   类型：string<br>   必选：否
        /// </summary>
        [JsonProperty("Filters")]
        public AdvancedFilter[] Filters{ get; set; }

        /// <summary>
        /// 列表排序方式，取值有：
        /// <li>asc：升序排列；</li>
        /// <li>desc：降序排列。</li>默认值为asc。
        /// </summary>
        [JsonProperty("Direction")]
        public string Direction{ get; set; }

        /// <summary>
        /// 匹配方式，取值有：
        /// <li>all：返回匹配所有查询条件的记录；</li>
        /// <li>any：返回匹配任意一个查询条件的记录。</li>默认值为all。
        /// </summary>
        [JsonProperty("Match")]
        public string Match{ get; set; }

        /// <summary>
        /// 分页查询限制数目，默认值：20，上限：1000。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 分页查询偏移量，默认为 0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 排序依据，取值有：
        /// <li>content：DNS记录内容；</li>
        /// <li>created_on：DNS记录创建时间；</li>
        /// <li>mode：代理模式；</li>
        /// <li>record-name：DNS记录名称；</li>
        /// <li>ttl：解析记录生效时间；</li>
        /// <li>record-type：DNS记录类型。</li>默认根据record-type, recrod-name属性组合排序。
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "Match", this.Match);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Order", this.Order);
        }
    }
}

