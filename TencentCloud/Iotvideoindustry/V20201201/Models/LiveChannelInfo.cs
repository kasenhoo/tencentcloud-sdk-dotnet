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

namespace TencentCloud.Iotvideoindustry.V20201201.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LiveChannelInfo : AbstractModel
    {
        
        /// <summary>
        /// 频道ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LiveChannelId")]
        public string LiveChannelId{ get; set; }

        /// <summary>
        /// 频道名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LiveChannelName")]
        public string LiveChannelName{ get; set; }

        /// <summary>
        /// 频道类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LiveChannelType")]
        public long? LiveChannelType{ get; set; }

        /// <summary>
        /// 通道直播状态：1: 未推流，2: 推流中
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LiveStatus")]
        public long? LiveStatus{ get; set; }

        /// <summary>
        /// 推流地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PushStreamAddress")]
        public string PushStreamAddress{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 修改时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LiveChannelId", this.LiveChannelId);
            this.SetParamSimple(map, prefix + "LiveChannelName", this.LiveChannelName);
            this.SetParamSimple(map, prefix + "LiveChannelType", this.LiveChannelType);
            this.SetParamSimple(map, prefix + "LiveStatus", this.LiveStatus);
            this.SetParamSimple(map, prefix + "PushStreamAddress", this.PushStreamAddress);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

