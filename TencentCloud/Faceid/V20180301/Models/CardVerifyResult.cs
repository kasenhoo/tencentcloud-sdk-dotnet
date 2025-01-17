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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CardVerifyResult : AbstractModel
    {
        
        /// <summary>
        /// 鉴伪或OCR是否成功
        /// </summary>
        [JsonProperty("IsPass")]
        public bool? IsPass{ get; set; }

        /// <summary>
        /// 身份证鉴伪视频，仅开启证件视频鉴伪功能时返回，url链接有效期10分钟。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CardVideo")]
        public FileInfo CardVideo{ get; set; }

        /// <summary>
        /// 证件照图片，url链接有效期10分钟。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CardImage")]
        public FileInfo CardImage{ get; set; }

        /// <summary>
        /// 证件照的文字识别结果，如果鉴伪失败或者ocr失败则该参数为空。url链接有效期10分钟。格式为json文本信息。
        /// IdCardType为HK时：
        /// - CnName string 中文姓名
        /// - EnName string 英文姓名
        /// - TelexCode string 中文姓名对应电码
        /// - Sex string 性别 ：“男M”或“女F”
        /// - Birthday string 出生日期
        /// - Permanent int 永久性居民身份证。0：非永久； 1：永久； -1：未知。
        /// - IdNum string 身份证号码
        /// - Symbol string 证件符号，出生日期下的符号，例如"***AZ"
        /// - FirstIssueDate string 首次签发日期
        /// - CurrentIssueDate string 最近领用日期
        /// 
        /// IdCardType为ML时：
        /// - Sex string 男：LELAKI 女：PEREMPUAN
        /// - Birthday  string 生日
        /// - ID string 证号
        /// - Name string 名字
        /// - Address string 地址
        /// - Type string 证件类型
        /// 
        /// IdCardType为PhilippinesVoteID时：
        /// - Birthday  string 生日
        /// - Address string 地址
        /// - LastName string 姓氏
        /// - FirstName string 姓名
        /// - VIN string VIN号
        /// - CivilStatus string 婚姻状况
        /// - Citizenship string 国籍
        /// - PrecinctNo string 地区
        /// 
        /// IdCardType为PhilippinesDrivingLicense时：
        /// - Sex string 性别
        /// - Birthday  string 生日
        /// - Name string 姓名
        /// - Address string 地址
        /// - LastName string 姓氏
        /// - FirstName string 首姓名
        /// - MiddleName string 中间姓名
        /// - Nationality string 国籍
        /// - LicenseNo string 证号
        /// - ExpiresDate string 有效期
        /// - AgencyCode string 机构代码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CardInfoOcrJson")]
        public FileInfo CardInfoOcrJson{ get; set; }

        /// <summary>
        /// 单次流程请求标示。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsPass", this.IsPass);
            this.SetParamObj(map, prefix + "CardVideo.", this.CardVideo);
            this.SetParamObj(map, prefix + "CardImage.", this.CardImage);
            this.SetParamObj(map, prefix + "CardInfoOcrJson.", this.CardInfoOcrJson);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

