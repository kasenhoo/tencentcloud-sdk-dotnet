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

namespace TencentCloud.Essbasic.V20210526
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Essbasic.V20210526.Models;

   public class EssbasicClient : AbstractClient{

       private const string endpoint = "essbasic.tencentcloudapi.com";
       private const string version = "2021-05-26";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EssbasicClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EssbasicClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 指定需要批量撤销的签署流程Id，批量撤销合同
        /// 客户指定需要撤销的签署流程Id，最多100个，超过100不处理；接口失败后返回错误信息
        /// 注意:
        /// 能撤回合同的只能是合同的发起人或者发起企业的超管、法人
        /// </summary>
        /// <param name="req"><see cref="ChannelBatchCancelFlowsRequest"/></param>
        /// <returns><see cref="ChannelBatchCancelFlowsResponse"/></returns>
        public async Task<ChannelBatchCancelFlowsResponse> ChannelBatchCancelFlows(ChannelBatchCancelFlowsRequest req)
        {
             JsonResponseModel<ChannelBatchCancelFlowsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelBatchCancelFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelBatchCancelFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定需要批量撤销的签署流程Id，批量撤销合同
        /// 客户指定需要撤销的签署流程Id，最多100个，超过100不处理；接口失败后返回错误信息
        /// 注意:
        /// 能撤回合同的只能是合同的发起人或者发起企业的超管、法人
        /// </summary>
        /// <param name="req"><see cref="ChannelBatchCancelFlowsRequest"/></param>
        /// <returns><see cref="ChannelBatchCancelFlowsResponse"/></returns>
        public ChannelBatchCancelFlowsResponse ChannelBatchCancelFlowsSync(ChannelBatchCancelFlowsRequest req)
        {
             JsonResponseModel<ChannelBatchCancelFlowsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelBatchCancelFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelBatchCancelFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 渠道版撤销签署流程接口
        /// 注意:
        /// 能撤回合同的只能是合同的发起人或者发起企业的超管、法人
        /// </summary>
        /// <param name="req"><see cref="ChannelCancelFlowRequest"/></param>
        /// <returns><see cref="ChannelCancelFlowResponse"/></returns>
        public async Task<ChannelCancelFlowResponse> ChannelCancelFlow(ChannelCancelFlowRequest req)
        {
             JsonResponseModel<ChannelCancelFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCancelFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCancelFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 渠道版撤销签署流程接口
        /// 注意:
        /// 能撤回合同的只能是合同的发起人或者发起企业的超管、法人
        /// </summary>
        /// <param name="req"><see cref="ChannelCancelFlowRequest"/></param>
        /// <returns><see cref="ChannelCancelFlowResponse"/></returns>
        public ChannelCancelFlowResponse ChannelCancelFlowSync(ChannelCancelFlowRequest req)
        {
             JsonResponseModel<ChannelCancelFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCancelFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCancelFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelCancelMultiFlowSignQRCode）用于取消一码多扫二维码。该接口对传入的二维码ID，若还在有效期内，可以提前失效。
        /// </summary>
        /// <param name="req"><see cref="ChannelCancelMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="ChannelCancelMultiFlowSignQRCodeResponse"/></returns>
        public async Task<ChannelCancelMultiFlowSignQRCodeResponse> ChannelCancelMultiFlowSignQRCode(ChannelCancelMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<ChannelCancelMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCancelMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCancelMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelCancelMultiFlowSignQRCode）用于取消一码多扫二维码。该接口对传入的二维码ID，若还在有效期内，可以提前失效。
        /// </summary>
        /// <param name="req"><see cref="ChannelCancelMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="ChannelCancelMultiFlowSignQRCodeResponse"/></returns>
        public ChannelCancelMultiFlowSignQRCodeResponse ChannelCancelMultiFlowSignQRCodeSync(ChannelCancelMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<ChannelCancelMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCancelMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCancelMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定需要批量撤销的签署流程Id，获取批量撤销链接
        /// 客户指定需要撤销的签署流程Id，最多100个，超过100不处理；
        /// 接口调用成功返回批量撤销合同的链接，通过链接跳转到电子签小程序完成批量撤销;
        /// 注意:
        /// 能撤回合同的只能是合同的发起人或者发起企业的超管、法人
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateBatchCancelFlowUrlRequest"/></param>
        /// <returns><see cref="ChannelCreateBatchCancelFlowUrlResponse"/></returns>
        public async Task<ChannelCreateBatchCancelFlowUrlResponse> ChannelCreateBatchCancelFlowUrl(ChannelCreateBatchCancelFlowUrlRequest req)
        {
             JsonResponseModel<ChannelCreateBatchCancelFlowUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateBatchCancelFlowUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateBatchCancelFlowUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 指定需要批量撤销的签署流程Id，获取批量撤销链接
        /// 客户指定需要撤销的签署流程Id，最多100个，超过100不处理；
        /// 接口调用成功返回批量撤销合同的链接，通过链接跳转到电子签小程序完成批量撤销;
        /// 注意:
        /// 能撤回合同的只能是合同的发起人或者发起企业的超管、法人
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateBatchCancelFlowUrlRequest"/></param>
        /// <returns><see cref="ChannelCreateBatchCancelFlowUrlResponse"/></returns>
        public ChannelCreateBatchCancelFlowUrlResponse ChannelCreateBatchCancelFlowUrlSync(ChannelCreateBatchCancelFlowUrlRequest req)
        {
             JsonResponseModel<ChannelCreateBatchCancelFlowUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateBatchCancelFlowUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateBatchCancelFlowUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 渠道创建文件转换任务
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateConvertTaskApiRequest"/></param>
        /// <returns><see cref="ChannelCreateConvertTaskApiResponse"/></returns>
        public async Task<ChannelCreateConvertTaskApiResponse> ChannelCreateConvertTaskApi(ChannelCreateConvertTaskApiRequest req)
        {
             JsonResponseModel<ChannelCreateConvertTaskApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateConvertTaskApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateConvertTaskApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 渠道创建文件转换任务
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateConvertTaskApiRequest"/></param>
        /// <returns><see cref="ChannelCreateConvertTaskApiResponse"/></returns>
        public ChannelCreateConvertTaskApiResponse ChannelCreateConvertTaskApiSync(ChannelCreateConvertTaskApiRequest req)
        {
             JsonResponseModel<ChannelCreateConvertTaskApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateConvertTaskApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateConvertTaskApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（ChannelCreateFlowByFiles）用于渠道版通过文件创建签署流程。此接口静默签能力不可直接使用，需要运营申请
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowByFilesRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowByFilesResponse"/></returns>
        public async Task<ChannelCreateFlowByFilesResponse> ChannelCreateFlowByFiles(ChannelCreateFlowByFilesRequest req)
        {
             JsonResponseModel<ChannelCreateFlowByFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateFlowByFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowByFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（ChannelCreateFlowByFiles）用于渠道版通过文件创建签署流程。此接口静默签能力不可直接使用，需要运营申请
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowByFilesRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowByFilesResponse"/></returns>
        public ChannelCreateFlowByFilesResponse ChannelCreateFlowByFilesSync(ChannelCreateFlowByFilesRequest req)
        {
             JsonResponseModel<ChannelCreateFlowByFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateFlowByFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowByFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（ChannelCreateFlowGroupByFiles）用于通过多文件创建合同组签署流程。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowGroupByFilesRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowGroupByFilesResponse"/></returns>
        public async Task<ChannelCreateFlowGroupByFilesResponse> ChannelCreateFlowGroupByFiles(ChannelCreateFlowGroupByFilesRequest req)
        {
             JsonResponseModel<ChannelCreateFlowGroupByFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateFlowGroupByFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowGroupByFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（ChannelCreateFlowGroupByFiles）用于通过多文件创建合同组签署流程。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowGroupByFilesRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowGroupByFilesResponse"/></returns>
        public ChannelCreateFlowGroupByFilesResponse ChannelCreateFlowGroupByFilesSync(ChannelCreateFlowGroupByFilesRequest req)
        {
             JsonResponseModel<ChannelCreateFlowGroupByFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateFlowGroupByFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowGroupByFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交企业签署流程审批结果
        /// 
        /// 在通过接口(CreateFlowsByTemplates 或者ChannelCreateFlowByFiles)创建签署流程时，若指定了参数 NeedSignReview 为true,则可以调用此接口提交企业内部签署审批结果。
        /// 若签署流程状态正常，且本企业存在签署方未签署，同一签署流程可以多次提交签署审批结果，签署时的最后一个“审批结果”有效。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowSignReviewRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowSignReviewResponse"/></returns>
        public async Task<ChannelCreateFlowSignReviewResponse> ChannelCreateFlowSignReview(ChannelCreateFlowSignReviewRequest req)
        {
             JsonResponseModel<ChannelCreateFlowSignReviewResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateFlowSignReview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowSignReviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 提交企业签署流程审批结果
        /// 
        /// 在通过接口(CreateFlowsByTemplates 或者ChannelCreateFlowByFiles)创建签署流程时，若指定了参数 NeedSignReview 为true,则可以调用此接口提交企业内部签署审批结果。
        /// 若签署流程状态正常，且本企业存在签署方未签署，同一签署流程可以多次提交签署审批结果，签署时的最后一个“审批结果”有效。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateFlowSignReviewRequest"/></param>
        /// <returns><see cref="ChannelCreateFlowSignReviewResponse"/></returns>
        public ChannelCreateFlowSignReviewResponse ChannelCreateFlowSignReviewSync(ChannelCreateFlowSignReviewRequest req)
        {
             JsonResponseModel<ChannelCreateFlowSignReviewResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateFlowSignReview");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateFlowSignReviewResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelCreateMultiFlowSignQRCode）用于创建一码多扫签署流程二维码。
        /// 适用的模版仅限于B2C（1、无序签署，2、顺序签署时B静默签署，3、顺序签署时B非首位签署）、单C的模版，且模版中发起方没有填写控件。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="ChannelCreateMultiFlowSignQRCodeResponse"/></returns>
        public async Task<ChannelCreateMultiFlowSignQRCodeResponse> ChannelCreateMultiFlowSignQRCode(ChannelCreateMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<ChannelCreateMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelCreateMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（ChannelCreateMultiFlowSignQRCode）用于创建一码多扫签署流程二维码。
        /// 适用的模版仅限于B2C（1、无序签署，2、顺序签署时B静默签署，3、顺序签署时B非首位签署）、单C的模版，且模版中发起方没有填写控件。
        /// </summary>
        /// <param name="req"><see cref="ChannelCreateMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="ChannelCreateMultiFlowSignQRCodeResponse"/></returns>
        public ChannelCreateMultiFlowSignQRCodeResponse ChannelCreateMultiFlowSignQRCodeSync(ChannelCreateMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<ChannelCreateMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelCreateMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelCreateMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询企业员工列表
        /// </summary>
        /// <param name="req"><see cref="ChannelDescribeEmployeesRequest"/></param>
        /// <returns><see cref="ChannelDescribeEmployeesResponse"/></returns>
        public async Task<ChannelDescribeEmployeesResponse> ChannelDescribeEmployees(ChannelDescribeEmployeesRequest req)
        {
             JsonResponseModel<ChannelDescribeEmployeesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelDescribeEmployees");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDescribeEmployeesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询企业员工列表
        /// </summary>
        /// <param name="req"><see cref="ChannelDescribeEmployeesRequest"/></param>
        /// <returns><see cref="ChannelDescribeEmployeesResponse"/></returns>
        public ChannelDescribeEmployeesResponse ChannelDescribeEmployeesSync(ChannelDescribeEmployeesRequest req)
        {
             JsonResponseModel<ChannelDescribeEmployeesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelDescribeEmployees");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelDescribeEmployeesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 渠道版查询转换任务状态
        /// </summary>
        /// <param name="req"><see cref="ChannelGetTaskResultApiRequest"/></param>
        /// <returns><see cref="ChannelGetTaskResultApiResponse"/></returns>
        public async Task<ChannelGetTaskResultApiResponse> ChannelGetTaskResultApi(ChannelGetTaskResultApiRequest req)
        {
             JsonResponseModel<ChannelGetTaskResultApiResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelGetTaskResultApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelGetTaskResultApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 渠道版查询转换任务状态
        /// </summary>
        /// <param name="req"><see cref="ChannelGetTaskResultApiRequest"/></param>
        /// <returns><see cref="ChannelGetTaskResultApiResponse"/></returns>
        public ChannelGetTaskResultApiResponse ChannelGetTaskResultApiSync(ChannelGetTaskResultApiRequest req)
        {
             JsonResponseModel<ChannelGetTaskResultApiResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelGetTaskResultApi");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelGetTaskResultApiResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 合同文件验签
        /// </summary>
        /// <param name="req"><see cref="ChannelVerifyPdfRequest"/></param>
        /// <returns><see cref="ChannelVerifyPdfResponse"/></returns>
        public async Task<ChannelVerifyPdfResponse> ChannelVerifyPdf(ChannelVerifyPdfRequest req)
        {
             JsonResponseModel<ChannelVerifyPdfResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ChannelVerifyPdf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelVerifyPdfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 合同文件验签
        /// </summary>
        /// <param name="req"><see cref="ChannelVerifyPdfRequest"/></param>
        /// <returns><see cref="ChannelVerifyPdfResponse"/></returns>
        public ChannelVerifyPdfResponse ChannelVerifyPdfSync(ChannelVerifyPdfRequest req)
        {
             JsonResponseModel<ChannelVerifyPdfResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ChannelVerifyPdf");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ChannelVerifyPdfResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateConsoleLoginUrl）用于创建渠道子客企业控制台Web端登录链接。Web端登录链接是子客控制台的唯一入口。
        /// 若子客企业未激活，会进入企业激活流程,首次参与激活流程的经办人会成为超管。（若企业激活过程中填写信息有误，需要重置激活流程，可以换一个经办人OpenId获取新的链接进入。）
        /// 若子客企业已激活，使用了新的经办人OpenId进入，则会进入经办人的实名流程。
        /// 若子客企业、经办人均已完成认证，则会直接进入子客Web控制台。
        /// 返回的Url仅支持PC端操作。
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleLoginUrlRequest"/></param>
        /// <returns><see cref="CreateConsoleLoginUrlResponse"/></returns>
        public async Task<CreateConsoleLoginUrlResponse> CreateConsoleLoginUrl(CreateConsoleLoginUrlRequest req)
        {
             JsonResponseModel<CreateConsoleLoginUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConsoleLoginUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConsoleLoginUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateConsoleLoginUrl）用于创建渠道子客企业控制台Web端登录链接。Web端登录链接是子客控制台的唯一入口。
        /// 若子客企业未激活，会进入企业激活流程,首次参与激活流程的经办人会成为超管。（若企业激活过程中填写信息有误，需要重置激活流程，可以换一个经办人OpenId获取新的链接进入。）
        /// 若子客企业已激活，使用了新的经办人OpenId进入，则会进入经办人的实名流程。
        /// 若子客企业、经办人均已完成认证，则会直接进入子客Web控制台。
        /// 返回的Url仅支持PC端操作。
        /// </summary>
        /// <param name="req"><see cref="CreateConsoleLoginUrlRequest"/></param>
        /// <returns><see cref="CreateConsoleLoginUrlResponse"/></returns>
        public CreateConsoleLoginUrlResponse CreateConsoleLoginUrlSync(CreateConsoleLoginUrlRequest req)
        {
             JsonResponseModel<CreateConsoleLoginUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConsoleLoginUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConsoleLoginUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（CreateFlowsByTemplates）用于使用多个模板批量创建签署流程。当前可批量发起合同（签署流程）数量最大为20个。
        /// 合同发起人必须在电子签已经进行实名。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowsByTemplatesRequest"/></param>
        /// <returns><see cref="CreateFlowsByTemplatesResponse"/></returns>
        public async Task<CreateFlowsByTemplatesResponse> CreateFlowsByTemplates(CreateFlowsByTemplatesRequest req)
        {
             JsonResponseModel<CreateFlowsByTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowsByTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowsByTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 接口（CreateFlowsByTemplates）用于使用多个模板批量创建签署流程。当前可批量发起合同（签署流程）数量最大为20个。
        /// 合同发起人必须在电子签已经进行实名。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowsByTemplatesRequest"/></param>
        /// <returns><see cref="CreateFlowsByTemplatesResponse"/></returns>
        public CreateFlowsByTemplatesResponse CreateFlowsByTemplatesSync(CreateFlowsByTemplatesRequest req)
        {
             JsonResponseModel<CreateFlowsByTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlowsByTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowsByTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 渠道通过图片为子客代创建印章，图片最大5m；此接口不可直接使用，请联系运营/客服咨询相关流程
        /// </summary>
        /// <param name="req"><see cref="CreateSealByImageRequest"/></param>
        /// <returns><see cref="CreateSealByImageResponse"/></returns>
        public async Task<CreateSealByImageResponse> CreateSealByImage(CreateSealByImageRequest req)
        {
             JsonResponseModel<CreateSealByImageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSealByImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSealByImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 渠道通过图片为子客代创建印章，图片最大5m；此接口不可直接使用，请联系运营/客服咨询相关流程
        /// </summary>
        /// <param name="req"><see cref="CreateSealByImageRequest"/></param>
        /// <returns><see cref="CreateSealByImageResponse"/></returns>
        public CreateSealByImageResponse CreateSealByImageSync(CreateSealByImageRequest req)
        {
             JsonResponseModel<CreateSealByImageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSealByImage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSealByImageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建跳转小程序查看或签署的链接。
        /// 
        /// 跳转小程序的几种方式：主要是设置不同的EndPoint
        /// 1. 通过链接Url直接跳转到小程序，不需要返回
        /// 设置EndPoint为WEIXINAPP，得到链接打开即可。（与短信提醒用户签署形式一样）。
        /// 2. 通过链接Url打开H5引导页-->点击跳转到小程序-->签署完退出小程序-->回到H5引导页-->跳转到指定JumpUrl
        /// 设置EndPoint为CHANNEL，指定JumpUrl，得到链接打开即可。
        /// 3. 客户App直接跳转到小程序-->小程序签署完成-->返回App
        /// 跳转到小程序的实现，参考官方文档（分为全屏、半屏两种方式）
        /// 全屏方式：
        /// （https://developers.weixin.qq.com/miniprogram/dev/api/navigate/wx.navigateToMiniProgram.html）
        /// 半屏方式：
        /// （https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/openEmbeddedMiniProgram.html）
        /// 其中小程序的原始Id，请联系<对接技术人员>获取，或者查看小程序信息自助获取。
        /// 使用CreateSignUrls，设置EndPoint为APP，得到path。
        /// 4. 客户小程序直接跳到电子签小程序-->签署完成退出电子签小程序-->回到客户小程序
        /// 实现方式同App跳小程序。
        /// </summary>
        /// <param name="req"><see cref="CreateSignUrlsRequest"/></param>
        /// <returns><see cref="CreateSignUrlsResponse"/></returns>
        public async Task<CreateSignUrlsResponse> CreateSignUrls(CreateSignUrlsRequest req)
        {
             JsonResponseModel<CreateSignUrlsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSignUrls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignUrlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建跳转小程序查看或签署的链接。
        /// 
        /// 跳转小程序的几种方式：主要是设置不同的EndPoint
        /// 1. 通过链接Url直接跳转到小程序，不需要返回
        /// 设置EndPoint为WEIXINAPP，得到链接打开即可。（与短信提醒用户签署形式一样）。
        /// 2. 通过链接Url打开H5引导页-->点击跳转到小程序-->签署完退出小程序-->回到H5引导页-->跳转到指定JumpUrl
        /// 设置EndPoint为CHANNEL，指定JumpUrl，得到链接打开即可。
        /// 3. 客户App直接跳转到小程序-->小程序签署完成-->返回App
        /// 跳转到小程序的实现，参考官方文档（分为全屏、半屏两种方式）
        /// 全屏方式：
        /// （https://developers.weixin.qq.com/miniprogram/dev/api/navigate/wx.navigateToMiniProgram.html）
        /// 半屏方式：
        /// （https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/openEmbeddedMiniProgram.html）
        /// 其中小程序的原始Id，请联系<对接技术人员>获取，或者查看小程序信息自助获取。
        /// 使用CreateSignUrls，设置EndPoint为APP，得到path。
        /// 4. 客户小程序直接跳到电子签小程序-->签署完成退出电子签小程序-->回到客户小程序
        /// 实现方式同App跳小程序。
        /// </summary>
        /// <param name="req"><see cref="CreateSignUrlsRequest"/></param>
        /// <returns><see cref="CreateSignUrlsResponse"/></returns>
        public CreateSignUrlsResponse CreateSignUrlsSync(CreateSignUrlsRequest req)
        {
             JsonResponseModel<CreateSignUrlsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSignUrls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSignUrlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeFlowDetailInfo）用于查询合同(签署流程)的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeFlowDetailInfoResponse"/></returns>
        public async Task<DescribeFlowDetailInfoResponse> DescribeFlowDetailInfo(DescribeFlowDetailInfoRequest req)
        {
             JsonResponseModel<DescribeFlowDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeFlowDetailInfo）用于查询合同(签署流程)的详细信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowDetailInfoRequest"/></param>
        /// <returns><see cref="DescribeFlowDetailInfoResponse"/></returns>
        public DescribeFlowDetailInfoResponse DescribeFlowDetailInfoSync(DescribeFlowDetailInfoRequest req)
        {
             JsonResponseModel<DescribeFlowDetailInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowDetailInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowDetailInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据签署流程信息批量获取资源下载链接，可以下载签署中、签署完的合同，需合作企业先进行授权。
        /// 此接口直接返回下载的资源的url，与接口GetDownloadFlowUrl跳转到控制台的下载方式不同。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUrlsByFlowsRequest"/></param>
        /// <returns><see cref="DescribeResourceUrlsByFlowsResponse"/></returns>
        public async Task<DescribeResourceUrlsByFlowsResponse> DescribeResourceUrlsByFlows(DescribeResourceUrlsByFlowsRequest req)
        {
             JsonResponseModel<DescribeResourceUrlsByFlowsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResourceUrlsByFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceUrlsByFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据签署流程信息批量获取资源下载链接，可以下载签署中、签署完的合同，需合作企业先进行授权。
        /// 此接口直接返回下载的资源的url，与接口GetDownloadFlowUrl跳转到控制台的下载方式不同。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourceUrlsByFlowsRequest"/></param>
        /// <returns><see cref="DescribeResourceUrlsByFlowsResponse"/></returns>
        public DescribeResourceUrlsByFlowsResponse DescribeResourceUrlsByFlowsSync(DescribeResourceUrlsByFlowsRequest req)
        {
             JsonResponseModel<DescribeResourceUrlsByFlowsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResourceUrlsByFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourceUrlsByFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口（DescribeTemplates）查询该子客企业在电子签拥有的有效模板，不包括渠道模板
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTemplatesResponse"/></returns>
        public async Task<DescribeTemplatesResponse> DescribeTemplates(DescribeTemplatesRequest req)
        {
             JsonResponseModel<DescribeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过此接口（DescribeTemplates）查询该子客企业在电子签拥有的有效模板，不包括渠道模板
        /// </summary>
        /// <param name="req"><see cref="DescribeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTemplatesResponse"/></returns>
        public DescribeTemplatesResponse DescribeTemplatesSync(DescribeTemplatesRequest req)
        {
             JsonResponseModel<DescribeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeUsage）用于获取渠道所有合作企业流量消耗情况。
        ///  注: 此接口每日限频2次，若要扩大限制次数,请提前与客服经理或邮件至e-contract@tencent.com进行联系。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageRequest"/></param>
        /// <returns><see cref="DescribeUsageResponse"/></returns>
        public async Task<DescribeUsageResponse> DescribeUsage(DescribeUsageRequest req)
        {
             JsonResponseModel<DescribeUsageResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（DescribeUsage）用于获取渠道所有合作企业流量消耗情况。
        ///  注: 此接口每日限频2次，若要扩大限制次数,请提前与客服经理或邮件至e-contract@tencent.com进行联系。
        /// </summary>
        /// <param name="req"><see cref="DescribeUsageRequest"/></param>
        /// <returns><see cref="DescribeUsageResponse"/></returns>
        public DescribeUsageResponse DescribeUsageSync(DescribeUsageRequest req)
        {
             JsonResponseModel<DescribeUsageResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsage");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsageResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（GetDownloadFlowUrl）用于创建电子签批量下载地址，让合作企业进入控制台直接下载，支持客户合同（流程）按照自定义文件夹形式 分类下载。
        /// 当前接口限制最多合同（流程）50个.
        /// </summary>
        /// <param name="req"><see cref="GetDownloadFlowUrlRequest"/></param>
        /// <returns><see cref="GetDownloadFlowUrlResponse"/></returns>
        public async Task<GetDownloadFlowUrlResponse> GetDownloadFlowUrl(GetDownloadFlowUrlRequest req)
        {
             JsonResponseModel<GetDownloadFlowUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetDownloadFlowUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDownloadFlowUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（GetDownloadFlowUrl）用于创建电子签批量下载地址，让合作企业进入控制台直接下载，支持客户合同（流程）按照自定义文件夹形式 分类下载。
        /// 当前接口限制最多合同（流程）50个.
        /// </summary>
        /// <param name="req"><see cref="GetDownloadFlowUrlRequest"/></param>
        /// <returns><see cref="GetDownloadFlowUrlResponse"/></returns>
        public GetDownloadFlowUrlResponse GetDownloadFlowUrlSync(GetDownloadFlowUrlRequest req)
        {
             JsonResponseModel<GetDownloadFlowUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetDownloadFlowUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetDownloadFlowUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（OperateChannelTemplate）用于针对渠道模板库中的模板对子客企业可见性的查询和设置，不会直接分配渠道模板给子客企业。
        /// 1、OperateType=select时：
        /// 查询渠道模板库
        /// 2、OperateType=update或者delete时：
        /// 对子客企业进行模板库中模板可见性的修改、删除操作。
        /// </summary>
        /// <param name="req"><see cref="OperateChannelTemplateRequest"/></param>
        /// <returns><see cref="OperateChannelTemplateResponse"/></returns>
        public async Task<OperateChannelTemplateResponse> OperateChannelTemplate(OperateChannelTemplateRequest req)
        {
             JsonResponseModel<OperateChannelTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "OperateChannelTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OperateChannelTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（OperateChannelTemplate）用于针对渠道模板库中的模板对子客企业可见性的查询和设置，不会直接分配渠道模板给子客企业。
        /// 1、OperateType=select时：
        /// 查询渠道模板库
        /// 2、OperateType=update或者delete时：
        /// 对子客企业进行模板库中模板可见性的修改、删除操作。
        /// </summary>
        /// <param name="req"><see cref="OperateChannelTemplateRequest"/></param>
        /// <returns><see cref="OperateChannelTemplateResponse"/></returns>
        public OperateChannelTemplateResponse OperateChannelTemplateSync(OperateChannelTemplateRequest req)
        {
             JsonResponseModel<OperateChannelTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "OperateChannelTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<OperateChannelTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口 (PrepareFlows) 用于创建待发起文件
        /// 用户通过该接口进入签署流程发起的确认页面，进行发起信息二次确认， 如果确认则进行正常发起。
        /// 目前该接口只支持B2C，不建议使用，将会废弃。
        /// </summary>
        /// <param name="req"><see cref="PrepareFlowsRequest"/></param>
        /// <returns><see cref="PrepareFlowsResponse"/></returns>
        public async Task<PrepareFlowsResponse> PrepareFlows(PrepareFlowsRequest req)
        {
             JsonResponseModel<PrepareFlowsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PrepareFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PrepareFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口 (PrepareFlows) 用于创建待发起文件
        /// 用户通过该接口进入签署流程发起的确认页面，进行发起信息二次确认， 如果确认则进行正常发起。
        /// 目前该接口只支持B2C，不建议使用，将会废弃。
        /// </summary>
        /// <param name="req"><see cref="PrepareFlowsRequest"/></param>
        /// <returns><see cref="PrepareFlowsResponse"/></returns>
        public PrepareFlowsResponse PrepareFlowsSync(PrepareFlowsRequest req)
        {
             JsonResponseModel<PrepareFlowsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PrepareFlows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PrepareFlowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SyncProxyOrganization）用于同步渠道子客企业信息，主要是子客企业的营业执照，便于子客企业开通过程中不用手动上传。若有需要调用此接口，需要在创建控制链接CreateConsoleLoginUrl之后即刻进行调用。
        /// </summary>
        /// <param name="req"><see cref="SyncProxyOrganizationRequest"/></param>
        /// <returns><see cref="SyncProxyOrganizationResponse"/></returns>
        public async Task<SyncProxyOrganizationResponse> SyncProxyOrganization(SyncProxyOrganizationRequest req)
        {
             JsonResponseModel<SyncProxyOrganizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncProxyOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncProxyOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SyncProxyOrganization）用于同步渠道子客企业信息，主要是子客企业的营业执照，便于子客企业开通过程中不用手动上传。若有需要调用此接口，需要在创建控制链接CreateConsoleLoginUrl之后即刻进行调用。
        /// </summary>
        /// <param name="req"><see cref="SyncProxyOrganizationRequest"/></param>
        /// <returns><see cref="SyncProxyOrganizationResponse"/></returns>
        public SyncProxyOrganizationResponse SyncProxyOrganizationSync(SyncProxyOrganizationRequest req)
        {
             JsonResponseModel<SyncProxyOrganizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncProxyOrganization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncProxyOrganizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SyncProxyOrganizationOperators）用于同步渠道子客企业经办人列表，主要是同步经办人的离职状态。子客Web控制台的组织架构管理，是依赖于渠道平台的，无法针对员工做新增/更新/离职等操作。
        /// 若经办人信息有误，或者需要修改，也可以先将之前的经办人做离职操作，然后重新使用控制台链接CreateConsoleLoginUrl让经办人重新实名。
        /// </summary>
        /// <param name="req"><see cref="SyncProxyOrganizationOperatorsRequest"/></param>
        /// <returns><see cref="SyncProxyOrganizationOperatorsResponse"/></returns>
        public async Task<SyncProxyOrganizationOperatorsResponse> SyncProxyOrganizationOperators(SyncProxyOrganizationOperatorsRequest req)
        {
             JsonResponseModel<SyncProxyOrganizationOperatorsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SyncProxyOrganizationOperators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncProxyOrganizationOperatorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（SyncProxyOrganizationOperators）用于同步渠道子客企业经办人列表，主要是同步经办人的离职状态。子客Web控制台的组织架构管理，是依赖于渠道平台的，无法针对员工做新增/更新/离职等操作。
        /// 若经办人信息有误，或者需要修改，也可以先将之前的经办人做离职操作，然后重新使用控制台链接CreateConsoleLoginUrl让经办人重新实名。
        /// </summary>
        /// <param name="req"><see cref="SyncProxyOrganizationOperatorsRequest"/></param>
        /// <returns><see cref="SyncProxyOrganizationOperatorsResponse"/></returns>
        public SyncProxyOrganizationOperatorsResponse SyncProxyOrganizationOperatorsSync(SyncProxyOrganizationOperatorsRequest req)
        {
             JsonResponseModel<SyncProxyOrganizationOperatorsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SyncProxyOrganizationOperators");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SyncProxyOrganizationOperatorsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（UploadFiles）用于文件上传。
        /// 调用时需要设置Domain, 正式环境为 file.ess.tencent.cn。
        /// 代码示例：
        /// HttpProfile httpProfile = new HttpProfile();
        /// httpProfile.setEndpoint("file.test.ess.tencent.cn");
        /// </summary>
        /// <param name="req"><see cref="UploadFilesRequest"/></param>
        /// <returns><see cref="UploadFilesResponse"/></returns>
        public async Task<UploadFilesResponse> UploadFiles(UploadFilesRequest req)
        {
             JsonResponseModel<UploadFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UploadFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（UploadFiles）用于文件上传。
        /// 调用时需要设置Domain, 正式环境为 file.ess.tencent.cn。
        /// 代码示例：
        /// HttpProfile httpProfile = new HttpProfile();
        /// httpProfile.setEndpoint("file.test.ess.tencent.cn");
        /// </summary>
        /// <param name="req"><see cref="UploadFilesRequest"/></param>
        /// <returns><see cref="UploadFilesResponse"/></returns>
        public UploadFilesResponse UploadFilesSync(UploadFilesRequest req)
        {
             JsonResponseModel<UploadFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UploadFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UploadFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
