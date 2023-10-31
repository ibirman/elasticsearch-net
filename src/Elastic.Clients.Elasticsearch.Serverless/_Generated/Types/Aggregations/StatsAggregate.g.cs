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

namespace Elastic.Clients.Elasticsearch.Serverless.Aggregations;

/// <summary>
/// <para>Statistics aggregation result. `min`, `max` and `avg` are missing if there were no values to process<br/>(`count` is zero).</para>
/// </summary>
public sealed partial class StatsAggregate : IAggregate
{
	[JsonInclude, JsonPropertyName("avg")]
	public double? Avg { get; init; }
	[JsonInclude, JsonPropertyName("avg_as_string")]
	public string? AvgAsString { get; init; }
	[JsonInclude, JsonPropertyName("count")]
	public long Count { get; init; }
	[JsonInclude, JsonPropertyName("max")]
	public double? Max { get; init; }
	[JsonInclude, JsonPropertyName("max_as_string")]
	public string? MaxAsString { get; init; }
	[JsonInclude, JsonPropertyName("meta")]
	public IReadOnlyDictionary<string, object>? Meta { get; init; }
	[JsonInclude, JsonPropertyName("min")]
	public double? Min { get; init; }
	[JsonInclude, JsonPropertyName("min_as_string")]
	public string? MinAsString { get; init; }
	[JsonInclude, JsonPropertyName("sum")]
	public double Sum { get; init; }
	[JsonInclude, JsonPropertyName("sum_as_string")]
	public string? SumAsString { get; init; }
}