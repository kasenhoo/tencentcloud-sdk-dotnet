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

namespace TencentCloud.Ms.V20180408
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ms.V20180408.Models;

   public class MsClient : AbstractClient{

       private const string endpoint = "ms.tencentcloudapi.com";
       private const string version = "2018-04-08";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 将应用和资源进行绑定
        /// </summary>
        /// <param name="req"><see cref="CreateBindInstanceRequest"/></param>
        /// <returns><see cref="CreateBindInstanceResponse"/></returns>
        public async Task<CreateBindInstanceResponse> CreateBindInstance(CreateBindInstanceRequest req)
        {
             JsonResponseModel<CreateBindInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateBindInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBindInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将应用和资源进行绑定
        /// </summary>
        /// <param name="req"><see cref="CreateBindInstanceRequest"/></param>
        /// <returns><see cref="CreateBindInstanceResponse"/></returns>
        public CreateBindInstanceResponse CreateBindInstanceSync(CreateBindInstanceRequest req)
        {
             JsonResponseModel<CreateBindInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateBindInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateBindInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云COS文件存储临时密钥，密钥仅限于临时上传文件，有访问限制和时效性。
        /// </summary>
        /// <param name="req"><see cref="CreateCosSecKeyInstanceRequest"/></param>
        /// <returns><see cref="CreateCosSecKeyInstanceResponse"/></returns>
        public async Task<CreateCosSecKeyInstanceResponse> CreateCosSecKeyInstance(CreateCosSecKeyInstanceRequest req)
        {
             JsonResponseModel<CreateCosSecKeyInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateCosSecKeyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCosSecKeyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云COS文件存储临时密钥，密钥仅限于临时上传文件，有访问限制和时效性。
        /// </summary>
        /// <param name="req"><see cref="CreateCosSecKeyInstanceRequest"/></param>
        /// <returns><see cref="CreateCosSecKeyInstanceResponse"/></returns>
        public CreateCosSecKeyInstanceResponse CreateCosSecKeyInstanceSync(CreateCosSecKeyInstanceRequest req)
        {
             JsonResponseModel<CreateCosSecKeyInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateCosSecKeyInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateCosSecKeyInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户可以使用该接口自建资源，只支持白名单用户
        /// </summary>
        /// <param name="req"><see cref="CreateResourceInstancesRequest"/></param>
        /// <returns><see cref="CreateResourceInstancesResponse"/></returns>
        public async Task<CreateResourceInstancesResponse> CreateResourceInstances(CreateResourceInstancesRequest req)
        {
             JsonResponseModel<CreateResourceInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateResourceInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourceInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户可以使用该接口自建资源，只支持白名单用户
        /// </summary>
        /// <param name="req"><see cref="CreateResourceInstancesRequest"/></param>
        /// <returns><see cref="CreateResourceInstancesResponse"/></returns>
        public CreateResourceInstancesResponse CreateResourceInstancesSync(CreateResourceInstancesRequest req)
        {
             JsonResponseModel<CreateResourceInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateResourceInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateResourceInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过该接口批量提交应用进行应用扫描，扫描后需通过DescribeScanResults接口查询扫描结果
        /// </summary>
        /// <param name="req"><see cref="CreateScanInstancesRequest"/></param>
        /// <returns><see cref="CreateScanInstancesResponse"/></returns>
        public async Task<CreateScanInstancesResponse> CreateScanInstances(CreateScanInstancesRequest req)
        {
             JsonResponseModel<CreateScanInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateScanInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScanInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过该接口批量提交应用进行应用扫描，扫描后需通过DescribeScanResults接口查询扫描结果
        /// </summary>
        /// <param name="req"><see cref="CreateScanInstancesRequest"/></param>
        /// <returns><see cref="CreateScanInstancesResponse"/></returns>
        public CreateScanInstancesResponse CreateScanInstancesSync(CreateScanInstancesRequest req)
        {
             JsonResponseModel<CreateScanInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateScanInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateScanInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过该接口提交应用进行应用加固，加固后需通过DescribeShieldResult接口查询加固结果
        /// </summary>
        /// <param name="req"><see cref="CreateShieldInstanceRequest"/></param>
        /// <returns><see cref="CreateShieldInstanceResponse"/></returns>
        public async Task<CreateShieldInstanceResponse> CreateShieldInstance(CreateShieldInstanceRequest req)
        {
             JsonResponseModel<CreateShieldInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateShieldInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateShieldInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过该接口提交应用进行应用加固，加固后需通过DescribeShieldResult接口查询加固结果
        /// </summary>
        /// <param name="req"><see cref="CreateShieldInstanceRequest"/></param>
        /// <returns><see cref="CreateShieldInstanceResponse"/></returns>
        public CreateShieldInstanceResponse CreateShieldInstanceSync(CreateShieldInstanceRequest req)
        {
             JsonResponseModel<CreateShieldInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateShieldInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateShieldInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对资源进行策略新增
        /// </summary>
        /// <param name="req"><see cref="CreateShieldPlanInstanceRequest"/></param>
        /// <returns><see cref="CreateShieldPlanInstanceResponse"/></returns>
        public async Task<CreateShieldPlanInstanceResponse> CreateShieldPlanInstance(CreateShieldPlanInstanceRequest req)
        {
             JsonResponseModel<CreateShieldPlanInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateShieldPlanInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateShieldPlanInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对资源进行策略新增
        /// </summary>
        /// <param name="req"><see cref="CreateShieldPlanInstanceRequest"/></param>
        /// <returns><see cref="CreateShieldPlanInstanceResponse"/></returns>
        public CreateShieldPlanInstanceResponse CreateShieldPlanInstanceSync(CreateShieldPlanInstanceRequest req)
        {
             JsonResponseModel<CreateShieldPlanInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateShieldPlanInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateShieldPlanInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个或者多个app扫描信息
        /// </summary>
        /// <param name="req"><see cref="DeleteScanInstancesRequest"/></param>
        /// <returns><see cref="DeleteScanInstancesResponse"/></returns>
        public async Task<DeleteScanInstancesResponse> DeleteScanInstances(DeleteScanInstancesRequest req)
        {
             JsonResponseModel<DeleteScanInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteScanInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScanInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个或者多个app扫描信息
        /// </summary>
        /// <param name="req"><see cref="DeleteScanInstancesRequest"/></param>
        /// <returns><see cref="DeleteScanInstancesResponse"/></returns>
        public DeleteScanInstancesResponse DeleteScanInstancesSync(DeleteScanInstancesRequest req)
        {
             JsonResponseModel<DeleteScanInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteScanInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteScanInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个或者多个app加固信息
        /// </summary>
        /// <param name="req"><see cref="DeleteShieldInstancesRequest"/></param>
        /// <returns><see cref="DeleteShieldInstancesResponse"/></returns>
        public async Task<DeleteShieldInstancesResponse> DeleteShieldInstances(DeleteShieldInstancesRequest req)
        {
             JsonResponseModel<DeleteShieldInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteShieldInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteShieldInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个或者多个app加固信息
        /// </summary>
        /// <param name="req"><see cref="DeleteShieldInstancesRequest"/></param>
        /// <returns><see cref="DeleteShieldInstancesResponse"/></returns>
        public DeleteShieldInstancesResponse DeleteShieldInstancesSync(DeleteShieldInstancesRequest req)
        {
             JsonResponseModel<DeleteShieldInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteShieldInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteShieldInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口采用同步模式请求腾讯APK云检测服务，即时返回检测数据，需要用户用轮询的方式调用本接口来进行样本送检并获取检测结果(每隔60s发送一次请求，传相同的参数，重试30次)，一般情况下0.5h内会出检测结果，最长时间是3h。当Result为ok并且ResultList数组非空有值时，代表检测完毕，若长时间获取不到检测结果，请联系客服。
        /// </summary>
        /// <param name="req"><see cref="DescribeApkDetectionResultRequest"/></param>
        /// <returns><see cref="DescribeApkDetectionResultResponse"/></returns>
        public async Task<DescribeApkDetectionResultResponse> DescribeApkDetectionResult(DescribeApkDetectionResultRequest req)
        {
             JsonResponseModel<DescribeApkDetectionResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApkDetectionResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApkDetectionResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口采用同步模式请求腾讯APK云检测服务，即时返回检测数据，需要用户用轮询的方式调用本接口来进行样本送检并获取检测结果(每隔60s发送一次请求，传相同的参数，重试30次)，一般情况下0.5h内会出检测结果，最长时间是3h。当Result为ok并且ResultList数组非空有值时，代表检测完毕，若长时间获取不到检测结果，请联系客服。
        /// </summary>
        /// <param name="req"><see cref="DescribeApkDetectionResultRequest"/></param>
        /// <returns><see cref="DescribeApkDetectionResultResponse"/></returns>
        public DescribeApkDetectionResultResponse DescribeApkDetectionResultSync(DescribeApkDetectionResultRequest req)
        {
             JsonResponseModel<DescribeApkDetectionResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApkDetectionResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApkDetectionResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取某个用户的所有资源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceInstancesRequest"/></param>
        /// <returns><see cref="DescribeResourceInstancesResponse"/></returns>
        public async Task<DescribeResourceInstancesResponse> DescribeResourceInstances(DescribeResourceInstancesRequest req)
        {
             JsonResponseModel<DescribeResourceInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取某个用户的所有资源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceInstancesRequest"/></param>
        /// <returns><see cref="DescribeResourceInstancesResponse"/></returns>
        public DescribeResourceInstancesResponse DescribeResourceInstancesSync(DescribeResourceInstancesRequest req)
        {
             JsonResponseModel<DescribeResourceInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查看app列表。
        /// 可以通过指定任务唯一标识ItemId来查询指定app的详细信息，或通过设定过滤器来查询满足过滤条件的app的详细信息。 指定偏移(Offset)和限制(Limit)来选择结果中的一部分，默认返回满足条件的前20个app信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeScanInstancesRequest"/></param>
        /// <returns><see cref="DescribeScanInstancesResponse"/></returns>
        public async Task<DescribeScanInstancesResponse> DescribeScanInstances(DescribeScanInstancesRequest req)
        {
             JsonResponseModel<DescribeScanInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查看app列表。
        /// 可以通过指定任务唯一标识ItemId来查询指定app的详细信息，或通过设定过滤器来查询满足过滤条件的app的详细信息。 指定偏移(Offset)和限制(Limit)来选择结果中的一部分，默认返回满足条件的前20个app信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeScanInstancesRequest"/></param>
        /// <returns><see cref="DescribeScanInstancesResponse"/></returns>
        public DescribeScanInstancesResponse DescribeScanInstancesSync(DescribeScanInstancesRequest req)
        {
             JsonResponseModel<DescribeScanInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过CreateScanInstances接口提交应用进行风险批量扫描后，用此接口批量获取风险详细信息,包含漏洞信息，广告信息，插件信息和病毒信息
        /// </summary>
        /// <param name="req"><see cref="DescribeScanResultsRequest"/></param>
        /// <returns><see cref="DescribeScanResultsResponse"/></returns>
        public async Task<DescribeScanResultsResponse> DescribeScanResults(DescribeScanResultsRequest req)
        {
             JsonResponseModel<DescribeScanResultsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeScanResults");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanResultsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用户通过CreateScanInstances接口提交应用进行风险批量扫描后，用此接口批量获取风险详细信息,包含漏洞信息，广告信息，插件信息和病毒信息
        /// </summary>
        /// <param name="req"><see cref="DescribeScanResultsRequest"/></param>
        /// <returns><see cref="DescribeScanResultsResponse"/></returns>
        public DescribeScanResultsResponse DescribeScanResultsSync(DescribeScanResultsRequest req)
        {
             JsonResponseModel<DescribeScanResultsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeScanResults");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeScanResultsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查看app列表。
        /// 可以通过指定任务唯一标识ItemId来查询指定app的详细信息，或通过设定过滤器来查询满足过滤条件的app的详细信息。 指定偏移(Offset)和限制(Limit)来选择结果中的一部分，默认返回满足条件的前20个app信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeShieldInstancesRequest"/></param>
        /// <returns><see cref="DescribeShieldInstancesResponse"/></returns>
        public async Task<DescribeShieldInstancesResponse> DescribeShieldInstances(DescribeShieldInstancesRequest req)
        {
             JsonResponseModel<DescribeShieldInstancesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShieldInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShieldInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于查看app列表。
        /// 可以通过指定任务唯一标识ItemId来查询指定app的详细信息，或通过设定过滤器来查询满足过滤条件的app的详细信息。 指定偏移(Offset)和限制(Limit)来选择结果中的一部分，默认返回满足条件的前20个app信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeShieldInstancesRequest"/></param>
        /// <returns><see cref="DescribeShieldInstancesResponse"/></returns>
        public DescribeShieldInstancesResponse DescribeShieldInstancesSync(DescribeShieldInstancesRequest req)
        {
             JsonResponseModel<DescribeShieldInstancesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeShieldInstances");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShieldInstancesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询加固策略
        /// </summary>
        /// <param name="req"><see cref="DescribeShieldPlanInstanceRequest"/></param>
        /// <returns><see cref="DescribeShieldPlanInstanceResponse"/></returns>
        public async Task<DescribeShieldPlanInstanceResponse> DescribeShieldPlanInstance(DescribeShieldPlanInstanceRequest req)
        {
             JsonResponseModel<DescribeShieldPlanInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShieldPlanInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShieldPlanInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询加固策略
        /// </summary>
        /// <param name="req"><see cref="DescribeShieldPlanInstanceRequest"/></param>
        /// <returns><see cref="DescribeShieldPlanInstanceResponse"/></returns>
        public DescribeShieldPlanInstanceResponse DescribeShieldPlanInstanceSync(DescribeShieldPlanInstanceRequest req)
        {
             JsonResponseModel<DescribeShieldPlanInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeShieldPlanInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShieldPlanInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过唯一标识获取加固的结果
        /// </summary>
        /// <param name="req"><see cref="DescribeShieldResultRequest"/></param>
        /// <returns><see cref="DescribeShieldResultResponse"/></returns>
        public async Task<DescribeShieldResultResponse> DescribeShieldResult(DescribeShieldResultRequest req)
        {
             JsonResponseModel<DescribeShieldResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeShieldResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShieldResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过唯一标识获取加固的结果
        /// </summary>
        /// <param name="req"><see cref="DescribeShieldResultRequest"/></param>
        /// <returns><see cref="DescribeShieldResultResponse"/></returns>
        public DescribeShieldResultResponse DescribeShieldResultSync(DescribeShieldResultRequest req)
        {
             JsonResponseModel<DescribeShieldResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeShieldResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeShieldResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动安全-网址检测服务
        /// </summary>
        /// <param name="req"><see cref="DescribeUrlDetectionResultRequest"/></param>
        /// <returns><see cref="DescribeUrlDetectionResultResponse"/></returns>
        public async Task<DescribeUrlDetectionResultResponse> DescribeUrlDetectionResult(DescribeUrlDetectionResultRequest req)
        {
             JsonResponseModel<DescribeUrlDetectionResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUrlDetectionResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUrlDetectionResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 移动安全-网址检测服务
        /// </summary>
        /// <param name="req"><see cref="DescribeUrlDetectionResultRequest"/></param>
        /// <returns><see cref="DescribeUrlDetectionResultResponse"/></returns>
        public DescribeUrlDetectionResultResponse DescribeUrlDetectionResultSync(DescribeUrlDetectionResultRequest req)
        {
             JsonResponseModel<DescribeUrlDetectionResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUrlDetectionResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUrlDetectionResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户基础信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserBaseInfoInstanceRequest"/></param>
        /// <returns><see cref="DescribeUserBaseInfoInstanceResponse"/></returns>
        public async Task<DescribeUserBaseInfoInstanceResponse> DescribeUserBaseInfoInstance(DescribeUserBaseInfoInstanceRequest req)
        {
             JsonResponseModel<DescribeUserBaseInfoInstanceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserBaseInfoInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserBaseInfoInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户基础信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserBaseInfoInstanceRequest"/></param>
        /// <returns><see cref="DescribeUserBaseInfoInstanceResponse"/></returns>
        public DescribeUserBaseInfoInstanceResponse DescribeUserBaseInfoInstanceSync(DescribeUserBaseInfoInstanceRequest req)
        {
             JsonResponseModel<DescribeUserBaseInfoInstanceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserBaseInfoInstance");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserBaseInfoInstanceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
