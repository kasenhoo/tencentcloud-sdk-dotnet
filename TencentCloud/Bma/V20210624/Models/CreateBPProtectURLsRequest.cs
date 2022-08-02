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

namespace TencentCloud.Bma.V20210624.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBPProtectURLsRequest : AbstractModel
    {
        
        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("CompanyName")]
        public string CompanyName{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("Phone")]
        public string Phone{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("LicenseName")]
        public string LicenseName{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("ProtectURLs")]
        public string[] ProtectURLs{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("ProtectWebs")]
        public string[] ProtectWebs{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CompanyName", this.CompanyName);
            this.SetParamSimple(map, prefix + "Phone", this.Phone);
            this.SetParamSimple(map, prefix + "LicenseName", this.LicenseName);
            this.SetParamArraySimple(map, prefix + "ProtectURLs.", this.ProtectURLs);
            this.SetParamArraySimple(map, prefix + "ProtectWebs.", this.ProtectWebs);
        }
    }
}

