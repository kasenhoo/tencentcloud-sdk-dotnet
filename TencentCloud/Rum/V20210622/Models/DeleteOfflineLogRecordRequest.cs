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

namespace TencentCloud.Rum.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteOfflineLogRecordRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目唯一上报 key
        /// </summary>
        [JsonProperty("ProjectKey")]
        public string ProjectKey{ get; set; }

        /// <summary>
        /// 离线日志文件 id
        /// </summary>
        [JsonProperty("FileID")]
        public string FileID{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectKey", this.ProjectKey);
            this.SetParamSimple(map, prefix + "FileID", this.FileID);
        }
    }
}

