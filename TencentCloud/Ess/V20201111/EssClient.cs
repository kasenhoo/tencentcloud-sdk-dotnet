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

namespace TencentCloud.Ess.V20201111
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Ess.V20201111.Models;

   public class EssClient : AbstractClient{

       private const string endpoint = "ess.tencentcloudapi.com";
       private const string version = "2020-11-11";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public EssClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public EssClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 用于撤销签署流程
        /// 适用场景：如果某个合同流程当前至少还有一方没有签署，则可通过该接口取消该合同流程。常用于合同发错、内容填错，需要及时撤销的场景。
        /// 注：如果合同流程中的参与方均已签署完毕，则无法通过该接口撤销合同。
        /// </summary>
        /// <param name="req"><see cref="CancelFlowRequest"/></param>
        /// <returns><see cref="CancelFlowResponse"/></returns>
        public async Task<CancelFlowResponse> CancelFlow(CancelFlowRequest req)
        {
             JsonResponseModel<CancelFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 用于撤销签署流程
        /// 适用场景：如果某个合同流程当前至少还有一方没有签署，则可通过该接口取消该合同流程。常用于合同发错、内容填错，需要及时撤销的场景。
        /// 注：如果合同流程中的参与方均已签署完毕，则无法通过该接口撤销合同。
        /// </summary>
        /// <param name="req"><see cref="CancelFlowRequest"/></param>
        /// <returns><see cref="CancelFlowResponse"/></returns>
        public CancelFlowResponse CancelFlowSync(CancelFlowRequest req)
        {
             JsonResponseModel<CancelFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CancelMultiFlowSignQRCode）用于取消一码多扫二维码。该接口对传入的二维码ID，若还在有效期内，可以提前失效。
        /// </summary>
        /// <param name="req"><see cref="CancelMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="CancelMultiFlowSignQRCodeResponse"/></returns>
        public async Task<CancelMultiFlowSignQRCodeResponse> CancelMultiFlowSignQRCode(CancelMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<CancelMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CancelMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CancelMultiFlowSignQRCode）用于取消一码多扫二维码。该接口对传入的二维码ID，若还在有效期内，可以提前失效。
        /// </summary>
        /// <param name="req"><see cref="CancelMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="CancelMultiFlowSignQRCodeResponse"/></returns>
        public CancelMultiFlowSignQRCodeResponse CancelMultiFlowSignQRCodeSync(CancelMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<CancelMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CancelMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CancelMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建电子文档
        /// 适用场景：见创建签署流程接口。
        /// 注：该接口需要给对应的流程指定一个模板id，并且填充该模板中需要补充的信息。是“发起流程”接口的前置接口。
        /// </summary>
        /// <param name="req"><see cref="CreateDocumentRequest"/></param>
        /// <returns><see cref="CreateDocumentResponse"/></returns>
        public async Task<CreateDocumentResponse> CreateDocument(CreateDocumentRequest req)
        {
             JsonResponseModel<CreateDocumentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建电子文档
        /// 适用场景：见创建签署流程接口。
        /// 注：该接口需要给对应的流程指定一个模板id，并且填充该模板中需要补充的信息。是“发起流程”接口的前置接口。
        /// </summary>
        /// <param name="req"><see cref="CreateDocumentRequest"/></param>
        /// <returns><see cref="CreateDocumentResponse"/></returns>
        public CreateDocumentResponse CreateDocumentSync(CreateDocumentRequest req)
        {
             JsonResponseModel<CreateDocumentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDocument");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDocumentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建签署流程
        /// 适用场景：在标准制式的合同场景中，可通过提前预制好模板文件，每次调用模板文件的id，补充合同内容信息及签署信息生成电子合同。
        /// 注：改接口是通过模板生成合同流程的前置接口，先创建一个不包含签署文件的流程。配合“创建电子文档”接口和“发起流程”接口使用。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowRequest"/></param>
        /// <returns><see cref="CreateFlowResponse"/></returns>
        public async Task<CreateFlowResponse> CreateFlow(CreateFlowRequest req)
        {
             JsonResponseModel<CreateFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建签署流程
        /// 适用场景：在标准制式的合同场景中，可通过提前预制好模板文件，每次调用模板文件的id，补充合同内容信息及签署信息生成电子合同。
        /// 注：改接口是通过模板生成合同流程的前置接口，先创建一个不包含签署文件的流程。配合“创建电子文档”接口和“发起流程”接口使用。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowRequest"/></param>
        /// <returns><see cref="CreateFlowResponse"/></returns>
        public CreateFlowResponse CreateFlowSync(CreateFlowRequest req)
        {
             JsonResponseModel<CreateFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateFlowByFiles）用来通过上传后的pdf资源编号来创建待签署的合同流程。
        /// 适用场景1：适用非制式的合同文件签署。一般开发者自己有完整的签署文件，可以通过该接口传入完整的PDF文件及流程信息生成待签署的合同流程。
        /// 适用场景2：可通过改接口传入制式合同文件，同时在指定位置添加签署控件。可以起到接口创建临时模板的效果。如果是标准的制式文件，建议使用模板功能生成模板ID进行合同流程的生成。
        /// 注意事项：该接口需要依赖“多文件上传”接口生成pdf资源编号（FileIds）进行使用。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowByFilesRequest"/></param>
        /// <returns><see cref="CreateFlowByFilesResponse"/></returns>
        public async Task<CreateFlowByFilesResponse> CreateFlowByFiles(CreateFlowByFilesRequest req)
        {
             JsonResponseModel<CreateFlowByFilesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateFlowByFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowByFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateFlowByFiles）用来通过上传后的pdf资源编号来创建待签署的合同流程。
        /// 适用场景1：适用非制式的合同文件签署。一般开发者自己有完整的签署文件，可以通过该接口传入完整的PDF文件及流程信息生成待签署的合同流程。
        /// 适用场景2：可通过改接口传入制式合同文件，同时在指定位置添加签署控件。可以起到接口创建临时模板的效果。如果是标准的制式文件，建议使用模板功能生成模板ID进行合同流程的生成。
        /// 注意事项：该接口需要依赖“多文件上传”接口生成pdf资源编号（FileIds）进行使用。
        /// </summary>
        /// <param name="req"><see cref="CreateFlowByFilesRequest"/></param>
        /// <returns><see cref="CreateFlowByFilesResponse"/></returns>
        public CreateFlowByFilesResponse CreateFlowByFilesSync(CreateFlowByFilesRequest req)
        {
             JsonResponseModel<CreateFlowByFilesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateFlowByFiles");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateFlowByFilesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateMultiFlowSignQRCode）用于创建一码多扫流程签署二维码。
        /// 适用场景：无需填写签署人信息，可通过模板id生成签署二维码，签署人可通过扫描二维码补充签署信息进行实名签署。常用于提前不知道签署人的身份信息场景，例如：劳务工招工、大批量员工入职等场景。
        /// 适用的模板仅限于B2C（1、无序签署，2、顺序签署时B静默签署，3、顺序签署时B非首位签署）、单C的模板，且模板中发起方没有填写控件。
        /// </summary>
        /// <param name="req"><see cref="CreateMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="CreateMultiFlowSignQRCodeResponse"/></returns>
        public async Task<CreateMultiFlowSignQRCodeResponse> CreateMultiFlowSignQRCode(CreateMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<CreateMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（CreateMultiFlowSignQRCode）用于创建一码多扫流程签署二维码。
        /// 适用场景：无需填写签署人信息，可通过模板id生成签署二维码，签署人可通过扫描二维码补充签署信息进行实名签署。常用于提前不知道签署人的身份信息场景，例如：劳务工招工、大批量员工入职等场景。
        /// 适用的模板仅限于B2C（1、无序签署，2、顺序签署时B静默签署，3、顺序签署时B非首位签署）、单C的模板，且模板中发起方没有填写控件。
        /// </summary>
        /// <param name="req"><see cref="CreateMultiFlowSignQRCodeRequest"/></param>
        /// <returns><see cref="CreateMultiFlowSignQRCodeResponse"/></returns>
        public CreateMultiFlowSignQRCodeResponse CreateMultiFlowSignQRCodeSync(CreateMultiFlowSignQRCodeRequest req)
        {
             JsonResponseModel<CreateMultiFlowSignQRCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateMultiFlowSignQRCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateMultiFlowSignQRCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取小程序跳转链接
        /// 
        /// 适用场景：如果需要签署人在自己的APP、小程序、H5应用中签署，可以通过此接口获取跳转腾讯电子签小程序的签署跳转链接。
        /// 
        /// 注：如果签署人是在PC端扫码签署，可以通过生成跳转链接自主转换成二维码，让签署人在PC端扫码签署。
        /// 
        /// 
        /// 跳转到小程序的实现，参考官方文档（分为<a href="https://developers.weixin.qq.com/miniprogram/dev/api/navigate/wx.navigateToMiniProgram.html">全屏</a>、<a href="https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/openEmbeddedMiniProgram.html">半屏</a>两种方式）
        /// 
        /// 
        /// 如您需要自主配置小程序跳转链接，请参考: <a href="https://cloud.tencent.com/document/product/1323/74774">跳转小程序链接配置说明</a>
        /// </summary>
        /// <param name="req"><see cref="CreateSchemeUrlRequest"/></param>
        /// <returns><see cref="CreateSchemeUrlResponse"/></returns>
        public async Task<CreateSchemeUrlResponse> CreateSchemeUrl(CreateSchemeUrlRequest req)
        {
             JsonResponseModel<CreateSchemeUrlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSchemeUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSchemeUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取小程序跳转链接
        /// 
        /// 适用场景：如果需要签署人在自己的APP、小程序、H5应用中签署，可以通过此接口获取跳转腾讯电子签小程序的签署跳转链接。
        /// 
        /// 注：如果签署人是在PC端扫码签署，可以通过生成跳转链接自主转换成二维码，让签署人在PC端扫码签署。
        /// 
        /// 
        /// 跳转到小程序的实现，参考官方文档（分为<a href="https://developers.weixin.qq.com/miniprogram/dev/api/navigate/wx.navigateToMiniProgram.html">全屏</a>、<a href="https://developers.weixin.qq.com/miniprogram/dev/framework/open-ability/openEmbeddedMiniProgram.html">半屏</a>两种方式）
        /// 
        /// 
        /// 如您需要自主配置小程序跳转链接，请参考: <a href="https://cloud.tencent.com/document/product/1323/74774">跳转小程序链接配置说明</a>
        /// </summary>
        /// <param name="req"><see cref="CreateSchemeUrlRequest"/></param>
        /// <returns><see cref="CreateSchemeUrlResponse"/></returns>
        public CreateSchemeUrlResponse CreateSchemeUrlSync(CreateSchemeUrlRequest req)
        {
             JsonResponseModel<CreateSchemeUrlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSchemeUrl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSchemeUrlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文件下载URL
        /// 适用场景：通过传参合同流程编号，下载对应的合同PDF文件流到本地。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileUrlsRequest"/></param>
        /// <returns><see cref="DescribeFileUrlsResponse"/></returns>
        public async Task<DescribeFileUrlsResponse> DescribeFileUrls(DescribeFileUrlsRequest req)
        {
             JsonResponseModel<DescribeFileUrlsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFileUrls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileUrlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询文件下载URL
        /// 适用场景：通过传参合同流程编号，下载对应的合同PDF文件流到本地。
        /// </summary>
        /// <param name="req"><see cref="DescribeFileUrlsRequest"/></param>
        /// <returns><see cref="DescribeFileUrlsResponse"/></returns>
        public DescribeFileUrlsResponse DescribeFileUrlsSync(DescribeFileUrlsRequest req)
        {
             JsonResponseModel<DescribeFileUrlsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFileUrls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFileUrlsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询流程摘要
        /// 适用场景：可用于主动查询某个合同流程的签署状态信息。可以配合回调通知使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowBriefsRequest"/></param>
        /// <returns><see cref="DescribeFlowBriefsResponse"/></returns>
        public async Task<DescribeFlowBriefsResponse> DescribeFlowBriefs(DescribeFlowBriefsRequest req)
        {
             JsonResponseModel<DescribeFlowBriefsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowBriefs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowBriefsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询流程摘要
        /// 适用场景：可用于主动查询某个合同流程的签署状态信息。可以配合回调通知使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowBriefsRequest"/></param>
        /// <returns><see cref="DescribeFlowBriefsResponse"/></returns>
        public DescribeFlowBriefsResponse DescribeFlowBriefsSync(DescribeFlowBriefsRequest req)
        {
             JsonResponseModel<DescribeFlowBriefsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowBriefs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowBriefsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 二期接口-查询模板
        /// 适用场景：当模板较多或模板中的控件较多时，可以通过查询模板接口更方便的获取自己主体下的模板列表，以及每个模板内的控件信息。该接口常用来配合“创建电子文档”接口作为前置的接口使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowTemplatesRequest"/></param>
        /// <returns><see cref="DescribeFlowTemplatesResponse"/></returns>
        public async Task<DescribeFlowTemplatesResponse> DescribeFlowTemplates(DescribeFlowTemplatesRequest req)
        {
             JsonResponseModel<DescribeFlowTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeFlowTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 二期接口-查询模板
        /// 适用场景：当模板较多或模板中的控件较多时，可以通过查询模板接口更方便的获取自己主体下的模板列表，以及每个模板内的控件信息。该接口常用来配合“创建电子文档”接口作为前置的接口使用。
        /// </summary>
        /// <param name="req"><see cref="DescribeFlowTemplatesRequest"/></param>
        /// <returns><see cref="DescribeFlowTemplatesResponse"/></returns>
        public DescribeFlowTemplatesResponse DescribeFlowTemplatesSync(DescribeFlowTemplatesRequest req)
        {
             JsonResponseModel<DescribeFlowTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeFlowTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeFlowTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过AuthCode查询用户是否实名
        /// </summary>
        /// <param name="req"><see cref="DescribeThirdPartyAuthCodeRequest"/></param>
        /// <returns><see cref="DescribeThirdPartyAuthCodeResponse"/></returns>
        public async Task<DescribeThirdPartyAuthCodeResponse> DescribeThirdPartyAuthCode(DescribeThirdPartyAuthCodeRequest req)
        {
             JsonResponseModel<DescribeThirdPartyAuthCodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeThirdPartyAuthCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeThirdPartyAuthCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 通过AuthCode查询用户是否实名
        /// </summary>
        /// <param name="req"><see cref="DescribeThirdPartyAuthCodeRequest"/></param>
        /// <returns><see cref="DescribeThirdPartyAuthCodeResponse"/></returns>
        public DescribeThirdPartyAuthCodeResponse DescribeThirdPartyAuthCodeSync(DescribeThirdPartyAuthCodeRequest req)
        {
             JsonResponseModel<DescribeThirdPartyAuthCodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeThirdPartyAuthCode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeThirdPartyAuthCodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于发起流程
        /// 适用场景：见创建签署流程接口。
        /// 注：该接口是“创建电子文档”接口的后置接口，用于激活包含完整合同信息（模板及内容信息）的流程。激活后的流程就是一份待签署的电子合同。
        /// </summary>
        /// <param name="req"><see cref="StartFlowRequest"/></param>
        /// <returns><see cref="StartFlowResponse"/></returns>
        public async Task<StartFlowResponse> StartFlow(StartFlowRequest req)
        {
             JsonResponseModel<StartFlowResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "StartFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口用于发起流程
        /// 适用场景：见创建签署流程接口。
        /// 注：该接口是“创建电子文档”接口的后置接口，用于激活包含完整合同信息（模板及内容信息）的流程。激活后的流程就是一份待签署的电子合同。
        /// </summary>
        /// <param name="req"><see cref="StartFlowRequest"/></param>
        /// <returns><see cref="StartFlowResponse"/></returns>
        public StartFlowResponse StartFlowSync(StartFlowRequest req)
        {
             JsonResponseModel<StartFlowResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "StartFlow");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<StartFlowResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 此接口（UploadFiles）用于文件上传。
        /// 适用场景：用于生成pdf资源编号（FileIds）来配合“用PDF创建流程”接口使用，使用场景可详见“用PDF创建流程”接口说明。
        /// 调用时需要设置Domain 为 file.ess.tencent.cn，设置Version为2020-12-22
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
        /// 适用场景：用于生成pdf资源编号（FileIds）来配合“用PDF创建流程”接口使用，使用场景可详见“用PDF创建流程”接口说明。
        /// 调用时需要设置Domain 为 file.ess.tencent.cn，设置Version为2020-12-22
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
