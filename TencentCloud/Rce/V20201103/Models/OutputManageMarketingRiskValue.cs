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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OutputManageMarketingRiskValue : AbstractModel
    {
        
        /// <summary>
        /// 账号ID。对应输入参数：
        /// AccountType是1时，对应QQ的OpenID。
        /// AccountType是2时，对应微信的OpenID/UnionID。
        /// AccountType是4时，对应手机号。
        /// AccountType是8时，对应imei、idfa、imeiMD5或者idfaMD5。
        /// AccountType是0时，对应账号信息。
        /// AccountType是10004时，对应手机号的MD5。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 操作时间戳，单位秒（对应输入参数）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostTime")]
        public ulong? PostTime{ get; set; }

        /// <summary>
        /// 对应输入参数，AccountType 是 QQ 或微信开放账号时，用于标识 QQ 或微信用户登录后关联业务自身的账号ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssociateAccount")]
        public string AssociateAccount{ get; set; }

        /// <summary>
        /// 操作来源的外网IP（对应输入参数）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// 风险值
        /// pass : 无恶意
        /// review：需要人工审核
        /// reject：拒绝，高风险恶意
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskLevel")]
        public string RiskLevel{ get; set; }

        /// <summary>
        /// 风险类型，请参考官网风险类型
        /// 账号风险 
        /// 1 账号信用低,账号近期存在因恶意被处罚历史，网络低活跃，被举报等因素
        /// 11 疑似 低活跃账号,账号活跃度与正常用户有差异
        /// 2 垃圾账号 疑似批量注册小号，近期存在严重违规或大量举报
        /// 21 疑似小号 账号有疑似线上养号，小号等行为
        /// 22 疑似违规账号 账号曾有违规行为、曾被举报过、曾因违规被处罚过等
        /// 3 无效账号 送检账号参数无法成功解析，请检查微信 openid 是否有误/appid与QQopenid无法关联/微信openid权限是否有开通/手机号是否为中国大陆手机号；
        /// 4 黑名单 该账号在业务侧有过拉黑记录
        /// 5 白名单 业务自行有添加过白名单记录
        /// 行为风险 
        /// 101 批量操作 存在 ip/设备/环境等因素的聚集性异常
        /// 1011 疑似 IP 属性聚集，出现 IP 聚集
        /// 1012 疑似 设备属性聚集 出现设备聚集
        /// 102 自动机 疑似自动机批量请求
        /// 103 恶意行为-网赚 疑似网赚
        /// 104 微信登录态无效 检查 WeChatAccessToken 参数，是否已经失效；
        /// 201 环境风险 环境异常 操作 ip/设备/环境存在异常。当前 ip 为非常用 ip 或恶意 ip 段
        /// 2011 疑似 非常用IP 请求 当前请求 IP 非该账号常用 IP
        /// 2012 疑似 IP 异常 使用 idc 机房 ip 或 使用代理 ip 或 使用恶意 ip 等
        /// 205 非公网有效ip 传进来的 IP 地址为内网 ip 地址或者 ip 保留地址；
        /// 设备风险
        /// 206  设备异常 该设备存在异常的使用行为
        /// 2061 疑似 非常用设备 当前请求的设备非该账号常用设备
        /// 2062 疑似 虚拟设备 请求设备为模拟器、脚本、云设备等虚拟设备
        /// 2063 疑似 群控设备 请求设备为猫池、手机墙等群控设备
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RiskType")]
        public long?[] RiskType{ get; set; }

        /// <summary>
        /// 唯一ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConstId")]
        public string ConstId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "PostTime", this.PostTime);
            this.SetParamSimple(map, prefix + "AssociateAccount", this.AssociateAccount);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "RiskLevel", this.RiskLevel);
            this.SetParamArraySimple(map, prefix + "RiskType.", this.RiskType);
            this.SetParamSimple(map, prefix + "ConstId", this.ConstId);
        }
    }
}

