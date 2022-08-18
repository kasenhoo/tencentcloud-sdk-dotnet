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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateTKEEdgeClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// k8s版本号
        /// </summary>
        [JsonProperty("K8SVersion")]
        public string K8SVersion{ get; set; }

        /// <summary>
        /// vpc 的Id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 集群pod cidr
        /// </summary>
        [JsonProperty("PodCIDR")]
        public string PodCIDR{ get; set; }

        /// <summary>
        /// 集群service cidr
        /// </summary>
        [JsonProperty("ServiceCIDR")]
        public string ServiceCIDR{ get; set; }

        /// <summary>
        /// 集群描述信息
        /// </summary>
        [JsonProperty("ClusterDesc")]
        public string ClusterDesc{ get; set; }

        /// <summary>
        /// 集群高级设置
        /// </summary>
        [JsonProperty("ClusterAdvancedSettings")]
        public EdgeClusterAdvancedSettings ClusterAdvancedSettings{ get; set; }

        /// <summary>
        /// 节点上最大Pod数量
        /// </summary>
        [JsonProperty("MaxNodePodNum")]
        public long? MaxNodePodNum{ get; set; }

        /// <summary>
        /// 边缘计算集群公网访问LB信息
        /// </summary>
        [JsonProperty("PublicLB")]
        public EdgeClusterPublicLB PublicLB{ get; set; }

        /// <summary>
        /// 集群的级别
        /// </summary>
        [JsonProperty("ClusterLevel")]
        public string ClusterLevel{ get; set; }

        /// <summary>
        /// 集群是否支持自动升配
        /// </summary>
        [JsonProperty("AutoUpgradeClusterLevel")]
        public bool? AutoUpgradeClusterLevel{ get; set; }

        /// <summary>
        /// 集群计费方式
        /// </summary>
        [JsonProperty("ChargeType")]
        public string ChargeType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "K8SVersion", this.K8SVersion);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "PodCIDR", this.PodCIDR);
            this.SetParamSimple(map, prefix + "ServiceCIDR", this.ServiceCIDR);
            this.SetParamSimple(map, prefix + "ClusterDesc", this.ClusterDesc);
            this.SetParamObj(map, prefix + "ClusterAdvancedSettings.", this.ClusterAdvancedSettings);
            this.SetParamSimple(map, prefix + "MaxNodePodNum", this.MaxNodePodNum);
            this.SetParamObj(map, prefix + "PublicLB.", this.PublicLB);
            this.SetParamSimple(map, prefix + "ClusterLevel", this.ClusterLevel);
            this.SetParamSimple(map, prefix + "AutoUpgradeClusterLevel", this.AutoUpgradeClusterLevel);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
        }
    }
}

