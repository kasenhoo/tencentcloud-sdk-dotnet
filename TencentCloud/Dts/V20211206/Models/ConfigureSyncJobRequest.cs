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

    public class ConfigureSyncJobRequest : AbstractModel
    {
        
        /// <summary>
        /// 同步实例id（即标识一个同步作业），形如sync-werwfs23
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 源端接入类型，cdb(云数据库)、cvm(云主机自建)、vpc(私有网络)、extranet(外网)、vpncloud(vpn接入)、dcg(专线接入)、ccn(云联网)、intranet(自研上云)、noProxy,注意具体可选值依赖当前链路
        /// </summary>
        [JsonProperty("SrcAccessType")]
        public string SrcAccessType{ get; set; }

        /// <summary>
        /// 源端信息
        /// </summary>
        [JsonProperty("SrcInfo")]
        public Endpoint SrcInfo{ get; set; }

        /// <summary>
        /// 目标端接入类型，cdb(云数据库)、cvm(云主机自建)、vpc(私有网络)、extranet(外网)、vpncloud(vpn接入)、dcg(专线接入)、ccn(云联网)、intranet(自研上云)、noProxy,注意具体可选值依赖当前链路
        /// </summary>
        [JsonProperty("DstAccessType")]
        public string DstAccessType{ get; set; }

        /// <summary>
        /// 目标端信息
        /// </summary>
        [JsonProperty("DstInfo")]
        public Endpoint DstInfo{ get; set; }

        /// <summary>
        /// 同步任务选项
        /// </summary>
        [JsonProperty("Options")]
        public Options Options{ get; set; }

        /// <summary>
        /// 同步库表对象信息
        /// </summary>
        [JsonProperty("Objects")]
        public Objects Objects{ get; set; }

        /// <summary>
        /// 同步任务名称
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// 运行模式，取值如：Immediate(表示立即运行，默认为此项值)、Timed(表示定时运行)
        /// </summary>
        [JsonProperty("RunMode")]
        public string RunMode{ get; set; }

        /// <summary>
        /// 期待启动时间，当RunMode取值为Timed时，此值必填，形如："2006-01-02 15:04:05"
        /// </summary>
        [JsonProperty("ExpectRunTime")]
        public string ExpectRunTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "SrcAccessType", this.SrcAccessType);
            this.SetParamObj(map, prefix + "SrcInfo.", this.SrcInfo);
            this.SetParamSimple(map, prefix + "DstAccessType", this.DstAccessType);
            this.SetParamObj(map, prefix + "DstInfo.", this.DstInfo);
            this.SetParamObj(map, prefix + "Options.", this.Options);
            this.SetParamObj(map, prefix + "Objects.", this.Objects);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "RunMode", this.RunMode);
            this.SetParamSimple(map, prefix + "ExpectRunTime", this.ExpectRunTime);
        }
    }
}

