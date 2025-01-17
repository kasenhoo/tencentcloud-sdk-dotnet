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

namespace TencentCloud.Billing.V20180709
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Billing.V20180709.Models;

   public class BillingClient : AbstractClient{

       private const string endpoint = "billing.tencentcloudapi.com";
       private const string version = "2018-07-09";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public BillingClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public BillingClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 获取云账户余额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountBalanceRequest"/></param>
        /// <returns><see cref="DescribeAccountBalanceResponse"/></returns>
        public async Task<DescribeAccountBalanceResponse> DescribeAccountBalance(DescribeAccountBalanceRequest req)
        {
             JsonResponseModel<DescribeAccountBalanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccountBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云账户余额信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeAccountBalanceRequest"/></param>
        /// <returns><see cref="DescribeAccountBalanceResponse"/></returns>
        public DescribeAccountBalanceResponse DescribeAccountBalanceSync(DescribeAccountBalanceRequest req)
        {
             JsonResponseModel<DescribeAccountBalanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccountBalance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccountBalanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账单明细数据
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDetailRequest"/></param>
        /// <returns><see cref="DescribeBillDetailResponse"/></returns>
        public async Task<DescribeBillDetailResponse> DescribeBillDetail(DescribeBillDetailRequest req)
        {
             JsonResponseModel<DescribeBillDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账单明细数据
        /// </summary>
        /// <param name="req"><see cref="DescribeBillDetailRequest"/></param>
        /// <returns><see cref="DescribeBillDetailResponse"/></returns>
        public DescribeBillDetailResponse DescribeBillDetailSync(DescribeBillDetailRequest req)
        {
             JsonResponseModel<DescribeBillDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取收支明细列表，支持翻页和参数过滤
        /// </summary>
        /// <param name="req"><see cref="DescribeBillListRequest"/></param>
        /// <returns><see cref="DescribeBillListResponse"/></returns>
        public async Task<DescribeBillListResponse> DescribeBillList(DescribeBillListRequest req)
        {
             JsonResponseModel<DescribeBillListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取收支明细列表，支持翻页和参数过滤
        /// </summary>
        /// <param name="req"><see cref="DescribeBillListRequest"/></param>
        /// <returns><see cref="DescribeBillListResponse"/></returns>
        public DescribeBillListResponse DescribeBillListSync(DescribeBillListRequest req)
        {
             JsonResponseModel<DescribeBillListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账单资源汇总数据 
        /// </summary>
        /// <param name="req"><see cref="DescribeBillResourceSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillResourceSummaryResponse"/></returns>
        public async Task<DescribeBillResourceSummaryResponse> DescribeBillResourceSummary(DescribeBillResourceSummaryRequest req)
        {
             JsonResponseModel<DescribeBillResourceSummaryResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillResourceSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillResourceSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询账单资源汇总数据 
        /// </summary>
        /// <param name="req"><see cref="DescribeBillResourceSummaryRequest"/></param>
        /// <returns><see cref="DescribeBillResourceSummaryResponse"/></returns>
        public DescribeBillResourceSummaryResponse DescribeBillResourceSummarySync(DescribeBillResourceSummaryRequest req)
        {
             JsonResponseModel<DescribeBillResourceSummaryResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillResourceSummary");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillResourceSummaryResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按付费模式汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByPayModeRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByPayModeResponse"/></returns>
        public async Task<DescribeBillSummaryByPayModeResponse> DescribeBillSummaryByPayMode(DescribeBillSummaryByPayModeRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByPayModeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummaryByPayMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByPayModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按付费模式汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByPayModeRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByPayModeResponse"/></returns>
        public DescribeBillSummaryByPayModeResponse DescribeBillSummaryByPayModeSync(DescribeBillSummaryByPayModeRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByPayModeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillSummaryByPayMode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByPayModeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取产品汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProductResponse"/></returns>
        public async Task<DescribeBillSummaryByProductResponse> DescribeBillSummaryByProduct(DescribeBillSummaryByProductRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummaryByProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取产品汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProductResponse"/></returns>
        public DescribeBillSummaryByProductResponse DescribeBillSummaryByProductSync(DescribeBillSummaryByProductRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillSummaryByProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按项目汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProjectRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProjectResponse"/></returns>
        public async Task<DescribeBillSummaryByProjectResponse> DescribeBillSummaryByProject(DescribeBillSummaryByProjectRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummaryByProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按项目汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByProjectRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByProjectResponse"/></returns>
        public DescribeBillSummaryByProjectResponse DescribeBillSummaryByProjectSync(DescribeBillSummaryByProjectRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillSummaryByProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按地域汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByRegionResponse"/></returns>
        public async Task<DescribeBillSummaryByRegionResponse> DescribeBillSummaryByRegion(DescribeBillSummaryByRegionRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummaryByRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按地域汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByRegionResponse"/></returns>
        public DescribeBillSummaryByRegionResponse DescribeBillSummaryByRegionSync(DescribeBillSummaryByRegionRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillSummaryByRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按标签汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByTagRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByTagResponse"/></returns>
        public async Task<DescribeBillSummaryByTagResponse> DescribeBillSummaryByTag(DescribeBillSummaryByTagRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByTagResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBillSummaryByTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按标签汇总费用分布
        /// </summary>
        /// <param name="req"><see cref="DescribeBillSummaryByTagRequest"/></param>
        /// <returns><see cref="DescribeBillSummaryByTagResponse"/></returns>
        public DescribeBillSummaryByTagResponse DescribeBillSummaryByTagSync(DescribeBillSummaryByTagRequest req)
        {
             JsonResponseModel<DescribeBillSummaryByTagResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBillSummaryByTag");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBillSummaryByTagResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询消耗明细
        /// </summary>
        /// <param name="req"><see cref="DescribeCostDetailRequest"/></param>
        /// <returns><see cref="DescribeCostDetailResponse"/></returns>
        public async Task<DescribeCostDetailResponse> DescribeCostDetail(DescribeCostDetailRequest req)
        {
             JsonResponseModel<DescribeCostDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCostDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCostDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询消耗明细
        /// </summary>
        /// <param name="req"><see cref="DescribeCostDetailRequest"/></param>
        /// <returns><see cref="DescribeCostDetailResponse"/></returns>
        public DescribeCostDetailResponse DescribeCostDetailSync(DescribeCostDetailRequest req)
        {
             JsonResponseModel<DescribeCostDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCostDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCostDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按产品汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByProductResponse"/></returns>
        public async Task<DescribeCostSummaryByProductResponse> DescribeCostSummaryByProduct(DescribeCostSummaryByProductRequest req)
        {
             JsonResponseModel<DescribeCostSummaryByProductResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCostSummaryByProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCostSummaryByProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按产品汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByProductRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByProductResponse"/></returns>
        public DescribeCostSummaryByProductResponse DescribeCostSummaryByProductSync(DescribeCostSummaryByProductRequest req)
        {
             JsonResponseModel<DescribeCostSummaryByProductResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCostSummaryByProduct");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCostSummaryByProductResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按项目汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByProjectRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByProjectResponse"/></returns>
        public async Task<DescribeCostSummaryByProjectResponse> DescribeCostSummaryByProject(DescribeCostSummaryByProjectRequest req)
        {
             JsonResponseModel<DescribeCostSummaryByProjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCostSummaryByProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCostSummaryByProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按项目汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByProjectRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByProjectResponse"/></returns>
        public DescribeCostSummaryByProjectResponse DescribeCostSummaryByProjectSync(DescribeCostSummaryByProjectRequest req)
        {
             JsonResponseModel<DescribeCostSummaryByProjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCostSummaryByProject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCostSummaryByProjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按地域汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByRegionResponse"/></returns>
        public async Task<DescribeCostSummaryByRegionResponse> DescribeCostSummaryByRegion(DescribeCostSummaryByRegionRequest req)
        {
             JsonResponseModel<DescribeCostSummaryByRegionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCostSummaryByRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCostSummaryByRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按地域汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByRegionRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByRegionResponse"/></returns>
        public DescribeCostSummaryByRegionResponse DescribeCostSummaryByRegionSync(DescribeCostSummaryByRegionRequest req)
        {
             JsonResponseModel<DescribeCostSummaryByRegionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCostSummaryByRegion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCostSummaryByRegionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按资源汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByResourceRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByResourceResponse"/></returns>
        public async Task<DescribeCostSummaryByResourceResponse> DescribeCostSummaryByResource(DescribeCostSummaryByResourceRequest req)
        {
             JsonResponseModel<DescribeCostSummaryByResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeCostSummaryByResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCostSummaryByResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取按资源汇总消耗详情
        /// </summary>
        /// <param name="req"><see cref="DescribeCostSummaryByResourceRequest"/></param>
        /// <returns><see cref="DescribeCostSummaryByResourceResponse"/></returns>
        public DescribeCostSummaryByResourceResponse DescribeCostSummaryByResourceSync(DescribeCostSummaryByResourceRequest req)
        {
             JsonResponseModel<DescribeCostSummaryByResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeCostSummaryByResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeCostSummaryByResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="req"><see cref="DescribeDealsByCondRequest"/></param>
        /// <returns><see cref="DescribeDealsByCondResponse"/></returns>
        public async Task<DescribeDealsByCondResponse> DescribeDealsByCond(DescribeDealsByCondRequest req)
        {
             JsonResponseModel<DescribeDealsByCondResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDealsByCond");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDealsByCondResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询订单
        /// </summary>
        /// <param name="req"><see cref="DescribeDealsByCondRequest"/></param>
        /// <returns><see cref="DescribeDealsByCondResponse"/></returns>
        public DescribeDealsByCondResponse DescribeDealsByCondSync(DescribeDealsByCondRequest req)
        {
             JsonResponseModel<DescribeDealsByCondResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDealsByCond");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDealsByCondResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS产品用量明细
        /// </summary>
        /// <param name="req"><see cref="DescribeDosageCosDetailByDateRequest"/></param>
        /// <returns><see cref="DescribeDosageCosDetailByDateResponse"/></returns>
        public async Task<DescribeDosageCosDetailByDateResponse> DescribeDosageCosDetailByDate(DescribeDosageCosDetailByDateRequest req)
        {
             JsonResponseModel<DescribeDosageCosDetailByDateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDosageCosDetailByDate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDosageCosDetailByDateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取COS产品用量明细
        /// </summary>
        /// <param name="req"><see cref="DescribeDosageCosDetailByDateRequest"/></param>
        /// <returns><see cref="DescribeDosageCosDetailByDateResponse"/></returns>
        public DescribeDosageCosDetailByDateResponse DescribeDosageCosDetailByDateSync(DescribeDosageCosDetailByDateRequest req)
        {
             JsonResponseModel<DescribeDosageCosDetailByDateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDosageCosDetailByDate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDosageCosDetailByDateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按日期获取产品用量明细
        /// </summary>
        /// <param name="req"><see cref="DescribeDosageDetailByDateRequest"/></param>
        /// <returns><see cref="DescribeDosageDetailByDateResponse"/></returns>
        public async Task<DescribeDosageDetailByDateResponse> DescribeDosageDetailByDate(DescribeDosageDetailByDateRequest req)
        {
             JsonResponseModel<DescribeDosageDetailByDateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDosageDetailByDate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDosageDetailByDateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 按日期获取产品用量明细
        /// </summary>
        /// <param name="req"><see cref="DescribeDosageDetailByDateRequest"/></param>
        /// <returns><see cref="DescribeDosageDetailByDateResponse"/></returns>
        public DescribeDosageDetailByDateResponse DescribeDosageDetailByDateSync(DescribeDosageDetailByDateRequest req)
        {
             JsonResponseModel<DescribeDosageDetailByDateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDosageDetailByDate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDosageDetailByDateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取代金券相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherInfoRequest"/></param>
        /// <returns><see cref="DescribeVoucherInfoResponse"/></returns>
        public async Task<DescribeVoucherInfoResponse> DescribeVoucherInfo(DescribeVoucherInfoRequest req)
        {
             JsonResponseModel<DescribeVoucherInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVoucherInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVoucherInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取代金券相关信息
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherInfoRequest"/></param>
        /// <returns><see cref="DescribeVoucherInfoResponse"/></returns>
        public DescribeVoucherInfoResponse DescribeVoucherInfoSync(DescribeVoucherInfoRequest req)
        {
             JsonResponseModel<DescribeVoucherInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVoucherInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVoucherInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取代金券使用记录
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherUsageDetailsRequest"/></param>
        /// <returns><see cref="DescribeVoucherUsageDetailsResponse"/></returns>
        public async Task<DescribeVoucherUsageDetailsResponse> DescribeVoucherUsageDetails(DescribeVoucherUsageDetailsRequest req)
        {
             JsonResponseModel<DescribeVoucherUsageDetailsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeVoucherUsageDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVoucherUsageDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取代金券使用记录
        /// </summary>
        /// <param name="req"><see cref="DescribeVoucherUsageDetailsRequest"/></param>
        /// <returns><see cref="DescribeVoucherUsageDetailsResponse"/></returns>
        public DescribeVoucherUsageDetailsResponse DescribeVoucherUsageDetailsSync(DescribeVoucherUsageDetailsRequest req)
        {
             JsonResponseModel<DescribeVoucherUsageDetailsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeVoucherUsageDetails");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeVoucherUsageDetailsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支付订单
        /// </summary>
        /// <param name="req"><see cref="PayDealsRequest"/></param>
        /// <returns><see cref="PayDealsResponse"/></returns>
        public async Task<PayDealsResponse> PayDeals(PayDealsRequest req)
        {
             JsonResponseModel<PayDealsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PayDeals");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PayDealsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 支付订单
        /// </summary>
        /// <param name="req"><see cref="PayDealsRequest"/></param>
        /// <returns><see cref="PayDealsResponse"/></returns>
        public PayDealsResponse PayDealsSync(PayDealsRequest req)
        {
             JsonResponseModel<PayDealsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PayDeals");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PayDealsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
