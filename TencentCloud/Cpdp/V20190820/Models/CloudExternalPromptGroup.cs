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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudExternalPromptGroup : AbstractModel
    {
        
        /// <summary>
        /// 渠道名。
        /// 为米大师定义的枚举值：
        /// wechat 微信渠道
        /// </summary>
        [JsonProperty("ChannelName")]
        public string ChannelName{ get; set; }

        /// <summary>
        /// 渠道扩展促销信息列表，由各个渠道自行定义。
        /// ChannelName为wechat时，组成为 <Wechat-ExternalPromptInfo>
        /// </summary>
        [JsonProperty("ExternalPromptInfoList")]
        public CloudExternalPromptInfo[] ExternalPromptInfoList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ChannelName", this.ChannelName);
            this.SetParamArrayObj(map, prefix + "ExternalPromptInfoList.", this.ExternalPromptInfoList);
        }
    }
}

