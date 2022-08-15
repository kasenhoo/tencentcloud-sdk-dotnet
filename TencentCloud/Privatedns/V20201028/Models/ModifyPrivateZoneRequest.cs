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

namespace TencentCloud.Privatedns.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPrivateZoneRequest : AbstractModel
    {
        
        /// <summary>
        /// 私有域ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 是否开启子域名递归, ENABLED， DISABLED
        /// </summary>
        [JsonProperty("DnsForwardStatus")]
        public string DnsForwardStatus{ get; set; }

        /// <summary>
        /// 是否开启CNAME加速：ENABLED， DISABLED
        /// </summary>
        [JsonProperty("CnameSpeedupStatus")]
        public string CnameSpeedupStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "DnsForwardStatus", this.DnsForwardStatus);
            this.SetParamSimple(map, prefix + "CnameSpeedupStatus", this.CnameSpeedupStatus);
        }
    }
}

