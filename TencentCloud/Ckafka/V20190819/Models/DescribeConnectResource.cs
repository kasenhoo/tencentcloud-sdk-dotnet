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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeConnectResource : AbstractModel
    {
        
        /// <summary>
        /// 连接源的Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceId")]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 连接源名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceName")]
        public string ResourceName{ get; set; }

        /// <summary>
        /// 连接源描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 连接源类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 连接源的状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 连接源的创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 连接源的异常信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// 连接源的当前所处步骤
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CurrentStep")]
        public string CurrentStep{ get; set; }

        /// <summary>
        /// 该连接源关联的Datahub任务数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DatahubTaskCount")]
        public long? DatahubTaskCount{ get; set; }

        /// <summary>
        /// Dts配置，Type为DTS时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DtsConnectParam")]
        public DtsConnectParam DtsConnectParam{ get; set; }

        /// <summary>
        /// MongoDB配置，Type为MONGODB时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MongoDBConnectParam")]
        public MongoDBConnectParam MongoDBConnectParam{ get; set; }

        /// <summary>
        /// Es配置，Type为ES时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EsConnectParam")]
        public EsConnectParam EsConnectParam{ get; set; }

        /// <summary>
        /// ClickHouse配置，Type为CLICKHOUSE时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClickHouseConnectParam")]
        public ClickHouseConnectParam ClickHouseConnectParam{ get; set; }

        /// <summary>
        /// MySQL配置，Type为MYSQL时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MySQLConnectParam")]
        public MySQLConnectParam MySQLConnectParam{ get; set; }

        /// <summary>
        /// PostgreSQL配置，Type为POSTGRESQL或TDSQL_C_POSTGRESQL时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostgreSQLConnectParam")]
        public PostgreSQLConnectParam PostgreSQLConnectParam{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "ResourceName", this.ResourceName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "CurrentStep", this.CurrentStep);
            this.SetParamSimple(map, prefix + "DatahubTaskCount", this.DatahubTaskCount);
            this.SetParamObj(map, prefix + "DtsConnectParam.", this.DtsConnectParam);
            this.SetParamObj(map, prefix + "MongoDBConnectParam.", this.MongoDBConnectParam);
            this.SetParamObj(map, prefix + "EsConnectParam.", this.EsConnectParam);
            this.SetParamObj(map, prefix + "ClickHouseConnectParam.", this.ClickHouseConnectParam);
            this.SetParamObj(map, prefix + "MySQLConnectParam.", this.MySQLConnectParam);
            this.SetParamObj(map, prefix + "PostgreSQLConnectParam.", this.PostgreSQLConnectParam);
        }
    }
}
