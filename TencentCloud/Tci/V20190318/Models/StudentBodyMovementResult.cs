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

namespace TencentCloud.Tci.V20190318.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StudentBodyMovementResult : AbstractModel
    {
        
        /// <summary>
        /// 置信度（已废弃）
        /// </summary>
        [JsonProperty("Confidence")]
        public float? Confidence{ get; set; }

        /// <summary>
        /// 举手识别结果置信度
        /// </summary>
        [JsonProperty("HandupConfidence")]
        public float? HandupConfidence{ get; set; }

        /// <summary>
        /// 举手识别结果，包含举手（handup）和未举手（nothandup）
        /// </summary>
        [JsonProperty("HandupStatus")]
        public string HandupStatus{ get; set; }

        /// <summary>
        /// 识别结果高度
        /// </summary>
        [JsonProperty("Height")]
        public long? Height{ get; set; }

        /// <summary>
        /// 识别结果左坐标
        /// </summary>
        [JsonProperty("Left")]
        public long? Left{ get; set; }

        /// <summary>
        /// 动作识别结果（已废弃）
        /// </summary>
        [JsonProperty("Movements")]
        public string Movements{ get; set; }

        /// <summary>
        /// 站立识别结果置信度
        /// </summary>
        [JsonProperty("StandConfidence")]
        public float? StandConfidence{ get; set; }

        /// <summary>
        /// 站立识别结果，包含站立（stand）和坐着（sit）
        /// </summary>
        [JsonProperty("StandStatus")]
        public string StandStatus{ get; set; }

        /// <summary>
        /// 识别结果顶坐标
        /// </summary>
        [JsonProperty("Top")]
        public long? Top{ get; set; }

        /// <summary>
        /// 识别结果宽度
        /// </summary>
        [JsonProperty("Width")]
        public long? Width{ get; set; }


        /// <summary>
        /// 内部实现，用户禁止调用
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Confidence", this.Confidence);
            this.SetParamSimple(map, prefix + "HandupConfidence", this.HandupConfidence);
            this.SetParamSimple(map, prefix + "HandupStatus", this.HandupStatus);
            this.SetParamSimple(map, prefix + "Height", this.Height);
            this.SetParamSimple(map, prefix + "Left", this.Left);
            this.SetParamSimple(map, prefix + "Movements", this.Movements);
            this.SetParamSimple(map, prefix + "StandConfidence", this.StandConfidence);
            this.SetParamSimple(map, prefix + "StandStatus", this.StandStatus);
            this.SetParamSimple(map, prefix + "Top", this.Top);
            this.SetParamSimple(map, prefix + "Width", this.Width);
        }
    }
}

