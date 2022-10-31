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

namespace TencentCloud.Dts.V20211206.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Database : AbstractModel
    {
        
        /// <summary>
        /// 需要迁移或同步的库名，当ObjectMode为Partial时，此项必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 迁移或同步后的库名，默认与源库相同
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NewDbName")]
        public string NewDbName{ get; set; }

        /// <summary>
        /// DB选择模式: All(为当前对象下的所有对象)，Partial(部分对象)，当Mode为Partial时，此项必填。注意，高级对象的同步不依赖此值。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbMode")]
        public string DbMode{ get; set; }

        /// <summary>
        /// 迁移或同步的 schema
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SchemaName")]
        public string SchemaName{ get; set; }

        /// <summary>
        /// 迁移或同步后的 schema name
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NewSchemaName")]
        public string NewSchemaName{ get; set; }

        /// <summary>
        /// 表选择模式: All(为当前对象下的所有对象)，Partial(部分对象)，当DBMode为Partial时此项必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TableMode")]
        public string TableMode{ get; set; }

        /// <summary>
        /// 表图对象集合，当 TableMode 为 Partial 时，此项需要填写
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tables")]
        public Table[] Tables{ get; set; }

        /// <summary>
        /// 视图选择模式: All 为当前对象下的所有视图对象,Partial 为部分视图对象
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ViewMode")]
        public string ViewMode{ get; set; }

        /// <summary>
        /// 视图对象集合，当 ViewMode 为 Partial 时， 此项需要填写
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Views")]
        public View[] Views{ get; set; }

        /// <summary>
        /// 选择要同步的模式，Partial为部分，all为整选
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FunctionMode")]
        public string FunctionMode{ get; set; }

        /// <summary>
        /// FunctionMode取值为Partial时需要填写
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Functions")]
        public string[] Functions{ get; set; }

        /// <summary>
        /// 选择要同步的模式，Partial为部分，All为整选
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProcedureMode")]
        public string ProcedureMode{ get; set; }

        /// <summary>
        /// ProcedureMode取值为Partial时需要填写
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Procedures")]
        public string[] Procedures{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamSimple(map, prefix + "NewDbName", this.NewDbName);
            this.SetParamSimple(map, prefix + "DbMode", this.DbMode);
            this.SetParamSimple(map, prefix + "SchemaName", this.SchemaName);
            this.SetParamSimple(map, prefix + "NewSchemaName", this.NewSchemaName);
            this.SetParamSimple(map, prefix + "TableMode", this.TableMode);
            this.SetParamArrayObj(map, prefix + "Tables.", this.Tables);
            this.SetParamSimple(map, prefix + "ViewMode", this.ViewMode);
            this.SetParamArrayObj(map, prefix + "Views.", this.Views);
            this.SetParamSimple(map, prefix + "FunctionMode", this.FunctionMode);
            this.SetParamArraySimple(map, prefix + "Functions.", this.Functions);
            this.SetParamSimple(map, prefix + "ProcedureMode", this.ProcedureMode);
            this.SetParamArraySimple(map, prefix + "Procedures.", this.Procedures);
        }
    }
}

