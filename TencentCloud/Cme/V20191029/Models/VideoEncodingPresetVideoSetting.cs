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

namespace TencentCloud.Cme.V20191029.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class VideoEncodingPresetVideoSetting : AbstractModel
    {
        
        /// <summary>
        /// 视频流的编码格式，可选值：
        /// <li>H264：H.264 编码。</li>
        /// </summary>
        [JsonProperty("Codec")]
        public string Codec{ get; set; }

        /// <summary>
        /// 视频短边尺寸，取值范围： [128, 4096]，单位：px。
        /// 视频最后的分辨率，根据短边尺寸和宽高比进行计算。
        /// 例：如果项目的宽高比是 16：9 ：
        /// <li>短边尺寸为 1080，则导出视频的分辨率为 1920 * 1080。</li>
        /// <li>短边尺寸为 720，则导出视频的分辨率为 1280 * 720。</li>
        /// 如果项目的宽高比是 9：16 ：
        /// <li>短边尺寸为 1080，则导出视频的分辨率为 1080 * 1920。</li>
        /// <li>短边尺寸为 720，则导出视频的分辨率为 720 * 1280。</li>
        /// 默认值：1080。
        /// </summary>
        [JsonProperty("ShortEdge")]
        public ulong? ShortEdge{ get; set; }

        /// <summary>
        /// 指定码率，单位 bps。当该参数为'0'时则不强制限定码率。
        /// 默认值：0。
        /// </summary>
        [JsonProperty("Bitrate")]
        public ulong? Bitrate{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Codec", this.Codec);
            this.SetParamSimple(map, prefix + "ShortEdge", this.ShortEdge);
            this.SetParamSimple(map, prefix + "Bitrate", this.Bitrate);
        }
    }
}

