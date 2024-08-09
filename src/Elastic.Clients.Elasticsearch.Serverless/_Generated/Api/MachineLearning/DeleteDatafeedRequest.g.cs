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
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class DeleteDatafeedRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Use to forcefully delete a started datafeed; this method is quicker than
	/// stopping and deleting the datafeed.
	/// </para>
	/// </summary>
	public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }
}

/// <summary>
/// <para>
/// Delete a datafeed.
/// </para>
/// </summary>
public sealed partial class DeleteDatafeedRequest : PlainRequest<DeleteDatafeedRequestParameters>
{
	public DeleteDatafeedRequest(Elastic.Clients.Elasticsearch.Serverless.Id datafeedId) : base(r => r.Required("datafeed_id", datafeedId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningDeleteDatafeed;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.delete_datafeed";

	/// <summary>
	/// <para>
	/// Use to forcefully delete a started datafeed; this method is quicker than
	/// stopping and deleting the datafeed.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? Force { get => Q<bool?>("force"); set => Q("force", value); }
}

/// <summary>
/// <para>
/// Delete a datafeed.
/// </para>
/// </summary>
public sealed partial class DeleteDatafeedRequestDescriptor : RequestDescriptor<DeleteDatafeedRequestDescriptor, DeleteDatafeedRequestParameters>
{
	internal DeleteDatafeedRequestDescriptor(Action<DeleteDatafeedRequestDescriptor> configure) => configure.Invoke(this);

	public DeleteDatafeedRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id datafeedId) : base(r => r.Required("datafeed_id", datafeedId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.MachineLearningDeleteDatafeed;

	protected override HttpMethod StaticHttpMethod => HttpMethod.DELETE;

	internal override bool SupportsBody => false;

	internal override string OperationName => "ml.delete_datafeed";

	public DeleteDatafeedRequestDescriptor Force(bool? force = true) => Qs("force", force);

	public DeleteDatafeedRequestDescriptor DatafeedId(Elastic.Clients.Elasticsearch.Serverless.Id datafeedId)
	{
		RouteValues.Required("datafeed_id", datafeedId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}