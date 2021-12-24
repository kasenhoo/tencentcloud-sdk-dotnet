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

namespace TencentCloud.Iecp.V20210914
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Iecp.V20210914.Models;

   public class IecpClient : AbstractClient{

       private const string endpoint = "iecp.tencentcloudapi.com";
       private const string version = "2021-09-14";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public IecpClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public IecpClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 从组件市场选中组件并添加到应用模板列表
        /// </summary>
        /// <param name="req"><see cref="ApplyMarketComponentRequest"/></param>
        /// <returns><see cref="ApplyMarketComponentResponse"/></returns>
        public async Task<ApplyMarketComponentResponse> ApplyMarketComponent(ApplyMarketComponentRequest req)
        {
             JsonResponseModel<ApplyMarketComponentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ApplyMarketComponent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyMarketComponentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 从组件市场选中组件并添加到应用模板列表
        /// </summary>
        /// <param name="req"><see cref="ApplyMarketComponentRequest"/></param>
        /// <returns><see cref="ApplyMarketComponentResponse"/></returns>
        public ApplyMarketComponentResponse ApplyMarketComponentSync(ApplyMarketComponentRequest req)
        {
             JsonResponseModel<ApplyMarketComponentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ApplyMarketComponent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ApplyMarketComponentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建可视化创建应用模板
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationVisualizationRequest"/></param>
        /// <returns><see cref="CreateApplicationVisualizationResponse"/></returns>
        public async Task<CreateApplicationVisualizationResponse> CreateApplicationVisualization(CreateApplicationVisualizationRequest req)
        {
             JsonResponseModel<CreateApplicationVisualizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateApplicationVisualization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationVisualizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建可视化创建应用模板
        /// </summary>
        /// <param name="req"><see cref="CreateApplicationVisualizationRequest"/></param>
        /// <returns><see cref="CreateApplicationVisualizationResponse"/></returns>
        public CreateApplicationVisualizationResponse CreateApplicationVisualizationSync(CreateApplicationVisualizationRequest req)
        {
             JsonResponseModel<CreateApplicationVisualizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateApplicationVisualization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateApplicationVisualizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建ConfigMap
        /// </summary>
        /// <param name="req"><see cref="CreateConfigMapRequest"/></param>
        /// <returns><see cref="CreateConfigMapResponse"/></returns>
        public async Task<CreateConfigMapResponse> CreateConfigMap(CreateConfigMapRequest req)
        {
             JsonResponseModel<CreateConfigMapResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateConfigMap");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConfigMapResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建ConfigMap
        /// </summary>
        /// <param name="req"><see cref="CreateConfigMapRequest"/></param>
        /// <returns><see cref="CreateConfigMapResponse"/></returns>
        public CreateConfigMapResponse CreateConfigMapSync(CreateConfigMapRequest req)
        {
             JsonResponseModel<CreateConfigMapResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateConfigMap");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateConfigMapResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘节点
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeResponse"/></returns>
        public async Task<CreateEdgeNodeResponse> CreateEdgeNode(CreateEdgeNodeRequest req)
        {
             JsonResponseModel<CreateEdgeNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEdgeNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘节点
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeResponse"/></returns>
        public CreateEdgeNodeResponse CreateEdgeNodeSync(CreateEdgeNodeRequest req)
        {
             JsonResponseModel<CreateEdgeNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEdgeNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘单元NodeGroup
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeGroupRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeGroupResponse"/></returns>
        public async Task<CreateEdgeNodeGroupResponse> CreateEdgeNodeGroup(CreateEdgeNodeGroupRequest req)
        {
             JsonResponseModel<CreateEdgeNodeGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEdgeNodeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeNodeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘单元NodeGroup
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeGroupRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeGroupResponse"/></returns>
        public CreateEdgeNodeGroupResponse CreateEdgeNodeGroupSync(CreateEdgeNodeGroupRequest req)
        {
             JsonResponseModel<CreateEdgeNodeGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEdgeNodeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeNodeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘单元NodeUnit模版
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeUnitTemplateRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeUnitTemplateResponse"/></returns>
        public async Task<CreateEdgeNodeUnitTemplateResponse> CreateEdgeNodeUnitTemplate(CreateEdgeNodeUnitTemplateRequest req)
        {
             JsonResponseModel<CreateEdgeNodeUnitTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEdgeNodeUnitTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeNodeUnitTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘单元NodeUnit模版
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeNodeUnitTemplateRequest"/></param>
        /// <returns><see cref="CreateEdgeNodeUnitTemplateResponse"/></returns>
        public CreateEdgeNodeUnitTemplateResponse CreateEdgeNodeUnitTemplateSync(CreateEdgeNodeUnitTemplateRequest req)
        {
             JsonResponseModel<CreateEdgeNodeUnitTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEdgeNodeUnitTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeNodeUnitTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可视化创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeUnitApplicationVisualizationRequest"/></param>
        /// <returns><see cref="CreateEdgeUnitApplicationVisualizationResponse"/></returns>
        public async Task<CreateEdgeUnitApplicationVisualizationResponse> CreateEdgeUnitApplicationVisualization(CreateEdgeUnitApplicationVisualizationRequest req)
        {
             JsonResponseModel<CreateEdgeUnitApplicationVisualizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEdgeUnitApplicationVisualization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeUnitApplicationVisualizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可视化创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeUnitApplicationVisualizationRequest"/></param>
        /// <returns><see cref="CreateEdgeUnitApplicationVisualizationResponse"/></returns>
        public CreateEdgeUnitApplicationVisualizationResponse CreateEdgeUnitApplicationVisualizationSync(CreateEdgeUnitApplicationVisualizationRequest req)
        {
             JsonResponseModel<CreateEdgeUnitApplicationVisualizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEdgeUnitApplicationVisualization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeUnitApplicationVisualizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// yaml方式创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeUnitApplicationYamlRequest"/></param>
        /// <returns><see cref="CreateEdgeUnitApplicationYamlResponse"/></returns>
        public async Task<CreateEdgeUnitApplicationYamlResponse> CreateEdgeUnitApplicationYaml(CreateEdgeUnitApplicationYamlRequest req)
        {
             JsonResponseModel<CreateEdgeUnitApplicationYamlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEdgeUnitApplicationYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeUnitApplicationYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// yaml方式创建应用
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeUnitApplicationYamlRequest"/></param>
        /// <returns><see cref="CreateEdgeUnitApplicationYamlResponse"/></returns>
        public CreateEdgeUnitApplicationYamlResponse CreateEdgeUnitApplicationYamlSync(CreateEdgeUnitApplicationYamlRequest req)
        {
             JsonResponseModel<CreateEdgeUnitApplicationYamlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEdgeUnitApplicationYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeUnitApplicationYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘单元
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeUnitCloudRequest"/></param>
        /// <returns><see cref="CreateEdgeUnitCloudResponse"/></returns>
        public async Task<CreateEdgeUnitCloudResponse> CreateEdgeUnitCloud(CreateEdgeUnitCloudRequest req)
        {
             JsonResponseModel<CreateEdgeUnitCloudResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateEdgeUnitCloud");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeUnitCloudResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建边缘单元
        /// </summary>
        /// <param name="req"><see cref="CreateEdgeUnitCloudRequest"/></param>
        /// <returns><see cref="CreateEdgeUnitCloudResponse"/></returns>
        public CreateEdgeUnitCloudResponse CreateEdgeUnitCloudSync(CreateEdgeUnitCloudRequest req)
        {
             JsonResponseModel<CreateEdgeUnitCloudResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateEdgeUnitCloud");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateEdgeUnitCloudResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public async Task<CreateNamespaceResponse> CreateNamespace(CreateNamespaceRequest req)
        {
             JsonResponseModel<CreateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建命名空间
        /// </summary>
        /// <param name="req"><see cref="CreateNamespaceRequest"/></param>
        /// <returns><see cref="CreateNamespaceResponse"/></returns>
        public CreateNamespaceResponse CreateNamespaceSync(CreateNamespaceRequest req)
        {
             JsonResponseModel<CreateNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Secret
        /// </summary>
        /// <param name="req"><see cref="CreateSecretRequest"/></param>
        /// <returns><see cref="CreateSecretResponse"/></returns>
        public async Task<CreateSecretResponse> CreateSecret(CreateSecretRequest req)
        {
             JsonResponseModel<CreateSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建Secret
        /// </summary>
        /// <param name="req"><see cref="CreateSecretRequest"/></param>
        /// <returns><see cref="CreateSecretResponse"/></returns>
        public CreateSecretResponse CreateSecretSync(CreateSecretRequest req)
        {
             JsonResponseModel<CreateSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建或更新边缘单元NodeUnit
        /// </summary>
        /// <param name="req"><see cref="CreateUpdateNodeUnitRequest"/></param>
        /// <returns><see cref="CreateUpdateNodeUnitResponse"/></returns>
        public async Task<CreateUpdateNodeUnitResponse> CreateUpdateNodeUnit(CreateUpdateNodeUnitRequest req)
        {
             JsonResponseModel<CreateUpdateNodeUnitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreateUpdateNodeUnit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUpdateNodeUnitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 创建或更新边缘单元NodeUnit
        /// </summary>
        /// <param name="req"><see cref="CreateUpdateNodeUnitRequest"/></param>
        /// <returns><see cref="CreateUpdateNodeUnitResponse"/></returns>
        public CreateUpdateNodeUnitResponse CreateUpdateNodeUnitSync(CreateUpdateNodeUnitRequest req)
        {
             JsonResponseModel<CreateUpdateNodeUnitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreateUpdateNodeUnit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreateUpdateNodeUnitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除应用模板
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationsRequest"/></param>
        /// <returns><see cref="DeleteApplicationsResponse"/></returns>
        public async Task<DeleteApplicationsResponse> DeleteApplications(DeleteApplicationsRequest req)
        {
             JsonResponseModel<DeleteApplicationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除应用模板
        /// </summary>
        /// <param name="req"><see cref="DeleteApplicationsRequest"/></param>
        /// <returns><see cref="DeleteApplicationsResponse"/></returns>
        public DeleteApplicationsResponse DeleteApplicationsSync(DeleteApplicationsRequest req)
        {
             JsonResponseModel<DeleteApplicationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除ConfigMap
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigMapRequest"/></param>
        /// <returns><see cref="DeleteConfigMapResponse"/></returns>
        public async Task<DeleteConfigMapResponse> DeleteConfigMap(DeleteConfigMapRequest req)
        {
             JsonResponseModel<DeleteConfigMapResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteConfigMap");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConfigMapResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除ConfigMap
        /// </summary>
        /// <param name="req"><see cref="DeleteConfigMapRequest"/></param>
        /// <returns><see cref="DeleteConfigMapResponse"/></returns>
        public DeleteConfigMapResponse DeleteConfigMapSync(DeleteConfigMapRequest req)
        {
             JsonResponseModel<DeleteConfigMapResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteConfigMap");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteConfigMapResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除边缘单元NodeGroup
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeNodeGroupRequest"/></param>
        /// <returns><see cref="DeleteEdgeNodeGroupResponse"/></returns>
        public async Task<DeleteEdgeNodeGroupResponse> DeleteEdgeNodeGroup(DeleteEdgeNodeGroupRequest req)
        {
             JsonResponseModel<DeleteEdgeNodeGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEdgeNodeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeNodeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除边缘单元NodeGroup
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeNodeGroupRequest"/></param>
        /// <returns><see cref="DeleteEdgeNodeGroupResponse"/></returns>
        public DeleteEdgeNodeGroupResponse DeleteEdgeNodeGroupSync(DeleteEdgeNodeGroupRequest req)
        {
             JsonResponseModel<DeleteEdgeNodeGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEdgeNodeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeNodeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除边缘单元NodeUnit模版
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeNodeUnitTemplatesRequest"/></param>
        /// <returns><see cref="DeleteEdgeNodeUnitTemplatesResponse"/></returns>
        public async Task<DeleteEdgeNodeUnitTemplatesResponse> DeleteEdgeNodeUnitTemplates(DeleteEdgeNodeUnitTemplatesRequest req)
        {
             JsonResponseModel<DeleteEdgeNodeUnitTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEdgeNodeUnitTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeNodeUnitTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除边缘单元NodeUnit模版
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeNodeUnitTemplatesRequest"/></param>
        /// <returns><see cref="DeleteEdgeNodeUnitTemplatesResponse"/></returns>
        public DeleteEdgeNodeUnitTemplatesResponse DeleteEdgeNodeUnitTemplatesSync(DeleteEdgeNodeUnitTemplatesRequest req)
        {
             JsonResponseModel<DeleteEdgeNodeUnitTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEdgeNodeUnitTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeNodeUnitTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除边缘节点
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeNodesRequest"/></param>
        /// <returns><see cref="DeleteEdgeNodesResponse"/></returns>
        public async Task<DeleteEdgeNodesResponse> DeleteEdgeNodes(DeleteEdgeNodesRequest req)
        {
             JsonResponseModel<DeleteEdgeNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEdgeNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 批量删除边缘节点
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeNodesRequest"/></param>
        /// <returns><see cref="DeleteEdgeNodesResponse"/></returns>
        public DeleteEdgeNodesResponse DeleteEdgeNodesSync(DeleteEdgeNodesRequest req)
        {
             JsonResponseModel<DeleteEdgeNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEdgeNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除应用列表
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitApplicationsRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitApplicationsResponse"/></returns>
        public async Task<DeleteEdgeUnitApplicationsResponse> DeleteEdgeUnitApplications(DeleteEdgeUnitApplicationsRequest req)
        {
             JsonResponseModel<DeleteEdgeUnitApplicationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEdgeUnitApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeUnitApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除应用列表
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitApplicationsRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitApplicationsResponse"/></returns>
        public DeleteEdgeUnitApplicationsResponse DeleteEdgeUnitApplicationsSync(DeleteEdgeUnitApplicationsRequest req)
        {
             JsonResponseModel<DeleteEdgeUnitApplicationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEdgeUnitApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeUnitApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除边缘单元
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitCloudRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitCloudResponse"/></returns>
        public async Task<DeleteEdgeUnitCloudResponse> DeleteEdgeUnitCloud(DeleteEdgeUnitCloudRequest req)
        {
             JsonResponseModel<DeleteEdgeUnitCloudResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEdgeUnitCloud");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeUnitCloudResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除边缘单元
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitCloudRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitCloudResponse"/></returns>
        public DeleteEdgeUnitCloudResponse DeleteEdgeUnitCloudSync(DeleteEdgeUnitCloudRequest req)
        {
             JsonResponseModel<DeleteEdgeUnitCloudResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEdgeUnitCloud");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeUnitCloudResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新部署边缘单元指定Grid下应用
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitDeployGridItemRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitDeployGridItemResponse"/></returns>
        public async Task<DeleteEdgeUnitDeployGridItemResponse> DeleteEdgeUnitDeployGridItem(DeleteEdgeUnitDeployGridItemRequest req)
        {
             JsonResponseModel<DeleteEdgeUnitDeployGridItemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEdgeUnitDeployGridItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeUnitDeployGridItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 重新部署边缘单元指定Grid下应用
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitDeployGridItemRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitDeployGridItemResponse"/></returns>
        public DeleteEdgeUnitDeployGridItemResponse DeleteEdgeUnitDeployGridItemSync(DeleteEdgeUnitDeployGridItemRequest req)
        {
             JsonResponseModel<DeleteEdgeUnitDeployGridItemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEdgeUnitDeployGridItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeUnitDeployGridItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除指定pod
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitPodRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitPodResponse"/></returns>
        public async Task<DeleteEdgeUnitPodResponse> DeleteEdgeUnitPod(DeleteEdgeUnitPodRequest req)
        {
             JsonResponseModel<DeleteEdgeUnitPodResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteEdgeUnitPod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeUnitPodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除指定pod
        /// </summary>
        /// <param name="req"><see cref="DeleteEdgeUnitPodRequest"/></param>
        /// <returns><see cref="DeleteEdgeUnitPodResponse"/></returns>
        public DeleteEdgeUnitPodResponse DeleteEdgeUnitPodSync(DeleteEdgeUnitPodRequest req)
        {
             JsonResponseModel<DeleteEdgeUnitPodResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteEdgeUnitPod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteEdgeUnitPodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public async Task<DeleteNamespaceResponse> DeleteNamespace(DeleteNamespaceRequest req)
        {
             JsonResponseModel<DeleteNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除命名空间
        /// </summary>
        /// <param name="req"><see cref="DeleteNamespaceRequest"/></param>
        /// <returns><see cref="DeleteNamespaceResponse"/></returns>
        public DeleteNamespaceResponse DeleteNamespaceSync(DeleteNamespaceRequest req)
        {
             JsonResponseModel<DeleteNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除边缘单元NodeUnit
        /// </summary>
        /// <param name="req"><see cref="DeleteNodeUnitRequest"/></param>
        /// <returns><see cref="DeleteNodeUnitResponse"/></returns>
        public async Task<DeleteNodeUnitResponse> DeleteNodeUnit(DeleteNodeUnitRequest req)
        {
             JsonResponseModel<DeleteNodeUnitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteNodeUnit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNodeUnitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除边缘单元NodeUnit
        /// </summary>
        /// <param name="req"><see cref="DeleteNodeUnitRequest"/></param>
        /// <returns><see cref="DeleteNodeUnitResponse"/></returns>
        public DeleteNodeUnitResponse DeleteNodeUnitSync(DeleteNodeUnitRequest req)
        {
             JsonResponseModel<DeleteNodeUnitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteNodeUnit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteNodeUnitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Secret
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretRequest"/></param>
        /// <returns><see cref="DeleteSecretResponse"/></returns>
        public async Task<DeleteSecretResponse> DeleteSecret(DeleteSecretRequest req)
        {
             JsonResponseModel<DeleteSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeleteSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除Secret
        /// </summary>
        /// <param name="req"><see cref="DeleteSecretRequest"/></param>
        /// <returns><see cref="DeleteSecretResponse"/></returns>
        public DeleteSecretResponse DeleteSecretSync(DeleteSecretRequest req)
        {
             JsonResponseModel<DeleteSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeleteSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeleteSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用模板可视化配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationVisualizationRequest"/></param>
        /// <returns><see cref="DescribeApplicationVisualizationResponse"/></returns>
        public async Task<DescribeApplicationVisualizationResponse> DescribeApplicationVisualization(DescribeApplicationVisualizationRequest req)
        {
             JsonResponseModel<DescribeApplicationVisualizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationVisualization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationVisualizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用模板可视化配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationVisualizationRequest"/></param>
        /// <returns><see cref="DescribeApplicationVisualizationResponse"/></returns>
        public DescribeApplicationVisualizationResponse DescribeApplicationVisualizationSync(DescribeApplicationVisualizationRequest req)
        {
             JsonResponseModel<DescribeApplicationVisualizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationVisualization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationVisualizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询应用模板Yaml
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationYamlRequest"/></param>
        /// <returns><see cref="DescribeApplicationYamlResponse"/></returns>
        public async Task<DescribeApplicationYamlResponse> DescribeApplicationYaml(DescribeApplicationYamlRequest req)
        {
             JsonResponseModel<DescribeApplicationYamlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询应用模板Yaml
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationYamlRequest"/></param>
        /// <returns><see cref="DescribeApplicationYamlResponse"/></returns>
        public DescribeApplicationYamlResponse DescribeApplicationYamlSync(DescribeApplicationYamlRequest req)
        {
             JsonResponseModel<DescribeApplicationYamlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查应用模板的Yaml配置
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeApplicationYamlErrorResponse"/></returns>
        public async Task<DescribeApplicationYamlErrorResponse> DescribeApplicationYamlError(DescribeApplicationYamlErrorRequest req)
        {
             JsonResponseModel<DescribeApplicationYamlErrorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplicationYamlError");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationYamlErrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查应用模板的Yaml配置
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeApplicationYamlErrorResponse"/></returns>
        public DescribeApplicationYamlErrorResponse DescribeApplicationYamlErrorSync(DescribeApplicationYamlErrorRequest req)
        {
             JsonResponseModel<DescribeApplicationYamlErrorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplicationYamlError");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationYamlErrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public async Task<DescribeApplicationsResponse> DescribeApplications(DescribeApplicationsRequest req)
        {
             JsonResponseModel<DescribeApplicationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用模板列表
        /// </summary>
        /// <param name="req"><see cref="DescribeApplicationsRequest"/></param>
        /// <returns><see cref="DescribeApplicationsResponse"/></returns>
        public DescribeApplicationsResponse DescribeApplicationsSync(DescribeApplicationsRequest req)
        {
             JsonResponseModel<DescribeApplicationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ConfigMap详情
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMapRequest"/></param>
        /// <returns><see cref="DescribeConfigMapResponse"/></returns>
        public async Task<DescribeConfigMapResponse> DescribeConfigMap(DescribeConfigMapRequest req)
        {
             JsonResponseModel<DescribeConfigMapResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfigMap");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigMapResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ConfigMap详情
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMapRequest"/></param>
        /// <returns><see cref="DescribeConfigMapResponse"/></returns>
        public DescribeConfigMapResponse DescribeConfigMapSync(DescribeConfigMapRequest req)
        {
             JsonResponseModel<DescribeConfigMapResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfigMap");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigMapResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 校验ConfigMap的Yaml语法
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMapYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeConfigMapYamlErrorResponse"/></returns>
        public async Task<DescribeConfigMapYamlErrorResponse> DescribeConfigMapYamlError(DescribeConfigMapYamlErrorRequest req)
        {
             JsonResponseModel<DescribeConfigMapYamlErrorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfigMapYamlError");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigMapYamlErrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 校验ConfigMap的Yaml语法
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMapYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeConfigMapYamlErrorResponse"/></returns>
        public DescribeConfigMapYamlErrorResponse DescribeConfigMapYamlErrorSync(DescribeConfigMapYamlErrorRequest req)
        {
             JsonResponseModel<DescribeConfigMapYamlErrorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfigMapYamlError");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigMapYamlErrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ConfigMap列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMapsRequest"/></param>
        /// <returns><see cref="DescribeConfigMapsResponse"/></returns>
        public async Task<DescribeConfigMapsResponse> DescribeConfigMaps(DescribeConfigMapsRequest req)
        {
             JsonResponseModel<DescribeConfigMapsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeConfigMaps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigMapsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取ConfigMap列表
        /// </summary>
        /// <param name="req"><see cref="DescribeConfigMapsRequest"/></param>
        /// <returns><see cref="DescribeConfigMapsResponse"/></returns>
        public DescribeConfigMapsResponse DescribeConfigMapsSync(DescribeConfigMapsRequest req)
        {
             JsonResponseModel<DescribeConfigMapsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeConfigMaps");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeConfigMapsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取节点安装信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeAgentNodeInstallerRequest"/></param>
        /// <returns><see cref="DescribeEdgeAgentNodeInstallerResponse"/></returns>
        public async Task<DescribeEdgeAgentNodeInstallerResponse> DescribeEdgeAgentNodeInstaller(DescribeEdgeAgentNodeInstallerRequest req)
        {
             JsonResponseModel<DescribeEdgeAgentNodeInstallerResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeAgentNodeInstaller");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeAgentNodeInstallerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取节点安装信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeAgentNodeInstallerRequest"/></param>
        /// <returns><see cref="DescribeEdgeAgentNodeInstallerResponse"/></returns>
        public DescribeEdgeAgentNodeInstallerResponse DescribeEdgeAgentNodeInstallerSync(DescribeEdgeAgentNodeInstallerRequest req)
        {
             JsonResponseModel<DescribeEdgeAgentNodeInstallerResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeAgentNodeInstaller");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeAgentNodeInstallerResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边缘集群默认VPC信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeDefaultVpcRequest"/></param>
        /// <returns><see cref="DescribeEdgeDefaultVpcResponse"/></returns>
        public async Task<DescribeEdgeDefaultVpcResponse> DescribeEdgeDefaultVpc(DescribeEdgeDefaultVpcRequest req)
        {
             JsonResponseModel<DescribeEdgeDefaultVpcResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeDefaultVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeDefaultVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边缘集群默认VPC信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeDefaultVpcRequest"/></param>
        /// <returns><see cref="DescribeEdgeDefaultVpcResponse"/></returns>
        public DescribeEdgeDefaultVpcResponse DescribeEdgeDefaultVpcSync(DescribeEdgeDefaultVpcRequest req)
        {
             JsonResponseModel<DescribeEdgeDefaultVpcResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeDefaultVpc");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeDefaultVpcResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边缘节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodeRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodeResponse"/></returns>
        public async Task<DescribeEdgeNodeResponse> DescribeEdgeNode(DescribeEdgeNodeRequest req)
        {
             JsonResponseModel<DescribeEdgeNodeResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取边缘节点信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodeRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodeResponse"/></returns>
        public DescribeEdgeNodeResponse DescribeEdgeNodeSync(DescribeEdgeNodeRequest req)
        {
             JsonResponseModel<DescribeEdgeNodeResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeNode");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeNodeResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询节点Pod内的容器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodePodContainersRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodePodContainersResponse"/></returns>
        public async Task<DescribeEdgeNodePodContainersResponse> DescribeEdgeNodePodContainers(DescribeEdgeNodePodContainersRequest req)
        {
             JsonResponseModel<DescribeEdgeNodePodContainersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeNodePodContainers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeNodePodContainersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询节点Pod内的容器列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodePodContainersRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodePodContainersResponse"/></returns>
        public DescribeEdgeNodePodContainersResponse DescribeEdgeNodePodContainersSync(DescribeEdgeNodePodContainersRequest req)
        {
             JsonResponseModel<DescribeEdgeNodePodContainersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeNodePodContainers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeNodePodContainersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询节点Pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodePodsRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodePodsResponse"/></returns>
        public async Task<DescribeEdgeNodePodsResponse> DescribeEdgeNodePods(DescribeEdgeNodePodsRequest req)
        {
             JsonResponseModel<DescribeEdgeNodePodsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeNodePods");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeNodePodsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询节点Pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodePodsRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodePodsResponse"/></returns>
        public DescribeEdgeNodePodsResponse DescribeEdgeNodePodsSync(DescribeEdgeNodePodsRequest req)
        {
             JsonResponseModel<DescribeEdgeNodePodsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeNodePods");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeNodePodsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodesRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodesResponse"/></returns>
        public async Task<DescribeEdgeNodesResponse> DescribeEdgeNodes(DescribeEdgeNodesRequest req)
        {
             JsonResponseModel<DescribeEdgeNodesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘节点列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeNodesRequest"/></param>
        /// <returns><see cref="DescribeEdgeNodesResponse"/></returns>
        public DescribeEdgeNodesResponse DescribeEdgeNodesSync(DescribeEdgeNodesRequest req)
        {
             JsonResponseModel<DescribeEdgeNodesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeNodes");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeNodesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeEdgeOperationLogsResponse"/></returns>
        public async Task<DescribeEdgeOperationLogsResponse> DescribeEdgeOperationLogs(DescribeEdgeOperationLogsRequest req)
        {
             JsonResponseModel<DescribeEdgeOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘操作日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeOperationLogsRequest"/></param>
        /// <returns><see cref="DescribeEdgeOperationLogsResponse"/></returns>
        public DescribeEdgeOperationLogsResponse DescribeEdgeOperationLogsSync(DescribeEdgeOperationLogsRequest req)
        {
             JsonResponseModel<DescribeEdgeOperationLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeOperationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeOperationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元Pod
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgePodRequest"/></param>
        /// <returns><see cref="DescribeEdgePodResponse"/></returns>
        public async Task<DescribeEdgePodResponse> DescribeEdgePod(DescribeEdgePodRequest req)
        {
             JsonResponseModel<DescribeEdgePodResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgePod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgePodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元Pod
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgePodRequest"/></param>
        /// <returns><see cref="DescribeEdgePodResponse"/></returns>
        public DescribeEdgePodResponse DescribeEdgePodSync(DescribeEdgePodRequest req)
        {
             JsonResponseModel<DescribeEdgePodResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgePod");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgePodResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationEventsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationEventsResponse"/></returns>
        public async Task<DescribeEdgeUnitApplicationEventsResponse> DescribeEdgeUnitApplicationEvents(DescribeEdgeUnitApplicationEventsRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitApplicationEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationEventsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationEventsResponse"/></returns>
        public DescribeEdgeUnitApplicationEventsResponse DescribeEdgeUnitApplicationEventsSync(DescribeEdgeUnitApplicationEventsRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitApplicationEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationLogsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationLogsResponse"/></returns>
        public async Task<DescribeEdgeUnitApplicationLogsResponse> DescribeEdgeUnitApplicationLogs(DescribeEdgeUnitApplicationLogsRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationLogsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitApplicationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用日志
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationLogsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationLogsResponse"/></returns>
        public DescribeEdgeUnitApplicationLogsResponse DescribeEdgeUnitApplicationLogsSync(DescribeEdgeUnitApplicationLogsRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationLogsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitApplicationLogs");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationLogsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用容器状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationPodContainersRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationPodContainersResponse"/></returns>
        public async Task<DescribeEdgeUnitApplicationPodContainersResponse> DescribeEdgeUnitApplicationPodContainers(DescribeEdgeUnitApplicationPodContainersRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationPodContainersResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitApplicationPodContainers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationPodContainersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用容器状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationPodContainersRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationPodContainersResponse"/></returns>
        public DescribeEdgeUnitApplicationPodContainersResponse DescribeEdgeUnitApplicationPodContainersSync(DescribeEdgeUnitApplicationPodContainersRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationPodContainersResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitApplicationPodContainers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationPodContainersResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用下Pod状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationPodsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationPodsResponse"/></returns>
        public async Task<DescribeEdgeUnitApplicationPodsResponse> DescribeEdgeUnitApplicationPods(DescribeEdgeUnitApplicationPodsRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationPodsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitApplicationPods");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationPodsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用下Pod状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationPodsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationPodsResponse"/></returns>
        public DescribeEdgeUnitApplicationPodsResponse DescribeEdgeUnitApplicationPodsSync(DescribeEdgeUnitApplicationPodsRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationPodsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitApplicationPods");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationPodsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单元可视化配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationVisualizationRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationVisualizationResponse"/></returns>
        public async Task<DescribeEdgeUnitApplicationVisualizationResponse> DescribeEdgeUnitApplicationVisualization(DescribeEdgeUnitApplicationVisualizationRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationVisualizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitApplicationVisualization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationVisualizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单元可视化配置信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationVisualizationRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationVisualizationResponse"/></returns>
        public DescribeEdgeUnitApplicationVisualizationResponse DescribeEdgeUnitApplicationVisualizationSync(DescribeEdgeUnitApplicationVisualizationRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationVisualizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitApplicationVisualization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationVisualizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用的Yaml配置
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationYamlRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationYamlResponse"/></returns>
        public async Task<DescribeEdgeUnitApplicationYamlResponse> DescribeEdgeUnitApplicationYaml(DescribeEdgeUnitApplicationYamlRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationYamlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitApplicationYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取应用的Yaml配置
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationYamlRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationYamlResponse"/></returns>
        public DescribeEdgeUnitApplicationYamlResponse DescribeEdgeUnitApplicationYamlSync(DescribeEdgeUnitApplicationYamlRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationYamlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitApplicationYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查单元应用的Yaml配置
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationYamlErrorResponse"/></returns>
        public async Task<DescribeEdgeUnitApplicationYamlErrorResponse> DescribeEdgeUnitApplicationYamlError(DescribeEdgeUnitApplicationYamlErrorRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationYamlErrorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitApplicationYamlError");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationYamlErrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 检查单元应用的Yaml配置
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationYamlErrorResponse"/></returns>
        public DescribeEdgeUnitApplicationYamlErrorResponse DescribeEdgeUnitApplicationYamlErrorSync(DescribeEdgeUnitApplicationYamlErrorRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationYamlErrorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitApplicationYamlError");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationYamlErrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单元下应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationsResponse"/></returns>
        public async Task<DescribeEdgeUnitApplicationsResponse> DescribeEdgeUnitApplications(DescribeEdgeUnitApplicationsRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取单元下应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitApplicationsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitApplicationsResponse"/></returns>
        public DescribeEdgeUnitApplicationsResponse DescribeEdgeUnitApplicationsSync(DescribeEdgeUnitApplicationsRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitApplicationsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitApplications");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitApplicationsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘集群详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitCloudRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitCloudResponse"/></returns>
        public async Task<DescribeEdgeUnitCloudResponse> DescribeEdgeUnitCloud(DescribeEdgeUnitCloudRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitCloudResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitCloud");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitCloudResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘集群详情
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitCloudRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitCloudResponse"/></returns>
        public DescribeEdgeUnitCloudResponse DescribeEdgeUnitCloudSync(DescribeEdgeUnitCloudRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitCloudResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitCloud");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitCloudResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元Grid列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitDeployGridRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitDeployGridResponse"/></returns>
        public async Task<DescribeEdgeUnitDeployGridResponse> DescribeEdgeUnitDeployGrid(DescribeEdgeUnitDeployGridRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitDeployGridResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitDeployGrid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitDeployGridResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元Grid列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitDeployGridRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitDeployGridResponse"/></returns>
        public DescribeEdgeUnitDeployGridResponse DescribeEdgeUnitDeployGridSync(DescribeEdgeUnitDeployGridRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitDeployGridResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitDeployGrid");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitDeployGridResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元指定Grid下的部署应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitDeployGridItemRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitDeployGridItemResponse"/></returns>
        public async Task<DescribeEdgeUnitDeployGridItemResponse> DescribeEdgeUnitDeployGridItem(DescribeEdgeUnitDeployGridItemRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitDeployGridItemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitDeployGridItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitDeployGridItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元指定Grid下的部署应用列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitDeployGridItemRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitDeployGridItemResponse"/></returns>
        public DescribeEdgeUnitDeployGridItemResponse DescribeEdgeUnitDeployGridItemSync(DescribeEdgeUnitDeployGridItemRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitDeployGridItemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitDeployGridItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitDeployGridItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定Grid下应用的Yaml
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitDeployGridItemYamlRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitDeployGridItemYamlResponse"/></returns>
        public async Task<DescribeEdgeUnitDeployGridItemYamlResponse> DescribeEdgeUnitDeployGridItemYaml(DescribeEdgeUnitDeployGridItemYamlRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitDeployGridItemYamlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitDeployGridItemYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitDeployGridItemYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定Grid下应用的Yaml
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitDeployGridItemYamlRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitDeployGridItemYamlResponse"/></returns>
        public DescribeEdgeUnitDeployGridItemYamlResponse DescribeEdgeUnitDeployGridItemYamlSync(DescribeEdgeUnitDeployGridItemYamlRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitDeployGridItemYamlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitDeployGridItemYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitDeployGridItemYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元额外信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitExtraRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitExtraResponse"/></returns>
        public async Task<DescribeEdgeUnitExtraResponse> DescribeEdgeUnitExtra(DescribeEdgeUnitExtraRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitExtraResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitExtra");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitExtraResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元额外信息
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitExtraRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitExtraResponse"/></returns>
        public DescribeEdgeUnitExtraResponse DescribeEdgeUnitExtraSync(DescribeEdgeUnitExtraRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitExtraResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitExtra");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitExtraResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元Grid事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitGridEventsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitGridEventsResponse"/></returns>
        public async Task<DescribeEdgeUnitGridEventsResponse> DescribeEdgeUnitGridEvents(DescribeEdgeUnitGridEventsRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitGridEventsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitGridEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitGridEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元Grid事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitGridEventsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitGridEventsResponse"/></returns>
        public DescribeEdgeUnitGridEventsResponse DescribeEdgeUnitGridEventsSync(DescribeEdgeUnitGridEventsRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitGridEventsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitGridEvents");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitGridEventsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元Grid的Pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitGridPodsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitGridPodsResponse"/></returns>
        public async Task<DescribeEdgeUnitGridPodsResponse> DescribeEdgeUnitGridPods(DescribeEdgeUnitGridPodsRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitGridPodsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitGridPods");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitGridPodsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元Grid的Pod列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitGridPodsRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitGridPodsResponse"/></returns>
        public DescribeEdgeUnitGridPodsResponse DescribeEdgeUnitGridPodsSync(DescribeEdgeUnitGridPodsRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitGridPodsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitGridPods");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitGridPodsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘集群监控状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitMonitorStatusRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitMonitorStatusResponse"/></returns>
        public async Task<DescribeEdgeUnitMonitorStatusResponse> DescribeEdgeUnitMonitorStatus(DescribeEdgeUnitMonitorStatusRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitMonitorStatusResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitMonitorStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitMonitorStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘集群监控状态
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitMonitorStatusRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitMonitorStatusResponse"/></returns>
        public DescribeEdgeUnitMonitorStatusResponse DescribeEdgeUnitMonitorStatusSync(DescribeEdgeUnitMonitorStatusRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitMonitorStatusResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitMonitorStatus");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitMonitorStatusResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘集群NodeGroup
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitNodeGroupRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitNodeGroupResponse"/></returns>
        public async Task<DescribeEdgeUnitNodeGroupResponse> DescribeEdgeUnitNodeGroup(DescribeEdgeUnitNodeGroupRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitNodeGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitNodeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitNodeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘集群NodeGroup
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitNodeGroupRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitNodeGroupResponse"/></returns>
        public DescribeEdgeUnitNodeGroupResponse DescribeEdgeUnitNodeGroupSync(DescribeEdgeUnitNodeGroupRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitNodeGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitNodeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitNodeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元EdgeUnit模版列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitNodeUnitTemplatesRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitNodeUnitTemplatesResponse"/></returns>
        public async Task<DescribeEdgeUnitNodeUnitTemplatesResponse> DescribeEdgeUnitNodeUnitTemplates(DescribeEdgeUnitNodeUnitTemplatesRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitNodeUnitTemplatesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitNodeUnitTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitNodeUnitTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元EdgeUnit模版列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitNodeUnitTemplatesRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitNodeUnitTemplatesResponse"/></returns>
        public DescribeEdgeUnitNodeUnitTemplatesResponse DescribeEdgeUnitNodeUnitTemplatesSync(DescribeEdgeUnitNodeUnitTemplatesRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitNodeUnitTemplatesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitNodeUnitTemplates");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitNodeUnitTemplatesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitsCloudRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitsCloudResponse"/></returns>
        public async Task<DescribeEdgeUnitsCloudResponse> DescribeEdgeUnitsCloud(DescribeEdgeUnitsCloudRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitsCloudResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeEdgeUnitsCloud");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitsCloudResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元列表
        /// </summary>
        /// <param name="req"><see cref="DescribeEdgeUnitsCloudRequest"/></param>
        /// <returns><see cref="DescribeEdgeUnitsCloudResponse"/></returns>
        public DescribeEdgeUnitsCloudResponse DescribeEdgeUnitsCloudSync(DescribeEdgeUnitsCloudRequest req)
        {
             JsonResponseModel<DescribeEdgeUnitsCloudResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeEdgeUnitsCloud");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeEdgeUnitsCloudResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元监控数据
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorMetricsRequest"/></param>
        /// <returns><see cref="DescribeMonitorMetricsResponse"/></returns>
        public async Task<DescribeMonitorMetricsResponse> DescribeMonitorMetrics(DescribeMonitorMetricsRequest req)
        {
             JsonResponseModel<DescribeMonitorMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeMonitorMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonitorMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元监控数据
        /// </summary>
        /// <param name="req"><see cref="DescribeMonitorMetricsRequest"/></param>
        /// <returns><see cref="DescribeMonitorMetricsResponse"/></returns>
        public DescribeMonitorMetricsResponse DescribeMonitorMetricsSync(DescribeMonitorMetricsRequest req)
        {
             JsonResponseModel<DescribeMonitorMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeMonitorMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeMonitorMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取命名空间
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespaceRequest"/></param>
        /// <returns><see cref="DescribeNamespaceResponse"/></returns>
        public async Task<DescribeNamespaceResponse> DescribeNamespace(DescribeNamespaceRequest req)
        {
             JsonResponseModel<DescribeNamespaceResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取命名空间
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespaceRequest"/></param>
        /// <returns><see cref="DescribeNamespaceResponse"/></returns>
        public DescribeNamespaceResponse DescribeNamespaceSync(DescribeNamespaceRequest req)
        {
             JsonResponseModel<DescribeNamespaceResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNamespace");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNamespaceResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取命名空间下的资源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespaceResourcesRequest"/></param>
        /// <returns><see cref="DescribeNamespaceResourcesResponse"/></returns>
        public async Task<DescribeNamespaceResourcesResponse> DescribeNamespaceResources(DescribeNamespaceResourcesRequest req)
        {
             JsonResponseModel<DescribeNamespaceResourcesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNamespaceResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNamespaceResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取命名空间下的资源信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespaceResourcesRequest"/></param>
        /// <returns><see cref="DescribeNamespaceResourcesResponse"/></returns>
        public DescribeNamespaceResourcesResponse DescribeNamespaceResourcesSync(DescribeNamespaceResourcesRequest req)
        {
             JsonResponseModel<DescribeNamespaceResourcesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNamespaceResources");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNamespaceResourcesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取命名空间列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacesRequest"/></param>
        /// <returns><see cref="DescribeNamespacesResponse"/></returns>
        public async Task<DescribeNamespacesResponse> DescribeNamespaces(DescribeNamespacesRequest req)
        {
             JsonResponseModel<DescribeNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取命名空间列表信息
        /// </summary>
        /// <param name="req"><see cref="DescribeNamespacesRequest"/></param>
        /// <returns><see cref="DescribeNamespacesResponse"/></returns>
        public DescribeNamespacesResponse DescribeNamespacesSync(DescribeNamespacesRequest req)
        {
             JsonResponseModel<DescribeNamespacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元NodeUnit列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeUnitRequest"/></param>
        /// <returns><see cref="DescribeNodeUnitResponse"/></returns>
        public async Task<DescribeNodeUnitResponse> DescribeNodeUnit(DescribeNodeUnitRequest req)
        {
             JsonResponseModel<DescribeNodeUnitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNodeUnit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNodeUnitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询边缘单元NodeUnit列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeUnitRequest"/></param>
        /// <returns><see cref="DescribeNodeUnitResponse"/></returns>
        public DescribeNodeUnitResponse DescribeNodeUnitSync(DescribeNodeUnitRequest req)
        {
             JsonResponseModel<DescribeNodeUnitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNodeUnit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNodeUnitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定NodeGroup下NodeUnit模版列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeUnitTemplateOnNodeGroupRequest"/></param>
        /// <returns><see cref="DescribeNodeUnitTemplateOnNodeGroupResponse"/></returns>
        public async Task<DescribeNodeUnitTemplateOnNodeGroupResponse> DescribeNodeUnitTemplateOnNodeGroup(DescribeNodeUnitTemplateOnNodeGroupRequest req)
        {
             JsonResponseModel<DescribeNodeUnitTemplateOnNodeGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeNodeUnitTemplateOnNodeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNodeUnitTemplateOnNodeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询指定NodeGroup下NodeUnit模版列表
        /// </summary>
        /// <param name="req"><see cref="DescribeNodeUnitTemplateOnNodeGroupRequest"/></param>
        /// <returns><see cref="DescribeNodeUnitTemplateOnNodeGroupResponse"/></returns>
        public DescribeNodeUnitTemplateOnNodeGroupResponse DescribeNodeUnitTemplateOnNodeGroupSync(DescribeNodeUnitTemplateOnNodeGroupRequest req)
        {
             JsonResponseModel<DescribeNodeUnitTemplateOnNodeGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeNodeUnitTemplateOnNodeGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeNodeUnitTemplateOnNodeGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Secret详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretRequest"/></param>
        /// <returns><see cref="DescribeSecretResponse"/></returns>
        public async Task<DescribeSecretResponse> DescribeSecret(DescribeSecretRequest req)
        {
             JsonResponseModel<DescribeSecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Secret详情
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretRequest"/></param>
        /// <returns><see cref="DescribeSecretResponse"/></returns>
        public DescribeSecretResponse DescribeSecretSync(DescribeSecretRequest req)
        {
             JsonResponseModel<DescribeSecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 校验Secret的Yaml语法
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeSecretYamlErrorResponse"/></returns>
        public async Task<DescribeSecretYamlErrorResponse> DescribeSecretYamlError(DescribeSecretYamlErrorRequest req)
        {
             JsonResponseModel<DescribeSecretYamlErrorResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecretYamlError");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecretYamlErrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 校验Secret的Yaml语法
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretYamlErrorRequest"/></param>
        /// <returns><see cref="DescribeSecretYamlErrorResponse"/></returns>
        public DescribeSecretYamlErrorResponse DescribeSecretYamlErrorSync(DescribeSecretYamlErrorRequest req)
        {
             JsonResponseModel<DescribeSecretYamlErrorResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecretYamlError");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecretYamlErrorResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Secrets列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretsRequest"/></param>
        /// <returns><see cref="DescribeSecretsResponse"/></returns>
        public async Task<DescribeSecretsResponse> DescribeSecrets(DescribeSecretsRequest req)
        {
             JsonResponseModel<DescribeSecretsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeSecrets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecretsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取Secrets列表
        /// </summary>
        /// <param name="req"><see cref="DescribeSecretsRequest"/></param>
        /// <returns><see cref="DescribeSecretsResponse"/></returns>
        public DescribeSecretsResponse DescribeSecretsSync(DescribeSecretsRequest req)
        {
             JsonResponseModel<DescribeSecretsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeSecrets");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeSecretsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取组件市场的组件信息
        /// </summary>
        /// <param name="req"><see cref="GetMarketComponentRequest"/></param>
        /// <returns><see cref="GetMarketComponentResponse"/></returns>
        public async Task<GetMarketComponentResponse> GetMarketComponent(GetMarketComponentRequest req)
        {
             JsonResponseModel<GetMarketComponentResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetMarketComponent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMarketComponentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取组件市场的组件信息
        /// </summary>
        /// <param name="req"><see cref="GetMarketComponentRequest"/></param>
        /// <returns><see cref="GetMarketComponentResponse"/></returns>
        public GetMarketComponentResponse GetMarketComponentSync(GetMarketComponentRequest req)
        {
             JsonResponseModel<GetMarketComponentResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetMarketComponent");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMarketComponentResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取组件市场组件列表
        /// </summary>
        /// <param name="req"><see cref="GetMarketComponentListRequest"/></param>
        /// <returns><see cref="GetMarketComponentListResponse"/></returns>
        public async Task<GetMarketComponentListResponse> GetMarketComponentList(GetMarketComponentListRequest req)
        {
             JsonResponseModel<GetMarketComponentListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetMarketComponentList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMarketComponentListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取组件市场组件列表
        /// </summary>
        /// <param name="req"><see cref="GetMarketComponentListRequest"/></param>
        /// <returns><see cref="GetMarketComponentListResponse"/></returns>
        public GetMarketComponentListResponse GetMarketComponentListSync(GetMarketComponentListRequest req)
        {
             JsonResponseModel<GetMarketComponentListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetMarketComponentList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMarketComponentListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改应用模板基本信息
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationBasicInfoRequest"/></param>
        /// <returns><see cref="ModifyApplicationBasicInfoResponse"/></returns>
        public async Task<ModifyApplicationBasicInfoResponse> ModifyApplicationBasicInfo(ModifyApplicationBasicInfoRequest req)
        {
             JsonResponseModel<ModifyApplicationBasicInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplicationBasicInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationBasicInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改应用模板基本信息
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationBasicInfoRequest"/></param>
        /// <returns><see cref="ModifyApplicationBasicInfoResponse"/></returns>
        public ModifyApplicationBasicInfoResponse ModifyApplicationBasicInfoSync(ModifyApplicationBasicInfoRequest req)
        {
             JsonResponseModel<ModifyApplicationBasicInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplicationBasicInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationBasicInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改应用模板配置
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationVisualizationRequest"/></param>
        /// <returns><see cref="ModifyApplicationVisualizationResponse"/></returns>
        public async Task<ModifyApplicationVisualizationResponse> ModifyApplicationVisualization(ModifyApplicationVisualizationRequest req)
        {
             JsonResponseModel<ModifyApplicationVisualizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyApplicationVisualization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationVisualizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改应用模板配置
        /// </summary>
        /// <param name="req"><see cref="ModifyApplicationVisualizationRequest"/></param>
        /// <returns><see cref="ModifyApplicationVisualizationResponse"/></returns>
        public ModifyApplicationVisualizationResponse ModifyApplicationVisualizationSync(ModifyApplicationVisualizationRequest req)
        {
             JsonResponseModel<ModifyApplicationVisualizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyApplicationVisualization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyApplicationVisualizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改ConfigMap
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigMapRequest"/></param>
        /// <returns><see cref="ModifyConfigMapResponse"/></returns>
        public async Task<ModifyConfigMapResponse> ModifyConfigMap(ModifyConfigMapRequest req)
        {
             JsonResponseModel<ModifyConfigMapResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyConfigMap");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConfigMapResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改ConfigMap
        /// </summary>
        /// <param name="req"><see cref="ModifyConfigMapRequest"/></param>
        /// <returns><see cref="ModifyConfigMapResponse"/></returns>
        public ModifyConfigMapResponse ModifyConfigMapSync(ModifyConfigMapRequest req)
        {
             JsonResponseModel<ModifyConfigMapResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyConfigMap");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyConfigMapResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑边缘节点标签
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeNodeLabelsRequest"/></param>
        /// <returns><see cref="ModifyEdgeNodeLabelsResponse"/></returns>
        public async Task<ModifyEdgeNodeLabelsResponse> ModifyEdgeNodeLabels(ModifyEdgeNodeLabelsRequest req)
        {
             JsonResponseModel<ModifyEdgeNodeLabelsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEdgeNodeLabels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEdgeNodeLabelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 编辑边缘节点标签
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeNodeLabelsRequest"/></param>
        /// <returns><see cref="ModifyEdgeNodeLabelsResponse"/></returns>
        public ModifyEdgeNodeLabelsResponse ModifyEdgeNodeLabelsSync(ModifyEdgeNodeLabelsRequest req)
        {
             JsonResponseModel<ModifyEdgeNodeLabelsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEdgeNodeLabels");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEdgeNodeLabelsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改边缘集群
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitResponse"/></returns>
        public async Task<ModifyEdgeUnitResponse> ModifyEdgeUnit(ModifyEdgeUnitRequest req)
        {
             JsonResponseModel<ModifyEdgeUnitResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEdgeUnit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEdgeUnitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改边缘集群
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitResponse"/></returns>
        public ModifyEdgeUnitResponse ModifyEdgeUnitSync(ModifyEdgeUnitRequest req)
        {
             JsonResponseModel<ModifyEdgeUnitResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEdgeUnit");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEdgeUnitResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改单元应用基本信息
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitApplicationBasicInfoRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitApplicationBasicInfoResponse"/></returns>
        public async Task<ModifyEdgeUnitApplicationBasicInfoResponse> ModifyEdgeUnitApplicationBasicInfo(ModifyEdgeUnitApplicationBasicInfoRequest req)
        {
             JsonResponseModel<ModifyEdgeUnitApplicationBasicInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEdgeUnitApplicationBasicInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEdgeUnitApplicationBasicInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改单元应用基本信息
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitApplicationBasicInfoRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitApplicationBasicInfoResponse"/></returns>
        public ModifyEdgeUnitApplicationBasicInfoResponse ModifyEdgeUnitApplicationBasicInfoSync(ModifyEdgeUnitApplicationBasicInfoRequest req)
        {
             JsonResponseModel<ModifyEdgeUnitApplicationBasicInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEdgeUnitApplicationBasicInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEdgeUnitApplicationBasicInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可视化修改应用配置
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitApplicationVisualizationRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitApplicationVisualizationResponse"/></returns>
        public async Task<ModifyEdgeUnitApplicationVisualizationResponse> ModifyEdgeUnitApplicationVisualization(ModifyEdgeUnitApplicationVisualizationRequest req)
        {
             JsonResponseModel<ModifyEdgeUnitApplicationVisualizationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEdgeUnitApplicationVisualization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEdgeUnitApplicationVisualizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 可视化修改应用配置
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitApplicationVisualizationRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitApplicationVisualizationResponse"/></returns>
        public ModifyEdgeUnitApplicationVisualizationResponse ModifyEdgeUnitApplicationVisualizationSync(ModifyEdgeUnitApplicationVisualizationRequest req)
        {
             JsonResponseModel<ModifyEdgeUnitApplicationVisualizationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEdgeUnitApplicationVisualization");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEdgeUnitApplicationVisualizationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Yaml方式修改应用配置
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitApplicationYamlRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitApplicationYamlResponse"/></returns>
        public async Task<ModifyEdgeUnitApplicationYamlResponse> ModifyEdgeUnitApplicationYaml(ModifyEdgeUnitApplicationYamlRequest req)
        {
             JsonResponseModel<ModifyEdgeUnitApplicationYamlResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEdgeUnitApplicationYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEdgeUnitApplicationYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// Yaml方式修改应用配置
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitApplicationYamlRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitApplicationYamlResponse"/></returns>
        public ModifyEdgeUnitApplicationYamlResponse ModifyEdgeUnitApplicationYamlSync(ModifyEdgeUnitApplicationYamlRequest req)
        {
             JsonResponseModel<ModifyEdgeUnitApplicationYamlResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEdgeUnitApplicationYaml");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEdgeUnitApplicationYamlResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改边缘单元Grid部署应用副本数
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitDeployGridItemRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitDeployGridItemResponse"/></returns>
        public async Task<ModifyEdgeUnitDeployGridItemResponse> ModifyEdgeUnitDeployGridItem(ModifyEdgeUnitDeployGridItemRequest req)
        {
             JsonResponseModel<ModifyEdgeUnitDeployGridItemResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyEdgeUnitDeployGridItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEdgeUnitDeployGridItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改边缘单元Grid部署应用副本数
        /// </summary>
        /// <param name="req"><see cref="ModifyEdgeUnitDeployGridItemRequest"/></param>
        /// <returns><see cref="ModifyEdgeUnitDeployGridItemResponse"/></returns>
        public ModifyEdgeUnitDeployGridItemResponse ModifyEdgeUnitDeployGridItemSync(ModifyEdgeUnitDeployGridItemRequest req)
        {
             JsonResponseModel<ModifyEdgeUnitDeployGridItemResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyEdgeUnitDeployGridItem");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyEdgeUnitDeployGridItemResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改边缘单元NodeUnit模版
        /// </summary>
        /// <param name="req"><see cref="ModifyNodeUnitTemplateRequest"/></param>
        /// <returns><see cref="ModifyNodeUnitTemplateResponse"/></returns>
        public async Task<ModifyNodeUnitTemplateResponse> ModifyNodeUnitTemplate(ModifyNodeUnitTemplateRequest req)
        {
             JsonResponseModel<ModifyNodeUnitTemplateResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyNodeUnitTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNodeUnitTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改边缘单元NodeUnit模版
        /// </summary>
        /// <param name="req"><see cref="ModifyNodeUnitTemplateRequest"/></param>
        /// <returns><see cref="ModifyNodeUnitTemplateResponse"/></returns>
        public ModifyNodeUnitTemplateResponse ModifyNodeUnitTemplateSync(ModifyNodeUnitTemplateRequest req)
        {
             JsonResponseModel<ModifyNodeUnitTemplateResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyNodeUnitTemplate");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyNodeUnitTemplateResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改Secret
        /// </summary>
        /// <param name="req"><see cref="ModifySecretRequest"/></param>
        /// <returns><see cref="ModifySecretResponse"/></returns>
        public async Task<ModifySecretResponse> ModifySecret(ModifySecretRequest req)
        {
             JsonResponseModel<ModifySecretResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifySecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改Secret
        /// </summary>
        /// <param name="req"><see cref="ModifySecretRequest"/></param>
        /// <returns><see cref="ModifySecretResponse"/></returns>
        public ModifySecretResponse ModifySecretSync(ModifySecretRequest req)
        {
             JsonResponseModel<ModifySecretResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifySecret");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifySecretResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 单元应用重部署
        /// </summary>
        /// <param name="req"><see cref="RedeployEdgeUnitApplicationRequest"/></param>
        /// <returns><see cref="RedeployEdgeUnitApplicationResponse"/></returns>
        public async Task<RedeployEdgeUnitApplicationResponse> RedeployEdgeUnitApplication(RedeployEdgeUnitApplicationRequest req)
        {
             JsonResponseModel<RedeployEdgeUnitApplicationResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "RedeployEdgeUnitApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RedeployEdgeUnitApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 单元应用重部署
        /// </summary>
        /// <param name="req"><see cref="RedeployEdgeUnitApplicationRequest"/></param>
        /// <returns><see cref="RedeployEdgeUnitApplicationResponse"/></returns>
        public RedeployEdgeUnitApplicationResponse RedeployEdgeUnitApplicationSync(RedeployEdgeUnitApplicationRequest req)
        {
             JsonResponseModel<RedeployEdgeUnitApplicationResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "RedeployEdgeUnitApplication");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<RedeployEdgeUnitApplicationResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
