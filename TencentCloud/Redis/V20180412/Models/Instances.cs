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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Instances : AbstractModel
    {
        
        /// <summary>
        /// 用户AppID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 地域ID 1--广州 4--上海 5-- 香港 6--多伦多 7--上海金融 8--北京 9-- 新加坡 11--深圳金融 15--美西（硅谷）
        /// </summary>
        [JsonProperty("RegionId")]
        public ulong? RegionId{ get; set; }

        /// <summary>
        /// 区域ID
        /// </summary>
        [JsonProperty("ZoneId")]
        public ulong? ZoneId{ get; set; }

        /// <summary>
        /// 副本数量
        /// </summary>
        [JsonProperty("RedisReplicasNum")]
        public ulong? RedisReplicasNum{ get; set; }

        /// <summary>
        /// 分片数量
        /// </summary>
        [JsonProperty("RedisShardNum")]
        public long? RedisShardNum{ get; set; }

        /// <summary>
        /// 分片大小
        /// </summary>
        [JsonProperty("RedisShardSize")]
        public long? RedisShardSize{ get; set; }

        /// <summary>
        /// 实例的磁盘大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 引擎：社区版Redis、腾讯云CKV
        /// </summary>
        [JsonProperty("Engine")]
        public string Engine{ get; set; }

        /// <summary>
        /// 实例角色，rw可读写，r只读
        /// </summary>
        [JsonProperty("Role")]
        public string Role{ get; set; }

        /// <summary>
        /// 实例VIP
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 内部参数，用户可忽略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Vip6")]
        public string Vip6{ get; set; }

        /// <summary>
        /// vpc网络ID 如：75101
        /// </summary>
        [JsonProperty("VpcID")]
        public long? VpcID{ get; set; }

        /// <summary>
        /// 实例端口
        /// </summary>
        [JsonProperty("VPort")]
        public long? VPort{ get; set; }

        /// <summary>
        /// 实例状态：0-待初始化，1-流程中，2-运行中，-2-已隔离，-3-待删除
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 仓库ID
        /// </summary>
        [JsonProperty("GrocerySysId")]
        public long? GrocerySysId{ get; set; }

        /// <summary>
        /// 实例类型：1 – Redis2.8内存版（集群架构），2 – Redis2.8内存版（标准架构），3 – CKV 3.2内存版(标准架构)，4 – CKV 3.2内存版(集群架构)，5 – Redis2.8内存版（单机），6 – Redis4.0内存版（标准架构），7 – Redis4.0内存版（集群架构），8 – Redis5.0内存版（标准架构），9 – Redis5.0内存版（集群架构）
        /// </summary>
        [JsonProperty("ProductType")]
        public long? ProductType{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新实例
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "RedisReplicasNum", this.RedisReplicasNum);
            this.SetParamSimple(map, prefix + "RedisShardNum", this.RedisShardNum);
            this.SetParamSimple(map, prefix + "RedisShardSize", this.RedisShardSize);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "Engine", this.Engine);
            this.SetParamSimple(map, prefix + "Role", this.Role);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vip6", this.Vip6);
            this.SetParamSimple(map, prefix + "VpcID", this.VpcID);
            this.SetParamSimple(map, prefix + "VPort", this.VPort);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "GrocerySysId", this.GrocerySysId);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

