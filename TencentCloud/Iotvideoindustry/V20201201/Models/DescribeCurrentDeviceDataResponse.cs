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

    public class DescribeCurrentDeviceDataResponse : AbstractModel
    {
        
        /// <summary>
        /// 通道数
        /// </summary>
        [JsonProperty("Channels")]
        public long? Channels{ get; set; }

        /// <summary>
        /// 设备数
        /// </summary>
        [JsonProperty("Devices")]
        public long? Devices{ get; set; }

        /// <summary>
        /// 在线通道数
        /// </summary>
        [JsonProperty("OnlineChannels")]
        public long? OnlineChannels{ get; set; }

        /// <summary>
        /// 在线设备数
        /// </summary>
        [JsonProperty("OnlineDevices")]
        public long? OnlineDevices{ get; set; }

        /// <summary>
        /// 正在录制通道数
        /// </summary>
        [JsonProperty("RecordingChannels")]
        public long? RecordingChannels{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Channels", this.Channels);
            this.SetParamSimple(map, prefix + "Devices", this.Devices);
            this.SetParamSimple(map, prefix + "OnlineChannels", this.OnlineChannels);
            this.SetParamSimple(map, prefix + "OnlineDevices", this.OnlineDevices);
            this.SetParamSimple(map, prefix + "RecordingChannels", this.RecordingChannels);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

