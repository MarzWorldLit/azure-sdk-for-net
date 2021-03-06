// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DevTestLabs
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure.OData;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// Extension methods for EnvironmentsOperations.
    /// </summary>
    public static partial class EnvironmentsOperationsExtensions
    {
            /// <summary>
            /// List environments in a given user profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<DtlEnvironment> List(this IEnvironmentsOperations operations, string labName, string userName, ODataQuery<DtlEnvironment> odataQuery = default(ODataQuery<DtlEnvironment>))
            {
                return Task.Factory.StartNew(s => ((IEnvironmentsOperations)s).ListAsync(labName, userName, odataQuery), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List environments in a given user profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DtlEnvironment>> ListAsync(this IEnvironmentsOperations operations, string labName, string userName, ODataQuery<DtlEnvironment> odataQuery = default(ODataQuery<DtlEnvironment>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(labName, userName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the environment.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example:
            /// 'properties($select=deploymentProperties)'
            /// </param>
            public static DtlEnvironment Get(this IEnvironmentsOperations operations, string labName, string userName, string name, string expand = default(string))
            {
                return Task.Factory.StartNew(s => ((IEnvironmentsOperations)s).GetAsync(labName, userName, name, expand), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get environment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the environment.
            /// </param>
            /// <param name='expand'>
            /// Specify the $expand query. Example:
            /// 'properties($select=deploymentProperties)'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DtlEnvironment> GetAsync(this IEnvironmentsOperations operations, string labName, string userName, string name, string expand = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(labName, userName, name, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing environment. This operation can take a while
            /// to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the environment.
            /// </param>
            /// <param name='dtlEnvironment'>
            /// An environment, which is essentially an ARM template deployment.
            /// </param>
            public static DtlEnvironment CreateOrUpdate(this IEnvironmentsOperations operations, string labName, string userName, string name, DtlEnvironment dtlEnvironment)
            {
                return Task.Factory.StartNew(s => ((IEnvironmentsOperations)s).CreateOrUpdateAsync(labName, userName, name, dtlEnvironment), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing environment. This operation can take a while
            /// to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the environment.
            /// </param>
            /// <param name='dtlEnvironment'>
            /// An environment, which is essentially an ARM template deployment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DtlEnvironment> CreateOrUpdateAsync(this IEnvironmentsOperations operations, string labName, string userName, string name, DtlEnvironment dtlEnvironment, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(labName, userName, name, dtlEnvironment, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or replace an existing environment. This operation can take a while
            /// to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the environment.
            /// </param>
            /// <param name='dtlEnvironment'>
            /// An environment, which is essentially an ARM template deployment.
            /// </param>
            public static DtlEnvironment BeginCreateOrUpdate(this IEnvironmentsOperations operations, string labName, string userName, string name, DtlEnvironment dtlEnvironment)
            {
                return Task.Factory.StartNew(s => ((IEnvironmentsOperations)s).BeginCreateOrUpdateAsync(labName, userName, name, dtlEnvironment), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or replace an existing environment. This operation can take a while
            /// to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the environment.
            /// </param>
            /// <param name='dtlEnvironment'>
            /// An environment, which is essentially an ARM template deployment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DtlEnvironment> BeginCreateOrUpdateAsync(this IEnvironmentsOperations operations, string labName, string userName, string name, DtlEnvironment dtlEnvironment, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(labName, userName, name, dtlEnvironment, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete environment. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the environment.
            /// </param>
            public static void Delete(this IEnvironmentsOperations operations, string labName, string userName, string name)
            {
                Task.Factory.StartNew(s => ((IEnvironmentsOperations)s).DeleteAsync(labName, userName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete environment. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the environment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IEnvironmentsOperations operations, string labName, string userName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteWithHttpMessagesAsync(labName, userName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Delete environment. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the environment.
            /// </param>
            public static void BeginDelete(this IEnvironmentsOperations operations, string labName, string userName, string name)
            {
                Task.Factory.StartNew(s => ((IEnvironmentsOperations)s).BeginDeleteAsync(labName, userName, name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete environment. This operation can take a while to complete.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='labName'>
            /// The name of the lab.
            /// </param>
            /// <param name='userName'>
            /// The name of the user profile.
            /// </param>
            /// <param name='name'>
            /// The name of the environment.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IEnvironmentsOperations operations, string labName, string userName, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteWithHttpMessagesAsync(labName, userName, name, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// List environments in a given user profile.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DtlEnvironment> ListNext(this IEnvironmentsOperations operations, string nextPageLink)
            {
                return Task.Factory.StartNew(s => ((IEnvironmentsOperations)s).ListNextAsync(nextPageLink), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// List environments in a given user profile.
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
            public static async Task<IPage<DtlEnvironment>> ListNextAsync(this IEnvironmentsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
