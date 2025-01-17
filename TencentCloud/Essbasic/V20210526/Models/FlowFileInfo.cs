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

    public class FlowFileInfo : AbstractModel
    {
        
        /// <summary>
        /// 签署文件资源Id列表，目前仅支持单个文件
        /// </summary>
        [JsonProperty("FileIds")]
        public string[] FileIds{ get; set; }

        /// <summary>
        /// 签署流程名称，长度不超过200个字符
        /// </summary>
        [JsonProperty("FlowName")]
        public string FlowName{ get; set; }

        /// <summary>
        /// 签署流程签约方列表，最多不超过5个参与方
        /// </summary>
        [JsonProperty("FlowApprovers")]
        public FlowApproverInfo[] FlowApprovers{ get; set; }

        /// <summary>
        /// 签署流程截止时间，十位数时间戳，最大值为33162419560，即3020年
        /// </summary>
        [JsonProperty("Deadline")]
        public long? Deadline{ get; set; }

        /// <summary>
        /// 签署流程的描述，长度不超过1000个字符
        /// </summary>
        [JsonProperty("FlowDescription")]
        public string FlowDescription{ get; set; }

        /// <summary>
        /// 签署流程的类型，长度不超过255个字符
        /// </summary>
        [JsonProperty("FlowType")]
        public string FlowType{ get; set; }

        /// <summary>
        /// 签署流程回调地址，长度不超过255个字符
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 渠道的业务信息，最大长度1000个字符。发起自动签署时，需设置对应自动签署场景，目前仅支持场景：处方单-E_PRESCRIPTION_AUTO_SIGN
        /// </summary>
        [JsonProperty("CustomerData")]
        public string CustomerData{ get; set; }

        /// <summary>
        /// 合同签署顺序类型(无序签,顺序签)，默认为false，即有序签署
        /// </summary>
        [JsonProperty("Unordered")]
        public bool? Unordered{ get; set; }

        /// <summary>
        /// 合同显示的页卡模板，说明：只支持{合同名称}, {发起方企业}, {发起方姓名}, {签署方N企业}, {签署方N姓名}，且N不能超过签署人的数量，N从1开始
        /// </summary>
        [JsonProperty("CustomShowMap")]
        public string CustomShowMap{ get; set; }

        /// <summary>
        /// 本企业(发起方企业)是否需要签署审批
        /// </summary>
        [JsonProperty("NeedSignReview")]
        public bool? NeedSignReview{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "FileIds.", this.FileIds);
            this.SetParamSimple(map, prefix + "FlowName", this.FlowName);
            this.SetParamArrayObj(map, prefix + "FlowApprovers.", this.FlowApprovers);
            this.SetParamSimple(map, prefix + "Deadline", this.Deadline);
            this.SetParamSimple(map, prefix + "FlowDescription", this.FlowDescription);
            this.SetParamSimple(map, prefix + "FlowType", this.FlowType);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "CustomerData", this.CustomerData);
            this.SetParamSimple(map, prefix + "Unordered", this.Unordered);
            this.SetParamSimple(map, prefix + "CustomShowMap", this.CustomShowMap);
            this.SetParamSimple(map, prefix + "NeedSignReview", this.NeedSignReview);
        }
    }
}

