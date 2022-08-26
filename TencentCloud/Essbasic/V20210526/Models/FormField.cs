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

    public class FormField : AbstractModel
    {
        
        /// <summary>
        /// 控件填充vaule，ComponentType和传入值类型对应关系：
        /// TEXT - 文本内容
        /// MULTI_LINE_TEXT - 文本内容
        /// CHECK_BOX - true/false
        /// FILL_IMAGE、ATTACHMENT - 附件的FileId，需要通过UploadFiles接口上传获取
        /// SELECTOR - 选项值
        /// DYNAMIC_TABLE - 传入json格式的表格内容，具体见数据结构FlowInfo：https://cloud.tencent.com/document/api/1420/61525#FlowInfo
        /// </summary>
        [JsonProperty("ComponentValue")]
        public string ComponentValue{ get; set; }

        /// <summary>
        /// 表单域或控件的ID，跟ComponentName二选一，不能全为空；
        /// CreateFlowsByTemplates 接口不使用此字段。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComponentId")]
        public string ComponentId{ get; set; }

        /// <summary>
        /// 控件的名字，跟ComponentId二选一，不能全为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComponentName")]
        public string ComponentName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComponentValue", this.ComponentValue);
            this.SetParamSimple(map, prefix + "ComponentId", this.ComponentId);
            this.SetParamSimple(map, prefix + "ComponentName", this.ComponentName);
        }
    }
}

