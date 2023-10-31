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

public sealed partial class SoftDeletes
{
	/// <summary>
	/// <para>Indicates whether soft deletes are enabled on the index.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// <para>The maximum period to retain a shard history retention lease before it is considered expired.<br/>Shard history retention leases ensure that soft deletes are retained during merges on the Lucene<br/>index. If a soft delete is merged away before it can be replicated to a follower the following<br/>process will fail due to incomplete history on the leader.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("retention_lease")]
	public Elastic.Clients.Elasticsearch.Serverless.IndexManagement.RetentionLease? RetentionLease { get; set; }
}

public sealed partial class SoftDeletesDescriptor : SerializableDescriptor<SoftDeletesDescriptor>
{
	internal SoftDeletesDescriptor(Action<SoftDeletesDescriptor> configure) => configure.Invoke(this);

	public SoftDeletesDescriptor() : base()
	{
	}

	private bool? EnabledValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.IndexManagement.RetentionLease? RetentionLeaseValue { get; set; }
	private RetentionLeaseDescriptor RetentionLeaseDescriptor { get; set; }
	private Action<RetentionLeaseDescriptor> RetentionLeaseDescriptorAction { get; set; }

	/// <summary>
	/// <para>Indicates whether soft deletes are enabled on the index.</para>
	/// </summary>
	public SoftDeletesDescriptor Enabled(bool? enabled = true)
	{
		EnabledValue = enabled;
		return Self;
	}

	/// <summary>
	/// <para>The maximum period to retain a shard history retention lease before it is considered expired.<br/>Shard history retention leases ensure that soft deletes are retained during merges on the Lucene<br/>index. If a soft delete is merged away before it can be replicated to a follower the following<br/>process will fail due to incomplete history on the leader.</para>
	/// </summary>
	public SoftDeletesDescriptor RetentionLease(Elastic.Clients.Elasticsearch.Serverless.IndexManagement.RetentionLease? retentionLease)
	{
		RetentionLeaseDescriptor = null;
		RetentionLeaseDescriptorAction = null;
		RetentionLeaseValue = retentionLease;
		return Self;
	}

	public SoftDeletesDescriptor RetentionLease(RetentionLeaseDescriptor descriptor)
	{
		RetentionLeaseValue = null;
		RetentionLeaseDescriptorAction = null;
		RetentionLeaseDescriptor = descriptor;
		return Self;
	}

	public SoftDeletesDescriptor RetentionLease(Action<RetentionLeaseDescriptor> configure)
	{
		RetentionLeaseValue = null;
		RetentionLeaseDescriptor = null;
		RetentionLeaseDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (EnabledValue.HasValue)
		{
			writer.WritePropertyName("enabled");
			writer.WriteBooleanValue(EnabledValue.Value);
		}

		if (RetentionLeaseDescriptor is not null)
		{
			writer.WritePropertyName("retention_lease");
			JsonSerializer.Serialize(writer, RetentionLeaseDescriptor, options);
		}
		else if (RetentionLeaseDescriptorAction is not null)
		{
			writer.WritePropertyName("retention_lease");
			JsonSerializer.Serialize(writer, new RetentionLeaseDescriptor(RetentionLeaseDescriptorAction), options);
		}
		else if (RetentionLeaseValue is not null)
		{
			writer.WritePropertyName("retention_lease");
			JsonSerializer.Serialize(writer, RetentionLeaseValue, options);
		}

		writer.WriteEndObject();
	}
}