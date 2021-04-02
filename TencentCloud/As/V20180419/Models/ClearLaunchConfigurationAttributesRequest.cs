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

namespace TencentCloud.As.V20180419.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClearLaunchConfigurationAttributesRequest : AbstractModel
    {
        
        /// <summary>
        /// 启动配置ID。
        /// </summary>
        [JsonProperty("LaunchConfigurationId")]
        public string LaunchConfigurationId{ get; set; }

        /// <summary>
        /// 是否清空数据盘信息，非必填，默认为 false。
        /// 填 true 代表清空“数据盘”信息，清空后基于此新创建的云主机将不含有任何数据盘。
        /// </summary>
        [JsonProperty("ClearDataDisks")]
        public bool? ClearDataDisks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LaunchConfigurationId", this.LaunchConfigurationId);
            this.SetParamSimple(map, prefix + "ClearDataDisks", this.ClearDataDisks);
        }
    }
}

