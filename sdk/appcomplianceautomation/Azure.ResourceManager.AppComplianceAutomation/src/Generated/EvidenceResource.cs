// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppComplianceAutomation.Models;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    /// <summary>
    /// A Class representing an EvidenceResource along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct an <see cref="EvidenceResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetEvidenceResource method.
    /// Otherwise you can get one from its parent resource <see cref="ReportResource" /> using the GetEvidenceResource method.
    /// </summary>
    public partial class EvidenceResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="EvidenceResource"/> instance. </summary>
        public static ResourceIdentifier CreateResourceIdentifier(string reportName, string evidenceName)
        {
            var resourceId = $"/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences/{evidenceName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _evidenceResourceEvidencesClientDiagnostics;
        private readonly EvidencesRestOperations _evidenceResourceEvidencesRestClient;
        private readonly EvidenceResourceData _data;

        /// <summary> Initializes a new instance of the <see cref="EvidenceResource"/> class for mocking. </summary>
        protected EvidenceResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "EvidenceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal EvidenceResource(ArmClient client, EvidenceResourceData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="EvidenceResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal EvidenceResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _evidenceResourceEvidencesClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppComplianceAutomation", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string evidenceResourceEvidencesApiVersion);
            _evidenceResourceEvidencesRestClient = new EvidencesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, evidenceResourceEvidencesApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.AppComplianceAutomation/reports/evidences";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual EvidenceResourceData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get the evidence metadata
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences/{evidenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<EvidenceResource>> GetAsync(string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _evidenceResourceEvidencesClientDiagnostics.CreateScope("EvidenceResource.Get");
            scope.Start();
            try
            {
                var response = await _evidenceResourceEvidencesRestClient.GetAsync(Id.Parent.Name, Id.Name, offerGuid, reportCreatorTenantId, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EvidenceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get the evidence metadata
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences/{evidenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<EvidenceResource> Get(string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            using var scope = _evidenceResourceEvidencesClientDiagnostics.CreateScope("EvidenceResource.Get");
            scope.Start();
            try
            {
                var response = _evidenceResourceEvidencesRestClient.Get(Id.Parent.Name, Id.Name, offerGuid, reportCreatorTenantId, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new EvidenceResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete an existent evidence from a specified report
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences/{evidenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _evidenceResourceEvidencesClientDiagnostics.CreateScope("EvidenceResource.Delete");
            scope.Start();
            try
            {
                var response = await _evidenceResourceEvidencesRestClient.DeleteAsync(Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new AppComplianceAutomationArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete an existent evidence from a specified report
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences/{evidenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_Delete</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _evidenceResourceEvidencesClientDiagnostics.CreateScope("EvidenceResource.Delete");
            scope.Start();
            try
            {
                var response = _evidenceResourceEvidencesRestClient.Delete(Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new AppComplianceAutomationArmOperation(response);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or Update an evidence a specified report
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences/{evidenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<EvidenceResource>> UpdateAsync(WaitUntil waitUntil, EvidenceResourceData data, string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _evidenceResourceEvidencesClientDiagnostics.CreateScope("EvidenceResource.Update");
            scope.Start();
            try
            {
                var response = await _evidenceResourceEvidencesRestClient.CreateOrUpdateAsync(Id.Parent.Name, Id.Name, data, offerGuid, reportCreatorTenantId, cancellationToken).ConfigureAwait(false);
                var operation = new AppComplianceAutomationArmOperation<EvidenceResource>(Response.FromValue(new EvidenceResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or Update an evidence a specified report
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences/{evidenceName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_CreateOrUpdate</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> Parameters for the create or update operation. </param>
        /// <param name="offerGuid"> The offerGuid which mapping to the reports. </param>
        /// <param name="reportCreatorTenantId"> The tenant id of the report creator. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<EvidenceResource> Update(WaitUntil waitUntil, EvidenceResourceData data, string offerGuid = null, string reportCreatorTenantId = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _evidenceResourceEvidencesClientDiagnostics.CreateScope("EvidenceResource.Update");
            scope.Start();
            try
            {
                var response = _evidenceResourceEvidencesRestClient.CreateOrUpdate(Id.Parent.Name, Id.Name, data, offerGuid, reportCreatorTenantId, cancellationToken);
                var operation = new AppComplianceAutomationArmOperation<EvidenceResource>(Response.FromValue(new EvidenceResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Download evidence file.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences/{evidenceName}/download</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_Download</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters for the query operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual async Task<Response<EvidenceFileDownloadResponse>> DownloadAsync(EvidenceFileDownloadContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _evidenceResourceEvidencesClientDiagnostics.CreateScope("EvidenceResource.Download");
            scope.Start();
            try
            {
                var response = await _evidenceResourceEvidencesRestClient.DownloadAsync(Id.Parent.Name, Id.Name, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Download evidence file.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AppComplianceAutomation/reports/{reportName}/evidences/{evidenceName}/download</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Evidences_Download</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> Parameters for the query operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public virtual Response<EvidenceFileDownloadResponse> Download(EvidenceFileDownloadContent content, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(content, nameof(content));

            using var scope = _evidenceResourceEvidencesClientDiagnostics.CreateScope("EvidenceResource.Download");
            scope.Start();
            try
            {
                var response = _evidenceResourceEvidencesRestClient.Download(Id.Parent.Name, Id.Name, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
