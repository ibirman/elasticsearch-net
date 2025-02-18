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
using System.IO;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Elastic.Clients.Elasticsearch.Serverless.Security;

public sealed partial class PutPrivilegesRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If <c>true</c> (the default) then refresh the affected shards to make this operation visible to search, if <c>wait_for</c> then wait for a refresh to make this operation visible to search, if <c>false</c> then do nothing with refreshes.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Serverless.Refresh?>("refresh"); set => Q("refresh", value); }
}

/// <summary>
/// <para>
/// Create or update application privileges.
/// </para>
/// </summary>
public sealed partial class PutPrivilegesRequest : PlainRequest<PutPrivilegesRequestParameters>, ISelfSerializable
{
	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityPutPrivileges;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.put_privileges";

	/// <summary>
	/// <para>
	/// If <c>true</c> (the default) then refresh the affected shards to make this operation visible to search, if <c>wait_for</c> then wait for a refresh to make this operation visible to search, if <c>false</c> then do nothing with refreshes.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Refresh? Refresh { get => Q<Elastic.Clients.Elasticsearch.Serverless.Refresh?>("refresh"); set => Q("refresh", value); }
	public Dictionary<string, Dictionary<string, Elastic.Clients.Elasticsearch.Serverless.Security.PrivilegeActions>> Privileges { get; set; }

	void ISelfSerializable.Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		JsonSerializer.Serialize(writer, Privileges, options);
	}
}

/// <summary>
/// <para>
/// Create or update application privileges.
/// </para>
/// </summary>
public sealed partial class PutPrivilegesRequestDescriptor : RequestDescriptor<PutPrivilegesRequestDescriptor, PutPrivilegesRequestParameters>, ISelfSerializable
{
	internal PutPrivilegesRequestDescriptor(Action<PutPrivilegesRequestDescriptor> configure) => configure.Invoke(this);

	public PutPrivilegesRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.SecurityPutPrivileges;

	protected override HttpMethod StaticHttpMethod => HttpMethod.PUT;

	internal override bool SupportsBody => true;

	internal override string OperationName => "security.put_privileges";

	public PutPrivilegesRequestDescriptor Refresh(Elastic.Clients.Elasticsearch.Serverless.Refresh? refresh) => Qs("refresh", refresh);

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		JsonSerializer.Serialize(writer, _items, options);
	}

	Dictionary<string, Dictionary<string, Elastic.Clients.Elasticsearch.Serverless.Security.PrivilegeActions>> _items = new();

	public PutPrivilegesRequestDescriptor AddPrivileges(string key, Dictionary<string, Elastic.Clients.Elasticsearch.Serverless.Security.PrivilegeActions> value)
	{
		_items.Add(key, value);
		return this;
	}
}