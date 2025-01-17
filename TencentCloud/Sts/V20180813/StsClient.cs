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

namespace TencentCloud.Sts.V20180813
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Sts.V20180813.Models;

   public class StsClient : AbstractClient{

       private const string endpoint = "sts.tencentcloudapi.com";
       private const string version = "2018-08-13";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public StsClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public StsClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 申请扮演角色
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleRequest"/></param>
        /// <returns><see cref="AssumeRoleResponse"/></returns>
        public async Task<AssumeRoleResponse> AssumeRole(AssumeRoleRequest req)
        {
             JsonResponseModel<AssumeRoleResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssumeRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 申请扮演角色
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleRequest"/></param>
        /// <returns><see cref="AssumeRoleResponse"/></returns>
        public AssumeRoleResponse AssumeRoleSync(AssumeRoleRequest req)
        {
             JsonResponseModel<AssumeRoleResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssumeRole");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssumeRoleWithSAML）用于根据 SAML 断言申请角色临时凭证。
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithSAMLRequest"/></param>
        /// <returns><see cref="AssumeRoleWithSAMLResponse"/></returns>
        public async Task<AssumeRoleWithSAMLResponse> AssumeRoleWithSAML(AssumeRoleWithSAMLRequest req)
        {
             JsonResponseModel<AssumeRoleWithSAMLResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssumeRoleWithSAML");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleWithSAMLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 本接口（AssumeRoleWithSAML）用于根据 SAML 断言申请角色临时凭证。
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithSAMLRequest"/></param>
        /// <returns><see cref="AssumeRoleWithSAMLResponse"/></returns>
        public AssumeRoleWithSAMLResponse AssumeRoleWithSAMLSync(AssumeRoleWithSAMLRequest req)
        {
             JsonResponseModel<AssumeRoleWithSAMLResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssumeRoleWithSAML");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleWithSAMLResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 申请OIDC角色临时密钥
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithWebIdentityRequest"/></param>
        /// <returns><see cref="AssumeRoleWithWebIdentityResponse"/></returns>
        public async Task<AssumeRoleWithWebIdentityResponse> AssumeRoleWithWebIdentity(AssumeRoleWithWebIdentityRequest req)
        {
             JsonResponseModel<AssumeRoleWithWebIdentityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AssumeRoleWithWebIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleWithWebIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 申请OIDC角色临时密钥
        /// </summary>
        /// <param name="req"><see cref="AssumeRoleWithWebIdentityRequest"/></param>
        /// <returns><see cref="AssumeRoleWithWebIdentityResponse"/></returns>
        public AssumeRoleWithWebIdentityResponse AssumeRoleWithWebIdentitySync(AssumeRoleWithWebIdentityRequest req)
        {
             JsonResponseModel<AssumeRoleWithWebIdentityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AssumeRoleWithWebIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AssumeRoleWithWebIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前调用者的身份信息。
        /// 接口支持主账号，子账号长期密钥以及AssumeRole，GetFederationToken生成的临时凭据的身份获取。
        /// </summary>
        /// <param name="req"><see cref="GetCallerIdentityRequest"/></param>
        /// <returns><see cref="GetCallerIdentityResponse"/></returns>
        public async Task<GetCallerIdentityResponse> GetCallerIdentity(GetCallerIdentityRequest req)
        {
             JsonResponseModel<GetCallerIdentityResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetCallerIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCallerIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取当前调用者的身份信息。
        /// 接口支持主账号，子账号长期密钥以及AssumeRole，GetFederationToken生成的临时凭据的身份获取。
        /// </summary>
        /// <param name="req"><see cref="GetCallerIdentityRequest"/></param>
        /// <returns><see cref="GetCallerIdentityResponse"/></returns>
        public GetCallerIdentityResponse GetCallerIdentitySync(GetCallerIdentityRequest req)
        {
             JsonResponseModel<GetCallerIdentityResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetCallerIdentity");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetCallerIdentityResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取联合身份临时访问凭证
        /// </summary>
        /// <param name="req"><see cref="GetFederationTokenRequest"/></param>
        /// <returns><see cref="GetFederationTokenResponse"/></returns>
        public async Task<GetFederationTokenResponse> GetFederationToken(GetFederationTokenRequest req)
        {
             JsonResponseModel<GetFederationTokenResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetFederationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFederationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取联合身份临时访问凭证
        /// </summary>
        /// <param name="req"><see cref="GetFederationTokenRequest"/></param>
        /// <returns><see cref="GetFederationTokenResponse"/></returns>
        public GetFederationTokenResponse GetFederationTokenSync(GetFederationTokenRequest req)
        {
             JsonResponseModel<GetFederationTokenResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetFederationToken");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetFederationTokenResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取API密钥列表
        /// </summary>
        /// <param name="req"><see cref="QueryApiKeyRequest"/></param>
        /// <returns><see cref="QueryApiKeyResponse"/></returns>
        public async Task<QueryApiKeyResponse> QueryApiKey(QueryApiKeyRequest req)
        {
             JsonResponseModel<QueryApiKeyResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "QueryApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取API密钥列表
        /// </summary>
        /// <param name="req"><see cref="QueryApiKeyRequest"/></param>
        /// <returns><see cref="QueryApiKeyResponse"/></returns>
        public QueryApiKeyResponse QueryApiKeySync(QueryApiKeyRequest req)
        {
             JsonResponseModel<QueryApiKeyResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "QueryApiKey");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<QueryApiKeyResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
