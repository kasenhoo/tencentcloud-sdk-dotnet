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

namespace TencentCloud.Iai.V20200303
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iai.V20200303.Models;

   public class IaiClient : AbstractClient{

       private const string endpoint = "iai.tencentcloudapi.com";
       private const string version = "2020-03-03";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IaiClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IaiClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 对请求图片进行五官定位（也称人脸关键点定位），获得人脸的精准信息，返回多达888点关键信息，对五官和脸部轮廓进行精确定位。
        /// </summary>
        /// <param name="req"><see cref="AnalyzeDenseLandmarksRequest"/></param>
        /// <returns><see cref="AnalyzeDenseLandmarksResponse"/></returns>
        public async Task<AnalyzeDenseLandmarksResponse> AnalyzeDenseLandmarks(AnalyzeDenseLandmarksRequest req)
        {
             JsonResponseModel<AnalyzeDenseLandmarksResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AnalyzeDenseLandmarks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AnalyzeDenseLandmarksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对请求图片进行五官定位（也称人脸关键点定位），获得人脸的精准信息，返回多达888点关键信息，对五官和脸部轮廓进行精确定位。
        /// </summary>
        /// <param name="req"><see cref="AnalyzeDenseLandmarksRequest"/></param>
        /// <returns><see cref="AnalyzeDenseLandmarksResponse"/></returns>
        public AnalyzeDenseLandmarksResponse AnalyzeDenseLandmarksSync(AnalyzeDenseLandmarksRequest req)
        {
             JsonResponseModel<AnalyzeDenseLandmarksResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AnalyzeDenseLandmarks");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AnalyzeDenseLandmarksResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对请求图片进行五官定位（也称人脸关键点定位），计算构成人脸轮廓的 90 个点，包括眉毛（左右各 8 点）、眼睛（左右各 8 点）、鼻子（13 点）、嘴巴（22 点）、脸型轮廓（21 点）、眼珠[或瞳孔]（2点）。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="AnalyzeFaceRequest"/></param>
        /// <returns><see cref="AnalyzeFaceResponse"/></returns>
        public async Task<AnalyzeFaceResponse> AnalyzeFace(AnalyzeFaceRequest req)
        {
             JsonResponseModel<AnalyzeFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AnalyzeFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AnalyzeFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对请求图片进行五官定位（也称人脸关键点定位），计算构成人脸轮廓的 90 个点，包括眉毛（左右各 8 点）、眼睛（左右各 8 点）、鼻子（13 点）、嘴巴（22 点）、脸型轮廓（21 点）、眼珠[或瞳孔]（2点）。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="AnalyzeFaceRequest"/></param>
        /// <returns><see cref="AnalyzeFaceResponse"/></returns>
        public AnalyzeFaceResponse AnalyzeFaceSync(AnalyzeFaceRequest req)
        {
             JsonResponseModel<AnalyzeFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AnalyzeFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AnalyzeFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对两张图片中的人脸进行相似度比对，返回人脸相似度分数。
        /// 
        /// 若您需要判断 “此人是否是某人”，即验证某张图片中的人是否是已知身份的某人，如常见的人脸登录场景，建议使用[人脸验证](https://cloud.tencent.com/document/product/867/44983)或[人员验证](https://cloud.tencent.com/document/product/867/44982)接口。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="CompareFaceRequest"/></param>
        /// <returns><see cref="CompareFaceResponse"/></returns>
        public async Task<CompareFaceResponse> CompareFace(CompareFaceRequest req)
        {
             JsonResponseModel<CompareFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CompareFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompareFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对两张图片中的人脸进行相似度比对，返回人脸相似度分数。
        /// 
        /// 若您需要判断 “此人是否是某人”，即验证某张图片中的人是否是已知身份的某人，如常见的人脸登录场景，建议使用[人脸验证](https://cloud.tencent.com/document/product/867/44983)或[人员验证](https://cloud.tencent.com/document/product/867/44982)接口。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="CompareFaceRequest"/></param>
        /// <returns><see cref="CompareFaceResponse"/></returns>
        public CompareFaceResponse CompareFaceSync(CompareFaceRequest req)
        {
             JsonResponseModel<CompareFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CompareFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompareFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对两张图片中的人脸进行相似度比对，返回人脸相似度分数。
        /// 
        /// 防疫场景人脸比对接口可在人脸戴口罩情况下使用，口罩遮挡程度最高可以遮挡鼻尖。
        /// 
        /// 如图片人脸不存在防疫场景下戴口罩的情况，建议使用人脸比对服务。
        /// </summary>
        /// <param name="req"><see cref="CompareMaskFaceRequest"/></param>
        /// <returns><see cref="CompareMaskFaceResponse"/></returns>
        public async Task<CompareMaskFaceResponse> CompareMaskFace(CompareMaskFaceRequest req)
        {
             JsonResponseModel<CompareMaskFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CompareMaskFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompareMaskFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 对两张图片中的人脸进行相似度比对，返回人脸相似度分数。
        /// 
        /// 防疫场景人脸比对接口可在人脸戴口罩情况下使用，口罩遮挡程度最高可以遮挡鼻尖。
        /// 
        /// 如图片人脸不存在防疫场景下戴口罩的情况，建议使用人脸比对服务。
        /// </summary>
        /// <param name="req"><see cref="CompareMaskFaceRequest"/></param>
        /// <returns><see cref="CompareMaskFaceResponse"/></returns>
        public CompareMaskFaceResponse CompareMaskFaceSync(CompareMaskFaceRequest req)
        {
             JsonResponseModel<CompareMaskFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CompareMaskFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CompareMaskFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将已存在于某人员库的人员复制到其他人员库，该人员的描述信息不会被复制。单个人员最多只能同时存在100个人员库中。
        /// >     
        /// - 注：若该人员创建时算法模型版本为2.0，复制到非2.0算法模型版本的Group中时，复制操作将会失败。
        /// </summary>
        /// <param name="req"><see cref="CopyPersonRequest"/></param>
        /// <returns><see cref="CopyPersonResponse"/></returns>
        public async Task<CopyPersonResponse> CopyPerson(CopyPersonRequest req)
        {
             JsonResponseModel<CopyPersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CopyPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将已存在于某人员库的人员复制到其他人员库，该人员的描述信息不会被复制。单个人员最多只能同时存在100个人员库中。
        /// >     
        /// - 注：若该人员创建时算法模型版本为2.0，复制到非2.0算法模型版本的Group中时，复制操作将会失败。
        /// </summary>
        /// <param name="req"><see cref="CopyPersonRequest"/></param>
        /// <returns><see cref="CopyPersonResponse"/></returns>
        public CopyPersonResponse CopyPersonSync(CopyPersonRequest req)
        {
             JsonResponseModel<CopyPersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CopyPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CopyPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将一组人脸图片添加到一个人员中。一个人员最多允许包含 5 张图片。若该人员存在多个人员库中，所有人员库中该人员图片均会增加。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="CreateFaceRequest"/></param>
        /// <returns><see cref="CreateFaceResponse"/></returns>
        public async Task<CreateFaceResponse> CreateFace(CreateFaceRequest req)
        {
             JsonResponseModel<CreateFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将一组人脸图片添加到一个人员中。一个人员最多允许包含 5 张图片。若该人员存在多个人员库中，所有人员库中该人员图片均会增加。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="CreateFaceRequest"/></param>
        /// <returns><see cref="CreateFaceResponse"/></returns>
        public CreateFaceResponse CreateFaceSync(CreateFaceRequest req)
        {
             JsonResponseModel<CreateFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建一个空的人员库，如果人员库已存在返回错误。
        /// 可根据需要创建自定义描述字段，用于辅助描述该人员库下的人员信息。
        /// 
        /// 1个APPID下最多创建10万个人员库（Group）、最多包含5000万张人脸（Face）。
        /// 
        /// 不同算法模型版本（FaceModelVersion）的人员库（Group）最多可包含人脸（Face）数不同。算法模型版本为2.0的人员库最多包含100万张人脸，算法模型版本为3.0的人员库最多可包含300万张人脸。
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public async Task<CreateGroupResponse> CreateGroup(CreateGroupRequest req)
        {
             JsonResponseModel<CreateGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于创建一个空的人员库，如果人员库已存在返回错误。
        /// 可根据需要创建自定义描述字段，用于辅助描述该人员库下的人员信息。
        /// 
        /// 1个APPID下最多创建10万个人员库（Group）、最多包含5000万张人脸（Face）。
        /// 
        /// 不同算法模型版本（FaceModelVersion）的人员库（Group）最多可包含人脸（Face）数不同。算法模型版本为2.0的人员库最多包含100万张人脸，算法模型版本为3.0的人员库最多可包含300万张人脸。
        /// </summary>
        /// <param name="req"><see cref="CreateGroupRequest"/></param>
        /// <returns><see cref="CreateGroupResponse"/></returns>
        public CreateGroupResponse CreateGroupSync(CreateGroupRequest req)
        {
             JsonResponseModel<CreateGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建人员，添加人脸、姓名、性别及其他相关信息。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonRequest"/></param>
        /// <returns><see cref="CreatePersonResponse"/></returns>
        public async Task<CreatePersonResponse> CreatePerson(CreatePersonRequest req)
        {
             JsonResponseModel<CreatePersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建人员，添加人脸、姓名、性别及其他相关信息。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="CreatePersonRequest"/></param>
        /// <returns><see cref="CreatePersonResponse"/></returns>
        public CreatePersonResponse CreatePersonSync(CreatePersonRequest req)
        {
             JsonResponseModel<CreatePersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个人员下的人脸图片。如果该人员只有一张人脸图片，则返回错误。
        /// </summary>
        /// <param name="req"><see cref="DeleteFaceRequest"/></param>
        /// <returns><see cref="DeleteFaceResponse"/></returns>
        public async Task<DeleteFaceResponse> DeleteFace(DeleteFaceRequest req)
        {
             JsonResponseModel<DeleteFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除一个人员下的人脸图片。如果该人员只有一张人脸图片，则返回错误。
        /// </summary>
        /// <param name="req"><see cref="DeleteFaceRequest"/></param>
        /// <returns><see cref="DeleteFaceResponse"/></returns>
        public DeleteFaceResponse DeleteFaceSync(DeleteFaceRequest req)
        {
             JsonResponseModel<DeleteFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除该人员库及包含的所有的人员。同时，人员对应的所有人脸信息将被删除。若某人员同时存在多个人员库中，该人员不会被删除，但属于该人员库中的自定义描述字段信息会被删除，属于其他人员库的自定义描述字段信息不受影响。
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public async Task<DeleteGroupResponse> DeleteGroup(DeleteGroupRequest req)
        {
             JsonResponseModel<DeleteGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除该人员库及包含的所有的人员。同时，人员对应的所有人脸信息将被删除。若某人员同时存在多个人员库中，该人员不会被删除，但属于该人员库中的自定义描述字段信息会被删除，属于其他人员库的自定义描述字段信息不受影响。
        /// </summary>
        /// <param name="req"><see cref="DeleteGroupRequest"/></param>
        /// <returns><see cref="DeleteGroupResponse"/></returns>
        public DeleteGroupResponse DeleteGroupSync(DeleteGroupRequest req)
        {
             JsonResponseModel<DeleteGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除该人员信息，此操作会导致所有人员库均删除此人员。同时，该人员的所有人脸信息将被删除。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonRequest"/></param>
        /// <returns><see cref="DeletePersonResponse"/></returns>
        public async Task<DeletePersonResponse> DeletePerson(DeletePersonRequest req)
        {
             JsonResponseModel<DeletePersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除该人员信息，此操作会导致所有人员库均删除此人员。同时，该人员的所有人脸信息将被删除。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonRequest"/></param>
        /// <returns><see cref="DeletePersonResponse"/></returns>
        public DeletePersonResponse DeletePersonSync(DeletePersonRequest req)
        {
             JsonResponseModel<DeletePersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从某人员库中删除人员，此操作仅影响该人员库。若该人员仅存在于指定的人员库中，该人员将被删除，其所有的人脸信息也将被删除。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonFromGroupRequest"/></param>
        /// <returns><see cref="DeletePersonFromGroupResponse"/></returns>
        public async Task<DeletePersonFromGroupResponse> DeletePersonFromGroup(DeletePersonFromGroupRequest req)
        {
             JsonResponseModel<DeletePersonFromGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePersonFromGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonFromGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从某人员库中删除人员，此操作仅影响该人员库。若该人员仅存在于指定的人员库中，该人员将被删除，其所有的人脸信息也将被删除。
        /// </summary>
        /// <param name="req"><see cref="DeletePersonFromGroupRequest"/></param>
        /// <returns><see cref="DeletePersonFromGroupResponse"/></returns>
        public DeletePersonFromGroupResponse DeletePersonFromGroupSync(DeletePersonFromGroupRequest req)
        {
             JsonResponseModel<DeletePersonFromGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePersonFromGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePersonFromGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检测给定图片中的人脸（Face）的位置、相应的面部属性和人脸质量信息，位置包括 (x，y，w，h)，面部属性包括性别（gender）、年龄（age）、表情（expression）、魅力（beauty）、眼镜（glass）、发型（hair）、口罩（mask）和姿态 (pitch，roll，yaw)，人脸质量信息包括整体质量分（score）、模糊分（sharpness）、光照分（brightness）和五官遮挡分（completeness）。
        /// 
        ///  
        /// 其中，人脸质量信息主要用于评价输入的人脸图片的质量。在使用人脸识别服务时，建议您对输入的人脸图片进行质量检测，提升后续业务处理的效果。该功能的应用场景包括：
        /// 
        /// 1） 人员库[创建人员](https://cloud.tencent.com/document/product/867/45014)/[增加人脸](https://cloud.tencent.com/document/product/867/45016)：保证人员人脸信息的质量，便于后续的业务处理。
        /// 
        /// 2） [人脸搜索](https://cloud.tencent.com/document/product/867/44994)：保证输入的图片质量，快速准确匹配到对应的人员。
        /// 
        /// 3） [人脸验证](https://cloud.tencent.com/document/product/867/44983)：保证人脸信息的质量，避免明明是本人却认证不通过的情况。
        /// 
        /// 4） 人脸融合：保证上传的人脸质量，人脸融合的效果更好。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// 
        /// </summary>
        /// <param name="req"><see cref="DetectFaceRequest"/></param>
        /// <returns><see cref="DetectFaceResponse"/></returns>
        public async Task<DetectFaceResponse> DetectFace(DetectFaceRequest req)
        {
             JsonResponseModel<DetectFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检测给定图片中的人脸（Face）的位置、相应的面部属性和人脸质量信息，位置包括 (x，y，w，h)，面部属性包括性别（gender）、年龄（age）、表情（expression）、魅力（beauty）、眼镜（glass）、发型（hair）、口罩（mask）和姿态 (pitch，roll，yaw)，人脸质量信息包括整体质量分（score）、模糊分（sharpness）、光照分（brightness）和五官遮挡分（completeness）。
        /// 
        ///  
        /// 其中，人脸质量信息主要用于评价输入的人脸图片的质量。在使用人脸识别服务时，建议您对输入的人脸图片进行质量检测，提升后续业务处理的效果。该功能的应用场景包括：
        /// 
        /// 1） 人员库[创建人员](https://cloud.tencent.com/document/product/867/45014)/[增加人脸](https://cloud.tencent.com/document/product/867/45016)：保证人员人脸信息的质量，便于后续的业务处理。
        /// 
        /// 2） [人脸搜索](https://cloud.tencent.com/document/product/867/44994)：保证输入的图片质量，快速准确匹配到对应的人员。
        /// 
        /// 3） [人脸验证](https://cloud.tencent.com/document/product/867/44983)：保证人脸信息的质量，避免明明是本人却认证不通过的情况。
        /// 
        /// 4） 人脸融合：保证上传的人脸质量，人脸融合的效果更好。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// 
        /// </summary>
        /// <param name="req"><see cref="DetectFaceRequest"/></param>
        /// <returns><see cref="DetectFaceResponse"/></returns>
        public DetectFaceResponse DetectFaceSync(DetectFaceRequest req)
        {
             JsonResponseModel<DetectFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检测给定图片中的人脸（Face）的位置、相应的面部属性和人脸质量信息，位置包括 (x，y，w，h)，面部属性包括性别（gender）、年龄（age）、表情（expression）、魅力（beauty）、眼镜（glass）、发型（hair）、口罩（mask）和姿态 (pitch，roll，yaw)，人脸质量信息包括整体质量分（score）、模糊分（sharpness）、光照分（brightness）和五官遮挡分（completeness）。
        /// 
        ///  
        /// 其中，人脸质量信息主要用于评价输入的人脸图片的质量。在使用人脸识别服务时，建议您对输入的人脸图片进行质量检测，提升后续业务处理的效果。该功能的应用场景包括：
        /// 
        /// 1） 人员库[创建人员](https://cloud.tencent.com/document/product/867/32793)/[增加人脸](https://cloud.tencent.com/document/product/867/32795)：保证人员人脸信息的质量，便于后续的业务处理。
        /// 
        /// 2） [人脸搜索](https://cloud.tencent.com/document/product/867/32798)：保证输入的图片质量，快速准确匹配到对应的人员。
        /// 
        /// 3） [人脸验证](https://cloud.tencent.com/document/product/867/32806)：保证人脸信息的质量，避免明明是本人却认证不通过的情况。
        /// 
        /// 4） [人脸融合](https://cloud.tencent.com/product/facefusion)：保证上传的人脸质量，人脸融合的效果更好。
        /// 
        /// >     
        /// - 本接口是[人脸检测与分析](https://cloud.tencent.com/document/product/867/44989)的升级，具体在于：
        /// 1.本接口可以指定需要计算返回的人脸属性，避免无效计算，降低耗时；
        /// 2.本接口支持更多属性细项数，也会持续增加更多功能。
        /// 请您使用本接口完成相应的人脸检测与属性分析需求。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="DetectFaceAttributesRequest"/></param>
        /// <returns><see cref="DetectFaceAttributesResponse"/></returns>
        public async Task<DetectFaceAttributesResponse> DetectFaceAttributes(DetectFaceAttributesRequest req)
        {
             JsonResponseModel<DetectFaceAttributesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectFaceAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectFaceAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检测给定图片中的人脸（Face）的位置、相应的面部属性和人脸质量信息，位置包括 (x，y，w，h)，面部属性包括性别（gender）、年龄（age）、表情（expression）、魅力（beauty）、眼镜（glass）、发型（hair）、口罩（mask）和姿态 (pitch，roll，yaw)，人脸质量信息包括整体质量分（score）、模糊分（sharpness）、光照分（brightness）和五官遮挡分（completeness）。
        /// 
        ///  
        /// 其中，人脸质量信息主要用于评价输入的人脸图片的质量。在使用人脸识别服务时，建议您对输入的人脸图片进行质量检测，提升后续业务处理的效果。该功能的应用场景包括：
        /// 
        /// 1） 人员库[创建人员](https://cloud.tencent.com/document/product/867/32793)/[增加人脸](https://cloud.tencent.com/document/product/867/32795)：保证人员人脸信息的质量，便于后续的业务处理。
        /// 
        /// 2） [人脸搜索](https://cloud.tencent.com/document/product/867/32798)：保证输入的图片质量，快速准确匹配到对应的人员。
        /// 
        /// 3） [人脸验证](https://cloud.tencent.com/document/product/867/32806)：保证人脸信息的质量，避免明明是本人却认证不通过的情况。
        /// 
        /// 4） [人脸融合](https://cloud.tencent.com/product/facefusion)：保证上传的人脸质量，人脸融合的效果更好。
        /// 
        /// >     
        /// - 本接口是[人脸检测与分析](https://cloud.tencent.com/document/product/867/44989)的升级，具体在于：
        /// 1.本接口可以指定需要计算返回的人脸属性，避免无效计算，降低耗时；
        /// 2.本接口支持更多属性细项数，也会持续增加更多功能。
        /// 请您使用本接口完成相应的人脸检测与属性分析需求。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="DetectFaceAttributesRequest"/></param>
        /// <returns><see cref="DetectFaceAttributesResponse"/></returns>
        public DetectFaceAttributesResponse DetectFaceAttributesSync(DetectFaceAttributesRequest req)
        {
             JsonResponseModel<DetectFaceAttributesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectFaceAttributes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectFaceAttributesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对用户上传的静态图片进行人脸活体检测。与动态活体检测的区别是：静态活体检测中，用户不需要通过唇语或摇头眨眼等动作来识别。
        /// 
        /// 静态活体检测适用于手机自拍的场景，或对防攻击要求不高的场景。如果对活体检测有更高安全性要求，请使用[人脸核身·云智慧眼](https://cloud.tencent.com/product/faceid)产品。
        /// 
        /// >     
        /// - 图片的宽高比请接近3：4，不符合宽高比的图片返回的分值不具备参考意义。本接口适用于类手机自拍场景，非类手机自拍照返回的分值不具备参考意义。
        /// 
        /// >
        /// - 使用过程中建议正对摄像头，不要距离太远，使面部可以完整地显示在识别的框内，识别过程中不要移动设备或遮挡面部。不要选择光线过强或过弱的环境进行面部识别，识别时不要添加任何滤镜。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="DetectLiveFaceRequest"/></param>
        /// <returns><see cref="DetectLiveFaceResponse"/></returns>
        public async Task<DetectLiveFaceResponse> DetectLiveFace(DetectLiveFaceRequest req)
        {
             JsonResponseModel<DetectLiveFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectLiveFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectLiveFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对用户上传的静态图片进行人脸活体检测。与动态活体检测的区别是：静态活体检测中，用户不需要通过唇语或摇头眨眼等动作来识别。
        /// 
        /// 静态活体检测适用于手机自拍的场景，或对防攻击要求不高的场景。如果对活体检测有更高安全性要求，请使用[人脸核身·云智慧眼](https://cloud.tencent.com/product/faceid)产品。
        /// 
        /// >     
        /// - 图片的宽高比请接近3：4，不符合宽高比的图片返回的分值不具备参考意义。本接口适用于类手机自拍场景，非类手机自拍照返回的分值不具备参考意义。
        /// 
        /// >
        /// - 使用过程中建议正对摄像头，不要距离太远，使面部可以完整地显示在识别的框内，识别过程中不要移动设备或遮挡面部。不要选择光线过强或过弱的环境进行面部识别，识别时不要添加任何滤镜。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="DetectLiveFaceRequest"/></param>
        /// <returns><see cref="DetectLiveFaceResponse"/></returns>
        public DetectLiveFaceResponse DetectLiveFaceSync(DetectLiveFaceRequest req)
        {
             JsonResponseModel<DetectLiveFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectLiveFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectLiveFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 人脸静态活体检测（高精度版）可用于对用户上传的静态图片进行防翻拍活体检测，以判断是否是翻拍图片。
        /// 
        /// 相比现有静态活体检测服务，高精度版在维持高真人通过率的前提下，增强了对高清屏幕、裁剪纸片、3D面具等攻击的防御能力，攻击拦截率约为业内同类型产品形态4-5倍。同时支持多场景人脸核验，满足移动端、PC端各类型场景的图片活体检验需求，适用于各个行业不同的活体检验应用。
        /// </summary>
        /// <param name="req"><see cref="DetectLiveFaceAccurateRequest"/></param>
        /// <returns><see cref="DetectLiveFaceAccurateResponse"/></returns>
        public async Task<DetectLiveFaceAccurateResponse> DetectLiveFaceAccurate(DetectLiveFaceAccurateRequest req)
        {
             JsonResponseModel<DetectLiveFaceAccurateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DetectLiveFaceAccurate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectLiveFaceAccurateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 人脸静态活体检测（高精度版）可用于对用户上传的静态图片进行防翻拍活体检测，以判断是否是翻拍图片。
        /// 
        /// 相比现有静态活体检测服务，高精度版在维持高真人通过率的前提下，增强了对高清屏幕、裁剪纸片、3D面具等攻击的防御能力，攻击拦截率约为业内同类型产品形态4-5倍。同时支持多场景人脸核验，满足移动端、PC端各类型场景的图片活体检验需求，适用于各个行业不同的活体检验应用。
        /// </summary>
        /// <param name="req"><see cref="DetectLiveFaceAccurateRequest"/></param>
        /// <returns><see cref="DetectLiveFaceAccurateResponse"/></returns>
        public DetectLiveFaceAccurateResponse DetectLiveFaceAccurateSync(DetectLiveFaceAccurateRequest req)
        {
             JsonResponseModel<DetectLiveFaceAccurateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DetectLiveFaceAccurate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DetectLiveFaceAccurateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取人员库信息。
        /// </summary>
        /// <param name="req"><see cref="GetGroupInfoRequest"/></param>
        /// <returns><see cref="GetGroupInfoResponse"/></returns>
        public async Task<GetGroupInfoResponse> GetGroupInfo(GetGroupInfoRequest req)
        {
             JsonResponseModel<GetGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取人员库信息。
        /// </summary>
        /// <param name="req"><see cref="GetGroupInfoRequest"/></param>
        /// <returns><see cref="GetGroupInfoResponse"/></returns>
        public GetGroupInfoResponse GetGroupInfoSync(GetGroupInfoRequest req)
        {
             JsonResponseModel<GetGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取人员库列表。
        /// </summary>
        /// <param name="req"><see cref="GetGroupListRequest"/></param>
        /// <returns><see cref="GetGroupListResponse"/></returns>
        public async Task<GetGroupListResponse> GetGroupList(GetGroupListRequest req)
        {
             JsonResponseModel<GetGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取人员库列表。
        /// </summary>
        /// <param name="req"><see cref="GetGroupListRequest"/></param>
        /// <returns><see cref="GetGroupListResponse"/></returns>
        public GetGroupListResponse GetGroupListSync(GetGroupListRequest req)
        {
             JsonResponseModel<GetGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员的信息，包括姓名、性别、人脸等。
        /// </summary>
        /// <param name="req"><see cref="GetPersonBaseInfoRequest"/></param>
        /// <returns><see cref="GetPersonBaseInfoResponse"/></returns>
        public async Task<GetPersonBaseInfoResponse> GetPersonBaseInfo(GetPersonBaseInfoRequest req)
        {
             JsonResponseModel<GetPersonBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员的信息，包括姓名、性别、人脸等。
        /// </summary>
        /// <param name="req"><see cref="GetPersonBaseInfoRequest"/></param>
        /// <returns><see cref="GetPersonBaseInfoResponse"/></returns>
        public GetPersonBaseInfoResponse GetPersonBaseInfoSync(GetPersonBaseInfoRequest req)
        {
             JsonResponseModel<GetPersonBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPersonBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员的信息，包括加入的人员库、描述内容等。
        /// </summary>
        /// <param name="req"><see cref="GetPersonGroupInfoRequest"/></param>
        /// <returns><see cref="GetPersonGroupInfoResponse"/></returns>
        public async Task<GetPersonGroupInfoResponse> GetPersonGroupInfo(GetPersonGroupInfoRequest req)
        {
             JsonResponseModel<GetPersonGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员的信息，包括加入的人员库、描述内容等。
        /// </summary>
        /// <param name="req"><see cref="GetPersonGroupInfoRequest"/></param>
        /// <returns><see cref="GetPersonGroupInfoResponse"/></returns>
        public GetPersonGroupInfoResponse GetPersonGroupInfoSync(GetPersonGroupInfoRequest req)
        {
             JsonResponseModel<GetPersonGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPersonGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员库中的人员列表。
        /// </summary>
        /// <param name="req"><see cref="GetPersonListRequest"/></param>
        /// <returns><see cref="GetPersonListResponse"/></returns>
        public async Task<GetPersonListResponse> GetPersonList(GetPersonListRequest req)
        {
             JsonResponseModel<GetPersonListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员库中的人员列表。
        /// </summary>
        /// <param name="req"><see cref="GetPersonListRequest"/></param>
        /// <returns><see cref="GetPersonListResponse"/></returns>
        public GetPersonListResponse GetPersonListSync(GetPersonListRequest req)
        {
             JsonResponseModel<GetPersonListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPersonList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员库中人员数量。
        /// </summary>
        /// <param name="req"><see cref="GetPersonListNumRequest"/></param>
        /// <returns><see cref="GetPersonListNumResponse"/></returns>
        public async Task<GetPersonListNumResponse> GetPersonListNum(GetPersonListNumRequest req)
        {
             JsonResponseModel<GetPersonListNumResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetPersonListNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonListNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取指定人员库中人员数量。
        /// </summary>
        /// <param name="req"><see cref="GetPersonListNumRequest"/></param>
        /// <returns><see cref="GetPersonListNumResponse"/></returns>
        public GetPersonListNumResponse GetPersonListNumSync(GetPersonListNumRequest req)
        {
             JsonResponseModel<GetPersonListNumResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetPersonListNum");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetPersonListNumResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取人员库升级任务列表
        /// </summary>
        /// <param name="req"><see cref="GetUpgradeGroupFaceModelVersionJobListRequest"/></param>
        /// <returns><see cref="GetUpgradeGroupFaceModelVersionJobListResponse"/></returns>
        public async Task<GetUpgradeGroupFaceModelVersionJobListResponse> GetUpgradeGroupFaceModelVersionJobList(GetUpgradeGroupFaceModelVersionJobListRequest req)
        {
             JsonResponseModel<GetUpgradeGroupFaceModelVersionJobListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetUpgradeGroupFaceModelVersionJobList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUpgradeGroupFaceModelVersionJobListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取人员库升级任务列表
        /// </summary>
        /// <param name="req"><see cref="GetUpgradeGroupFaceModelVersionJobListRequest"/></param>
        /// <returns><see cref="GetUpgradeGroupFaceModelVersionJobListResponse"/></returns>
        public GetUpgradeGroupFaceModelVersionJobListResponse GetUpgradeGroupFaceModelVersionJobListSync(GetUpgradeGroupFaceModelVersionJobListRequest req)
        {
             JsonResponseModel<GetUpgradeGroupFaceModelVersionJobListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetUpgradeGroupFaceModelVersionJobList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUpgradeGroupFaceModelVersionJobListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 人员库升级结果查询
        /// </summary>
        /// <param name="req"><see cref="GetUpgradeGroupFaceModelVersionResultRequest"/></param>
        /// <returns><see cref="GetUpgradeGroupFaceModelVersionResultResponse"/></returns>
        public async Task<GetUpgradeGroupFaceModelVersionResultResponse> GetUpgradeGroupFaceModelVersionResult(GetUpgradeGroupFaceModelVersionResultRequest req)
        {
             JsonResponseModel<GetUpgradeGroupFaceModelVersionResultResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetUpgradeGroupFaceModelVersionResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUpgradeGroupFaceModelVersionResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 人员库升级结果查询
        /// </summary>
        /// <param name="req"><see cref="GetUpgradeGroupFaceModelVersionResultRequest"/></param>
        /// <returns><see cref="GetUpgradeGroupFaceModelVersionResultResponse"/></returns>
        public GetUpgradeGroupFaceModelVersionResultResponse GetUpgradeGroupFaceModelVersionResultSync(GetUpgradeGroupFaceModelVersionResultRequest req)
        {
             JsonResponseModel<GetUpgradeGroupFaceModelVersionResultResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetUpgradeGroupFaceModelVersionResult");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetUpgradeGroupFaceModelVersionResultResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改人员库名称、备注、自定义描述字段名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupRequest"/></param>
        /// <returns><see cref="ModifyGroupResponse"/></returns>
        public async Task<ModifyGroupResponse> ModifyGroup(ModifyGroupRequest req)
        {
             JsonResponseModel<ModifyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改人员库名称、备注、自定义描述字段名称。
        /// </summary>
        /// <param name="req"><see cref="ModifyGroupRequest"/></param>
        /// <returns><see cref="ModifyGroupResponse"/></returns>
        public ModifyGroupResponse ModifyGroupSync(ModifyGroupRequest req)
        {
             JsonResponseModel<ModifyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改人员信息，包括名称、性别等。人员名称和性别修改会同步到包含该人员的所有人员库。
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonBaseInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonBaseInfoResponse"/></returns>
        public async Task<ModifyPersonBaseInfoResponse> ModifyPersonBaseInfo(ModifyPersonBaseInfoRequest req)
        {
             JsonResponseModel<ModifyPersonBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPersonBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改人员信息，包括名称、性别等。人员名称和性别修改会同步到包含该人员的所有人员库。
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonBaseInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonBaseInfoResponse"/></returns>
        public ModifyPersonBaseInfoResponse ModifyPersonBaseInfoSync(ModifyPersonBaseInfoRequest req)
        {
             JsonResponseModel<ModifyPersonBaseInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPersonBaseInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonBaseInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定人员库人员描述内容。
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonGroupInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonGroupInfoResponse"/></returns>
        public async Task<ModifyPersonGroupInfoResponse> ModifyPersonGroupInfo(ModifyPersonGroupInfoRequest req)
        {
             JsonResponseModel<ModifyPersonGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPersonGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改指定人员库人员描述内容。
        /// </summary>
        /// <param name="req"><see cref="ModifyPersonGroupInfoRequest"/></param>
        /// <returns><see cref="ModifyPersonGroupInfoResponse"/></returns>
        public ModifyPersonGroupInfoResponse ModifyPersonGroupInfoSync(ModifyPersonGroupInfoRequest req)
        {
             JsonResponseModel<ModifyPersonGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPersonGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPersonGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于回滚人员库的人脸识别算法模型版本。单个人员库有且仅有一次回滚机会。
        /// 
        /// 回滚操作会在10s内生效，回滚操作中，您对人员库的操作可能会失效。
        /// </summary>
        /// <param name="req"><see cref="RevertGroupFaceModelVersionRequest"/></param>
        /// <returns><see cref="RevertGroupFaceModelVersionResponse"/></returns>
        public async Task<RevertGroupFaceModelVersionResponse> RevertGroupFaceModelVersion(RevertGroupFaceModelVersionRequest req)
        {
             JsonResponseModel<RevertGroupFaceModelVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RevertGroupFaceModelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevertGroupFaceModelVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口用于回滚人员库的人脸识别算法模型版本。单个人员库有且仅有一次回滚机会。
        /// 
        /// 回滚操作会在10s内生效，回滚操作中，您对人员库的操作可能会失效。
        /// </summary>
        /// <param name="req"><see cref="RevertGroupFaceModelVersionRequest"/></param>
        /// <returns><see cref="RevertGroupFaceModelVersionResponse"/></returns>
        public RevertGroupFaceModelVersionResponse RevertGroupFaceModelVersionSync(RevertGroupFaceModelVersionRequest req)
        {
             JsonResponseModel<RevertGroupFaceModelVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RevertGroupFaceModelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RevertGroupFaceModelVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopK 人员，识别结果按照相似度从大到小排序。
        /// 
        /// 支持一次性识别图片中的最多 10 张人脸，支持一次性跨 100 个人员库（Group）搜索。
        /// 
        /// 单次搜索的人员库人脸总数量和人员库的算法模型版本（FaceModelVersion）相关。算法模型版本为2.0的人员库，单次搜索人员库人脸总数量不得超过 100 万张；算法模型版本为3.0的人员库，单次搜索人员库人脸总数量不得超过 300 万张。
        /// 
        /// 与[人员搜索](https://cloud.tencent.com/document/product/867/44992)及[人员搜索按库返回](https://cloud.tencent.com/document/product/867/44991)接口不同的是，本接口将该人员（Person）下的每个人脸（Face）都作为单独个体进行验证，而人员搜索及人员搜索按库返回接口 会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个Person下有4张 Face，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使搜索更加准确。
        /// 
        /// 
        /// 本接口需与[人员库管理相关接口](https://cloud.tencent.com/document/product/867/45015)结合使用。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// 
        /// >     
        /// - 不可同时搜索不同算法模型版本（FaceModelVersion）的人员库。
        /// </summary>
        /// <param name="req"><see cref="SearchFacesRequest"/></param>
        /// <returns><see cref="SearchFacesResponse"/></returns>
        public async Task<SearchFacesResponse> SearchFaces(SearchFacesRequest req)
        {
             JsonResponseModel<SearchFacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchFaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopK 人员，识别结果按照相似度从大到小排序。
        /// 
        /// 支持一次性识别图片中的最多 10 张人脸，支持一次性跨 100 个人员库（Group）搜索。
        /// 
        /// 单次搜索的人员库人脸总数量和人员库的算法模型版本（FaceModelVersion）相关。算法模型版本为2.0的人员库，单次搜索人员库人脸总数量不得超过 100 万张；算法模型版本为3.0的人员库，单次搜索人员库人脸总数量不得超过 300 万张。
        /// 
        /// 与[人员搜索](https://cloud.tencent.com/document/product/867/44992)及[人员搜索按库返回](https://cloud.tencent.com/document/product/867/44991)接口不同的是，本接口将该人员（Person）下的每个人脸（Face）都作为单独个体进行验证，而人员搜索及人员搜索按库返回接口 会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个Person下有4张 Face，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使搜索更加准确。
        /// 
        /// 
        /// 本接口需与[人员库管理相关接口](https://cloud.tencent.com/document/product/867/45015)结合使用。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// 
        /// >     
        /// - 不可同时搜索不同算法模型版本（FaceModelVersion）的人员库。
        /// </summary>
        /// <param name="req"><see cref="SearchFacesRequest"/></param>
        /// <returns><see cref="SearchFacesResponse"/></returns>
        public SearchFacesResponse SearchFacesSync(SearchFacesRequest req)
        {
             JsonResponseModel<SearchFacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchFaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopK 人员，按照**人员库的维度**以人员相似度从大到小顺序排列。
        /// 
        /// 支持一次性识别图片中的最多 10 张人脸，支持跨人员库（Group）搜索。
        /// 
        /// 单次搜索的人员库人脸总数量和人员库的算法模型版本（FaceModelVersion）相关。算法模型版本为2.0的人员库，单次搜索人员库人脸总数量不得超过 100 万张；算法模型版本为3.0的人员库，单次搜索人员库人脸总数量不得超过 300 万张。
        /// 
        /// 与[人员搜索](https://cloud.tencent.com/document/product/867/44992)及[人员搜索按库返回](https://cloud.tencent.com/document/product/867/44991)接口不同的是，本接口将该人员（Person）下的每个人脸（Face）都作为单独个体进行验证，而[人员搜索](https://cloud.tencent.com/document/product/867/44992)及[人员搜索按库返回](https://cloud.tencent.com/document/product/867/44991)接口 会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个Person下有4张 Face，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使搜索更加准确。
        /// 
        /// 本接口需与[人员库管理相关接口](https://cloud.tencent.com/document/product/867/45015)结合使用。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// 
        /// >     
        /// - 不可同时搜索不同算法模型版本（FaceModelVersion）的人员库。
        /// </summary>
        /// <param name="req"><see cref="SearchFacesReturnsByGroupRequest"/></param>
        /// <returns><see cref="SearchFacesReturnsByGroupResponse"/></returns>
        public async Task<SearchFacesReturnsByGroupResponse> SearchFacesReturnsByGroup(SearchFacesReturnsByGroupRequest req)
        {
             JsonResponseModel<SearchFacesReturnsByGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchFacesReturnsByGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFacesReturnsByGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopK 人员，按照**人员库的维度**以人员相似度从大到小顺序排列。
        /// 
        /// 支持一次性识别图片中的最多 10 张人脸，支持跨人员库（Group）搜索。
        /// 
        /// 单次搜索的人员库人脸总数量和人员库的算法模型版本（FaceModelVersion）相关。算法模型版本为2.0的人员库，单次搜索人员库人脸总数量不得超过 100 万张；算法模型版本为3.0的人员库，单次搜索人员库人脸总数量不得超过 300 万张。
        /// 
        /// 与[人员搜索](https://cloud.tencent.com/document/product/867/44992)及[人员搜索按库返回](https://cloud.tencent.com/document/product/867/44991)接口不同的是，本接口将该人员（Person）下的每个人脸（Face）都作为单独个体进行验证，而[人员搜索](https://cloud.tencent.com/document/product/867/44992)及[人员搜索按库返回](https://cloud.tencent.com/document/product/867/44991)接口 会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个Person下有4张 Face，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使搜索更加准确。
        /// 
        /// 本接口需与[人员库管理相关接口](https://cloud.tencent.com/document/product/867/45015)结合使用。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// 
        /// >     
        /// - 不可同时搜索不同算法模型版本（FaceModelVersion）的人员库。
        /// </summary>
        /// <param name="req"><see cref="SearchFacesReturnsByGroupRequest"/></param>
        /// <returns><see cref="SearchFacesReturnsByGroupResponse"/></returns>
        public SearchFacesReturnsByGroupResponse SearchFacesReturnsByGroupSync(SearchFacesReturnsByGroupRequest req)
        {
             JsonResponseModel<SearchFacesReturnsByGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchFacesReturnsByGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchFacesReturnsByGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopK 人员，按照相似度从大到小排列。
        /// 
        /// 支持一次性识别图片中的最多 10 张人脸，支持一次性跨 100 个人员库（Group）搜索。
        /// 
        /// 单次搜索的人员库人脸总数量和人员库的算法模型版本（FaceModelVersion）相关。算法模型版本为2.0的人员库，单次搜索人员库人脸总数量不得超过 100 万张；算法模型版本为3.0的人员库，单次搜索人员库人脸总数量不得超过 300 万张。
        /// 
        /// 本接口会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个 Person 下有4张 Face ，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使人员搜索（确定待识别的人脸图片是某人）更加准确。而[人脸搜索](https://cloud.tencent.com/document/product/867/44994)及[人脸搜索按库返回接口](https://cloud.tencent.com/document/product/867/44993)将该人员（Person）下的每个人脸（Face）都作为单独个体进行搜索。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// - 仅支持算法模型版本（FaceModelVersion）为3.0的人员库。
        /// </summary>
        /// <param name="req"><see cref="SearchPersonsRequest"/></param>
        /// <returns><see cref="SearchPersonsResponse"/></returns>
        public async Task<SearchPersonsResponse> SearchPersons(SearchPersonsRequest req)
        {
             JsonResponseModel<SearchPersonsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchPersons");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchPersonsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopK 人员，按照相似度从大到小排列。
        /// 
        /// 支持一次性识别图片中的最多 10 张人脸，支持一次性跨 100 个人员库（Group）搜索。
        /// 
        /// 单次搜索的人员库人脸总数量和人员库的算法模型版本（FaceModelVersion）相关。算法模型版本为2.0的人员库，单次搜索人员库人脸总数量不得超过 100 万张；算法模型版本为3.0的人员库，单次搜索人员库人脸总数量不得超过 300 万张。
        /// 
        /// 本接口会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个 Person 下有4张 Face ，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使人员搜索（确定待识别的人脸图片是某人）更加准确。而[人脸搜索](https://cloud.tencent.com/document/product/867/44994)及[人脸搜索按库返回接口](https://cloud.tencent.com/document/product/867/44993)将该人员（Person）下的每个人脸（Face）都作为单独个体进行搜索。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// - 仅支持算法模型版本（FaceModelVersion）为3.0的人员库。
        /// </summary>
        /// <param name="req"><see cref="SearchPersonsRequest"/></param>
        /// <returns><see cref="SearchPersonsResponse"/></returns>
        public SearchPersonsResponse SearchPersonsSync(SearchPersonsRequest req)
        {
             JsonResponseModel<SearchPersonsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchPersons");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchPersonsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopK 人员，按照**人员库的维度**以人员相似度从大到小顺序排列。
        /// 
        /// 支持一次性识别图片中的最多 10 张人脸，支持跨人员库（Group）搜索。
        /// 
        /// 单次搜索的人员库人脸总数量和人员库的算法模型版本（FaceModelVersion）相关。算法模型版本为2.0的人员库，单次搜索人员库人脸总数量不得超过 100 万张；算法模型版本为3.0的人员库，单次搜索人员库人脸总数量不得超过 300 万张。
        /// 
        /// 本接口会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个 Person 下有4张 Face ，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使人员搜索（确定待识别的人脸图片是某人）更加准确。而[人脸搜索](https://cloud.tencent.com/document/product/867/44994)及[人脸搜索按库返回接口](https://cloud.tencent.com/document/product/867/44993)将该人员（Person）下的每个人脸（Face）都作为单独个体进行搜索。
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// - 仅支持算法模型版本（FaceModelVersion）为3.0的人员库。
        /// </summary>
        /// <param name="req"><see cref="SearchPersonsReturnsByGroupRequest"/></param>
        /// <returns><see cref="SearchPersonsReturnsByGroupResponse"/></returns>
        public async Task<SearchPersonsReturnsByGroupResponse> SearchPersonsReturnsByGroup(SearchPersonsReturnsByGroupRequest req)
        {
             JsonResponseModel<SearchPersonsReturnsByGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SearchPersonsReturnsByGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchPersonsReturnsByGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于对一张待识别的人脸图片，在一个或多个人员库中识别出最相似的 TopK 人员，按照**人员库的维度**以人员相似度从大到小顺序排列。
        /// 
        /// 支持一次性识别图片中的最多 10 张人脸，支持跨人员库（Group）搜索。
        /// 
        /// 单次搜索的人员库人脸总数量和人员库的算法模型版本（FaceModelVersion）相关。算法模型版本为2.0的人员库，单次搜索人员库人脸总数量不得超过 100 万张；算法模型版本为3.0的人员库，单次搜索人员库人脸总数量不得超过 300 万张。
        /// 
        /// 本接口会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个 Person 下有4张 Face ，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使人员搜索（确定待识别的人脸图片是某人）更加准确。而[人脸搜索](https://cloud.tencent.com/document/product/867/44994)及[人脸搜索按库返回接口](https://cloud.tencent.com/document/product/867/44993)将该人员（Person）下的每个人脸（Face）都作为单独个体进行搜索。
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// - 仅支持算法模型版本（FaceModelVersion）为3.0的人员库。
        /// </summary>
        /// <param name="req"><see cref="SearchPersonsReturnsByGroupRequest"/></param>
        /// <returns><see cref="SearchPersonsReturnsByGroupResponse"/></returns>
        public SearchPersonsReturnsByGroupResponse SearchPersonsReturnsByGroupSync(SearchPersonsReturnsByGroupRequest req)
        {
             JsonResponseModel<SearchPersonsReturnsByGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SearchPersonsReturnsByGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SearchPersonsReturnsByGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级人员库。升级过程中，人员库仍然为原算法版本，人员库相关操作仍然支持。升级完成后，人员库为新算法版本。
        /// 单个人员库有且仅支持一次回滚操作。
        /// 
        /// 升级是一个耗时的操作，执行时间与人员库的人脸数相关，升级的人员库中的人脸数越多，升级的耗时越长。升级接口是个异步任务，调用成功后返回JobId，通过GetUpgradeGroupFaceModelVersionResult查询升级进度和结果。如果升级成功，人员库版本将切换到新版本。如果想回滚到旧版本，可以调用RevertGroupFaceModelVersion进行回滚。
        /// 
        /// 注：某些接口无法进行跨人员库版本操作，例如SearchFaces，SearchPersons和CopyPerson等。当业务有多个Group操作的场景时，如同时搜索Group1和Group2，如果升级了Group1，此时Group1和Group2版本不同，造成了跨版本操作，将导致Search接口无法正常执行，返回不允许执行跨版本操作错误，升级前需考虑业务是否有多库操作的场景，否则会影响线上接口表现。
        /// </summary>
        /// <param name="req"><see cref="UpgradeGroupFaceModelVersionRequest"/></param>
        /// <returns><see cref="UpgradeGroupFaceModelVersionResponse"/></returns>
        public async Task<UpgradeGroupFaceModelVersionResponse> UpgradeGroupFaceModelVersion(UpgradeGroupFaceModelVersionRequest req)
        {
             JsonResponseModel<UpgradeGroupFaceModelVersionResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UpgradeGroupFaceModelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeGroupFaceModelVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 升级人员库。升级过程中，人员库仍然为原算法版本，人员库相关操作仍然支持。升级完成后，人员库为新算法版本。
        /// 单个人员库有且仅支持一次回滚操作。
        /// 
        /// 升级是一个耗时的操作，执行时间与人员库的人脸数相关，升级的人员库中的人脸数越多，升级的耗时越长。升级接口是个异步任务，调用成功后返回JobId，通过GetUpgradeGroupFaceModelVersionResult查询升级进度和结果。如果升级成功，人员库版本将切换到新版本。如果想回滚到旧版本，可以调用RevertGroupFaceModelVersion进行回滚。
        /// 
        /// 注：某些接口无法进行跨人员库版本操作，例如SearchFaces，SearchPersons和CopyPerson等。当业务有多个Group操作的场景时，如同时搜索Group1和Group2，如果升级了Group1，此时Group1和Group2版本不同，造成了跨版本操作，将导致Search接口无法正常执行，返回不允许执行跨版本操作错误，升级前需考虑业务是否有多库操作的场景，否则会影响线上接口表现。
        /// </summary>
        /// <param name="req"><see cref="UpgradeGroupFaceModelVersionRequest"/></param>
        /// <returns><see cref="UpgradeGroupFaceModelVersionResponse"/></returns>
        public UpgradeGroupFaceModelVersionResponse UpgradeGroupFaceModelVersionSync(UpgradeGroupFaceModelVersionRequest req)
        {
             JsonResponseModel<UpgradeGroupFaceModelVersionResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UpgradeGroupFaceModelVersion");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UpgradeGroupFaceModelVersionResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给定一张人脸图片和一个 PersonId，判断图片中的人和 PersonId 对应的人是否为同一人。PersonId 请参考[人员库管理相关接口](https://cloud.tencent.com/document/product/867/45015)。 
        /// 
        /// 与[人脸比对](https://cloud.tencent.com/document/product/867/44987)接口不同的是，人脸验证用于判断 “此人是否是此人”，“此人”的信息已存于人员库中，“此人”可能存在多张人脸图片；而[人脸比对](https://cloud.tencent.com/document/product/867/44987)用于判断两张人脸的相似度。
        /// 
        /// 与[人员验证](https://cloud.tencent.com/document/product/867/44982)接口不同的是，人脸验证将该人员（Person）下的每个人脸（Face）都作为单独个体进行验证，而[人员验证](https://cloud.tencent.com/document/product/867/44982)会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个 Person下有4张 Face，人员验证接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使人员验证（确定待识别的人脸图片是某人员）更加准确。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="VerifyFaceRequest"/></param>
        /// <returns><see cref="VerifyFaceResponse"/></returns>
        public async Task<VerifyFaceResponse> VerifyFace(VerifyFaceRequest req)
        {
             JsonResponseModel<VerifyFaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给定一张人脸图片和一个 PersonId，判断图片中的人和 PersonId 对应的人是否为同一人。PersonId 请参考[人员库管理相关接口](https://cloud.tencent.com/document/product/867/45015)。 
        /// 
        /// 与[人脸比对](https://cloud.tencent.com/document/product/867/44987)接口不同的是，人脸验证用于判断 “此人是否是此人”，“此人”的信息已存于人员库中，“此人”可能存在多张人脸图片；而[人脸比对](https://cloud.tencent.com/document/product/867/44987)用于判断两张人脸的相似度。
        /// 
        /// 与[人员验证](https://cloud.tencent.com/document/product/867/44982)接口不同的是，人脸验证将该人员（Person）下的每个人脸（Face）都作为单独个体进行验证，而[人员验证](https://cloud.tencent.com/document/product/867/44982)会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个 Person下有4张 Face，人员验证接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使人员验证（确定待识别的人脸图片是某人员）更加准确。
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// </summary>
        /// <param name="req"><see cref="VerifyFaceRequest"/></param>
        /// <returns><see cref="VerifyFaceResponse"/></returns>
        public VerifyFaceResponse VerifyFaceSync(VerifyFaceRequest req)
        {
             JsonResponseModel<VerifyFaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyFace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyFaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给定一张人脸图片和一个 PersonId，判断图片中的人和 PersonId 对应的人是否为同一人。PersonId 请参考[人员库管理相关接口](https://cloud.tencent.com/document/product/867/45015)。
        /// 本接口会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个Person下有4张 Face，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使人员验证（确定待识别的人脸图片是某人员）更加准确。
        /// 
        ///  和人脸比对相关接口不同的是，人脸验证相关接口用于判断 “此人是否是此人”，“此人”的信息已存于人员库中，“此人”可能存在多张人脸图片；而人脸比对相关接口用于判断两张人脸的相似度。
        /// 
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// - 仅支持算法模型版本（FaceModelVersion）为3.0的人员库。
        /// </summary>
        /// <param name="req"><see cref="VerifyPersonRequest"/></param>
        /// <returns><see cref="VerifyPersonResponse"/></returns>
        public async Task<VerifyPersonResponse> VerifyPerson(VerifyPersonRequest req)
        {
             JsonResponseModel<VerifyPersonResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "VerifyPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 给定一张人脸图片和一个 PersonId，判断图片中的人和 PersonId 对应的人是否为同一人。PersonId 请参考[人员库管理相关接口](https://cloud.tencent.com/document/product/867/45015)。
        /// 本接口会将该人员（Person）下的所有人脸（Face）进行融合特征处理，即若某个Person下有4张 Face，本接口会将4张 Face 的特征进行融合处理，生成对应这个 Person 的特征，使人员验证（确定待识别的人脸图片是某人员）更加准确。
        /// 
        ///  和人脸比对相关接口不同的是，人脸验证相关接口用于判断 “此人是否是此人”，“此人”的信息已存于人员库中，“此人”可能存在多张人脸图片；而人脸比对相关接口用于判断两张人脸的相似度。
        /// 
        /// 
        /// >     
        /// - 公共参数中的签名方式请使用V3版本，即配置SignatureMethod参数为TC3-HMAC-SHA256。
        /// - 仅支持算法模型版本（FaceModelVersion）为3.0的人员库。
        /// </summary>
        /// <param name="req"><see cref="VerifyPersonRequest"/></param>
        /// <returns><see cref="VerifyPersonResponse"/></returns>
        public VerifyPersonResponse VerifyPersonSync(VerifyPersonRequest req)
        {
             JsonResponseModel<VerifyPersonResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "VerifyPerson");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<VerifyPersonResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
