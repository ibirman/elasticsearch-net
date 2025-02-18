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

using Elastic.Clients.Elasticsearch.Serverless.Fluent;
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.AsyncSearch;

public sealed partial class AsyncSearchStatusRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Get the async search status.
/// </para>
/// <para>
/// Get the status of a previously submitted async search request given its identifier, without retrieving search results.
/// If the Elasticsearch security features are enabled, use of this API is restricted to the <c>monitoring_user</c> role.
/// </para>
/// </summary>
public sealed partial class AsyncSearchStatusRequest : PlainRequest<AsyncSearchStatusRequestParameters>
{
	public AsyncSearchStatusRequest(Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.AsyncSearchStatus;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "async_search.status";
}

/// <summary>
/// <para>
/// Get the async search status.
/// </para>
/// <para>
/// Get the status of a previously submitted async search request given its identifier, without retrieving search results.
/// If the Elasticsearch security features are enabled, use of this API is restricted to the <c>monitoring_user</c> role.
/// </para>
/// </summary>
public sealed partial class AsyncSearchStatusRequestDescriptor<TDocument> : RequestDescriptor<AsyncSearchStatusRequestDescriptor<TDocument>, AsyncSearchStatusRequestParameters>
{
	internal AsyncSearchStatusRequestDescriptor(Action<AsyncSearchStatusRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public AsyncSearchStatusRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.AsyncSearchStatus;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "async_search.status";

	public AsyncSearchStatusRequestDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}

/// <summary>
/// <para>
/// Get the async search status.
/// </para>
/// <para>
/// Get the status of a previously submitted async search request given its identifier, without retrieving search results.
/// If the Elasticsearch security features are enabled, use of this API is restricted to the <c>monitoring_user</c> role.
/// </para>
/// </summary>
public sealed partial class AsyncSearchStatusRequestDescriptor : RequestDescriptor<AsyncSearchStatusRequestDescriptor, AsyncSearchStatusRequestParameters>
{
	internal AsyncSearchStatusRequestDescriptor(Action<AsyncSearchStatusRequestDescriptor> configure) => configure.Invoke(this);

	public AsyncSearchStatusRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id id) : base(r => r.Required("id", id))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.AsyncSearchStatus;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "async_search.status";

	public AsyncSearchStatusRequestDescriptor Id(Elastic.Clients.Elasticsearch.Serverless.Id id)
	{
		RouteValues.Required("id", id);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}