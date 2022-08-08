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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskLinkInfo : AbstractModel
    {
        
        /// <summary>
        /// 下游任务id
        /// </summary>
        [JsonProperty("TaskTo")]
        public string TaskTo{ get; set; }

        /// <summary>
        /// 上游任务id
        /// </summary>
        [JsonProperty("TaskFrom")]
        public string TaskFrom{ get; set; }

        /// <summary>
        /// 依赖边类型 1、“real_real”表示任务->任务；2、"virtual_real" 跨工作流任务->任务
        /// </summary>
        [JsonProperty("LinkType")]
        public string LinkType{ get; set; }

        /// <summary>
        /// 依赖边id
        /// </summary>
        [JsonProperty("LinkId")]
        public string LinkId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskTo", this.TaskTo);
            this.SetParamSimple(map, prefix + "TaskFrom", this.TaskFrom);
            this.SetParamSimple(map, prefix + "LinkType", this.LinkType);
            this.SetParamSimple(map, prefix + "LinkId", this.LinkId);
        }
    }
}

