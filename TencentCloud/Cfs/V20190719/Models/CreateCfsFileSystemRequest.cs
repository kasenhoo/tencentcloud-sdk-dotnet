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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCfsFileSystemRequest : AbstractModel
    {
        
        /// <summary>
        /// 可用区名称，例如ap-beijing-1，请参考 [概览](https://cloud.tencent.com/document/product/582/13225) 文档中的地域与可用区列表
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 网络类型，可选值为 VPC，BASIC，CCN；其中 VPC 为私有网络，BASIC 为基础网络, CCN 为云联网，Turbo系列当前必须选择云联网。目前基础网络已逐渐淘汰，不推荐使用。
        /// </summary>
        [JsonProperty("NetInterface")]
        public string NetInterface{ get; set; }

        /// <summary>
        /// 权限组 ID，通用标准型和性能型必填，turbo系列请填写pgroupbasic
        /// </summary>
        [JsonProperty("PGroupId")]
        public string PGroupId{ get; set; }

        /// <summary>
        /// 文件系统协议类型， 值为 NFS、CIFS、TURBO ; 若留空则默认为 NFS协议，turbo系列必须选择turbo，不支持NFS、CIFS
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 文件系统存储类型，默认值为 SD ；其中 SD 为通用标准型标准型存储， HP为通用性能型存储， TB为turbo标准型， TP 为turbo性能型。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// 私有网络（VPC） ID，若网络类型选择的是VPC，该字段为必填。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网 ID，若网络类型选择的是VPC，该字段为必填。
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 指定IP地址，仅VPC网络支持；若不填写、将在该子网下随机分配 IP，Turbo系列当前不支持指定
        /// </summary>
        [JsonProperty("MountIP")]
        public string MountIP{ get; set; }

        /// <summary>
        /// 用户自定义文件系统名称
        /// </summary>
        [JsonProperty("FsName")]
        public string FsName{ get; set; }

        /// <summary>
        /// 文件系统标签
        /// </summary>
        [JsonProperty("ResourceTags")]
        public TagInfo[] ResourceTags{ get; set; }

        /// <summary>
        /// 用于保证请求幂等性的字符串。该字符串由客户生成，需保证不同请求之间唯一，最大值不超过64个ASCII字符。若不指定该参数，则无法保证请求的幂等性。用于保证请求幂等性的字符串失效时间为2小时。
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 云联网ID， 若网络类型选择的是CCN，该字段为必填
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// 云联网中CFS使用的网段， 若网络类型选择的是Ccn，该字段为必填，且不能和Ccn中已经绑定的网段冲突
        /// </summary>
        [JsonProperty("CidrBlock")]
        public string CidrBlock{ get; set; }

        /// <summary>
        /// 文件系统容量，turbo系列必填，单位为GiB。 turbo标准型单位GB，起售40TiB，即40960 GiB；扩容步长20TiB，即20480 GiB。turbo性能型起售20TiB，即20480 GiB；扩容步长10TiB，10240 GiB。
        /// </summary>
        [JsonProperty("Capacity")]
        public ulong? Capacity{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "NetInterface", this.NetInterface);
            this.SetParamSimple(map, prefix + "PGroupId", this.PGroupId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "MountIP", this.MountIP);
            this.SetParamSimple(map, prefix + "FsName", this.FsName);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamSimple(map, prefix + "CidrBlock", this.CidrBlock);
            this.SetParamSimple(map, prefix + "Capacity", this.Capacity);
        }
    }
}

