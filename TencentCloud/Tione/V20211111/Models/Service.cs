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

namespace TencentCloud.Tione.V20211111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Service : AbstractModel
    {
        
        /// <summary>
        /// 服务组id
        /// </summary>
        [JsonProperty("ServiceGroupId")]
        public string ServiceGroupId{ get; set; }

        /// <summary>
        /// 服务id
        /// </summary>
        [JsonProperty("ServiceId")]
        public string ServiceId{ get; set; }

        /// <summary>
        /// 服务组名
        /// </summary>
        [JsonProperty("ServiceGroupName")]
        public string ServiceGroupName{ get; set; }

        /// <summary>
        /// 服务描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceDescription")]
        public string ServiceDescription{ get; set; }

        /// <summary>
        /// 集群id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 地域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 命名空间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 付费类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }

        /// <summary>
        /// 后付费资源组id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceGroupId")]
        public string ResourceGroupId{ get; set; }

        /// <summary>
        /// 创建者
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreatedBy")]
        public string CreatedBy{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 主账号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 子账号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubUin")]
        public string SubUin{ get; set; }

        /// <summary>
        /// app_id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 版本号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// 服务组下服务的最高版本号
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LatestVersion")]
        public string LatestVersion{ get; set; }

        /// <summary>
        /// 服务的详细信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceInfo")]
        public ServiceInfo ServiceInfo{ get; set; }

        /// <summary>
        /// 服务的业务状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BusinessStatus")]
        public string BusinessStatus{ get; set; }

        /// <summary>
        /// 服务的创建来源 AUTO_ML,DEFAULT
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateSource")]
        public string CreateSource{ get; set; }

        /// <summary>
        /// 费用信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BillingInfo")]
        public string BillingInfo{ get; set; }

        /// <summary>
        /// 服务状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 模型权重
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Weight")]
        public long? Weight{ get; set; }

        /// <summary>
        /// 服务所在的 ingress 的 name
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IngressName")]
        public string IngressName{ get; set; }

        /// <summary>
        /// 服务限速限流相关配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServiceLimit")]
        public ServiceLimit ServiceLimit{ get; set; }

        /// <summary>
        /// 定时停止的配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScheduledAction")]
        public ScheduledAction ScheduledAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceGroupId", this.ServiceGroupId);
            this.SetParamSimple(map, prefix + "ServiceId", this.ServiceId);
            this.SetParamSimple(map, prefix + "ServiceGroupName", this.ServiceGroupName);
            this.SetParamSimple(map, prefix + "ServiceDescription", this.ServiceDescription);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "ResourceGroupId", this.ResourceGroupId);
            this.SetParamSimple(map, prefix + "CreatedBy", this.CreatedBy);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "LatestVersion", this.LatestVersion);
            this.SetParamObj(map, prefix + "ServiceInfo.", this.ServiceInfo);
            this.SetParamSimple(map, prefix + "BusinessStatus", this.BusinessStatus);
            this.SetParamSimple(map, prefix + "CreateSource", this.CreateSource);
            this.SetParamSimple(map, prefix + "BillingInfo", this.BillingInfo);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Weight", this.Weight);
            this.SetParamSimple(map, prefix + "IngressName", this.IngressName);
            this.SetParamObj(map, prefix + "ServiceLimit.", this.ServiceLimit);
            this.SetParamObj(map, prefix + "ScheduledAction.", this.ScheduledAction);
        }
    }
}

