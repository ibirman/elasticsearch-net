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
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Security;

public sealed partial class Restriction
{
	[JsonInclude, JsonPropertyName("workflows")]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.Security.RestrictionWorkflow> Workflows { get; set; }
}

public sealed partial class RestrictionDescriptor : SerializableDescriptor<RestrictionDescriptor>
{
	internal RestrictionDescriptor(Action<RestrictionDescriptor> configure) => configure.Invoke(this);

	public RestrictionDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.Serverless.Security.RestrictionWorkflow> WorkflowsValue { get; set; }

	public RestrictionDescriptor Workflows(ICollection<Elastic.Clients.Elasticsearch.Serverless.Security.RestrictionWorkflow> workflows)
	{
		WorkflowsValue = workflows;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("workflows");
		JsonSerializer.Serialize(writer, WorkflowsValue, options);
		writer.WriteEndObject();
	}
}