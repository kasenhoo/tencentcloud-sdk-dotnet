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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeImportMachineInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 有效的机器信息列表：机器名称、机器公网/内网ip、机器标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EffectiveMachineInfoList")]
        public EffectiveMachineInfo[] EffectiveMachineInfoList{ get; set; }

        /// <summary>
        /// 用户批量导入失败的机器列表（比如机器不存在等...）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InvalidMachineList")]
        public string[] InvalidMachineList{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "EffectiveMachineInfoList.", this.EffectiveMachineInfoList);
            this.SetParamArraySimple(map, prefix + "InvalidMachineList.", this.InvalidMachineList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

