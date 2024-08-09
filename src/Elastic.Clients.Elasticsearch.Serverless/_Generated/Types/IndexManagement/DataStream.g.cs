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

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class DataStream
{
	/// <summary>
	/// <para>
	/// If <c>true</c>, the data stream allows custom routing on write request.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("allow_custom_routing")]
	public bool? AllowCustomRouting { get; init; }

	/// <summary>
	/// <para>
	/// Current generation for the data stream. This number acts as a cumulative count of the stream’s rollovers, starting at 1.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("generation")]
	public int Generation { get; init; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the data stream is hidden.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("hidden")]
	public bool Hidden { get; init; }

	/// <summary>
	/// <para>
	/// Name of the current ILM lifecycle policy in the stream’s matching index template.
	/// This lifecycle policy is set in the <c>index.lifecycle.name</c> setting.
	/// If the template does not include a lifecycle policy, this property is not included in the response.
	/// NOTE: A data stream’s backing indices may be assigned different lifecycle policies. To retrieve the lifecycle policy for individual backing indices, use the get index settings API.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ilm_policy")]
	public string? IlmPolicy { get; init; }

	/// <summary>
	/// <para>
	/// Array of objects containing information about the data stream’s backing indices.
	/// The last item in this array contains information about the stream’s current write index.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("indices")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamIndex> Indices { get; init; }

	/// <summary>
	/// <para>
	/// Contains the configuration for the data stream lifecycle of this data stream.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("lifecycle")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamLifecycleWithRollover? Lifecycle { get; init; }

	/// <summary>
	/// <para>
	/// Custom metadata for the stream, copied from the <c>_meta</c> object of the stream’s matching index template.
	/// If empty, the response omits this property.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("_meta")]
	public IReadOnlyDictionary<string, object>? Meta { get; init; }

	/// <summary>
	/// <para>
	/// Name of the data stream.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("name")]
	public string Name { get; init; }

	/// <summary>
	/// <para>
	/// Name of the lifecycle system that'll manage the next generation of the data stream.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("next_generation_managed_by")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.ManagedBy NextGenerationManagedBy { get; init; }

	/// <summary>
	/// <para>
	/// Indicates if ILM should take precedence over DSL in case both are configured to managed this data stream.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("prefer_ilm")]
	public bool PreferIlm { get; init; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the data stream is created and managed by cross-cluster replication and the local cluster can not write into this data stream or change its mappings.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("replicated")]
	public bool? Replicated { get; init; }

	/// <summary>
	/// <para>
	/// Health status of the data stream.
	/// This health status is based on the state of the primary and replica shards of the stream’s backing indices.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("status")]
	public Elastic.Clients.Elasticsearch.Serverless.HealthStatus Status { get; init; }

	/// <summary>
	/// <para>
	/// If <c>true</c>, the data stream is created and managed by an Elastic stack component and cannot be modified through normal user interaction.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("system")]
	public bool? System { get; init; }

	/// <summary>
	/// <para>
	/// Name of the index template used to create the data stream’s backing indices.
	/// The template’s index pattern must match the name of this data stream.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("template")]
	public string Template { get; init; }

	/// <summary>
	/// <para>
	/// Information about the <c>@timestamp</c> field in the data stream.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("timestamp_field")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.DataStreamTimestampField TimestampField { get; init; }
}