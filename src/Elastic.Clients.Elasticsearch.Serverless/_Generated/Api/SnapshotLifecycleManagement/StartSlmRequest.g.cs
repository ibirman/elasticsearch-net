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
using Elastic.Clients.Elasticsearch.Serverless.Requests;
using Elastic.Clients.Elasticsearch.Serverless.Serialization;
using Elastic.Transport;
using Elastic.Transport.Extensions;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.SnapshotLifecycleManagement;

public sealed partial class StartSlmRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Turns on snapshot lifecycle management (SLM).
/// </para>
/// </summary>
public sealed partial class StartSlmRequest : PlainRequest<StartSlmRequestParameters>
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotLifecycleManagementStart;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "slm.start";
}

/// <summary>
/// <para>
/// Turns on snapshot lifecycle management (SLM).
/// </para>
/// </summary>
public sealed partial class StartSlmRequestDescriptor : RequestDescriptor<StartSlmRequestDescriptor, StartSlmRequestParameters>
{
	internal StartSlmRequestDescriptor(Action<StartSlmRequestDescriptor> configure) => configure.Invoke(this);

	public StartSlmRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SnapshotLifecycleManagementStart;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => false;

	internal override string OperationName => "slm.start";

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}