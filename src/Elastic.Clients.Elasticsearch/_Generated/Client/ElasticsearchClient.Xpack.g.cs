// Licensed to Elasticsearch B.V under one or more agreements.
// Elasticsearch B.V licenses this file to you under the Apache 2.0 License.
// See the LICENSE file in the project root for more information.
//
// ███╗   ██╗ ██████╗ ████████╗██╗ ██████╗███████╗
// ████╗  ██║██╔═══██╗╚══██╔══╝██║██╔════╝██╔════╝
// ██╔██╗ ██║██║   ██║   ██║   ██║██║     █████╗
// ██║╚██╗██║██║   ██║   ██║   ██║██║     ██╔══╝
// ██║ ╚████║╚██████╔╝   ██║   ██║╚██████╗███████╗
// ╚═╝  ╚═══╝ ╚═════╝    ╚═╝   ╚═╝ ╚═════╝╚══════╝
// ------------------------------------------------
//
// This file is automatically generated.
// Please do not edit these files manually.
//
// ------------------------------------------------

#nullable restore

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Elastic.Clients.Elasticsearch.Xpack;

public partial class XpackNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// <para>
	/// Initializes a new instance of the <see cref="XpackNamespacedClient"/> class for mocking.
	/// </para>
	/// </summary>
	protected XpackNamespacedClient() : base()
	{
	}

	internal XpackNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	/// <summary>
	/// <para>
	/// Provides general information about the installed X-Pack features.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/info-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual XpackInfoResponse Info(XpackInfoRequest request)
	{
		request.BeforeRequest();
		return DoRequest<XpackInfoRequest, XpackInfoResponse, XpackInfoRequestParameters>(request);
	}

	/// <summary>
	/// <para>
	/// Provides general information about the installed X-Pack features.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/info-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<XpackInfoResponse> InfoAsync(XpackInfoRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<XpackInfoRequest, XpackInfoResponse, XpackInfoRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Provides general information about the installed X-Pack features.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/info-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual XpackInfoResponse Info(XpackInfoRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<XpackInfoRequestDescriptor, XpackInfoResponse, XpackInfoRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>
	/// Provides general information about the installed X-Pack features.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/info-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual XpackInfoResponse Info()
	{
		var descriptor = new XpackInfoRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<XpackInfoRequestDescriptor, XpackInfoResponse, XpackInfoRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>
	/// Provides general information about the installed X-Pack features.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/info-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual XpackInfoResponse Info(Action<XpackInfoRequestDescriptor> configureRequest)
	{
		var descriptor = new XpackInfoRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<XpackInfoRequestDescriptor, XpackInfoResponse, XpackInfoRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>
	/// Provides general information about the installed X-Pack features.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/info-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<XpackInfoResponse> InfoAsync(XpackInfoRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<XpackInfoRequestDescriptor, XpackInfoResponse, XpackInfoRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Provides general information about the installed X-Pack features.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/info-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<XpackInfoResponse> InfoAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new XpackInfoRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<XpackInfoRequestDescriptor, XpackInfoResponse, XpackInfoRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Provides general information about the installed X-Pack features.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/info-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<XpackInfoResponse> InfoAsync(Action<XpackInfoRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new XpackInfoRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<XpackInfoRequestDescriptor, XpackInfoResponse, XpackInfoRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// This API provides information about which features are currently enabled and available under the current license and some usage statistics.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/usage-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual XpackUsageResponse Usage(XpackUsageRequest request)
	{
		request.BeforeRequest();
		return DoRequest<XpackUsageRequest, XpackUsageResponse, XpackUsageRequestParameters>(request);
	}

	/// <summary>
	/// <para>
	/// This API provides information about which features are currently enabled and available under the current license and some usage statistics.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/usage-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<XpackUsageResponse> UsageAsync(XpackUsageRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<XpackUsageRequest, XpackUsageResponse, XpackUsageRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// This API provides information about which features are currently enabled and available under the current license and some usage statistics.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/usage-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual XpackUsageResponse Usage(XpackUsageRequestDescriptor descriptor)
	{
		descriptor.BeforeRequest();
		return DoRequest<XpackUsageRequestDescriptor, XpackUsageResponse, XpackUsageRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>
	/// This API provides information about which features are currently enabled and available under the current license and some usage statistics.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/usage-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual XpackUsageResponse Usage()
	{
		var descriptor = new XpackUsageRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequest<XpackUsageRequestDescriptor, XpackUsageResponse, XpackUsageRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>
	/// This API provides information about which features are currently enabled and available under the current license and some usage statistics.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/usage-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	[Obsolete("Synchronous methods are deprecated and could be removed in the future.")]
	public virtual XpackUsageResponse Usage(Action<XpackUsageRequestDescriptor> configureRequest)
	{
		var descriptor = new XpackUsageRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequest<XpackUsageRequestDescriptor, XpackUsageResponse, XpackUsageRequestParameters>(descriptor);
	}

	/// <summary>
	/// <para>
	/// This API provides information about which features are currently enabled and available under the current license and some usage statistics.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/usage-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<XpackUsageResponse> UsageAsync(XpackUsageRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<XpackUsageRequestDescriptor, XpackUsageResponse, XpackUsageRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// This API provides information about which features are currently enabled and available under the current license and some usage statistics.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/usage-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<XpackUsageResponse> UsageAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new XpackUsageRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<XpackUsageRequestDescriptor, XpackUsageResponse, XpackUsageRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// This API provides information about which features are currently enabled and available under the current license and some usage statistics.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/current/usage-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<XpackUsageResponse> UsageAsync(Action<XpackUsageRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new XpackUsageRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<XpackUsageRequestDescriptor, XpackUsageResponse, XpackUsageRequestParameters>(descriptor, cancellationToken);
	}
}