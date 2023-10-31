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

namespace Elastic.Clients.Elasticsearch.Serverless.IndexManagement;

public sealed partial class IndexSettingsLifecycle
{
	/// <summary>
	/// <para>Indicates whether or not the index has been rolled over. Automatically set to true when ILM completes the rollover action.<br/>You can explicitly set it to skip rollover.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("indexing_complete")]
	[JsonConverter(typeof(StringifiedBoolConverter))]
	public bool? IndexingComplete { get; set; }

	/// <summary>
	/// <para>The name of the policy to use to manage the index. For information about how Elasticsearch applies policy changes, see Policy updates.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("name")]
	public Elastic.Clients.Elasticsearch.Serverless.Name Name { get; set; }

	/// <summary>
	/// <para>If specified, this is the timestamp used to calculate the index age for its phase transitions. Use this setting<br/>if you create a new index that contains old data and want to use the original creation date to calculate the index<br/>age. Specified as a Unix epoch value in milliseconds.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("origination_date")]
	public long? OriginationDate { get; set; }

	/// <summary>
	/// <para>Set to true to parse the origination date from the index name. This origination date is used to calculate the index age<br/>for its phase transitions. The index name must match the pattern ^.*-{date_format}-\\d+, where the date_format is<br/>yyyy.MM.dd and the trailing digits are optional. An index that was rolled over would normally match the full format,<br/>for example logs-2016.10.31-000002). If the index name doesn’t match the pattern, index creation fails.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("parse_origination_date")]
	public bool? ParseOriginationDate { get; set; }

	/// <summary>
	/// <para>The index alias to update when the index rolls over. Specify when using a policy that contains a rollover action.<br/>When the index rolls over, the alias is updated to reflect that the index is no longer the write index. For more<br/>information about rolling indices, see Rollover.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("rollover_alias")]
	public string? RolloverAlias { get; set; }
	[JsonInclude, JsonPropertyName("step")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettingsLifecycleStep? Step { get; set; }
}

public sealed partial class IndexSettingsLifecycleDescriptor : SerializableDescriptor<IndexSettingsLifecycleDescriptor>
{
	internal IndexSettingsLifecycleDescriptor(Action<IndexSettingsLifecycleDescriptor> configure) => configure.Invoke(this);

	public IndexSettingsLifecycleDescriptor() : base()
	{
	}

	private bool? IndexingCompleteValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Name NameValue { get; set; }
	private long? OriginationDateValue { get; set; }
	private bool? ParseOriginationDateValue { get; set; }
	private string? RolloverAliasValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettingsLifecycleStep? StepValue { get; set; }
	private IndexSettingsLifecycleStepDescriptor StepDescriptor { get; set; }
	private Action<IndexSettingsLifecycleStepDescriptor> StepDescriptorAction { get; set; }

	/// <summary>
	/// <para>Indicates whether or not the index has been rolled over. Automatically set to true when ILM completes the rollover action.<br/>You can explicitly set it to skip rollover.</para>
	/// </summary>
	public IndexSettingsLifecycleDescriptor IndexingComplete(bool? indexingComplete = true)
	{
		IndexingCompleteValue = indexingComplete;
		return Self;
	}

	/// <summary>
	/// <para>The name of the policy to use to manage the index. For information about how Elasticsearch applies policy changes, see Policy updates.</para>
	/// </summary>
	public IndexSettingsLifecycleDescriptor Name(Elastic.Clients.Elasticsearch.Serverless.Name name)
	{
		NameValue = name;
		return Self;
	}

	/// <summary>
	/// <para>If specified, this is the timestamp used to calculate the index age for its phase transitions. Use this setting<br/>if you create a new index that contains old data and want to use the original creation date to calculate the index<br/>age. Specified as a Unix epoch value in milliseconds.</para>
	/// </summary>
	public IndexSettingsLifecycleDescriptor OriginationDate(long? originationDate)
	{
		OriginationDateValue = originationDate;
		return Self;
	}

	/// <summary>
	/// <para>Set to true to parse the origination date from the index name. This origination date is used to calculate the index age<br/>for its phase transitions. The index name must match the pattern ^.*-{date_format}-\\d+, where the date_format is<br/>yyyy.MM.dd and the trailing digits are optional. An index that was rolled over would normally match the full format,<br/>for example logs-2016.10.31-000002). If the index name doesn’t match the pattern, index creation fails.</para>
	/// </summary>
	public IndexSettingsLifecycleDescriptor ParseOriginationDate(bool? parseOriginationDate = true)
	{
		ParseOriginationDateValue = parseOriginationDate;
		return Self;
	}

	/// <summary>
	/// <para>The index alias to update when the index rolls over. Specify when using a policy that contains a rollover action.<br/>When the index rolls over, the alias is updated to reflect that the index is no longer the write index. For more<br/>information about rolling indices, see Rollover.</para>
	/// </summary>
	public IndexSettingsLifecycleDescriptor RolloverAlias(string? rolloverAlias)
	{
		RolloverAliasValue = rolloverAlias;
		return Self;
	}

	public IndexSettingsLifecycleDescriptor Step(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.IndexSettingsLifecycleStep? step)
	{
		StepDescriptor = null;
		StepDescriptorAction = null;
		StepValue = step;
		return Self;
	}

	public IndexSettingsLifecycleDescriptor Step(IndexSettingsLifecycleStepDescriptor descriptor)
	{
		StepValue = null;
		StepDescriptorAction = null;
		StepDescriptor = descriptor;
		return Self;
	}

	public IndexSettingsLifecycleDescriptor Step(Action<IndexSettingsLifecycleStepDescriptor> configure)
	{
		StepValue = null;
		StepDescriptor = null;
		StepDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (IndexingCompleteValue is not null)
		{
			writer.WritePropertyName("indexing_complete");
			JsonSerializer.Serialize(writer, IndexingCompleteValue, options);
		}

		writer.WritePropertyName("name");
		JsonSerializer.Serialize(writer, NameValue, options);
		if (OriginationDateValue.HasValue)
		{
			writer.WritePropertyName("origination_date");
			writer.WriteNumberValue(OriginationDateValue.Value);
		}

		if (ParseOriginationDateValue.HasValue)
		{
			writer.WritePropertyName("parse_origination_date");
			writer.WriteBooleanValue(ParseOriginationDateValue.Value);
		}

		if (!string.IsNullOrEmpty(RolloverAliasValue))
		{
			writer.WritePropertyName("rollover_alias");
			writer.WriteStringValue(RolloverAliasValue);
		}

		if (StepDescriptor is not null)
		{
			writer.WritePropertyName("step");
			JsonSerializer.Serialize(writer, StepDescriptor, options);
		}
		else if (StepDescriptorAction is not null)
		{
			writer.WritePropertyName("step");
			JsonSerializer.Serialize(writer, new IndexSettingsLifecycleStepDescriptor(StepDescriptorAction), options);
		}
		else if (StepValue is not null)
		{
			writer.WritePropertyName("step");
			JsonSerializer.Serialize(writer, StepValue, options);
		}

		writer.WriteEndObject();
	}
}