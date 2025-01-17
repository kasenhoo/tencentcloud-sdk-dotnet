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

    public class ChannelBatchCancelFlowsRequest : AbstractModel
    {
        
        /// <summary>
        /// 渠道应用相关信息。 此接口Agent.ProxyOrganizationOpenId、Agent. ProxyOperator.OpenId、Agent.AppId 和 Agent.ProxyAppId 均必填。
        /// </summary>
        [JsonProperty("Agent")]
        public Agent Agent{ get; set; }

        /// <summary>
        /// 签署流程Id数组，最多100个，超过100不处理
        /// </summary>
        [JsonProperty("FlowIds")]
        public string[] FlowIds{ get; set; }

        /// <summary>
        /// 撤销理由
        /// </summary>
        [JsonProperty("CancelMessage")]
        public string CancelMessage{ get; set; }

        /// <summary>
        /// 撤销理由自定义格式；选项：
        /// 0 默认格式
        /// 1 只保留身份信息：展示为【发起方】
        /// 2 保留身份信息+企业名称：展示为【发起方xxx公司】
        /// 3 保留身份信息+企业名称+经办人名称：展示为【发起方xxxx公司-经办人姓名】
        /// </summary>
        [JsonProperty("CancelMessageFormat")]
        public long? CancelMessageFormat{ get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Agent.", this.Agent);
            this.SetParamArraySimple(map, prefix + "FlowIds.", this.FlowIds);
            this.SetParamSimple(map, prefix + "CancelMessage", this.CancelMessage);
            this.SetParamSimple(map, prefix + "CancelMessageFormat", this.CancelMessageFormat);
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
        }
    }
}

