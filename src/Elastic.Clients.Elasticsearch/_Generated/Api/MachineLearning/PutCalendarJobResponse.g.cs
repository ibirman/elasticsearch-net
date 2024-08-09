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
using Elastic.Transport.Products.Elasticsearch;
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.MachineLearning;

public sealed partial class PutCalendarJobResponse : ElasticsearchResponse
{
	/// <summary>
	/// <para>
	/// A string that uniquely identifies a calendar.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("calendar_id")]
	public string CalendarId { get; init; }

	/// <summary>
	/// <para>
	/// A description of the calendar.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; init; }

	/// <summary>
	/// <para>
	/// A list of anomaly detection job identifiers or group names.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("job_ids")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public IReadOnlyCollection<string> JobIds { get; init; }
}