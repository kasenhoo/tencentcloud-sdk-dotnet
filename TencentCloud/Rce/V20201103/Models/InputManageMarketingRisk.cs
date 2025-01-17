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

    public class InputManageMarketingRisk : AbstractModel
    {
        
        /// <summary>
        /// 账号信息。
        /// </summary>
        [JsonProperty("Account")]
        public AccountInfo Account{ get; set; }

        /// <summary>
        /// 场景类型：场景SceneCode, 控制台上新建对应的场景并获取对应的值；
        /// 例如：e_register_protection_1521184361
        /// 控制台链接：https://console.cloud.tencent.com/rce/risk/sceneroot；
        /// </summary>
        [JsonProperty("SceneCode")]
        public string SceneCode{ get; set; }

        /// <summary>
        /// 登录来源的外网IP
        /// </summary>
        [JsonProperty("UserIp")]
        public string UserIp{ get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        [JsonProperty("PostTime")]
        public ulong? PostTime{ get; set; }

        /// <summary>
        /// 用户唯一标识。
        /// </summary>
        [JsonProperty("UserId")]
        public string UserId{ get; set; }

        /// <summary>
        /// 设备指纹token。
        /// </summary>
        [JsonProperty("DeviceToken")]
        public string DeviceToken{ get; set; }

        /// <summary>
        /// 设备指纹BusinessId
        /// </summary>
        [JsonProperty("DeviceBusinessId")]
        public long? DeviceBusinessId{ get; set; }

        /// <summary>
        /// 业务ID。网站或应用在多个业务中使用此服务，通过此ID区分统计数据。
        /// </summary>
        [JsonProperty("BusinessId")]
        public ulong? BusinessId{ get; set; }

        /// <summary>
        /// 昵称，UTF-8 编码。
        /// </summary>
        [JsonProperty("Nickname")]
        public string Nickname{ get; set; }

        /// <summary>
        /// 用户邮箱地址（非系统自动生成）。
        /// </summary>
        [JsonProperty("EmailAddress")]
        public string EmailAddress{ get; set; }

        /// <summary>
        /// 是否识别设备异常：
        /// 0：不识别。
        /// 1：识别。
        /// </summary>
        [JsonProperty("CheckDevice")]
        public long? CheckDevice{ get; set; }

        /// <summary>
        /// 用户HTTP请求中的Cookie进行2次hash的值，只要保证相同Cookie的hash值一致即可。
        /// </summary>
        [JsonProperty("CookieHash")]
        public string CookieHash{ get; set; }

        /// <summary>
        /// 用户HTTP请求的Referer值。
        /// </summary>
        [JsonProperty("Referer")]
        public string Referer{ get; set; }

        /// <summary>
        /// 用户HTTP请求的User-Agent值。
        /// </summary>
        [JsonProperty("UserAgent")]
        public string UserAgent{ get; set; }

        /// <summary>
        /// 用户HTTP请求的X-Forwarded-For值。
        /// </summary>
        [JsonProperty("XForwardedFor")]
        public string XForwardedFor{ get; set; }

        /// <summary>
        /// MAC地址或设备唯一标识。
        /// </summary>
        [JsonProperty("MacAddress")]
        public string MacAddress{ get; set; }

        /// <summary>
        /// 手机制造商ID，如果手机注册，请带上此信息。
        /// </summary>
        [JsonProperty("VendorId")]
        public string VendorId{ get; set; }

        /// <summary>
        /// 设备类型：
        /// 1：Android
        /// 2：IOS
        /// </summary>
        [JsonProperty("DeviceType")]
        public long? DeviceType{ get; set; }

        /// <summary>
        /// 详细信息
        /// </summary>
        [JsonProperty("Details")]
        public InputDetails[] Details{ get; set; }

        /// <summary>
        /// 可选填写。详情请跳转至SponsorInfo查看。
        /// </summary>
        [JsonProperty("Sponsor")]
        public SponsorInfo Sponsor{ get; set; }

        /// <summary>
        /// 可选填写。详情请跳转至OnlineScamInfo查看。
        /// </summary>
        [JsonProperty("OnlineScam")]
        public OnlineScamInfo OnlineScam{ get; set; }

        /// <summary>
        /// 平台: 1android
        /// </summary>
        [JsonProperty("Platform")]
        public string Platform{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Account.", this.Account);
            this.SetParamSimple(map, prefix + "SceneCode", this.SceneCode);
            this.SetParamSimple(map, prefix + "UserIp", this.UserIp);
            this.SetParamSimple(map, prefix + "PostTime", this.PostTime);
            this.SetParamSimple(map, prefix + "UserId", this.UserId);
            this.SetParamSimple(map, prefix + "DeviceToken", this.DeviceToken);
            this.SetParamSimple(map, prefix + "DeviceBusinessId", this.DeviceBusinessId);
            this.SetParamSimple(map, prefix + "BusinessId", this.BusinessId);
            this.SetParamSimple(map, prefix + "Nickname", this.Nickname);
            this.SetParamSimple(map, prefix + "EmailAddress", this.EmailAddress);
            this.SetParamSimple(map, prefix + "CheckDevice", this.CheckDevice);
            this.SetParamSimple(map, prefix + "CookieHash", this.CookieHash);
            this.SetParamSimple(map, prefix + "Referer", this.Referer);
            this.SetParamSimple(map, prefix + "UserAgent", this.UserAgent);
            this.SetParamSimple(map, prefix + "XForwardedFor", this.XForwardedFor);
            this.SetParamSimple(map, prefix + "MacAddress", this.MacAddress);
            this.SetParamSimple(map, prefix + "VendorId", this.VendorId);
            this.SetParamSimple(map, prefix + "DeviceType", this.DeviceType);
            this.SetParamArrayObj(map, prefix + "Details.", this.Details);
            this.SetParamObj(map, prefix + "Sponsor.", this.Sponsor);
            this.SetParamObj(map, prefix + "OnlineScam.", this.OnlineScam);
            this.SetParamSimple(map, prefix + "Platform", this.Platform);
        }
    }
}

