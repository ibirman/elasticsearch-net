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

namespace Elastic.Clients.Elasticsearch.Serverless.Cluster;

public sealed partial class CharFilterTypes
{
	/// <summary>
	/// <para>
	/// Contains statistics about analyzer types used in selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("analyzer_types")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Cluster.FieldTypes> AnalyzerTypes { get; init; }

	/// <summary>
	/// <para>
	/// Contains statistics about built-in analyzers used in selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("built_in_analyzers")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Cluster.FieldTypes> BuiltInAnalyzers { get; init; }

	/// <summary>
	/// <para>
	/// Contains statistics about built-in character filters used in selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("built_in_char_filters")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Cluster.FieldTypes> BuiltInCharFilters { get; init; }

	/// <summary>
	/// <para>
	/// Contains statistics about built-in token filters used in selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("built_in_filters")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Cluster.FieldTypes> BuiltInFilters { get; init; }

	/// <summary>
	/// <para>
	/// Contains statistics about built-in tokenizers used in selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("built_in_tokenizers")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Cluster.FieldTypes> BuiltInTokenizers { get; init; }

	/// <summary>
	/// <para>
	/// Contains statistics about character filter types used in selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("char_filter_types")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Cluster.FieldTypes> CharFilterTypes2 { get; init; }

	/// <summary>
	/// <para>
	/// Contains statistics about token filter types used in selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("filter_types")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Cluster.FieldTypes> FilterTypes { get; init; }

	/// <summary>
	/// <para>
	/// Contains statistics about tokenizer types used in selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tokenizer_types")]
	public IReadOnlyCollection<Elastic.Clients.Elasticsearch.Serverless.Cluster.FieldTypes> TokenizerTypes { get; init; }
}