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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetDetectInfoEnhancedResponse : AbstractModel
    {
        
        /// <summary>
        /// 文本类信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Text")]
        public DetectInfoText Text{ get; set; }

        /// <summary>
        /// 身份证照片信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IdCardData")]
        public DetectInfoIdCardData IdCardData{ get; set; }

        /// <summary>
        /// 最佳帧信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BestFrame")]
        public DetectInfoBestFrame BestFrame{ get; set; }

        /// <summary>
        /// 视频信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VideoData")]
        public DetectInfoVideoData VideoData{ get; set; }

        /// <summary>
        /// 敏感数据加密信息。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Encryption")]
        public Encryption Encryption{ get; set; }

        /// <summary>
        /// 意愿核身相关信息。若未使用意愿核身功能，该字段返回值可以不处理。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntentionVerifyData")]
        public IntentionVerifyData IntentionVerifyData{ get; set; }

        /// <summary>
        /// 意愿核身问答模式结果。若未使用该意愿核身功能，该字段返回值可以不处理。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IntentionQuestionResult")]
        public IntentionQuestionResult IntentionQuestionResult{ get; set; }

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
            this.SetParamObj(map, prefix + "Text.", this.Text);
            this.SetParamObj(map, prefix + "IdCardData.", this.IdCardData);
            this.SetParamObj(map, prefix + "BestFrame.", this.BestFrame);
            this.SetParamObj(map, prefix + "VideoData.", this.VideoData);
            this.SetParamObj(map, prefix + "Encryption.", this.Encryption);
            this.SetParamObj(map, prefix + "IntentionVerifyData.", this.IntentionVerifyData);
            this.SetParamObj(map, prefix + "IntentionQuestionResult.", this.IntentionQuestionResult);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

