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

namespace TencentCloud.Tdmq.V20200217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAMQPVHostRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// vhost名称，3-64个字符，只能包含字母、数字、“-”及“_”
        /// </summary>
        [JsonProperty("VHostId")]
        public string VHostId{ get; set; }

        /// <summary>
        /// 未消费消息的保留时间，以毫秒为单位，60秒-15天
        /// </summary>
        [JsonProperty("MsgTtl")]
        public ulong? MsgTtl{ get; set; }

        /// <summary>
        /// 说明，最大128个字符
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "VHostId", this.VHostId);
            this.SetParamSimple(map, prefix + "MsgTtl", this.MsgTtl);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}
