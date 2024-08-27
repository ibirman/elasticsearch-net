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

namespace Elastic.Clients.Elasticsearch.Security;

public sealed partial class EnableUserProfileRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If 'true', Elasticsearch refreshes the affected shards to make this operation
	/// visible to search, if 'wait_for' then wait for a refresh to make this operation
	/// visible to search, if 'false' do nothing with refreshes.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }
}

/// <summary>
/// <para>
/// Enables a user profile so it's visible in user profile searches.
/// </para>
/// </summary>
public sealed partial class EnableUserProfileRequest : PlainRequest<EnableUserProfileRequestParameters>
{
	public EnableUserProfileRequest(string uid) : base(r => r.Required("uid", uid))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityEnableUserProfile;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => false;

	internal override string OperationName => "security.enable_user_profile";

	/// <summary>
	/// <para>
	/// If 'true', Elasticsearch refreshes the affected shards to make this operation
	/// visible to search, if 'wait_for' then wait for a refresh to make this operation
	/// visible to search, if 'false' do nothing with refreshes.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Refresh?>("refresh"); set => Q("refresh", value); }
}

/// <summary>
/// <para>
/// Enables a user profile so it's visible in user profile searches.
/// </para>
/// </summary>
public sealed partial class EnableUserProfileRequestDescriptor : RequestDescriptor<EnableUserProfileRequestDescriptor, EnableUserProfileRequestParameters>
{
	internal EnableUserProfileRequestDescriptor(Action<EnableUserProfileRequestDescriptor> configure) => configure.Invoke(this);

	public EnableUserProfileRequestDescriptor(string uid) : base(r => r.Required("uid", uid))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityEnableUserProfile;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => false;

	internal override string OperationName => "security.enable_user_profile";

	public EnableUserProfileRequestDescriptor Refresh(Elastic.Clients.Elasticsearch.Refresh? refresh) => Qs("refresh", refresh);

	public EnableUserProfileRequestDescriptor Uid(string uid)
	{
		RouteValues.Required("uid", uid);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}