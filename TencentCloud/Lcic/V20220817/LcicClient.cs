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

namespace TencentCloud.Lcic.V20220817
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Lcic.V20220817.Models;

   public class LcicClient : AbstractClient{

       private const string endpoint = "lcic.tencentcloudapi.com";
       private const string version = "2022-08-17";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public LcicClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public LcicClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 创建房间
        /// </summary>
        /// <param name="req"><see cref="CreateRoomRequest"/></param>
        /// <returns><see cref="CreateRoomResponse"/></returns>
        public async Task<CreateRoomResponse> CreateRoom(CreateRoomRequest req)
        {
             JsonResponseModel<CreateRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建房间
        /// </summary>
        /// <param name="req"><see cref="CreateRoomRequest"/></param>
        /// <returns><see cref="CreateRoomResponse"/></returns>
        public CreateRoomResponse CreateRoomSync(CreateRoomRequest req)
        {
             JsonResponseModel<CreateRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建巡课
        /// </summary>
        /// <param name="req"><see cref="CreateSupervisorRequest"/></param>
        /// <returns><see cref="CreateSupervisorResponse"/></returns>
        public async Task<CreateSupervisorResponse> CreateSupervisor(CreateSupervisorRequest req)
        {
             JsonResponseModel<CreateSupervisorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSupervisor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSupervisorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建巡课
        /// </summary>
        /// <param name="req"><see cref="CreateSupervisorRequest"/></param>
        /// <returns><see cref="CreateSupervisorResponse"/></returns>
        public CreateSupervisorResponse CreateSupervisorSync(CreateSupervisorRequest req)
        {
             JsonResponseModel<CreateSupervisorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSupervisor");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSupervisorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取房间信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomRequest"/></param>
        /// <returns><see cref="DescribeRoomResponse"/></returns>
        public async Task<DescribeRoomResponse> DescribeRoom(DescribeRoomRequest req)
        {
             JsonResponseModel<DescribeRoomResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取房间信息
        /// </summary>
        /// <param name="req"><see cref="DescribeRoomRequest"/></param>
        /// <returns><see cref="DescribeRoomResponse"/></returns>
        public DescribeRoomResponse DescribeRoomSync(DescribeRoomRequest req)
        {
             JsonResponseModel<DescribeRoomResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeRoom");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeRoomResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public async Task<DescribeUserResponse> DescribeUser(DescribeUserRequest req)
        {
             JsonResponseModel<DescribeUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="req"><see cref="DescribeUserRequest"/></param>
        /// <returns><see cref="DescribeUserResponse"/></returns>
        public DescribeUserResponse DescribeUserSync(DescribeUserRequest req)
        {
             JsonResponseModel<DescribeUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用源账号登录，源账号为注册时填入的originId
        /// </summary>
        /// <param name="req"><see cref="LoginOriginIdRequest"/></param>
        /// <returns><see cref="LoginOriginIdResponse"/></returns>
        public async Task<LoginOriginIdResponse> LoginOriginId(LoginOriginIdRequest req)
        {
             JsonResponseModel<LoginOriginIdResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LoginOriginId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LoginOriginIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 使用源账号登录，源账号为注册时填入的originId
        /// </summary>
        /// <param name="req"><see cref="LoginOriginIdRequest"/></param>
        /// <returns><see cref="LoginOriginIdResponse"/></returns>
        public LoginOriginIdResponse LoginOriginIdSync(LoginOriginIdRequest req)
        {
             JsonResponseModel<LoginOriginIdResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LoginOriginId");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LoginOriginIdResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="req"><see cref="LoginUserRequest"/></param>
        /// <returns><see cref="LoginUserResponse"/></returns>
        public async Task<LoginUserResponse> LoginUser(LoginUserRequest req)
        {
             JsonResponseModel<LoginUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "LoginUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LoginUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="req"><see cref="LoginUserRequest"/></param>
        /// <returns><see cref="LoginUserResponse"/></returns>
        public LoginUserResponse LoginUserSync(LoginUserRequest req)
        {
             JsonResponseModel<LoginUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "LoginUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<LoginUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="req"><see cref="RegisterUserRequest"/></param>
        /// <returns><see cref="RegisterUserResponse"/></returns>
        public async Task<RegisterUserResponse> RegisterUser(RegisterUserRequest req)
        {
             JsonResponseModel<RegisterUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RegisterUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="req"><see cref="RegisterUserRequest"/></param>
        /// <returns><see cref="RegisterUserResponse"/></returns>
        public RegisterUserResponse RegisterUserSync(RegisterUserRequest req)
        {
             JsonResponseModel<RegisterUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RegisterUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RegisterUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}