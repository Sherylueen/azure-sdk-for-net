// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FailoverGroupsOperations.
    /// </summary>
    public static partial class FailoverGroupsOperationsExtensions
    {
            /// <summary>
            /// Gets a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            public static FailoverGroup Get(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName)
            {
                return operations.GetAsync(resourceGroupName, serverName, failoverGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroup> GetAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='parameters'>
            /// The failover group parameters.
            /// </param>
            public static FailoverGroup CreateOrUpdate(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, FailoverGroup parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, serverName, failoverGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='parameters'>
            /// The failover group parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroup> CreateOrUpdateAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, FailoverGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            public static void Delete(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName)
            {
                operations.DeleteAsync(resourceGroupName, serverName, failoverGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='parameters'>
            /// The failover group parameters.
            /// </param>
            public static FailoverGroup Update(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, FailoverGroup parameters)
            {
                return operations.UpdateAsync(resourceGroupName, serverName, failoverGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='parameters'>
            /// The failover group parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroup> UpdateAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, FailoverGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the failover groups in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            public static IPage<FailoverGroup> ListByServer(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName)
            {
                return operations.ListByServerAsync(resourceGroupName, serverName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the failover groups in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FailoverGroup>> ListByServerAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerWithHttpMessagesAsync(resourceGroupName, serverName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Fails over from the current primary server to this server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            public static FailoverGroup Failover(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName)
            {
                return operations.FailoverAsync(resourceGroupName, serverName, failoverGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Fails over from the current primary server to this server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroup> FailoverAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.FailoverWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Fails over from the current primary server to this server. This operation
            /// might result in data loss.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            public static FailoverGroup ForceFailoverAllowDataLoss(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName)
            {
                return operations.ForceFailoverAllowDataLossAsync(resourceGroupName, serverName, failoverGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Fails over from the current primary server to this server. This operation
            /// might result in data loss.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroup> ForceFailoverAllowDataLossAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ForceFailoverAllowDataLossWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='parameters'>
            /// The failover group parameters.
            /// </param>
            public static FailoverGroup BeginCreateOrUpdate(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, FailoverGroup parameters)
            {
                return operations.BeginCreateOrUpdateAsync(resourceGroupName, serverName, failoverGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates or updates a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='parameters'>
            /// The failover group parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroup> BeginCreateOrUpdateAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, FailoverGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            public static void BeginDelete(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName)
            {
                operations.BeginDeleteAsync(resourceGroupName, serverName, failoverGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='parameters'>
            /// The failover group parameters.
            /// </param>
            public static FailoverGroup BeginUpdate(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, FailoverGroup parameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, serverName, failoverGroupName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a failover group.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='parameters'>
            /// The failover group parameters.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroup> BeginUpdateAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, FailoverGroup parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Fails over from the current primary server to this server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            public static FailoverGroup BeginFailover(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName)
            {
                return operations.BeginFailoverAsync(resourceGroupName, serverName, failoverGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Fails over from the current primary server to this server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroup> BeginFailoverAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginFailoverWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Fails over from the current primary server to this server. This operation
            /// might result in data loss.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            public static FailoverGroup BeginForceFailoverAllowDataLoss(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName)
            {
                return operations.BeginForceFailoverAllowDataLossAsync(resourceGroupName, serverName, failoverGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Fails over from the current primary server to this server. This operation
            /// might result in data loss.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the resource. You can obtain
            /// this value from the Azure Resource Manager API or the portal.
            /// </param>
            /// <param name='serverName'>
            /// The name of the server containing the failover group.
            /// </param>
            /// <param name='failoverGroupName'>
            /// The name of the failover group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FailoverGroup> BeginForceFailoverAllowDataLossAsync(this IFailoverGroupsOperations operations, string resourceGroupName, string serverName, string failoverGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginForceFailoverAllowDataLossWithHttpMessagesAsync(resourceGroupName, serverName, failoverGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the failover groups in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<FailoverGroup> ListByServerNext(this IFailoverGroupsOperations operations, string nextPageLink)
            {
                return operations.ListByServerNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the failover groups in a server.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<FailoverGroup>> ListByServerNextAsync(this IFailoverGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServerNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
