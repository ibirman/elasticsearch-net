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
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.SnapshotLifecycleManagement;

public sealed partial class GetSlmStatusRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Retrieves the status of snapshot lifecycle management (SLM).
/// </para>
/// </summary>
public sealed partial class GetSlmStatusRequest : PlainRequest<GetSlmStatusRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotLifecycleManagementGetStatus;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "slm.get_status";
}

/// <summary>
/// <para>
/// Retrieves the status of snapshot lifecycle management (SLM).
/// </para>
/// </summary>
public sealed partial class GetSlmStatusRequestDescriptor : RequestDescriptor<GetSlmStatusRequestDescriptor, GetSlmStatusRequestParameters>
{
	internal GetSlmStatusRequestDescriptor(Action<GetSlmStatusRequestDescriptor> configure) => configure.Invoke(this);

	public GetSlmStatusRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotLifecycleManagementGetStatus;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "slm.get_status";

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}