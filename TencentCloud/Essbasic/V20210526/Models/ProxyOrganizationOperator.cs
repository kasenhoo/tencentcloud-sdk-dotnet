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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProxyOrganizationOperator : AbstractModel
    {
        
        /// <summary>
        /// 经办人ID（渠道颁发），最大长度64个字符
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 经办人姓名，最大长度50个字符
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 经办人身份证件类型
        /// 1.ID_CARD 居民身份证
        /// 2.HONGKONG_MACAO_AND_TAIWAN 港澳台居民居住证
        /// 3.HONGKONG_AND_MACAO 港澳居民来往内地通行证
        /// </summary>
        [JsonProperty("IdCardType")]
        public string IdCardType{ get; set; }

        /// <summary>
        /// 经办人证件号
        /// </summary>
        [JsonProperty("IdCardNumber")]
        public string IdCardNumber{ get; set; }

        /// <summary>
        /// 经办人手机号，大陆手机号输入11位，暂不支持海外手机号。
        /// </summary>
        [JsonProperty("Mobile")]
        public string Mobile{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "IdCardType", this.IdCardType);
            this.SetParamSimple(map, prefix + "IdCardNumber", this.IdCardNumber);
            this.SetParamSimple(map, prefix + "Mobile", this.Mobile);
        }
    }
}

