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

using Elastic.Clients.Elasticsearch.Fluent;
using Elastic.Clients.Elasticsearch.Requests;
using Elastic.Clients.Elasticsearch.Serialization;
using Elastic.Transport;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.IndexManagement;

public sealed partial class SimulateIndexTemplateRequestParameters : RequestParameters
{
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
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>
/// Simulate an index.
/// Returns the index configuration that would be applied to the specified index from an existing index template.
/// </para>
/// </summary>
public sealed partial class SimulateIndexTemplateRequest : PlainRequest<SimulateIndexTemplateRequestParameters>
{
	public SimulateIndexTemplateRequest(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementSimulateIndexTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.simulate_index_template";

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
	public Elastic.Clients.Elasticsearch.Duration? MasterTimeout { get => Q<Elastic.Clients.Elasticsearch.Duration?>("master_timeout"); set => Q("master_timeout", value); }
}

/// <summary>
/// <para>
/// Simulate an index.
/// Returns the index configuration that would be applied to the specified index from an existing index template.
/// </para>
/// </summary>
public sealed partial class SimulateIndexTemplateRequestDescriptor : RequestDescriptor<SimulateIndexTemplateRequestDescriptor, SimulateIndexTemplateRequestParameters>
{
	internal SimulateIndexTemplateRequestDescriptor(Action<SimulateIndexTemplateRequestDescriptor> configure) => configure.Invoke(this);

	public SimulateIndexTemplateRequestDescriptor(Elastic.Clients.Elasticsearch.Name name) : base(r => r.Required("name", name))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.IndexManagementSimulateIndexTemplate;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "indices.simulate_index_template";

	public SimulateIndexTemplateRequestDescriptor IncludeDefaults(bool? includeDefaults = true) => Qs("include_defaults", includeDefaults);
	public SimulateIndexTemplateRequestDescriptor MasterTimeout(Elastic.Clients.Elasticsearch.Duration? masterTimeout) => Qs("master_timeout", masterTimeout);

	public SimulateIndexTemplateRequestDescriptor Name(Elastic.Clients.Elasticsearch.Name name)
	{
		RouteValues.Required("name", name);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}