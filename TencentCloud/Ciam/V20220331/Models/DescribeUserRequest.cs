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

namespace TencentCloud.Ciam.V20220331.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeUserRequest : AbstractModel
    {
        
        /// <summary>
        /// 用户目录ID
        /// </summary>
        [JsonProperty("UserStoreId")]
        public string UserStoreId{ get; set; }

        /// <summary>
        /// 分页数据
        /// </summary>
        [JsonProperty("Pageable")]
        public Pageable Pageable{ get; set; }

        /// <summary>
        /// 查询条件，根据propertycode和propertykey
        /// </summary>
        [JsonProperty("Filters")]
        public QueryUserFilter[] Filters{ get; set; }

        /// <summary>
        /// 是否返回明文
        /// </summary>
        [JsonProperty("Original")]
        public bool? Original{ get; set; }

        /// <summary>
        /// 排序设置
        /// </summary>
        [JsonProperty("Sort")]
        public Sort Sort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserStoreId", this.UserStoreId);
            this.SetParamObj(map, prefix + "Pageable.", this.Pageable);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Original", this.Original);
            this.SetParamObj(map, prefix + "Sort.", this.Sort);
        }
    }
}

