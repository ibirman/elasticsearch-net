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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.TransformManagement;

public sealed partial class GetTransformRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Specifies what to do when the request:
	/// </para>
	/// <list type="number">
	/// <item>
	/// <para>
	/// Contains wildcard expressions and there are no transforms that match.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// Contains the _all string or no identifiers and there are no matches.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// Contains wildcard expressions and there are only partial matches.
	/// </para>
	/// </item>
	/// </list>
	/// <para>
	/// If this parameter is false, the request returns a 404 status code when
	/// there are no matches or only partial matches.
	/// </para>
	/// </summary>
	public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

	/// <summary>
	/// <para>
	/// Excludes fields that were automatically added when creating the
	/// transform. This allows the configuration to be in an acceptable format to
	/// be retrieved and then added to another cluster.
	/// </para>
	/// </summary>
	public bool? ExcludeGenerated { get => Q<bool?>("exclude_generated"); set => Q("exclude_generated", value); }

	/// <summary>
	/// <para>
	/// Skips the specified number of transforms.
	/// </para>
	/// </summary>
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>
	/// Specifies the maximum number of transforms to obtain.
	/// </para>
	/// </summary>
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }
}

/// <summary>
/// <para>
/// Get transforms.
/// Retrieves configuration information for transforms.
/// </para>
/// </summary>
public sealed partial class GetTransformRequest : PlainRequest<GetTransformRequestParameters>
{
	public GetTransformRequest()
	{
	}

	public GetTransformRequest(Elastic.Clients.Elasticsearch.Names? transformId) : base(r => r.Optional("transform_id", transformId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.TransformManagementGetTransform;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "transform.get_transform";

	/// <summary>
	/// <para>
	/// Specifies what to do when the request:
	/// </para>
	/// <list type="number">
	/// <item>
	/// <para>
	/// Contains wildcard expressions and there are no transforms that match.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// Contains the _all string or no identifiers and there are no matches.
	/// </para>
	/// </item>
	/// <item>
	/// <para>
	/// Contains wildcard expressions and there are only partial matches.
	/// </para>
	/// </item>
	/// </list>
	/// <para>
	/// If this parameter is false, the request returns a 404 status code when
	/// there are no matches or only partial matches.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowNoMatch { get => Q<bool?>("allow_no_match"); set => Q("allow_no_match", value); }

	/// <summary>
	/// <para>
	/// Excludes fields that were automatically added when creating the
	/// transform. This allows the configuration to be in an acceptable format to
	/// be retrieved and then added to another cluster.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? ExcludeGenerated { get => Q<bool?>("exclude_generated"); set => Q("exclude_generated", value); }

	/// <summary>
	/// <para>
	/// Skips the specified number of transforms.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? From { get => Q<int?>("from"); set => Q("from", value); }

	/// <summary>
	/// <para>
	/// Specifies the maximum number of transforms to obtain.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public int? Size { get => Q<int?>("size"); set => Q("size", value); }
}

/// <summary>
/// <para>
/// Get transforms.
/// Retrieves configuration information for transforms.
/// </para>
/// </summary>
public sealed partial class GetTransformRequestDescriptor : RequestDescriptor<GetTransformRequestDescriptor, GetTransformRequestParameters>
{
	internal GetTransformRequestDescriptor(Action<GetTransformRequestDescriptor> configure) => configure.Invoke(this);

	public GetTransformRequestDescriptor(Elastic.Clients.Elasticsearch.Names? transformId) : base(r => r.Optional("transform_id", transformId))
	{
	}

	public GetTransformRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.TransformManagementGetTransform;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "transform.get_transform";

	public GetTransformRequestDescriptor AllowNoMatch(bool? allowNoMatch = true) => Qs("allow_no_match", allowNoMatch);
	public GetTransformRequestDescriptor ExcludeGenerated(bool? excludeGenerated = true) => Qs("exclude_generated", excludeGenerated);
	public GetTransformRequestDescriptor From(int? from) => Qs("from", from);
	public GetTransformRequestDescriptor Size(int? size) => Qs("size", size);

	public GetTransformRequestDescriptor TransformId(Elastic.Clients.Elasticsearch.Names? transformId)
	{
		RouteValues.Optional("transform_id", transformId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}