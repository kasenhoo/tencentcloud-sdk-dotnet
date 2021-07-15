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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExtractRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// 时间字段的key名字，time_key和time_format必须成对出现
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeKey")]
        public string TimeKey{ get; set; }

        /// <summary>
        /// 时间字段的格式，参考c语言的strftime函数对于时间的格式说明输出参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }

        /// <summary>
        /// 分隔符类型日志的分隔符，只有log_type为delimiter_log时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Delimiter")]
        public string Delimiter{ get; set; }

        /// <summary>
        /// 整条日志匹配规则，只有log_type为fullregex_log时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogRegex")]
        public string LogRegex{ get; set; }

        /// <summary>
        /// 行首匹配规则，只有log_type为multiline_log或fullregex_log时有效
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BeginRegex")]
        public string BeginRegex{ get; set; }

        /// <summary>
        /// 取的每个字段的key名字，为空的key代表丢弃这个字段，只有log_type为delimiter_log时有效，json_log的日志使用json本身的key
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Keys")]
        public string[] Keys{ get; set; }

        /// <summary>
        /// 需要过滤日志的key，及其对应的regex
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilterKeyRegex")]
        public KeyRegexInfo[] FilterKeyRegex{ get; set; }

        /// <summary>
        /// 解析失败日志是否上传，true表示上传，false表示不上传
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnMatchUpLoadSwitch")]
        public bool? UnMatchUpLoadSwitch{ get; set; }

        /// <summary>
        /// 失败日志的key
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnMatchLogKey")]
        public string UnMatchLogKey{ get; set; }

        /// <summary>
        /// 增量采集模式下的回溯数据量，默认-1（全量采集）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Backtracking")]
        public long? Backtracking{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimeKey", this.TimeKey);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
            this.SetParamSimple(map, prefix + "Delimiter", this.Delimiter);
            this.SetParamSimple(map, prefix + "LogRegex", this.LogRegex);
            this.SetParamSimple(map, prefix + "BeginRegex", this.BeginRegex);
            this.SetParamArraySimple(map, prefix + "Keys.", this.Keys);
            this.SetParamArrayObj(map, prefix + "FilterKeyRegex.", this.FilterKeyRegex);
            this.SetParamSimple(map, prefix + "UnMatchUpLoadSwitch", this.UnMatchUpLoadSwitch);
            this.SetParamSimple(map, prefix + "UnMatchLogKey", this.UnMatchLogKey);
            this.SetParamSimple(map, prefix + "Backtracking", this.Backtracking);
        }
    }
}

