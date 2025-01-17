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

namespace TencentCloud.Iecp.V20210914.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEdgeUnitApplicationVisualizationResponse : AbstractModel
    {
        
        /// <summary>
        /// 基本信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BasicInfo")]
        public ApplicationBasicInfo BasicInfo{ get; set; }

        /// <summary>
        /// 基本配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BasicConfig")]
        public ApplicationBasicConfig BasicConfig{ get; set; }

        /// <summary>
        /// 卷配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Volumes")]
        public Volume[] Volumes{ get; set; }

        /// <summary>
        /// 初始化容器配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InitContainers")]
        public Container[] InitContainers{ get; set; }

        /// <summary>
        /// 容器配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Containers")]
        public Container[] Containers{ get; set; }

        /// <summary>
        /// 服务配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Service")]
        public Service Service{ get; set; }

        /// <summary>
        /// Job配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Job")]
        public Job Job{ get; set; }

        /// <summary>
        /// CronJob配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CronJob")]
        public CronJob CronJob{ get; set; }

        /// <summary>
        /// 重启策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RestartPolicy")]
        public string RestartPolicy{ get; set; }

        /// <summary>
        /// HPA
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HorizontalPodAutoscaler")]
        public HorizontalPodAutoscaler HorizontalPodAutoscaler{ get; set; }

        /// <summary>
        /// 镜像拉取Secret
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ImagePullSecrets")]
        public string[] ImagePullSecrets{ get; set; }

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
            this.SetParamObj(map, prefix + "BasicInfo.", this.BasicInfo);
            this.SetParamObj(map, prefix + "BasicConfig.", this.BasicConfig);
            this.SetParamArrayObj(map, prefix + "Volumes.", this.Volumes);
            this.SetParamArrayObj(map, prefix + "InitContainers.", this.InitContainers);
            this.SetParamArrayObj(map, prefix + "Containers.", this.Containers);
            this.SetParamObj(map, prefix + "Service.", this.Service);
            this.SetParamObj(map, prefix + "Job.", this.Job);
            this.SetParamObj(map, prefix + "CronJob.", this.CronJob);
            this.SetParamSimple(map, prefix + "RestartPolicy", this.RestartPolicy);
            this.SetParamObj(map, prefix + "HorizontalPodAutoscaler.", this.HorizontalPodAutoscaler);
            this.SetParamArraySimple(map, prefix + "ImagePullSecrets.", this.ImagePullSecrets);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

