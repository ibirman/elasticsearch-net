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

public sealed partial class PendingTask
{
	/// <summary>
	/// <para>
	/// Indicates whether the pending tasks are currently executing or not.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("executing")]
	public bool Executing { get; init; }

	/// <summary>
	/// <para>
	/// The number that represents when the task has been inserted into the task queue.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("insert_order")]
	public int InsertOrder { get; init; }

	/// <summary>
	/// <para>
	/// The priority of the pending task.
	/// The valid priorities in descending priority order are: <c>IMMEDIATE</c> > <c>URGENT</c> > <c>HIGH</c> > <c>NORMAL</c> > <c>LOW</c> > <c>LANGUID</c>.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("priority")]
	public string Priority { get; init; }

	/// <summary>
	/// <para>
	/// A general description of the cluster task that may include a reason and origin.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("source")]
	public string Source { get; init; }

	/// <summary>
	/// <para>
	/// The time since the task is waiting for being performed.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("time_in_queue")]
	public Elastic.Clients.Elasticsearch.Duration? TimeInQueue { get; init; }

	/// <summary>
	/// <para>
	/// The time expressed in milliseconds since the task is waiting for being performed.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("time_in_queue_millis")]
	public long TimeInQueueMillis { get; init; }
}