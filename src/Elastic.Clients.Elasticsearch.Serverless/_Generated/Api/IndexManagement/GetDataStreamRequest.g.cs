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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class GetDataStreamRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Type of data stream that wildcard patterns can match.
	/// Supports comma-separated values, such as <c>open,hidden</c>.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>
	/// If true, returns all relevant default configurations for the index template.
	/// </para>
	/// </summary>
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>
/// Get data streams.
/// Retrieves information about one or more data streams.
/// </para>
/// </summary>
public sealed partial class GetDataStreamRequest : PlainRequest<GetDataStreamRequestParameters>
{
	public GetDataStreamRequest()
	{
	}

	public GetDataStreamRequest(Elastic.Clients.Elasticsearch.Serverless.DataStreamNames? name) : base(r => r.Optional("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementGetDataStream;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.get_data_stream";

	/// <summary>
	/// <para>
	/// Type of data stream that wildcard patterns can match.
	/// Supports comma-separated values, such as <c>open,hidden</c>.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>
	/// If true, returns all relevant default configurations for the index template.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? IncludeDefaults { get => Q<bool?>("include_defaults"); set => Q("include_defaults", value); }

	/// <summary>
	/// <para>
	/// Period to wait for a connection to the master node. If no response is received before the timeout expires, the request fails and returns an error.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>
/// Get data streams.
/// Retrieves information about one or more data streams.
/// </para>
/// </summary>
public sealed partial class GetDataStreamRequestDescriptor : RequestDescriptor<GetDataStreamRequestDescriptor, GetDataStreamRequestParameters>
{
	internal GetDataStreamRequestDescriptor(Action<GetDataStreamRequestDescriptor> configure) => configure.Invoke(this);

	public GetDataStreamRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.DataStreamNames? name) : base(r => r.Optional("name", name))
	{
	}

	public GetDataStreamRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementGetDataStream;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.get_data_stream";

	public GetDataStreamRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public GetDataStreamRequestDescriptor IncludeDefaults(bool? includeDefaults = true) => Qs("include_defaults", includeDefaults);
	public GetDataStreamRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Serverless.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);

	public GetDataStreamRequestDescriptor Name(Elastic.Clients.Elasticsearch.Serverless.DataStreamNames? name)
	{
		RouteValues.Optional("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}