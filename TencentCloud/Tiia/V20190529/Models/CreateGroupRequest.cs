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

namespace TencentCloud.Tiia.V20190529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 图库ID，不可重复，仅支持字母、数字和下划线。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 图库名称描述。
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 图库可容纳的最大图片数量。
        /// </summary>
        [JsonProperty("MaxCapacity")]
        public ulong? MaxCapacity{ get; set; }

        /// <summary>
        /// 图库简介。
        /// </summary>
        [JsonProperty("Brief")]
        public string Brief{ get; set; }

        /// <summary>
        /// 访问限制默认为10qps，如需扩容请联系[在线客服](https://cloud.tencent.com/online-service)申请。
        /// </summary>
        [JsonProperty("MaxQps")]
        public ulong? MaxQps{ get; set; }

        /// <summary>
        /// 图库类型，对应不同的图像搜索服务类型，默认为4。1～3为历史版本，不推荐。
        /// 参数取值：
        /// 4：相同图像搜索。
        /// 5：商品图像搜索。
        /// 6：相似图像搜索。
        /// </summary>
        [JsonProperty("GroupType")]
        public ulong? GroupType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "MaxCapacity", this.MaxCapacity);
            this.SetParamSimple(map, prefix + "Brief", this.Brief);
            this.SetParamSimple(map, prefix + "MaxQps", this.MaxQps);
            this.SetParamSimple(map, prefix + "GroupType", this.GroupType);
        }
    }
}

