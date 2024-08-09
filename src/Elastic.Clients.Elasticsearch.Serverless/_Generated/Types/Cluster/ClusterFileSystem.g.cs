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

public sealed partial class ClusterFileSystem
{
	/// <summary>
	/// <para>
	/// Total number of bytes available to JVM in file stores across all selected nodes.
	/// Depending on operating system or process-level restrictions, this number may be less than <c>nodes.fs.free_in_byes</c>.
	/// This is the actual amount of free disk space the selected Elasticsearch nodes can use.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("available_in_bytes")]
	public long AvailableInBytes { get; init; }

	/// <summary>
	/// <para>
	/// Total number of unallocated bytes in file stores across all selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("free_in_bytes")]
	public long FreeInBytes { get; init; }

	/// <summary>
	/// <para>
	/// Total size, in bytes, of all file stores across all selected nodes.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("total_in_bytes")]
	public long TotalInBytes { get; init; }
}