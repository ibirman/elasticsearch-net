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
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Cluster;

public sealed partial class FieldTypesMappings
{
	/// <summary>
	/// <para>
	/// Contains statistics about field data types used in selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field_types")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.FieldTypes> FieldTypes { get; init; }

	/// <summary>
	/// <para>
	/// Contains statistics about runtime field data types used in selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("runtime_field_types")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Cluster.RuntimeFieldTypes>? RuntimeFieldTypes { get; init; }

	/// <summary>
	/// <para>
	/// Total number of fields in all non-system indices, accounting for mapping deduplication.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("total_deduplicated_field_count")]
	public int? TotalDeduplicatedFieldCount { get; init; }

	/// <summary>
	/// <para>
	/// Total size of all mappings after deduplication and compression.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("total_deduplicated_mapping_size")]
	public Elastic.Clients.Elasticsearch.ByteSize? TotalDeduplicatedMappingSize { get; init; }

	/// <summary>
	/// <para>
	/// Total size of all mappings, in bytes, after deduplication and compression.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("total_deduplicated_mapping_size_in_bytes")]
	public long? TotalDeduplicatedMappingSizeInBytes { get; init; }

	/// <summary>
	/// <para>
	/// Total number of fields in all non-system indices.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("total_field_count")]
	public int? TotalFieldCount { get; init; }
}