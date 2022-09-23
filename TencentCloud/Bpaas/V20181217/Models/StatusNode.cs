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

namespace TencentCloud.Bpaas.V20181217.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class StatusNode : AbstractModel
    {
        
        /// <summary>
        /// 节点id
        /// </summary>
        [JsonProperty("NodeId")]
        public string NodeId{ get; set; }

        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("NodeName")]
        public string NodeName{ get; set; }

        /// <summary>
        /// 节点类型 1:审批节点 2:执行节点 3:条件节点
        /// </summary>
        [JsonProperty("NodeType")]
        public ulong? NodeType{ get; set; }

        /// <summary>
        /// 下一个节点
        /// </summary>
        [JsonProperty("NextNode")]
        public string NextNode{ get; set; }

        /// <summary>
        /// 审批意见模型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Opinion")]
        public ApproveOpinion Opinion{ get; set; }

        /// <summary>
        /// scf函数名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScfName")]
        public string ScfName{ get; set; }

        /// <summary>
        /// 状态（0：待审批，1：审批通过，2：拒绝，3：scf执行失败，4：scf执行成功）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubStatus")]
        public ulong? SubStatus{ get; set; }

        /// <summary>
        /// 审批节点审批人
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApprovedUin")]
        public ulong?[] ApprovedUin{ get; set; }

        /// <summary>
        /// 审批时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 审批意见信息 审批节点:审批人意见  执行节点:scf函数执行日志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Msg")]
        public string Msg{ get; set; }

        /// <summary>
        /// 有权限审批该节点的uin
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Users")]
        public ApproveUser Users{ get; set; }

        /// <summary>
        /// 是否有权限审批该节点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsApprove")]
        public bool? IsApprove{ get; set; }

        /// <summary>
        /// 审批id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproveId")]
        public string ApproveId{ get; set; }

        /// <summary>
        /// 审批方式 0或签 1会签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproveMethod")]
        public ulong? ApproveMethod{ get; set; }

        /// <summary>
        /// 审批节点审批类型，1人工审批 2自动通过 3自动决绝 4外部审批scf
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApproveType")]
        public ulong? ApproveType{ get; set; }

        /// <summary>
        /// 外部审批类型 scf:0或null ; CKafka:1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CallMethod")]
        public ulong? CallMethod{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NodeId", this.NodeId);
            this.SetParamSimple(map, prefix + "NodeName", this.NodeName);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "NextNode", this.NextNode);
            this.SetParamObj(map, prefix + "Opinion.", this.Opinion);
            this.SetParamSimple(map, prefix + "ScfName", this.ScfName);
            this.SetParamSimple(map, prefix + "SubStatus", this.SubStatus);
            this.SetParamArraySimple(map, prefix + "ApprovedUin.", this.ApprovedUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Msg", this.Msg);
            this.SetParamObj(map, prefix + "Users.", this.Users);
            this.SetParamSimple(map, prefix + "IsApprove", this.IsApprove);
            this.SetParamSimple(map, prefix + "ApproveId", this.ApproveId);
            this.SetParamSimple(map, prefix + "ApproveMethod", this.ApproveMethod);
            this.SetParamSimple(map, prefix + "ApproveType", this.ApproveType);
            this.SetParamSimple(map, prefix + "CallMethod", this.CallMethod);
        }
    }
}

