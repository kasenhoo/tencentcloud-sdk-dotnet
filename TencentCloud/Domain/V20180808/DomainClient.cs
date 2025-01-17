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

namespace TencentCloud.Domain.V20180808
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Domain.V20180808.Models;

   public class DomainClient : AbstractClient{

       private const string endpoint = "domain.tencentcloudapi.com";
       private const string version = "2018-08-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DomainClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DomainClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 本接口 ( BatchModifyDomainInfo ) 用于批量域名信息修改 。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyDomainInfoRequest"/></param>
        /// <returns><see cref="BatchModifyDomainInfoResponse"/></returns>
        public async Task<BatchModifyDomainInfoResponse> BatchModifyDomainInfo(BatchModifyDomainInfoRequest req)
        {
             JsonResponseModel<BatchModifyDomainInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BatchModifyDomainInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyDomainInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( BatchModifyDomainInfo ) 用于批量域名信息修改 。
        /// </summary>
        /// <param name="req"><see cref="BatchModifyDomainInfoRequest"/></param>
        /// <returns><see cref="BatchModifyDomainInfoResponse"/></returns>
        public BatchModifyDomainInfoResponse BatchModifyDomainInfoSync(BatchModifyDomainInfoRequest req)
        {
             JsonResponseModel<BatchModifyDomainInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BatchModifyDomainInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BatchModifyDomainInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( CheckBatchStatus ) 用于查询批量操作日志状态 。
        /// </summary>
        /// <param name="req"><see cref="CheckBatchStatusRequest"/></param>
        /// <returns><see cref="CheckBatchStatusResponse"/></returns>
        public async Task<CheckBatchStatusResponse> CheckBatchStatus(CheckBatchStatusRequest req)
        {
             JsonResponseModel<CheckBatchStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckBatchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBatchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( CheckBatchStatus ) 用于查询批量操作日志状态 。
        /// </summary>
        /// <param name="req"><see cref="CheckBatchStatusRequest"/></param>
        /// <returns><see cref="CheckBatchStatusResponse"/></returns>
        public CheckBatchStatusResponse CheckBatchStatusSync(CheckBatchStatusRequest req)
        {
             JsonResponseModel<CheckBatchStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckBatchStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckBatchStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查域名是否可以注册。
        /// </summary>
        /// <param name="req"><see cref="CheckDomainRequest"/></param>
        /// <returns><see cref="CheckDomainResponse"/></returns>
        public async Task<CheckDomainResponse> CheckDomain(CheckDomainRequest req)
        {
             JsonResponseModel<CheckDomainResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CheckDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查域名是否可以注册。
        /// </summary>
        /// <param name="req"><see cref="CheckDomainRequest"/></param>
        /// <returns><see cref="CheckDomainResponse"/></returns>
        public CheckDomainResponse CheckDomainSync(CheckDomainRequest req)
        {
             JsonResponseModel<CheckDomainResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CheckDomain");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CheckDomainResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( CreateDomainBatch ) 用于批量域名注册 。
        /// </summary>
        /// <param name="req"><see cref="CreateDomainBatchRequest"/></param>
        /// <returns><see cref="CreateDomainBatchResponse"/></returns>
        public async Task<CreateDomainBatchResponse> CreateDomainBatch(CreateDomainBatchRequest req)
        {
             JsonResponseModel<CreateDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( CreateDomainBatch ) 用于批量域名注册 。
        /// </summary>
        /// <param name="req"><see cref="CreateDomainBatchRequest"/></param>
        /// <returns><see cref="CreateDomainBatchResponse"/></returns>
        public CreateDomainBatchResponse CreateDomainBatchSync(CreateDomainBatchRequest req)
        {
             JsonResponseModel<CreateDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于创建有效的手机、邮箱
        /// </summary>
        /// <param name="req"><see cref="CreatePhoneEmailRequest"/></param>
        /// <returns><see cref="CreatePhoneEmailResponse"/></returns>
        public async Task<CreatePhoneEmailResponse> CreatePhoneEmail(CreatePhoneEmailRequest req)
        {
             JsonResponseModel<CreatePhoneEmailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePhoneEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePhoneEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于创建有效的手机、邮箱
        /// </summary>
        /// <param name="req"><see cref="CreatePhoneEmailRequest"/></param>
        /// <returns><see cref="CreatePhoneEmailResponse"/></returns>
        public CreatePhoneEmailResponse CreatePhoneEmailSync(CreatePhoneEmailRequest req)
        {
             JsonResponseModel<CreatePhoneEmailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePhoneEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePhoneEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( CreateTemplate ) 用于添加域名信息模板 。
        /// </summary>
        /// <param name="req"><see cref="CreateTemplateRequest"/></param>
        /// <returns><see cref="CreateTemplateResponse"/></returns>
        public async Task<CreateTemplateResponse> CreateTemplate(CreateTemplateRequest req)
        {
             JsonResponseModel<CreateTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( CreateTemplate ) 用于添加域名信息模板 。
        /// </summary>
        /// <param name="req"><see cref="CreateTemplateRequest"/></param>
        /// <returns><see cref="CreateTemplateResponse"/></returns>
        public CreateTemplateResponse CreateTemplateSync(CreateTemplateRequest req)
        {
             JsonResponseModel<CreateTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于删除已验证的手机邮箱
        /// </summary>
        /// <param name="req"><see cref="DeletePhoneEmailRequest"/></param>
        /// <returns><see cref="DeletePhoneEmailResponse"/></returns>
        public async Task<DeletePhoneEmailResponse> DeletePhoneEmail(DeletePhoneEmailRequest req)
        {
             JsonResponseModel<DeletePhoneEmailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePhoneEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePhoneEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于删除已验证的手机邮箱
        /// </summary>
        /// <param name="req"><see cref="DeletePhoneEmailRequest"/></param>
        /// <returns><see cref="DeletePhoneEmailResponse"/></returns>
        public DeletePhoneEmailResponse DeletePhoneEmailSync(DeletePhoneEmailRequest req)
        {
             JsonResponseModel<DeletePhoneEmailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePhoneEmail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePhoneEmailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( DeleteTemplate ) 用于删除信息模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteTemplateRequest"/></param>
        /// <returns><see cref="DeleteTemplateResponse"/></returns>
        public async Task<DeleteTemplateResponse> DeleteTemplate(DeleteTemplateRequest req)
        {
             JsonResponseModel<DeleteTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( DeleteTemplate ) 用于删除信息模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteTemplateRequest"/></param>
        /// <returns><see cref="DeleteTemplateResponse"/></returns>
        public DeleteTemplateResponse DeleteTemplateSync(DeleteTemplateRequest req)
        {
             JsonResponseModel<DeleteTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( DescribeBatchOperationLogDetails ) 用于获取批量操作日志详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchOperationLogDetailsRequest"/></param>
        /// <returns><see cref="DescribeBatchOperationLogDetailsResponse"/></returns>
        public async Task<DescribeBatchOperationLogDetailsResponse> DescribeBatchOperationLogDetails(DescribeBatchOperationLogDetailsRequest req)
        {
             JsonResponseModel<DescribeBatchOperationLogDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBatchOperationLogDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchOperationLogDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( DescribeBatchOperationLogDetails ) 用于获取批量操作日志详情。
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchOperationLogDetailsRequest"/></param>
        /// <returns><see cref="DescribeBatchOperationLogDetailsResponse"/></returns>
        public DescribeBatchOperationLogDetailsResponse DescribeBatchOperationLogDetailsSync(DescribeBatchOperationLogDetailsRequest req)
        {
             JsonResponseModel<DescribeBatchOperationLogDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBatchOperationLogDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchOperationLogDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( DescribeBatchOperationLogs ) 用于获取批量操作日志 。
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeBatchOperationLogsResponse"/></returns>
        public async Task<DescribeBatchOperationLogsResponse> DescribeBatchOperationLogs(DescribeBatchOperationLogsRequest req)
        {
             JsonResponseModel<DescribeBatchOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBatchOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( DescribeBatchOperationLogs ) 用于获取批量操作日志 。
        /// </summary>
        /// <param name="req"><see cref="DescribeBatchOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeBatchOperationLogsResponse"/></returns>
        public DescribeBatchOperationLogsResponse DescribeBatchOperationLogsSync(DescribeBatchOperationLogsRequest req)
        {
             JsonResponseModel<DescribeBatchOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBatchOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBatchOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (  DescribeDomainBaseInfo) 获取域名基本信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainBaseInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainBaseInfoResponse"/></returns>
        public async Task<DescribeDomainBaseInfoResponse> DescribeDomainBaseInfo(DescribeDomainBaseInfoRequest req)
        {
             JsonResponseModel<DescribeDomainBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (  DescribeDomainBaseInfo) 获取域名基本信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainBaseInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainBaseInfoResponse"/></returns>
        public DescribeDomainBaseInfoResponse DescribeDomainBaseInfoSync(DescribeDomainBaseInfoRequest req)
        {
             JsonResponseModel<DescribeDomainBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (  DescribeDomainNameList ) 我的域名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainNameListRequest"/></param>
        /// <returns><see cref="DescribeDomainNameListResponse"/></returns>
        public async Task<DescribeDomainNameListResponse> DescribeDomainNameList(DescribeDomainNameListRequest req)
        {
             JsonResponseModel<DescribeDomainNameListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainNameList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainNameListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (  DescribeDomainNameList ) 我的域名列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainNameListRequest"/></param>
        /// <returns><see cref="DescribeDomainNameListResponse"/></returns>
        public DescribeDomainNameListResponse DescribeDomainNameListSync(DescribeDomainNameListRequest req)
        {
             JsonResponseModel<DescribeDomainNameListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainNameList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainNameListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照域名后缀获取对应的价格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainPriceListRequest"/></param>
        /// <returns><see cref="DescribeDomainPriceListResponse"/></returns>
        public async Task<DescribeDomainPriceListResponse> DescribeDomainPriceList(DescribeDomainPriceListRequest req)
        {
             JsonResponseModel<DescribeDomainPriceListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainPriceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainPriceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按照域名后缀获取对应的价格列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainPriceListRequest"/></param>
        /// <returns><see cref="DescribeDomainPriceListResponse"/></returns>
        public DescribeDomainPriceListResponse DescribeDomainPriceListSync(DescribeDomainPriceListRequest req)
        {
             JsonResponseModel<DescribeDomainPriceListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainPriceList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainPriceListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名实名信息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainSimpleInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainSimpleInfoResponse"/></returns>
        public async Task<DescribeDomainSimpleInfoResponse> DescribeDomainSimpleInfo(DescribeDomainSimpleInfoRequest req)
        {
             JsonResponseModel<DescribeDomainSimpleInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDomainSimpleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainSimpleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取域名实名信息详情
        /// </summary>
        /// <param name="req"><see cref="DescribeDomainSimpleInfoRequest"/></param>
        /// <returns><see cref="DescribeDomainSimpleInfoResponse"/></returns>
        public DescribeDomainSimpleInfoResponse DescribeDomainSimpleInfoSync(DescribeDomainSimpleInfoRequest req)
        {
             JsonResponseModel<DescribeDomainSimpleInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDomainSimpleInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDomainSimpleInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取已验证的手机邮箱列表
        /// </summary>
        /// <param name="req"><see cref="DescribePhoneEmailListRequest"/></param>
        /// <returns><see cref="DescribePhoneEmailListResponse"/></returns>
        public async Task<DescribePhoneEmailListResponse> DescribePhoneEmailList(DescribePhoneEmailListRequest req)
        {
             JsonResponseModel<DescribePhoneEmailListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePhoneEmailList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePhoneEmailListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于获取已验证的手机邮箱列表
        /// </summary>
        /// <param name="req"><see cref="DescribePhoneEmailListRequest"/></param>
        /// <returns><see cref="DescribePhoneEmailListResponse"/></returns>
        public DescribePhoneEmailListResponse DescribePhoneEmailListSync(DescribePhoneEmailListRequest req)
        {
             JsonResponseModel<DescribePhoneEmailListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePhoneEmailList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePhoneEmailListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeTemplate) 用于获取模板信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateRequest"/></param>
        /// <returns><see cref="DescribeTemplateResponse"/></returns>
        public async Task<DescribeTemplateResponse> DescribeTemplate(DescribeTemplateRequest req)
        {
             JsonResponseModel<DescribeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeTemplate) 用于获取模板信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateRequest"/></param>
        /// <returns><see cref="DescribeTemplateResponse"/></returns>
        public DescribeTemplateResponse DescribeTemplateSync(DescribeTemplateRequest req)
        {
             JsonResponseModel<DescribeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeTemplateList) 用于获取信息模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateListRequest"/></param>
        /// <returns><see cref="DescribeTemplateListResponse"/></returns>
        public async Task<DescribeTemplateListResponse> DescribeTemplateList(DescribeTemplateListRequest req)
        {
             JsonResponseModel<DescribeTemplateListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTemplateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 (DescribeTemplateList) 用于获取信息模板列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplateListRequest"/></param>
        /// <returns><see cref="DescribeTemplateListResponse"/></returns>
        public DescribeTemplateListResponse DescribeTemplateListSync(DescribeTemplateListRequest req)
        {
             JsonResponseModel<DescribeTemplateListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTemplateList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplateListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( ModifyDomainDNSBatch) 用于批量域名 DNS 修改 。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainDNSBatchRequest"/></param>
        /// <returns><see cref="ModifyDomainDNSBatchResponse"/></returns>
        public async Task<ModifyDomainDNSBatchResponse> ModifyDomainDNSBatch(ModifyDomainDNSBatchRequest req)
        {
             JsonResponseModel<ModifyDomainDNSBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainDNSBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainDNSBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( ModifyDomainDNSBatch) 用于批量域名 DNS 修改 。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainDNSBatchRequest"/></param>
        /// <returns><see cref="ModifyDomainDNSBatchResponse"/></returns>
        public ModifyDomainDNSBatchResponse ModifyDomainDNSBatchSync(ModifyDomainDNSBatchRequest req)
        {
             JsonResponseModel<ModifyDomainDNSBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainDNSBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainDNSBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( ModifyDomainOwnerBatch) 用于域名批量账号间转移 。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainOwnerBatchRequest"/></param>
        /// <returns><see cref="ModifyDomainOwnerBatchResponse"/></returns>
        public async Task<ModifyDomainOwnerBatchResponse> ModifyDomainOwnerBatch(ModifyDomainOwnerBatchRequest req)
        {
             JsonResponseModel<ModifyDomainOwnerBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyDomainOwnerBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainOwnerBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( ModifyDomainOwnerBatch) 用于域名批量账号间转移 。
        /// </summary>
        /// <param name="req"><see cref="ModifyDomainOwnerBatchRequest"/></param>
        /// <returns><see cref="ModifyDomainOwnerBatchResponse"/></returns>
        public ModifyDomainOwnerBatchResponse ModifyDomainOwnerBatchSync(ModifyDomainOwnerBatchRequest req)
        {
             JsonResponseModel<ModifyDomainOwnerBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyDomainOwnerBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyDomainOwnerBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( RenewDomainBatch ) 用于批量续费域名 。
        /// </summary>
        /// <param name="req"><see cref="RenewDomainBatchRequest"/></param>
        /// <returns><see cref="RenewDomainBatchResponse"/></returns>
        public async Task<RenewDomainBatchResponse> RenewDomainBatch(RenewDomainBatchRequest req)
        {
             JsonResponseModel<RenewDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RenewDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( RenewDomainBatch ) 用于批量续费域名 。
        /// </summary>
        /// <param name="req"><see cref="RenewDomainBatchRequest"/></param>
        /// <returns><see cref="RenewDomainBatchResponse"/></returns>
        public RenewDomainBatchResponse RenewDomainBatchSync(RenewDomainBatchRequest req)
        {
             JsonResponseModel<RenewDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RenewDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RenewDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于发送手机邮箱验证码。
        /// </summary>
        /// <param name="req"><see cref="SendPhoneEmailCodeRequest"/></param>
        /// <returns><see cref="SendPhoneEmailCodeResponse"/></returns>
        public async Task<SendPhoneEmailCodeResponse> SendPhoneEmailCode(SendPhoneEmailCodeRequest req)
        {
             JsonResponseModel<SendPhoneEmailCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendPhoneEmailCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendPhoneEmailCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于发送手机邮箱验证码。
        /// </summary>
        /// <param name="req"><see cref="SendPhoneEmailCodeRequest"/></param>
        /// <returns><see cref="SendPhoneEmailCodeResponse"/></returns>
        public SendPhoneEmailCodeResponse SendPhoneEmailCodeSync(SendPhoneEmailCodeRequest req)
        {
             JsonResponseModel<SendPhoneEmailCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendPhoneEmailCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendPhoneEmailCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( SetDomainAutoRenew ) 用于设置域名自动续费。
        /// </summary>
        /// <param name="req"><see cref="SetDomainAutoRenewRequest"/></param>
        /// <returns><see cref="SetDomainAutoRenewResponse"/></returns>
        public async Task<SetDomainAutoRenewResponse> SetDomainAutoRenew(SetDomainAutoRenewRequest req)
        {
             JsonResponseModel<SetDomainAutoRenewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SetDomainAutoRenew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetDomainAutoRenewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( SetDomainAutoRenew ) 用于设置域名自动续费。
        /// </summary>
        /// <param name="req"><see cref="SetDomainAutoRenewRequest"/></param>
        /// <returns><see cref="SetDomainAutoRenewResponse"/></returns>
        public SetDomainAutoRenewResponse SetDomainAutoRenewSync(SetDomainAutoRenewRequest req)
        {
             JsonResponseModel<SetDomainAutoRenewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SetDomainAutoRenew");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SetDomainAutoRenewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( TransferInDomainBatch ) 用于批量转入域名 。
        /// </summary>
        /// <param name="req"><see cref="TransferInDomainBatchRequest"/></param>
        /// <returns><see cref="TransferInDomainBatchResponse"/></returns>
        public async Task<TransferInDomainBatchResponse> TransferInDomainBatch(TransferInDomainBatchRequest req)
        {
             JsonResponseModel<TransferInDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TransferInDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransferInDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( TransferInDomainBatch ) 用于批量转入域名 。
        /// </summary>
        /// <param name="req"><see cref="TransferInDomainBatchRequest"/></param>
        /// <returns><see cref="TransferInDomainBatchResponse"/></returns>
        public TransferInDomainBatchResponse TransferInDomainBatchSync(TransferInDomainBatchRequest req)
        {
             JsonResponseModel<TransferInDomainBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TransferInDomainBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransferInDomainBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( TransferProhibitionBatch ) 用于批量禁止域名转移 。
        /// </summary>
        /// <param name="req"><see cref="TransferProhibitionBatchRequest"/></param>
        /// <returns><see cref="TransferProhibitionBatchResponse"/></returns>
        public async Task<TransferProhibitionBatchResponse> TransferProhibitionBatch(TransferProhibitionBatchRequest req)
        {
             JsonResponseModel<TransferProhibitionBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "TransferProhibitionBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransferProhibitionBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( TransferProhibitionBatch ) 用于批量禁止域名转移 。
        /// </summary>
        /// <param name="req"><see cref="TransferProhibitionBatchRequest"/></param>
        /// <returns><see cref="TransferProhibitionBatchResponse"/></returns>
        public TransferProhibitionBatchResponse TransferProhibitionBatchSync(TransferProhibitionBatchRequest req)
        {
             JsonResponseModel<TransferProhibitionBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "TransferProhibitionBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<TransferProhibitionBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( UpdateProhibitionBatch ) 用于批量禁止更新锁。
        /// </summary>
        /// <param name="req"><see cref="UpdateProhibitionBatchRequest"/></param>
        /// <returns><see cref="UpdateProhibitionBatchResponse"/></returns>
        public async Task<UpdateProhibitionBatchResponse> UpdateProhibitionBatch(UpdateProhibitionBatchRequest req)
        {
             JsonResponseModel<UpdateProhibitionBatchResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpdateProhibitionBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProhibitionBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( UpdateProhibitionBatch ) 用于批量禁止更新锁。
        /// </summary>
        /// <param name="req"><see cref="UpdateProhibitionBatchRequest"/></param>
        /// <returns><see cref="UpdateProhibitionBatchResponse"/></returns>
        public UpdateProhibitionBatchResponse UpdateProhibitionBatchSync(UpdateProhibitionBatchRequest req)
        {
             JsonResponseModel<UpdateProhibitionBatchResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpdateProhibitionBatch");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpdateProhibitionBatchResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( UploadImage ) 用于证件图片上传 。
        /// </summary>
        /// <param name="req"><see cref="UploadImageRequest"/></param>
        /// <returns><see cref="UploadImageResponse"/></returns>
        public async Task<UploadImageResponse> UploadImage(UploadImageRequest req)
        {
             JsonResponseModel<UploadImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口 ( UploadImage ) 用于证件图片上传 。
        /// </summary>
        /// <param name="req"><see cref="UploadImageRequest"/></param>
        /// <returns><see cref="UploadImageResponse"/></returns>
        public UploadImageResponse UploadImageSync(UploadImageRequest req)
        {
             JsonResponseModel<UploadImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
