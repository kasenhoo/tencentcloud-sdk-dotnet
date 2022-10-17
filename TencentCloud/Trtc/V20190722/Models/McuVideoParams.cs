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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class McuVideoParams : AbstractModel
    {
        
        /// <summary>
        /// 输出流视频编码参数。
        /// </summary>
        [JsonProperty("VideoEncode")]
        public VideoEncode VideoEncode{ get; set; }

        /// <summary>
        /// 混流布局参数。
        /// </summary>
        [JsonProperty("LayoutParams")]
        public McuLayoutParams LayoutParams{ get; set; }

        /// <summary>
        /// 整个画布背景颜色，常用的颜色有：
        /// 红色：0xcc0033。
        /// 黄色：0xcc9900。
        /// 绿色：0xcccc33。
        /// 蓝色：0x99CCFF。
        /// 黑色：0x000000。
        /// 白色：0xFFFFFF。
        /// 灰色：0x999999。
        /// </summary>
        [JsonProperty("BackGroundColor")]
        public string BackGroundColor{ get; set; }

        /// <summary>
        /// 整个画布的背景图url，优先级高于BackGroundColor。
        /// </summary>
        [JsonProperty("BackgroundImageUrl")]
        public string BackgroundImageUrl{ get; set; }

        /// <summary>
        /// 混流布局的水印参数。
        /// </summary>
        [JsonProperty("WaterMarkList")]
        public McuWaterMarkParams[] WaterMarkList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "VideoEncode.", this.VideoEncode);
            this.SetParamObj(map, prefix + "LayoutParams.", this.LayoutParams);
            this.SetParamSimple(map, prefix + "BackGroundColor", this.BackGroundColor);
            this.SetParamSimple(map, prefix + "BackgroundImageUrl", this.BackgroundImageUrl);
            this.SetParamArrayObj(map, prefix + "WaterMarkList.", this.WaterMarkList);
        }
    }
}

