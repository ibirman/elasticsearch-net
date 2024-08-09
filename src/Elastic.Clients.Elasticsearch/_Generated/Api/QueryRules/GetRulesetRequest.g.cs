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

namespace Elastic.Clients.Elasticsearch.QueryRules;

public sealed partial class GetRulesetRequestParameters : RequestParameters
{
}

/// <summary>
/// <para>
/// Returns the details about a query ruleset
/// </para>
/// </summary>
public sealed partial class GetRulesetRequest : PlainRequest<GetRulesetRequestParameters>
{
	public GetRulesetRequest(Elastic.Clients.Elasticsearch.Id rulesetId) : base(r => r.Required("ruleset_id", rulesetId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.QueryRulesGetRuleset;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "query_rules.get_ruleset";
}

/// <summary>
/// <para>
/// Returns the details about a query ruleset
/// </para>
/// </summary>
public sealed partial class GetRulesetRequestDescriptor : RequestDescriptor<GetRulesetRequestDescriptor, GetRulesetRequestParameters>
{
	internal GetRulesetRequestDescriptor(Action<GetRulesetRequestDescriptor> configure) => configure.Invoke(this);

	public GetRulesetRequestDescriptor(Elastic.Clients.Elasticsearch.Id rulesetId) : base(r => r.Required("ruleset_id", rulesetId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.QueryRulesGetRuleset;

	protected override HttpMethod StaticHttpMethod => HttpMethod.GET;

	internal override bool SupportsBody => false;

	internal override string OperationName => "query_rules.get_ruleset";

	public GetRulesetRequestDescriptor RulesetId(Elastic.Clients.Elasticsearch.Id rulesetId)
	{
		RouteValues.Required("ruleset_id", rulesetId);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}
}