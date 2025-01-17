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

namespace TencentCloud.Dasb.V20191018
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Dasb.V20191018.Models;

   public class DasbClient : AbstractClient{

       private const string endpoint = "dasb.tencentcloudapi.com";
       private const string version = "2019-10-18";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public DasbClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public DasbClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 添加资产组成员
        /// </summary>
        /// <param name="req"><see cref="AddDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="AddDeviceGroupMembersResponse"/></returns>
        public async Task<AddDeviceGroupMembersResponse> AddDeviceGroupMembers(AddDeviceGroupMembersRequest req)
        {
             JsonResponseModel<AddDeviceGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddDeviceGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDeviceGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加资产组成员
        /// </summary>
        /// <param name="req"><see cref="AddDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="AddDeviceGroupMembersResponse"/></returns>
        public AddDeviceGroupMembersResponse AddDeviceGroupMembersSync(AddDeviceGroupMembersRequest req)
        {
             JsonResponseModel<AddDeviceGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddDeviceGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddDeviceGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加用户组成员
        /// </summary>
        /// <param name="req"><see cref="AddUserGroupMembersRequest"/></param>
        /// <returns><see cref="AddUserGroupMembersResponse"/></returns>
        public async Task<AddUserGroupMembersResponse> AddUserGroupMembers(AddUserGroupMembersRequest req)
        {
             JsonResponseModel<AddUserGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "AddUserGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 添加用户组成员
        /// </summary>
        /// <param name="req"><see cref="AddUserGroupMembersRequest"/></param>
        /// <returns><see cref="AddUserGroupMembersResponse"/></returns>
        public AddUserGroupMembersResponse AddUserGroupMembersSync(AddUserGroupMembersRequest req)
        {
             JsonResponseModel<AddUserGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "AddUserGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<AddUserGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改资产绑定的堡垒机服务
        /// </summary>
        /// <param name="req"><see cref="BindDeviceResourceRequest"/></param>
        /// <returns><see cref="BindDeviceResourceResponse"/></returns>
        public async Task<BindDeviceResourceResponse> BindDeviceResource(BindDeviceResourceRequest req)
        {
             JsonResponseModel<BindDeviceResourceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindDeviceResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDeviceResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改资产绑定的堡垒机服务
        /// </summary>
        /// <param name="req"><see cref="BindDeviceResourceRequest"/></param>
        /// <returns><see cref="BindDeviceResourceResponse"/></returns>
        public BindDeviceResourceResponse BindDeviceResourceSync(BindDeviceResourceRequest req)
        {
             JsonResponseModel<BindDeviceResourceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindDeviceResource");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindDeviceResourceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建访问权限
        /// </summary>
        /// <param name="req"><see cref="CreateAclRequest"/></param>
        /// <returns><see cref="CreateAclResponse"/></returns>
        public async Task<CreateAclResponse> CreateAcl(CreateAclRequest req)
        {
             JsonResponseModel<CreateAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建访问权限
        /// </summary>
        /// <param name="req"><see cref="CreateAclRequest"/></param>
        /// <returns><see cref="CreateAclResponse"/></returns>
        public CreateAclResponse CreateAclSync(CreateAclRequest req)
        {
             JsonResponseModel<CreateAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建资产组
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceGroupRequest"/></param>
        /// <returns><see cref="CreateDeviceGroupResponse"/></returns>
        public async Task<CreateDeviceGroupResponse> CreateDeviceGroup(CreateDeviceGroupRequest req)
        {
             JsonResponseModel<CreateDeviceGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateDeviceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建资产组
        /// </summary>
        /// <param name="req"><see cref="CreateDeviceGroupRequest"/></param>
        /// <returns><see cref="CreateDeviceGroupResponse"/></returns>
        public CreateDeviceGroupResponse CreateDeviceGroupSync(CreateDeviceGroupRequest req)
        {
             JsonResponseModel<CreateDeviceGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateDeviceGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateDeviceGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public async Task<CreateUserResponse> CreateUser(CreateUserRequest req)
        {
             JsonResponseModel<CreateUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建用户
        /// </summary>
        /// <param name="req"><see cref="CreateUserRequest"/></param>
        /// <returns><see cref="CreateUserResponse"/></returns>
        public CreateUserResponse CreateUserSync(CreateUserRequest req)
        {
             JsonResponseModel<CreateUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建用户组
        /// </summary>
        /// <param name="req"><see cref="CreateUserGroupRequest"/></param>
        /// <returns><see cref="CreateUserGroupResponse"/></returns>
        public async Task<CreateUserGroupResponse> CreateUserGroup(CreateUserGroupRequest req)
        {
             JsonResponseModel<CreateUserGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 新建用户组
        /// </summary>
        /// <param name="req"><see cref="CreateUserGroupRequest"/></param>
        /// <returns><see cref="CreateUserGroupResponse"/></returns>
        public CreateUserGroupResponse CreateUserGroupSync(CreateUserGroupRequest req)
        {
             JsonResponseModel<CreateUserGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUserGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUserGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除访问权限
        /// </summary>
        /// <param name="req"><see cref="DeleteAclsRequest"/></param>
        /// <returns><see cref="DeleteAclsResponse"/></returns>
        public async Task<DeleteAclsResponse> DeleteAcls(DeleteAclsRequest req)
        {
             JsonResponseModel<DeleteAclsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除访问权限
        /// </summary>
        /// <param name="req"><see cref="DeleteAclsRequest"/></param>
        /// <returns><see cref="DeleteAclsResponse"/></returns>
        public DeleteAclsResponse DeleteAclsSync(DeleteAclsRequest req)
        {
             JsonResponseModel<DeleteAclsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除资产组成员
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupMembersResponse"/></returns>
        public async Task<DeleteDeviceGroupMembersResponse> DeleteDeviceGroupMembers(DeleteDeviceGroupMembersRequest req)
        {
             JsonResponseModel<DeleteDeviceGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDeviceGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除资产组成员
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupMembersResponse"/></returns>
        public DeleteDeviceGroupMembersResponse DeleteDeviceGroupMembersSync(DeleteDeviceGroupMembersRequest req)
        {
             JsonResponseModel<DeleteDeviceGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDeviceGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除资产组
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupsRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupsResponse"/></returns>
        public async Task<DeleteDeviceGroupsResponse> DeleteDeviceGroups(DeleteDeviceGroupsRequest req)
        {
             JsonResponseModel<DeleteDeviceGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteDeviceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除资产组
        /// </summary>
        /// <param name="req"><see cref="DeleteDeviceGroupsRequest"/></param>
        /// <returns><see cref="DeleteDeviceGroupsResponse"/></returns>
        public DeleteDeviceGroupsResponse DeleteDeviceGroupsSync(DeleteDeviceGroupsRequest req)
        {
             JsonResponseModel<DeleteDeviceGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteDeviceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteDeviceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户组成员
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupMembersRequest"/></param>
        /// <returns><see cref="DeleteUserGroupMembersResponse"/></returns>
        public async Task<DeleteUserGroupMembersResponse> DeleteUserGroupMembers(DeleteUserGroupMembersRequest req)
        {
             JsonResponseModel<DeleteUserGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUserGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户组成员
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupMembersRequest"/></param>
        /// <returns><see cref="DeleteUserGroupMembersResponse"/></returns>
        public DeleteUserGroupMembersResponse DeleteUserGroupMembersSync(DeleteUserGroupMembersRequest req)
        {
             JsonResponseModel<DeleteUserGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUserGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户组
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupsRequest"/></param>
        /// <returns><see cref="DeleteUserGroupsResponse"/></returns>
        public async Task<DeleteUserGroupsResponse> DeleteUserGroups(DeleteUserGroupsRequest req)
        {
             JsonResponseModel<DeleteUserGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUserGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户组
        /// </summary>
        /// <param name="req"><see cref="DeleteUserGroupsRequest"/></param>
        /// <returns><see cref="DeleteUserGroupsResponse"/></returns>
        public DeleteUserGroupsResponse DeleteUserGroupsSync(DeleteUserGroupsRequest req)
        {
             JsonResponseModel<DeleteUserGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUserGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUserGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public async Task<DeleteUsersResponse> DeleteUsers(DeleteUsersRequest req)
        {
             JsonResponseModel<DeleteUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="req"><see cref="DeleteUsersRequest"/></param>
        /// <returns><see cref="DeleteUsersResponse"/></returns>
        public DeleteUsersResponse DeleteUsersSync(DeleteUsersRequest req)
        {
             JsonResponseModel<DeleteUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询访问权限列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAclsRequest"/></param>
        /// <returns><see cref="DescribeAclsResponse"/></returns>
        public async Task<DescribeAclsResponse> DescribeAcls(DescribeAclsRequest req)
        {
             JsonResponseModel<DescribeAclsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询访问权限列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAclsRequest"/></param>
        /// <returns><see cref="DescribeAclsResponse"/></returns>
        public DescribeAclsResponse DescribeAclsSync(DescribeAclsRequest req)
        {
             JsonResponseModel<DescribeAclsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAcls");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAclsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDasbImageIdsRequest"/></param>
        /// <returns><see cref="DescribeDasbImageIdsResponse"/></returns>
        public async Task<DescribeDasbImageIdsResponse> DescribeDasbImageIds(DescribeDasbImageIdsRequest req)
        {
             JsonResponseModel<DescribeDasbImageIdsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDasbImageIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDasbImageIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取镜像列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDasbImageIdsRequest"/></param>
        /// <returns><see cref="DescribeDasbImageIdsResponse"/></returns>
        public DescribeDasbImageIdsResponse DescribeDasbImageIdsSync(DescribeDasbImageIdsRequest req)
        {
             JsonResponseModel<DescribeDasbImageIdsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDasbImageIds");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDasbImageIdsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产组成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupMembersResponse"/></returns>
        public async Task<DescribeDeviceGroupMembersResponse> DescribeDeviceGroupMembers(DescribeDeviceGroupMembersRequest req)
        {
             JsonResponseModel<DescribeDeviceGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产组成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupMembersRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupMembersResponse"/></returns>
        public DescribeDeviceGroupMembersResponse DescribeDeviceGroupMembersSync(DescribeDeviceGroupMembersRequest req)
        {
             JsonResponseModel<DescribeDeviceGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupsRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupsResponse"/></returns>
        public async Task<DescribeDeviceGroupsResponse> DescribeDeviceGroups(DescribeDeviceGroupsRequest req)
        {
             JsonResponseModel<DescribeDeviceGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDeviceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDeviceGroupsRequest"/></param>
        /// <returns><see cref="DescribeDeviceGroupsResponse"/></returns>
        public DescribeDeviceGroupsResponse DescribeDeviceGroupsSync(DescribeDeviceGroupsRequest req)
        {
             JsonResponseModel<DescribeDeviceGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDeviceGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDeviceGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public async Task<DescribeDevicesResponse> DescribeDevices(DescribeDevicesRequest req)
        {
             JsonResponseModel<DescribeDevicesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询资产列表
        /// </summary>
        /// <param name="req"><see cref="DescribeDevicesRequest"/></param>
        /// <returns><see cref="DescribeDevicesResponse"/></returns>
        public DescribeDevicesResponse DescribeDevicesSync(DescribeDevicesRequest req)
        {
             JsonResponseModel<DescribeDevicesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeDevices");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeDevicesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户购买的堡垒机服务信息，包括资源ID、授权点数、VPC、过期时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public async Task<DescribeResourcesResponse> DescribeResources(DescribeResourcesRequest req)
        {
             JsonResponseModel<DescribeResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户购买的堡垒机服务信息，包括资源ID、授权点数、VPC、过期时间等。
        /// </summary>
        /// <param name="req"><see cref="DescribeResourcesRequest"/></param>
        /// <returns><see cref="DescribeResourcesResponse"/></returns>
        public DescribeResourcesResponse DescribeResourcesSync(DescribeResourcesRequest req)
        {
             JsonResponseModel<DescribeResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户组成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupMembersRequest"/></param>
        /// <returns><see cref="DescribeUserGroupMembersResponse"/></returns>
        public async Task<DescribeUserGroupMembersResponse> DescribeUserGroupMembers(DescribeUserGroupMembersRequest req)
        {
             JsonResponseModel<DescribeUserGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户组成员列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupMembersRequest"/></param>
        /// <returns><see cref="DescribeUserGroupMembersResponse"/></returns>
        public DescribeUserGroupMembersResponse DescribeUserGroupMembersSync(DescribeUserGroupMembersRequest req)
        {
             JsonResponseModel<DescribeUserGroupMembersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserGroupMembers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserGroupMembersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupsRequest"/></param>
        /// <returns><see cref="DescribeUserGroupsResponse"/></returns>
        public async Task<DescribeUserGroupsResponse> DescribeUserGroups(DescribeUserGroupsRequest req)
        {
             JsonResponseModel<DescribeUserGroupsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUserGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户组列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUserGroupsRequest"/></param>
        /// <returns><see cref="DescribeUserGroupsResponse"/></returns>
        public DescribeUserGroupsResponse DescribeUserGroupsSync(DescribeUserGroupsRequest req)
        {
             JsonResponseModel<DescribeUserGroupsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUserGroups");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUserGroupsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public async Task<DescribeUsersResponse> DescribeUsers(DescribeUsersRequest req)
        {
             JsonResponseModel<DescribeUsersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询用户列表
        /// </summary>
        /// <param name="req"><see cref="DescribeUsersRequest"/></param>
        /// <returns><see cref="DescribeUsersResponse"/></returns>
        public DescribeUsersResponse DescribeUsersSync(DescribeUsersRequest req)
        {
             JsonResponseModel<DescribeUsersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeUsers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeUsersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改访问权限
        /// </summary>
        /// <param name="req"><see cref="ModifyAclRequest"/></param>
        /// <returns><see cref="ModifyAclResponse"/></returns>
        public async Task<ModifyAclResponse> ModifyAcl(ModifyAclRequest req)
        {
             JsonResponseModel<ModifyAclResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改访问权限
        /// </summary>
        /// <param name="req"><see cref="ModifyAclRequest"/></param>
        /// <returns><see cref="ModifyAclResponse"/></returns>
        public ModifyAclResponse ModifyAclSync(ModifyAclRequest req)
        {
             JsonResponseModel<ModifyAclResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAcl");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAclResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public async Task<ModifyUserResponse> ModifyUser(ModifyUserRequest req)
        {
             JsonResponseModel<ModifyUserResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="req"><see cref="ModifyUserRequest"/></param>
        /// <returns><see cref="ModifyUserResponse"/></returns>
        public ModifyUserResponse ModifyUserSync(ModifyUserRequest req)
        {
             JsonResponseModel<ModifyUserResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyUser");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyUserResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
