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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Task : AbstractModel
    {
        
        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonProperty("TaskId")]
        public long? TaskId{ get; set; }

        /// <summary>
        /// 任务标题
        /// </summary>
        [JsonProperty("TaskTitle")]
        public string TaskTitle{ get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        [JsonProperty("TaskDescription")]
        public string TaskDescription{ get; set; }

        /// <summary>
        /// 自定义标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskTag")]
        public string TaskTag{ get; set; }

        /// <summary>
        /// 任务状态，1001--未开始  1002--进行中（执行）1003--进行中（暂停）1004--执行结束
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskStatus")]
        public long? TaskStatus{ get; set; }

        /// <summary>
        /// 任务结束状态，表明任务以何种状态结束: 0 -- 尚未结束，1 -- 成功，2-- 失败，3--终止
        /// </summary>
        [JsonProperty("TaskStatusType")]
        public long? TaskStatusType{ get; set; }

        /// <summary>
        /// 保护策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskProtectStrategy")]
        public string TaskProtectStrategy{ get; set; }

        /// <summary>
        /// 任务创建时间
        /// </summary>
        [JsonProperty("TaskCreateTime")]
        public string TaskCreateTime{ get; set; }

        /// <summary>
        /// 任务更新时间
        /// </summary>
        [JsonProperty("TaskUpdateTime")]
        public string TaskUpdateTime{ get; set; }

        /// <summary>
        /// 任务动作组
        /// </summary>
        [JsonProperty("TaskGroups")]
        public TaskGroup[] TaskGroups{ get; set; }

        /// <summary>
        /// 开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskStartTime")]
        public string TaskStartTime{ get; set; }

        /// <summary>
        /// 结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskEndTime")]
        public string TaskEndTime{ get; set; }

        /// <summary>
        /// 是否符合预期。1：符合预期，2：不符合预期
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskExpect")]
        public long? TaskExpect{ get; set; }

        /// <summary>
        /// 演习记录
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskSummary")]
        public string TaskSummary{ get; set; }

        /// <summary>
        /// 任务模式。1:手工执行，2:自动执行
        /// </summary>
        [JsonProperty("TaskMode")]
        public long? TaskMode{ get; set; }

        /// <summary>
        /// 自动暂停时长。单位分钟
        /// </summary>
        [JsonProperty("TaskPauseDuration")]
        public long? TaskPauseDuration{ get; set; }

        /// <summary>
        /// 演练创建者Uin
        /// </summary>
        [JsonProperty("TaskOwnerUin")]
        public string TaskOwnerUin{ get; set; }

        /// <summary>
        /// 地域ID
        /// </summary>
        [JsonProperty("TaskRegionId")]
        public long? TaskRegionId{ get; set; }

        /// <summary>
        /// 监控指标列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskMonitors")]
        public TaskMonitor[] TaskMonitors{ get; set; }

        /// <summary>
        /// 保护策略
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskPolicy")]
        public DescribePolicy TaskPolicy{ get; set; }

        /// <summary>
        /// 标签列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public TagWithDescribe[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "TaskTitle", this.TaskTitle);
            this.SetParamSimple(map, prefix + "TaskDescription", this.TaskDescription);
            this.SetParamSimple(map, prefix + "TaskTag", this.TaskTag);
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamSimple(map, prefix + "TaskStatusType", this.TaskStatusType);
            this.SetParamSimple(map, prefix + "TaskProtectStrategy", this.TaskProtectStrategy);
            this.SetParamSimple(map, prefix + "TaskCreateTime", this.TaskCreateTime);
            this.SetParamSimple(map, prefix + "TaskUpdateTime", this.TaskUpdateTime);
            this.SetParamArrayObj(map, prefix + "TaskGroups.", this.TaskGroups);
            this.SetParamSimple(map, prefix + "TaskStartTime", this.TaskStartTime);
            this.SetParamSimple(map, prefix + "TaskEndTime", this.TaskEndTime);
            this.SetParamSimple(map, prefix + "TaskExpect", this.TaskExpect);
            this.SetParamSimple(map, prefix + "TaskSummary", this.TaskSummary);
            this.SetParamSimple(map, prefix + "TaskMode", this.TaskMode);
            this.SetParamSimple(map, prefix + "TaskPauseDuration", this.TaskPauseDuration);
            this.SetParamSimple(map, prefix + "TaskOwnerUin", this.TaskOwnerUin);
            this.SetParamSimple(map, prefix + "TaskRegionId", this.TaskRegionId);
            this.SetParamArrayObj(map, prefix + "TaskMonitors.", this.TaskMonitors);
            this.SetParamObj(map, prefix + "TaskPolicy.", this.TaskPolicy);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

