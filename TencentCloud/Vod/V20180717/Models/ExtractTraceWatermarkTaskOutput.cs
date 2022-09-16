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

namespace TencentCloud.Vod.V20180717.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtractTraceWatermarkTaskOutput : AbstractModel
    {
        
        /// <summary>
        /// 播放者的 ID，以十六进制表示，共6位，该参数用于 [溯源水印](https://cloud.tencent.com/document/product/266/75789) 使用场景。
        /// </summary>
        [JsonProperty("Uv")]
        public string Uv{ get; set; }

        /// <summary>
        /// 该字段已废弃。
        /// </summary>
        [JsonProperty("Uid")]
        public string Uid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Uv", this.Uv);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
        }
    }
}

