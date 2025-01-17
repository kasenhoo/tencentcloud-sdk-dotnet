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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogContextInfo : AbstractModel
    {
        
        /// <summary>
        /// 日志来源设备
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 采集路径
        /// </summary>
        [JsonProperty("Filename")]
        public string Filename{ get; set; }

        /// <summary>
        /// 日志内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 日志包序号
        /// </summary>
        [JsonProperty("PkgId")]
        public string PkgId{ get; set; }

        /// <summary>
        /// 日志包内一条日志的序号
        /// </summary>
        [JsonProperty("PkgLogId")]
        public long? PkgLogId{ get; set; }

        /// <summary>
        /// 日志时间戳
        /// </summary>
        [JsonProperty("BTime")]
        public long? BTime{ get; set; }

        /// <summary>
        /// 日志来源主机名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Filename", this.Filename);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "PkgId", this.PkgId);
            this.SetParamSimple(map, prefix + "PkgLogId", this.PkgLogId);
            this.SetParamSimple(map, prefix + "BTime", this.BTime);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
        }
    }
}

