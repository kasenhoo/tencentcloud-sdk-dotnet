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

namespace TencentCloud.Mps.V20190612
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Mps.V20190612.Models;

   public class MpsClient : AbstractClient{

       private const string endpoint = "mps.tencentcloudapi.com";
       private const string version = "2019-06-12";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MpsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MpsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建用户自定义内容分析模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public async Task<CreateAIAnalysisTemplateResponse> CreateAIAnalysisTemplate(CreateAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<CreateAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义内容分析模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="CreateAIAnalysisTemplateResponse"/></returns>
        public CreateAIAnalysisTemplateResponse CreateAIAnalysisTemplateSync(CreateAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<CreateAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义内容识别模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="CreateAIRecognitionTemplateResponse"/></returns>
        public async Task<CreateAIRecognitionTemplateResponse> CreateAIRecognitionTemplate(CreateAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<CreateAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义内容识别模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="CreateAIRecognitionTemplateResponse"/></returns>
        public CreateAIRecognitionTemplateResponse CreateAIRecognitionTemplateSync(CreateAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<CreateAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建转自适应码流模板，数量上限：100。
        /// </summary>
        /// <param name="req"><see cref="CreateAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="CreateAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public async Task<CreateAdaptiveDynamicStreamingTemplateResponse> CreateAdaptiveDynamicStreamingTemplate(CreateAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<CreateAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建转自适应码流模板，数量上限：100。
        /// </summary>
        /// <param name="req"><see cref="CreateAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="CreateAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public CreateAdaptiveDynamicStreamingTemplateResponse CreateAdaptiveDynamicStreamingTemplateSync(CreateAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<CreateAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义转动图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="CreateAnimatedGraphicsTemplateResponse"/></returns>
        public async Task<CreateAnimatedGraphicsTemplateResponse> CreateAnimatedGraphicsTemplate(CreateAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<CreateAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义转动图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="CreateAnimatedGraphicsTemplateResponse"/></returns>
        public CreateAnimatedGraphicsTemplateResponse CreateAnimatedGraphicsTemplateSync(CreateAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<CreateAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义内容审核模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public async Task<CreateContentReviewTemplateResponse> CreateContentReviewTemplate(CreateContentReviewTemplateRequest req)
        {
             JsonResponseModel<CreateContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义内容审核模板，数量上限：50。
        /// </summary>
        /// <param name="req"><see cref="CreateContentReviewTemplateRequest"/></param>
        /// <returns><see cref="CreateContentReviewTemplateResponse"/></returns>
        public CreateContentReviewTemplateResponse CreateContentReviewTemplateSync(CreateContentReviewTemplateRequest req)
        {
             JsonResponseModel<CreateContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义雪碧图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="CreateImageSpriteTemplateResponse"/></returns>
        public async Task<CreateImageSpriteTemplateResponse> CreateImageSpriteTemplate(CreateImageSpriteTemplateRequest req)
        {
             JsonResponseModel<CreateImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义雪碧图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="CreateImageSpriteTemplateResponse"/></returns>
        public CreateImageSpriteTemplateResponse CreateImageSpriteTemplateSync(CreateImageSpriteTemplateRequest req)
        {
             JsonResponseModel<CreateImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于创建素材样本，用于通过五官定位等技术，进行内容识别、内容不适宜等视频处理。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public async Task<CreatePersonSampleResponse> CreatePersonSample(CreatePersonSampleRequest req)
        {
             JsonResponseModel<CreatePersonSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于创建素材样本，用于通过五官定位等技术，进行内容识别、内容不适宜等视频处理。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonSampleRequest"/></param>
        /// <returns><see cref="CreatePersonSampleResponse"/></returns>
        public CreatePersonSampleResponse CreatePersonSampleSync(CreatePersonSampleRequest req)
        {
             JsonResponseModel<CreatePersonSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义采样截图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateSampleSnapshotTemplateResponse"/></returns>
        public async Task<CreateSampleSnapshotTemplateResponse> CreateSampleSnapshotTemplate(CreateSampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<CreateSampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义采样截图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="CreateSampleSnapshotTemplateResponse"/></returns>
        public CreateSampleSnapshotTemplateResponse CreateSampleSnapshotTemplateSync(CreateSampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<CreateSampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义指定时间点截图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="CreateSnapshotByTimeOffsetTemplateResponse"/></returns>
        public async Task<CreateSnapshotByTimeOffsetTemplateResponse> CreateSnapshotByTimeOffsetTemplate(CreateSnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<CreateSnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义指定时间点截图模板，数量上限：16。
        /// </summary>
        /// <param name="req"><see cref="CreateSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="CreateSnapshotByTimeOffsetTemplateResponse"/></returns>
        public CreateSnapshotByTimeOffsetTemplateResponse CreateSnapshotByTimeOffsetTemplateSync(CreateSnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<CreateSnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义转码模板，数量上限：1000。
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public async Task<CreateTranscodeTemplateResponse> CreateTranscodeTemplate(CreateTranscodeTemplateRequest req)
        {
             JsonResponseModel<CreateTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义转码模板，数量上限：1000。
        /// </summary>
        /// <param name="req"><see cref="CreateTranscodeTemplateRequest"/></param>
        /// <returns><see cref="CreateTranscodeTemplateResponse"/></returns>
        public CreateTranscodeTemplateResponse CreateTranscodeTemplateSync(CreateTranscodeTemplateRequest req)
        {
             JsonResponseModel<CreateTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义水印模板，数量上限：1000。
        /// </summary>
        /// <param name="req"><see cref="CreateWatermarkTemplateRequest"/></param>
        /// <returns><see cref="CreateWatermarkTemplateResponse"/></returns>
        public async Task<CreateWatermarkTemplateResponse> CreateWatermarkTemplate(CreateWatermarkTemplateRequest req)
        {
             JsonResponseModel<CreateWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建用户自定义水印模板，数量上限：1000。
        /// </summary>
        /// <param name="req"><see cref="CreateWatermarkTemplateRequest"/></param>
        /// <returns><see cref="CreateWatermarkTemplateResponse"/></returns>
        public CreateWatermarkTemplateResponse CreateWatermarkTemplateSync(CreateWatermarkTemplateRequest req)
        {
             JsonResponseModel<CreateWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于批量创建关键词样本，样本用于通过OCR、ASR技术，进行不适宜内容识别、内容识别等视频处理。
        /// </summary>
        /// <param name="req"><see cref="CreateWordSamplesRequest"/></param>
        /// <returns><see cref="CreateWordSamplesResponse"/></returns>
        public async Task<CreateWordSamplesResponse> CreateWordSamples(CreateWordSamplesRequest req)
        {
             JsonResponseModel<CreateWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于批量创建关键词样本，样本用于通过OCR、ASR技术，进行不适宜内容识别、内容识别等视频处理。
        /// </summary>
        /// <param name="req"><see cref="CreateWordSamplesRequest"/></param>
        /// <returns><see cref="CreateWordSamplesResponse"/></returns>
        public CreateWordSamplesResponse CreateWordSamplesSync(CreateWordSamplesRequest req)
        {
             JsonResponseModel<CreateWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对 COS 中指定 Bucket 的目录下上传的媒体文件，设置处理规则，包括：
        /// 1. 视频转码（带水印）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截图雪碧图；
        /// 6. 对视频转自适应码流；
        /// 7. 智能内容审核（鉴黄、敏感信息检测）；
        /// 8. 智能内容分析（标签、分类、封面、按帧标签）；
        /// 9. 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词）。
        /// 
        /// 注意：创建工作流成功后是禁用状态，需要手动启用。
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public async Task<CreateWorkflowResponse> CreateWorkflow(CreateWorkflowRequest req)
        {
             JsonResponseModel<CreateWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对 COS 中指定 Bucket 的目录下上传的媒体文件，设置处理规则，包括：
        /// 1. 视频转码（带水印）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截图雪碧图；
        /// 6. 对视频转自适应码流；
        /// 7. 智能内容审核（鉴黄、敏感信息检测）；
        /// 8. 智能内容分析（标签、分类、封面、按帧标签）；
        /// 9. 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词）。
        /// 
        /// 注意：创建工作流成功后是禁用状态，需要手动启用。
        /// </summary>
        /// <param name="req"><see cref="CreateWorkflowRequest"/></param>
        /// <returns><see cref="CreateWorkflowResponse"/></returns>
        public CreateWorkflowResponse CreateWorkflowSync(CreateWorkflowRequest req)
        {
             JsonResponseModel<CreateWorkflowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义内容分析模板。
        /// 
        /// 注意：模板 ID 为 10000 以下的为系统预置模板，不允许删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIAnalysisTemplateResponse"/></returns>
        public async Task<DeleteAIAnalysisTemplateResponse> DeleteAIAnalysisTemplate(DeleteAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<DeleteAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义内容分析模板。
        /// 
        /// 注意：模板 ID 为 10000 以下的为系统预置模板，不允许删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIAnalysisTemplateResponse"/></returns>
        public DeleteAIAnalysisTemplateResponse DeleteAIAnalysisTemplateSync(DeleteAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<DeleteAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义内容识别模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIRecognitionTemplateResponse"/></returns>
        public async Task<DeleteAIRecognitionTemplateResponse> DeleteAIRecognitionTemplate(DeleteAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<DeleteAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义内容识别模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="DeleteAIRecognitionTemplateResponse"/></returns>
        public DeleteAIRecognitionTemplateResponse DeleteAIRecognitionTemplateSync(DeleteAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<DeleteAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除转自适应码流模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="DeleteAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public async Task<DeleteAdaptiveDynamicStreamingTemplateResponse> DeleteAdaptiveDynamicStreamingTemplate(DeleteAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<DeleteAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除转自适应码流模板
        /// </summary>
        /// <param name="req"><see cref="DeleteAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="DeleteAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public DeleteAdaptiveDynamicStreamingTemplateResponse DeleteAdaptiveDynamicStreamingTemplateSync(DeleteAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<DeleteAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义转动图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="DeleteAnimatedGraphicsTemplateResponse"/></returns>
        public async Task<DeleteAnimatedGraphicsTemplateResponse> DeleteAnimatedGraphicsTemplate(DeleteAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<DeleteAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义转动图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="DeleteAnimatedGraphicsTemplateResponse"/></returns>
        public DeleteAnimatedGraphicsTemplateResponse DeleteAnimatedGraphicsTemplateSync(DeleteAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<DeleteAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义内容审核模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public async Task<DeleteContentReviewTemplateResponse> DeleteContentReviewTemplate(DeleteContentReviewTemplateRequest req)
        {
             JsonResponseModel<DeleteContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义内容审核模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteContentReviewTemplateRequest"/></param>
        /// <returns><see cref="DeleteContentReviewTemplateResponse"/></returns>
        public DeleteContentReviewTemplateResponse DeleteContentReviewTemplateSync(DeleteContentReviewTemplateRequest req)
        {
             JsonResponseModel<DeleteContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除雪碧图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageSpriteTemplateResponse"/></returns>
        public async Task<DeleteImageSpriteTemplateResponse> DeleteImageSpriteTemplate(DeleteImageSpriteTemplateRequest req)
        {
             JsonResponseModel<DeleteImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除雪碧图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="DeleteImageSpriteTemplateResponse"/></returns>
        public DeleteImageSpriteTemplateResponse DeleteImageSpriteTemplateSync(DeleteImageSpriteTemplateRequest req)
        {
             JsonResponseModel<DeleteImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于根据素材 ID，删除素材样本。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public async Task<DeletePersonSampleResponse> DeletePersonSample(DeletePersonSampleRequest req)
        {
             JsonResponseModel<DeletePersonSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于根据素材 ID，删除素材样本。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonSampleRequest"/></param>
        /// <returns><see cref="DeletePersonSampleResponse"/></returns>
        public DeletePersonSampleResponse DeletePersonSampleSync(DeletePersonSampleRequest req)
        {
             JsonResponseModel<DeletePersonSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义采样截图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteSampleSnapshotTemplateResponse"/></returns>
        public async Task<DeleteSampleSnapshotTemplateResponse> DeleteSampleSnapshotTemplate(DeleteSampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<DeleteSampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义采样截图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteSampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="DeleteSampleSnapshotTemplateResponse"/></returns>
        public DeleteSampleSnapshotTemplateResponse DeleteSampleSnapshotTemplateSync(DeleteSampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<DeleteSampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="DeleteSnapshotByTimeOffsetTemplateResponse"/></returns>
        public async Task<DeleteSnapshotByTimeOffsetTemplateResponse> DeleteSnapshotByTimeOffsetTemplate(DeleteSnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<DeleteSnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteSnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="DeleteSnapshotByTimeOffsetTemplateResponse"/></returns>
        public DeleteSnapshotByTimeOffsetTemplateResponse DeleteSnapshotByTimeOffsetTemplateSync(DeleteSnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<DeleteSnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义转码模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteTranscodeTemplateResponse"/></returns>
        public async Task<DeleteTranscodeTemplateResponse> DeleteTranscodeTemplate(DeleteTranscodeTemplateRequest req)
        {
             JsonResponseModel<DeleteTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义转码模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteTranscodeTemplateRequest"/></param>
        /// <returns><see cref="DeleteTranscodeTemplateResponse"/></returns>
        public DeleteTranscodeTemplateResponse DeleteTranscodeTemplateSync(DeleteTranscodeTemplateRequest req)
        {
             JsonResponseModel<DeleteTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义水印模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteWatermarkTemplateRequest"/></param>
        /// <returns><see cref="DeleteWatermarkTemplateResponse"/></returns>
        public async Task<DeleteWatermarkTemplateResponse> DeleteWatermarkTemplate(DeleteWatermarkTemplateRequest req)
        {
             JsonResponseModel<DeleteWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户自定义水印模板。
        /// </summary>
        /// <param name="req"><see cref="DeleteWatermarkTemplateRequest"/></param>
        /// <returns><see cref="DeleteWatermarkTemplateResponse"/></returns>
        public DeleteWatermarkTemplateResponse DeleteWatermarkTemplateSync(DeleteWatermarkTemplateRequest req)
        {
             JsonResponseModel<DeleteWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于批量删除关键词样本。
        /// </summary>
        /// <param name="req"><see cref="DeleteWordSamplesRequest"/></param>
        /// <returns><see cref="DeleteWordSamplesResponse"/></returns>
        public async Task<DeleteWordSamplesResponse> DeleteWordSamples(DeleteWordSamplesRequest req)
        {
             JsonResponseModel<DeleteWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于批量删除关键词样本。
        /// </summary>
        /// <param name="req"><see cref="DeleteWordSamplesRequest"/></param>
        /// <returns><see cref="DeleteWordSamplesResponse"/></returns>
        public DeleteWordSamplesResponse DeleteWordSamplesSync(DeleteWordSamplesRequest req)
        {
             JsonResponseModel<DeleteWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除工作流。对于已启用的工作流，需要禁用后才能删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowRequest"/></param>
        /// <returns><see cref="DeleteWorkflowResponse"/></returns>
        public async Task<DeleteWorkflowResponse> DeleteWorkflow(DeleteWorkflowRequest req)
        {
             JsonResponseModel<DeleteWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除工作流。对于已启用的工作流，需要禁用后才能删除。
        /// </summary>
        /// <param name="req"><see cref="DeleteWorkflowRequest"/></param>
        /// <returns><see cref="DeleteWorkflowResponse"/></returns>
        public DeleteWorkflowResponse DeleteWorkflowSync(DeleteWorkflowRequest req)
        {
             JsonResponseModel<DeleteWorkflowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据内容分析模板唯一标识，获取内容分析模板详情列表。返回结果包含符合条件的所有用户自定义内容分析模板及系统预置视频内容分析模板
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public async Task<DescribeAIAnalysisTemplatesResponse> DescribeAIAnalysisTemplates(DescribeAIAnalysisTemplatesRequest req)
        {
             JsonResponseModel<DescribeAIAnalysisTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAIAnalysisTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAIAnalysisTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据内容分析模板唯一标识，获取内容分析模板详情列表。返回结果包含符合条件的所有用户自定义内容分析模板及系统预置视频内容分析模板
        /// </summary>
        /// <param name="req"><see cref="DescribeAIAnalysisTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIAnalysisTemplatesResponse"/></returns>
        public DescribeAIAnalysisTemplatesResponse DescribeAIAnalysisTemplatesSync(DescribeAIAnalysisTemplatesRequest req)
        {
             JsonResponseModel<DescribeAIAnalysisTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAIAnalysisTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAIAnalysisTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据内容识别模板唯一标识，获取内容识别模板详情列表。返回结果包含符合条件的所有用户自定义内容识别模板及系统预置视频内容识别模板
        /// </summary>
        /// <param name="req"><see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIRecognitionTemplatesResponse"/></returns>
        public async Task<DescribeAIRecognitionTemplatesResponse> DescribeAIRecognitionTemplates(DescribeAIRecognitionTemplatesRequest req)
        {
             JsonResponseModel<DescribeAIRecognitionTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAIRecognitionTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAIRecognitionTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据内容识别模板唯一标识，获取内容识别模板详情列表。返回结果包含符合条件的所有用户自定义内容识别模板及系统预置视频内容识别模板
        /// </summary>
        /// <param name="req"><see cref="DescribeAIRecognitionTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAIRecognitionTemplatesResponse"/></returns>
        public DescribeAIRecognitionTemplatesResponse DescribeAIRecognitionTemplatesSync(DescribeAIRecognitionTemplatesRequest req)
        {
             JsonResponseModel<DescribeAIRecognitionTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAIRecognitionTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAIRecognitionTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询转自适应码流模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeAdaptiveDynamicStreamingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAdaptiveDynamicStreamingTemplatesResponse"/></returns>
        public async Task<DescribeAdaptiveDynamicStreamingTemplatesResponse> DescribeAdaptiveDynamicStreamingTemplates(DescribeAdaptiveDynamicStreamingTemplatesRequest req)
        {
             JsonResponseModel<DescribeAdaptiveDynamicStreamingTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAdaptiveDynamicStreamingTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAdaptiveDynamicStreamingTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询转自适应码流模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeAdaptiveDynamicStreamingTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAdaptiveDynamicStreamingTemplatesResponse"/></returns>
        public DescribeAdaptiveDynamicStreamingTemplatesResponse DescribeAdaptiveDynamicStreamingTemplatesSync(DescribeAdaptiveDynamicStreamingTemplatesRequest req)
        {
             JsonResponseModel<DescribeAdaptiveDynamicStreamingTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAdaptiveDynamicStreamingTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAdaptiveDynamicStreamingTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询转动图模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeAnimatedGraphicsTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAnimatedGraphicsTemplatesResponse"/></returns>
        public async Task<DescribeAnimatedGraphicsTemplatesResponse> DescribeAnimatedGraphicsTemplates(DescribeAnimatedGraphicsTemplatesRequest req)
        {
             JsonResponseModel<DescribeAnimatedGraphicsTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAnimatedGraphicsTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAnimatedGraphicsTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询转动图模板列表，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeAnimatedGraphicsTemplatesRequest"/></param>
        /// <returns><see cref="DescribeAnimatedGraphicsTemplatesResponse"/></returns>
        public DescribeAnimatedGraphicsTemplatesResponse DescribeAnimatedGraphicsTemplatesSync(DescribeAnimatedGraphicsTemplatesRequest req)
        {
             JsonResponseModel<DescribeAnimatedGraphicsTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAnimatedGraphicsTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAnimatedGraphicsTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据智能审核模板唯一标识，获取智能审核模板详情列表。返回结果包含符合条件的所有用户自定义模板及系统预置智能审核模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public async Task<DescribeContentReviewTemplatesResponse> DescribeContentReviewTemplates(DescribeContentReviewTemplatesRequest req)
        {
             JsonResponseModel<DescribeContentReviewTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeContentReviewTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContentReviewTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据智能审核模板唯一标识，获取智能审核模板详情列表。返回结果包含符合条件的所有用户自定义模板及系统预置智能审核模板。
        /// </summary>
        /// <param name="req"><see cref="DescribeContentReviewTemplatesRequest"/></param>
        /// <returns><see cref="DescribeContentReviewTemplatesResponse"/></returns>
        public DescribeContentReviewTemplatesResponse DescribeContentReviewTemplatesSync(DescribeContentReviewTemplatesRequest req)
        {
             JsonResponseModel<DescribeContentReviewTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeContentReviewTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeContentReviewTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询雪碧图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSpriteTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageSpriteTemplatesResponse"/></returns>
        public async Task<DescribeImageSpriteTemplatesResponse> DescribeImageSpriteTemplates(DescribeImageSpriteTemplatesRequest req)
        {
             JsonResponseModel<DescribeImageSpriteTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeImageSpriteTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageSpriteTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询雪碧图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeImageSpriteTemplatesRequest"/></param>
        /// <returns><see cref="DescribeImageSpriteTemplatesResponse"/></returns>
        public DescribeImageSpriteTemplatesResponse DescribeImageSpriteTemplatesSync(DescribeImageSpriteTemplatesRequest req)
        {
             JsonResponseModel<DescribeImageSpriteTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeImageSpriteTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeImageSpriteTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取媒体的元信息，包括视频画面宽、高、编码格式、时长、帧率等。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaMetaDataRequest"/></param>
        /// <returns><see cref="DescribeMediaMetaDataResponse"/></returns>
        public async Task<DescribeMediaMetaDataResponse> DescribeMediaMetaData(DescribeMediaMetaDataRequest req)
        {
             JsonResponseModel<DescribeMediaMetaDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMediaMetaData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaMetaDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取媒体的元信息，包括视频画面宽、高、编码格式、时长、帧率等。
        /// </summary>
        /// <param name="req"><see cref="DescribeMediaMetaDataRequest"/></param>
        /// <returns><see cref="DescribeMediaMetaDataResponse"/></returns>
        public DescribeMediaMetaDataResponse DescribeMediaMetaDataSync(DescribeMediaMetaDataRequest req)
        {
             JsonResponseModel<DescribeMediaMetaDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMediaMetaData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMediaMetaDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询素材样本信息，支持根据素材 ID、名称、标签，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePersonSamplesRequest"/></param>
        /// <returns><see cref="DescribePersonSamplesResponse"/></returns>
        public async Task<DescribePersonSamplesResponse> DescribePersonSamples(DescribePersonSamplesRequest req)
        {
             JsonResponseModel<DescribePersonSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePersonSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于查询素材样本信息，支持根据素材 ID、名称、标签，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribePersonSamplesRequest"/></param>
        /// <returns><see cref="DescribePersonSamplesResponse"/></returns>
        public DescribePersonSamplesResponse DescribePersonSamplesSync(DescribePersonSamplesRequest req)
        {
             JsonResponseModel<DescribePersonSamplesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePersonSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePersonSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询采样截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSampleSnapshotTemplatesResponse"/></returns>
        public async Task<DescribeSampleSnapshotTemplatesResponse> DescribeSampleSnapshotTemplates(DescribeSampleSnapshotTemplatesRequest req)
        {
             JsonResponseModel<DescribeSampleSnapshotTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSampleSnapshotTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleSnapshotTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询采样截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSampleSnapshotTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSampleSnapshotTemplatesResponse"/></returns>
        public DescribeSampleSnapshotTemplatesResponse DescribeSampleSnapshotTemplatesSync(DescribeSampleSnapshotTemplatesRequest req)
        {
             JsonResponseModel<DescribeSampleSnapshotTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSampleSnapshotTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSampleSnapshotTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间点截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotByTimeOffsetTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotByTimeOffsetTemplatesResponse"/></returns>
        public async Task<DescribeSnapshotByTimeOffsetTemplatesResponse> DescribeSnapshotByTimeOffsetTemplates(DescribeSnapshotByTimeOffsetTemplatesRequest req)
        {
             JsonResponseModel<DescribeSnapshotByTimeOffsetTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSnapshotByTimeOffsetTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotByTimeOffsetTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定时间点截图模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeSnapshotByTimeOffsetTemplatesRequest"/></param>
        /// <returns><see cref="DescribeSnapshotByTimeOffsetTemplatesResponse"/></returns>
        public DescribeSnapshotByTimeOffsetTemplatesResponse DescribeSnapshotByTimeOffsetTemplatesSync(DescribeSnapshotByTimeOffsetTemplatesRequest req)
        {
             JsonResponseModel<DescribeSnapshotByTimeOffsetTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSnapshotByTimeOffsetTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSnapshotByTimeOffsetTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过任务 ID 查询任务的执行状态和结果的详细信息（最多可以查询3天之内提交的任务）。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public async Task<DescribeTaskDetailResponse> DescribeTaskDetail(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过任务 ID 查询任务的执行状态和结果的详细信息（最多可以查询3天之内提交的任务）。
        /// </summary>
        /// <param name="req"><see cref="DescribeTaskDetailRequest"/></param>
        /// <returns><see cref="DescribeTaskDetailResponse"/></returns>
        public DescribeTaskDetailResponse DescribeTaskDetailSync(DescribeTaskDetailRequest req)
        {
             JsonResponseModel<DescribeTaskDetailResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTaskDetail");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTaskDetailResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 该接口用于查询任务列表；
        /// * 当列表数据比较多时，单次接口调用无法拉取整个列表，可通过 ScrollToken 参数，分批拉取；
        /// * 只能查询到最近七天（168小时）内的任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public async Task<DescribeTasksResponse> DescribeTasks(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// * 该接口用于查询任务列表；
        /// * 当列表数据比较多时，单次接口调用无法拉取整个列表，可通过 ScrollToken 参数，分批拉取；
        /// * 只能查询到最近七天（168小时）内的任务。
        /// </summary>
        /// <param name="req"><see cref="DescribeTasksRequest"/></param>
        /// <returns><see cref="DescribeTasksResponse"/></returns>
        public DescribeTasksResponse DescribeTasksSync(DescribeTasksRequest req)
        {
             JsonResponseModel<DescribeTasksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTasks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTasksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据转码模板唯一标识，获取转码模板详情列表。返回结果包含符合条件的所有用户自定义模板及[系统预置转码模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTemplatesResponse"/></returns>
        public async Task<DescribeTranscodeTemplatesResponse> DescribeTranscodeTemplates(DescribeTranscodeTemplatesRequest req)
        {
             JsonResponseModel<DescribeTranscodeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeTranscodeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据转码模板唯一标识，获取转码模板详情列表。返回结果包含符合条件的所有用户自定义模板及[系统预置转码模板](https://cloud.tencent.com/document/product/266/33476#.E9.A2.84.E7.BD.AE.E8.BD.AC.E7.A0.81.E6.A8.A1.E6.9D.BF)。
        /// </summary>
        /// <param name="req"><see cref="DescribeTranscodeTemplatesRequest"/></param>
        /// <returns><see cref="DescribeTranscodeTemplatesResponse"/></returns>
        public DescribeTranscodeTemplatesResponse DescribeTranscodeTemplatesSync(DescribeTranscodeTemplatesRequest req)
        {
             JsonResponseModel<DescribeTranscodeTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeTranscodeTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeTranscodeTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户自定义水印模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeWatermarkTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWatermarkTemplatesResponse"/></returns>
        public async Task<DescribeWatermarkTemplatesResponse> DescribeWatermarkTemplates(DescribeWatermarkTemplatesRequest req)
        {
             JsonResponseModel<DescribeWatermarkTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWatermarkTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWatermarkTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户自定义水印模板，支持根据条件，分页查询。
        /// </summary>
        /// <param name="req"><see cref="DescribeWatermarkTemplatesRequest"/></param>
        /// <returns><see cref="DescribeWatermarkTemplatesResponse"/></returns>
        public DescribeWatermarkTemplatesResponse DescribeWatermarkTemplatesSync(DescribeWatermarkTemplatesRequest req)
        {
             JsonResponseModel<DescribeWatermarkTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWatermarkTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWatermarkTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于根据应用场景、关键词、标签，分页查询关键词样本信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeWordSamplesRequest"/></param>
        /// <returns><see cref="DescribeWordSamplesResponse"/></returns>
        public async Task<DescribeWordSamplesResponse> DescribeWordSamples(DescribeWordSamplesRequest req)
        {
             JsonResponseModel<DescribeWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于根据应用场景、关键词、标签，分页查询关键词样本信息。
        /// </summary>
        /// <param name="req"><see cref="DescribeWordSamplesRequest"/></param>
        /// <returns><see cref="DescribeWordSamplesResponse"/></returns>
        public DescribeWordSamplesResponse DescribeWordSamplesSync(DescribeWordSamplesRequest req)
        {
             JsonResponseModel<DescribeWordSamplesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWordSamples");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWordSamplesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据工作流 ID，获取工作流详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowsResponse"/></returns>
        public async Task<DescribeWorkflowsResponse> DescribeWorkflows(DescribeWorkflowsRequest req)
        {
             JsonResponseModel<DescribeWorkflowsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeWorkflows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkflowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 根据工作流 ID，获取工作流详情列表。
        /// </summary>
        /// <param name="req"><see cref="DescribeWorkflowsRequest"/></param>
        /// <returns><see cref="DescribeWorkflowsResponse"/></returns>
        public DescribeWorkflowsResponse DescribeWorkflowsSync(DescribeWorkflowsRequest req)
        {
             JsonResponseModel<DescribeWorkflowsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeWorkflows");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeWorkflowsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用工作流。
        /// </summary>
        /// <param name="req"><see cref="DisableWorkflowRequest"/></param>
        /// <returns><see cref="DisableWorkflowResponse"/></returns>
        public async Task<DisableWorkflowResponse> DisableWorkflow(DisableWorkflowRequest req)
        {
             JsonResponseModel<DisableWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DisableWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 禁用工作流。
        /// </summary>
        /// <param name="req"><see cref="DisableWorkflowRequest"/></param>
        /// <returns><see cref="DisableWorkflowResponse"/></returns>
        public DisableWorkflowResponse DisableWorkflowSync(DisableWorkflowRequest req)
        {
             JsonResponseModel<DisableWorkflowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DisableWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DisableWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对视频进行编辑（剪辑、拼接等），生成一个新的点播视频。编辑的功能包括：
        /// 
        /// 1. 对一个文件进行剪辑，生成一个新的视频；
        /// 2. 对多个文件进行拼接，生成一个新的视频；
        /// 3. 对多个文件进行剪辑，然后再拼接，生成一个新的视频。
        /// </summary>
        /// <param name="req"><see cref="EditMediaRequest"/></param>
        /// <returns><see cref="EditMediaResponse"/></returns>
        public async Task<EditMediaResponse> EditMedia(EditMediaRequest req)
        {
             JsonResponseModel<EditMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EditMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对视频进行编辑（剪辑、拼接等），生成一个新的点播视频。编辑的功能包括：
        /// 
        /// 1. 对一个文件进行剪辑，生成一个新的视频；
        /// 2. 对多个文件进行拼接，生成一个新的视频；
        /// 3. 对多个文件进行剪辑，然后再拼接，生成一个新的视频。
        /// </summary>
        /// <param name="req"><see cref="EditMediaRequest"/></param>
        /// <returns><see cref="EditMediaResponse"/></returns>
        public EditMediaResponse EditMediaSync(EditMediaRequest req)
        {
             JsonResponseModel<EditMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EditMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EditMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用工作流。
        /// </summary>
        /// <param name="req"><see cref="EnableWorkflowRequest"/></param>
        /// <returns><see cref="EnableWorkflowResponse"/></returns>
        public async Task<EnableWorkflowResponse> EnableWorkflow(EnableWorkflowRequest req)
        {
             JsonResponseModel<EnableWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "EnableWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 启用工作流。
        /// </summary>
        /// <param name="req"><see cref="EnableWorkflowRequest"/></param>
        /// <returns><see cref="EnableWorkflowResponse"/></returns>
        public EnableWorkflowResponse EnableWorkflowSync(EnableWorkflowRequest req)
        {
             JsonResponseModel<EnableWorkflowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "EnableWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<EnableWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口仅用于定制开发的特殊场景，除非云媒体处理客服人员主动告知您需要使用本接口，其它情况请勿调用。
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public async Task<ExecuteFunctionResponse> ExecuteFunction(ExecuteFunctionRequest req)
        {
             JsonResponseModel<ExecuteFunctionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ExecuteFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口仅用于定制开发的特殊场景，除非云媒体处理客服人员主动告知您需要使用本接口，其它情况请勿调用。
        /// </summary>
        /// <param name="req"><see cref="ExecuteFunctionRequest"/></param>
        /// <returns><see cref="ExecuteFunctionResponse"/></returns>
        public ExecuteFunctionResponse ExecuteFunctionSync(ExecuteFunctionRequest req)
        {
             JsonResponseModel<ExecuteFunctionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ExecuteFunction");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ExecuteFunctionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对已发起的任务进行管理。
        /// </summary>
        /// <param name="req"><see cref="ManageTaskRequest"/></param>
        /// <returns><see cref="ManageTaskResponse"/></returns>
        public async Task<ManageTaskResponse> ManageTask(ManageTaskRequest req)
        {
             JsonResponseModel<ManageTaskResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ManageTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对已发起的任务进行管理。
        /// </summary>
        /// <param name="req"><see cref="ManageTaskRequest"/></param>
        /// <returns><see cref="ManageTaskResponse"/></returns>
        public ManageTaskResponse ManageTaskSync(ManageTaskRequest req)
        {
             JsonResponseModel<ManageTaskResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ManageTask");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ManageTaskResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义内容分析模板。
        /// 
        /// 注意：模板 ID 10000 以下的为系统预置模板，不允许修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIAnalysisTemplateResponse"/></returns>
        public async Task<ModifyAIAnalysisTemplateResponse> ModifyAIAnalysisTemplate(ModifyAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<ModifyAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义内容分析模板。
        /// 
        /// 注意：模板 ID 10000 以下的为系统预置模板，不允许修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyAIAnalysisTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIAnalysisTemplateResponse"/></returns>
        public ModifyAIAnalysisTemplateResponse ModifyAIAnalysisTemplateSync(ModifyAIAnalysisTemplateRequest req)
        {
             JsonResponseModel<ModifyAIAnalysisTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAIAnalysisTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAIAnalysisTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义内容识别模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIRecognitionTemplateResponse"/></returns>
        public async Task<ModifyAIRecognitionTemplateResponse> ModifyAIRecognitionTemplate(ModifyAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<ModifyAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义内容识别模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAIRecognitionTemplateRequest"/></param>
        /// <returns><see cref="ModifyAIRecognitionTemplateResponse"/></returns>
        public ModifyAIRecognitionTemplateResponse ModifyAIRecognitionTemplateSync(ModifyAIRecognitionTemplateRequest req)
        {
             JsonResponseModel<ModifyAIRecognitionTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAIRecognitionTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAIRecognitionTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改转自适应码流模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="ModifyAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public async Task<ModifyAdaptiveDynamicStreamingTemplateResponse> ModifyAdaptiveDynamicStreamingTemplate(ModifyAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<ModifyAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改转自适应码流模板
        /// </summary>
        /// <param name="req"><see cref="ModifyAdaptiveDynamicStreamingTemplateRequest"/></param>
        /// <returns><see cref="ModifyAdaptiveDynamicStreamingTemplateResponse"/></returns>
        public ModifyAdaptiveDynamicStreamingTemplateResponse ModifyAdaptiveDynamicStreamingTemplateSync(ModifyAdaptiveDynamicStreamingTemplateRequest req)
        {
             JsonResponseModel<ModifyAdaptiveDynamicStreamingTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAdaptiveDynamicStreamingTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAdaptiveDynamicStreamingTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义转动图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="ModifyAnimatedGraphicsTemplateResponse"/></returns>
        public async Task<ModifyAnimatedGraphicsTemplateResponse> ModifyAnimatedGraphicsTemplate(ModifyAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<ModifyAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义转动图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyAnimatedGraphicsTemplateRequest"/></param>
        /// <returns><see cref="ModifyAnimatedGraphicsTemplateResponse"/></returns>
        public ModifyAnimatedGraphicsTemplateResponse ModifyAnimatedGraphicsTemplateSync(ModifyAnimatedGraphicsTemplateRequest req)
        {
             JsonResponseModel<ModifyAnimatedGraphicsTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAnimatedGraphicsTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAnimatedGraphicsTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义内容审核模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public async Task<ModifyContentReviewTemplateResponse> ModifyContentReviewTemplate(ModifyContentReviewTemplateRequest req)
        {
             JsonResponseModel<ModifyContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义内容审核模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyContentReviewTemplateRequest"/></param>
        /// <returns><see cref="ModifyContentReviewTemplateResponse"/></returns>
        public ModifyContentReviewTemplateResponse ModifyContentReviewTemplateSync(ModifyContentReviewTemplateRequest req)
        {
             JsonResponseModel<ModifyContentReviewTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyContentReviewTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyContentReviewTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义雪碧图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="ModifyImageSpriteTemplateResponse"/></returns>
        public async Task<ModifyImageSpriteTemplateResponse> ModifyImageSpriteTemplate(ModifyImageSpriteTemplateRequest req)
        {
             JsonResponseModel<ModifyImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义雪碧图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifyImageSpriteTemplateRequest"/></param>
        /// <returns><see cref="ModifyImageSpriteTemplateResponse"/></returns>
        public ModifyImageSpriteTemplateResponse ModifyImageSpriteTemplateSync(ModifyImageSpriteTemplateRequest req)
        {
             JsonResponseModel<ModifyImageSpriteTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyImageSpriteTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyImageSpriteTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于根据素材 ID，修改素材样本信息，包括名称、描述的修改，以及五官、标签的添加、删除、重置操作。五官删除操作需保证至少剩余 1 张图片，否则，请使用重置操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonSampleRequest"/></param>
        /// <returns><see cref="ModifyPersonSampleResponse"/></returns>
        public async Task<ModifyPersonSampleResponse> ModifyPersonSample(ModifyPersonSampleRequest req)
        {
             JsonResponseModel<ModifyPersonSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于根据素材 ID，修改素材样本信息，包括名称、描述的修改，以及五官、标签的添加、删除、重置操作。五官删除操作需保证至少剩余 1 张图片，否则，请使用重置操作。
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonSampleRequest"/></param>
        /// <returns><see cref="ModifyPersonSampleResponse"/></returns>
        public ModifyPersonSampleResponse ModifyPersonSampleSync(ModifyPersonSampleRequest req)
        {
             JsonResponseModel<ModifyPersonSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPersonSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义采样截图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifySampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifySampleSnapshotTemplateResponse"/></returns>
        public async Task<ModifySampleSnapshotTemplateResponse> ModifySampleSnapshotTemplate(ModifySampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<ModifySampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义采样截图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifySampleSnapshotTemplateRequest"/></param>
        /// <returns><see cref="ModifySampleSnapshotTemplateResponse"/></returns>
        public ModifySampleSnapshotTemplateResponse ModifySampleSnapshotTemplateSync(ModifySampleSnapshotTemplateRequest req)
        {
             JsonResponseModel<ModifySampleSnapshotTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySampleSnapshotTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySampleSnapshotTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="ModifySnapshotByTimeOffsetTemplateResponse"/></returns>
        public async Task<ModifySnapshotByTimeOffsetTemplateResponse> ModifySnapshotByTimeOffsetTemplate(ModifySnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<ModifySnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义指定时间点截图模板。
        /// </summary>
        /// <param name="req"><see cref="ModifySnapshotByTimeOffsetTemplateRequest"/></param>
        /// <returns><see cref="ModifySnapshotByTimeOffsetTemplateResponse"/></returns>
        public ModifySnapshotByTimeOffsetTemplateResponse ModifySnapshotByTimeOffsetTemplateSync(ModifySnapshotByTimeOffsetTemplateRequest req)
        {
             JsonResponseModel<ModifySnapshotByTimeOffsetTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySnapshotByTimeOffsetTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySnapshotByTimeOffsetTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义转码模板信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyTranscodeTemplateResponse"/></returns>
        public async Task<ModifyTranscodeTemplateResponse> ModifyTranscodeTemplate(ModifyTranscodeTemplateRequest req)
        {
             JsonResponseModel<ModifyTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义转码模板信息。
        /// </summary>
        /// <param name="req"><see cref="ModifyTranscodeTemplateRequest"/></param>
        /// <returns><see cref="ModifyTranscodeTemplateResponse"/></returns>
        public ModifyTranscodeTemplateResponse ModifyTranscodeTemplateSync(ModifyTranscodeTemplateRequest req)
        {
             JsonResponseModel<ModifyTranscodeTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyTranscodeTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyTranscodeTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义水印模板，水印类型不允许修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyWatermarkTemplateRequest"/></param>
        /// <returns><see cref="ModifyWatermarkTemplateResponse"/></returns>
        public async Task<ModifyWatermarkTemplateResponse> ModifyWatermarkTemplate(ModifyWatermarkTemplateRequest req)
        {
             JsonResponseModel<ModifyWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户自定义水印模板，水印类型不允许修改。
        /// </summary>
        /// <param name="req"><see cref="ModifyWatermarkTemplateRequest"/></param>
        /// <returns><see cref="ModifyWatermarkTemplateResponse"/></returns>
        public ModifyWatermarkTemplateResponse ModifyWatermarkTemplateSync(ModifyWatermarkTemplateRequest req)
        {
             JsonResponseModel<ModifyWatermarkTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWatermarkTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWatermarkTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改关键词的应用场景、标签，关键词本身不可修改，如需修改，可删除重建。
        /// </summary>
        /// <param name="req"><see cref="ModifyWordSampleRequest"/></param>
        /// <returns><see cref="ModifyWordSampleResponse"/></returns>
        public async Task<ModifyWordSampleResponse> ModifyWordSample(ModifyWordSampleRequest req)
        {
             JsonResponseModel<ModifyWordSampleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyWordSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWordSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 该接口用于修改关键词的应用场景、标签，关键词本身不可修改，如需修改，可删除重建。
        /// </summary>
        /// <param name="req"><see cref="ModifyWordSampleRequest"/></param>
        /// <returns><see cref="ModifyWordSampleResponse"/></returns>
        public ModifyWordSampleResponse ModifyWordSampleSync(ModifyWordSampleRequest req)
        {
             JsonResponseModel<ModifyWordSampleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyWordSample");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyWordSampleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从 CMQ 获取到消息后，从消息的 msgBody 字段中解析出 MPS 直播流处理事件通知的内容。
        /// 该接口不用于发起网络调用，而是用来帮助生成各个语言平台的 SDK，您可以参考 SDK 的中解析函数的实现事件通知的解析。
        /// </summary>
        /// <param name="req"><see cref="ParseLiveStreamProcessNotificationRequest"/></param>
        /// <returns><see cref="ParseLiveStreamProcessNotificationResponse"/></returns>
        public async Task<ParseLiveStreamProcessNotificationResponse> ParseLiveStreamProcessNotification(ParseLiveStreamProcessNotificationRequest req)
        {
             JsonResponseModel<ParseLiveStreamProcessNotificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ParseLiveStreamProcessNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ParseLiveStreamProcessNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从 CMQ 获取到消息后，从消息的 msgBody 字段中解析出 MPS 直播流处理事件通知的内容。
        /// 该接口不用于发起网络调用，而是用来帮助生成各个语言平台的 SDK，您可以参考 SDK 的中解析函数的实现事件通知的解析。
        /// </summary>
        /// <param name="req"><see cref="ParseLiveStreamProcessNotificationRequest"/></param>
        /// <returns><see cref="ParseLiveStreamProcessNotificationResponse"/></returns>
        public ParseLiveStreamProcessNotificationResponse ParseLiveStreamProcessNotificationSync(ParseLiveStreamProcessNotificationRequest req)
        {
             JsonResponseModel<ParseLiveStreamProcessNotificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ParseLiveStreamProcessNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ParseLiveStreamProcessNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从 CMQ 获取到消息后，从消息的 msgBody 字段中解析出 MPS 事件通知的内容。
        /// 该接口不用于发起网络调用，而是用来帮助生成各个语言平台的 SDK，您可以参考 SDK 的中解析函数的实现事件通知的解析。
        /// </summary>
        /// <param name="req"><see cref="ParseNotificationRequest"/></param>
        /// <returns><see cref="ParseNotificationResponse"/></returns>
        public async Task<ParseNotificationResponse> ParseNotification(ParseNotificationRequest req)
        {
             JsonResponseModel<ParseNotificationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ParseNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ParseNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从 CMQ 获取到消息后，从消息的 msgBody 字段中解析出 MPS 事件通知的内容。
        /// 该接口不用于发起网络调用，而是用来帮助生成各个语言平台的 SDK，您可以参考 SDK 的中解析函数的实现事件通知的解析。
        /// </summary>
        /// <param name="req"><see cref="ParseNotificationRequest"/></param>
        /// <returns><see cref="ParseNotificationResponse"/></returns>
        public ParseNotificationResponse ParseNotificationSync(ParseNotificationRequest req)
        {
             JsonResponseModel<ParseNotificationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ParseNotification");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ParseNotificationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对直播流媒体发起处理任务，功能包括：
        /// 
        /// * 智能内容审核（画面鉴黄、敏感信息检测、声音鉴黄）；
        /// * 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词、语音实时翻译）。
        /// 
        /// 直播流处理事件通知实时写入用户指定的消息队列 CMQ 中，用户需要从消息队列 CMQ 中获取事件通知结果，同时处理过程中存在输出文件的，会写入用户指定的输出文件的目标存储中。
        /// </summary>
        /// <param name="req"><see cref="ProcessLiveStreamRequest"/></param>
        /// <returns><see cref="ProcessLiveStreamResponse"/></returns>
        public async Task<ProcessLiveStreamResponse> ProcessLiveStream(ProcessLiveStreamRequest req)
        {
             JsonResponseModel<ProcessLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ProcessLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对直播流媒体发起处理任务，功能包括：
        /// 
        /// * 智能内容审核（画面鉴黄、敏感信息检测、声音鉴黄）；
        /// * 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词、语音实时翻译）。
        /// 
        /// 直播流处理事件通知实时写入用户指定的消息队列 CMQ 中，用户需要从消息队列 CMQ 中获取事件通知结果，同时处理过程中存在输出文件的，会写入用户指定的输出文件的目标存储中。
        /// </summary>
        /// <param name="req"><see cref="ProcessLiveStreamRequest"/></param>
        /// <returns><see cref="ProcessLiveStreamResponse"/></returns>
        public ProcessLiveStreamResponse ProcessLiveStreamSync(ProcessLiveStreamRequest req)
        {
             JsonResponseModel<ProcessLiveStreamResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ProcessLiveStream");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessLiveStreamResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对 URL视频链接 或 COS 中的媒体文件发起处理任务，功能包括：
        /// 1. 视频转码（普通转码、极速高清转码、音视频增强）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截图雪碧图；
        /// 6. 对视频转自适应码流；
        /// 7. 智能内容审核（鉴黄、敏感信息检测）；
        /// 8. 智能内容分析（标签、分类、封面、按帧标签、拆条、集锦、片头片尾）；
        /// 9. 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词、语音翻译、物体识别）。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaRequest"/></param>
        /// <returns><see cref="ProcessMediaResponse"/></returns>
        public async Task<ProcessMediaResponse> ProcessMedia(ProcessMediaRequest req)
        {
             JsonResponseModel<ProcessMediaResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ProcessMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对 URL视频链接 或 COS 中的媒体文件发起处理任务，功能包括：
        /// 1. 视频转码（普通转码、极速高清转码、音视频增强）；
        /// 2. 视频转动图；
        /// 3. 对视频按指定时间点截图；
        /// 4. 对视频采样截图；
        /// 5. 对视频截图雪碧图；
        /// 6. 对视频转自适应码流；
        /// 7. 智能内容审核（鉴黄、敏感信息检测）；
        /// 8. 智能内容分析（标签、分类、封面、按帧标签、拆条、集锦、片头片尾）；
        /// 9. 智能内容识别（人脸、文本全文、文本关键词、语音全文、语音关键词、语音翻译、物体识别）。
        /// </summary>
        /// <param name="req"><see cref="ProcessMediaRequest"/></param>
        /// <returns><see cref="ProcessMediaResponse"/></returns>
        public ProcessMediaResponse ProcessMediaSync(ProcessMediaRequest req)
        {
             JsonResponseModel<ProcessMediaResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ProcessMedia");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ProcessMediaResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智能媒体识别，包含表情和动作识别。仅用于智学，其他调用无效。
        /// </summary>
        /// <param name="req"><see cref="RecognizeMediaForZhiXueRequest"/></param>
        /// <returns><see cref="RecognizeMediaForZhiXueResponse"/></returns>
        public async Task<RecognizeMediaForZhiXueResponse> RecognizeMediaForZhiXue(RecognizeMediaForZhiXueRequest req)
        {
             JsonResponseModel<RecognizeMediaForZhiXueResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RecognizeMediaForZhiXue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizeMediaForZhiXueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 智能媒体识别，包含表情和动作识别。仅用于智学，其他调用无效。
        /// </summary>
        /// <param name="req"><see cref="RecognizeMediaForZhiXueRequest"/></param>
        /// <returns><see cref="RecognizeMediaForZhiXueResponse"/></returns>
        public RecognizeMediaForZhiXueResponse RecognizeMediaForZhiXueSync(RecognizeMediaForZhiXueRequest req)
        {
             JsonResponseModel<RecognizeMediaForZhiXueResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RecognizeMediaForZhiXue");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RecognizeMediaForZhiXueResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新设置一个已经存在且处于禁用状态的工作流。
        /// </summary>
        /// <param name="req"><see cref="ResetWorkflowRequest"/></param>
        /// <returns><see cref="ResetWorkflowResponse"/></returns>
        public async Task<ResetWorkflowResponse> ResetWorkflow(ResetWorkflowRequest req)
        {
             JsonResponseModel<ResetWorkflowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ResetWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新设置一个已经存在且处于禁用状态的工作流。
        /// </summary>
        /// <param name="req"><see cref="ResetWorkflowRequest"/></param>
        /// <returns><see cref="ResetWorkflowResponse"/></returns>
        public ResetWorkflowResponse ResetWorkflowSync(ResetWorkflowRequest req)
        {
             JsonResponseModel<ResetWorkflowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ResetWorkflow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ResetWorkflowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
