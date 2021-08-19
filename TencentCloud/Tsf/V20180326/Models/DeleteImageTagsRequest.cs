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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeleteImageTagsRequest : AbstractModel
    {
        
        /// <summary>
        /// 镜像版本数组
        /// </summary>
        [JsonProperty("ImageTags")]
        public DeleteImageTag[] ImageTags{ get; set; }

        /// <summary>
        /// 企业: tcr ；个人: personal或者不填
        /// </summary>
        [JsonProperty("RepoType")]
        public string RepoType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ImageTags.", this.ImageTags);
            this.SetParamSimple(map, prefix + "RepoType", this.RepoType);
        }
    }
}

