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

namespace TencentCloud.Ic.V20190307
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ic.V20190307.Models;

   public class IcClient : AbstractClient{

       private const string endpoint = "ic.tencentcloudapi.com";
       private const string version = "2019-03-07";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IcClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IcClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 根据应用id查询物联卡应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAppRequest"/></param>
        /// <returns><see cref="DescribeAppResponse"/></returns>
        public async Task<DescribeAppResponse> DescribeApp(DescribeAppRequest req)
        {
             JsonResponseModel<DescribeAppResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据应用id查询物联卡应用详情
        /// </summary>
        /// <param name="req"><see cref="DescribeAppRequest"/></param>
        /// <returns><see cref="DescribeAppResponse"/></returns>
        public DescribeAppResponse DescribeAppSync(DescribeAppRequest req)
        {
             JsonResponseModel<DescribeAppResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApp");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAppResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询卡片详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCardRequest"/></param>
        /// <returns><see cref="DescribeCardResponse"/></returns>
        public async Task<DescribeCardResponse> DescribeCard(DescribeCardRequest req)
        {
             JsonResponseModel<DescribeCardResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询卡片详细信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCardRequest"/></param>
        /// <returns><see cref="DescribeCardResponse"/></returns>
        public DescribeCardResponse DescribeCardSync(DescribeCardRequest req)
        {
             JsonResponseModel<DescribeCardResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCard");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCardResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询卡片列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCardsRequest"/></param>
        /// <returns><see cref="DescribeCardsResponse"/></returns>
        public async Task<DescribeCardsResponse> DescribeCards(DescribeCardsRequest req)
        {
             JsonResponseModel<DescribeCardsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询卡片列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeCardsRequest"/></param>
        /// <returns><see cref="DescribeCardsResponse"/></returns>
        public DescribeCardsResponse DescribeCardsSync(DescribeCardsRequest req)
        {
             JsonResponseModel<DescribeCardsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询短信列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsRequest"/></param>
        /// <returns><see cref="DescribeSmsResponse"/></returns>
        public async Task<DescribeSmsResponse> DescribeSms(DescribeSmsRequest req)
        {
             JsonResponseModel<DescribeSmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询短信列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSmsRequest"/></param>
        /// <returns><see cref="DescribeSmsResponse"/></returns>
        public DescribeSmsResponse DescribeSmsSync(DescribeSmsRequest req)
        {
             JsonResponseModel<DescribeSmsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑卡片备注
        /// </summary>
        /// <param name="req"><see cref="ModifyUserCardRemarkRequest"/></param>
        /// <returns><see cref="ModifyUserCardRemarkResponse"/></returns>
        public async Task<ModifyUserCardRemarkResponse> ModifyUserCardRemark(ModifyUserCardRemarkRequest req)
        {
             JsonResponseModel<ModifyUserCardRemarkResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUserCardRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserCardRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑卡片备注
        /// </summary>
        /// <param name="req"><see cref="ModifyUserCardRemarkRequest"/></param>
        /// <returns><see cref="ModifyUserCardRemarkResponse"/></returns>
        public ModifyUserCardRemarkResponse ModifyUserCardRemarkSync(ModifyUserCardRemarkRequest req)
        {
             JsonResponseModel<ModifyUserCardRemarkResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUserCardRemark");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserCardRemarkResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 购买套外流量包
        /// </summary>
        /// <param name="req"><see cref="PayForExtendDataRequest"/></param>
        /// <returns><see cref="PayForExtendDataResponse"/></returns>
        public async Task<PayForExtendDataResponse> PayForExtendData(PayForExtendDataRequest req)
        {
             JsonResponseModel<PayForExtendDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PayForExtendData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PayForExtendDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 购买套外流量包
        /// </summary>
        /// <param name="req"><see cref="PayForExtendDataRequest"/></param>
        /// <returns><see cref="PayForExtendDataResponse"/></returns>
        public PayForExtendDataResponse PayForExtendDataSync(PayForExtendDataRequest req)
        {
             JsonResponseModel<PayForExtendDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PayForExtendData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PayForExtendDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量为卡片续费，此接口建议调用至少间隔10s,如果出现返回deal lock failed相关的错误，请过10s再重试。
        /// 续费的必要条件：
        /// 1、单次续费的卡片不可以超过 100张。
        /// 2、接口只支持在控制台购买的卡片进行续费
        /// 3、销户和未激活的卡片不支持续费。
        /// 4、每张物联网卡，续费总周期不能超过24个月
        /// </summary>
        /// <param name="req"><see cref="RenewCardsRequest"/></param>
        /// <returns><see cref="RenewCardsResponse"/></returns>
        public async Task<RenewCardsResponse> RenewCards(RenewCardsRequest req)
        {
             JsonResponseModel<RenewCardsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewCards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewCardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量为卡片续费，此接口建议调用至少间隔10s,如果出现返回deal lock failed相关的错误，请过10s再重试。
        /// 续费的必要条件：
        /// 1、单次续费的卡片不可以超过 100张。
        /// 2、接口只支持在控制台购买的卡片进行续费
        /// 3、销户和未激活的卡片不支持续费。
        /// 4、每张物联网卡，续费总周期不能超过24个月
        /// </summary>
        /// <param name="req"><see cref="RenewCardsRequest"/></param>
        /// <returns><see cref="RenewCardsResponse"/></returns>
        public RenewCardsResponse RenewCardsSync(RenewCardsRequest req)
        {
             JsonResponseModel<RenewCardsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewCards");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewCardsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 群发短信
        /// </summary>
        /// <param name="req"><see cref="SendMultiSmsRequest"/></param>
        /// <returns><see cref="SendMultiSmsResponse"/></returns>
        public async Task<SendMultiSmsResponse> SendMultiSms(SendMultiSmsRequest req)
        {
             JsonResponseModel<SendMultiSmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendMultiSms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendMultiSmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 群发短信
        /// </summary>
        /// <param name="req"><see cref="SendMultiSmsRequest"/></param>
        /// <returns><see cref="SendMultiSmsResponse"/></returns>
        public SendMultiSmsResponse SendMultiSmsSync(SendMultiSmsRequest req)
        {
             JsonResponseModel<SendMultiSmsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendMultiSms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendMultiSmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送短信息接口
        /// </summary>
        /// <param name="req"><see cref="SendSmsRequest"/></param>
        /// <returns><see cref="SendSmsResponse"/></returns>
        public async Task<SendSmsResponse> SendSms(SendSmsRequest req)
        {
             JsonResponseModel<SendSmsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendSms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendSmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送短信息接口
        /// </summary>
        /// <param name="req"><see cref="SendSmsRequest"/></param>
        /// <returns><see cref="SendSmsResponse"/></returns>
        public SendSmsResponse SendSmsSync(SendSmsRequest req)
        {
             JsonResponseModel<SendSmsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendSms");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendSmsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
