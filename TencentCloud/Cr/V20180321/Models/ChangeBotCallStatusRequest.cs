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

namespace TencentCloud.Cr.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChangeBotCallStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 模块名。默认值（固定）：AiApi
        /// </summary>
        [JsonProperty("Module")]
        public string Module{ get; set; }

        /// <summary>
        /// 操作名。默认值（固定）：ChangeBotCallStatus
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }

        /// <summary>
        /// 作业变更状态
        /// SUSPEND：暂停；EXECUTE：恢复；
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 作业唯一标识
        /// </summary>
        [JsonProperty("CallId")]
        public string CallId{ get; set; }

        /// <summary>
        /// 业务日期
        /// </summary>
        [JsonProperty("BizDate")]
        public string BizDate{ get; set; }

        /// <summary>
        /// 任务ID，二者必填一个
        /// </summary>
        [JsonProperty("BotId")]
        public string BotId{ get; set; }

        /// <summary>
        /// 任务名称，二者必填一个
        /// </summary>
        [JsonProperty("BotName")]
        public string BotName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Module", this.Module);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CallId", this.CallId);
            this.SetParamSimple(map, prefix + "BizDate", this.BizDate);
            this.SetParamSimple(map, prefix + "BotId", this.BotId);
            this.SetParamSimple(map, prefix + "BotName", this.BotName);
        }
    }
}

