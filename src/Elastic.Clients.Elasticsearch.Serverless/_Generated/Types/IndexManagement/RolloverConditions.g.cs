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

public sealed partial class RolloverConditions
{
	[JsonInclude, JsonPropertyName("max_age")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MaxAge { get; set; }
	[JsonInclude, JsonPropertyName("max_age_millis")]
	public long? MaxAgeMillis { get; set; }
	[JsonInclude, JsonPropertyName("max_docs")]
	public long? MaxDocs { get; set; }
	[JsonInclude, JsonPropertyName("max_primary_shard_docs")]
	public long? MaxPrimaryShardDocs { get; set; }
	[JsonInclude, JsonPropertyName("max_primary_shard_size")]
	public Elastic.Clients.Elasticsearch.Serverless.ByteSize? MaxPrimaryShardSize { get; set; }
	[JsonInclude, JsonPropertyName("max_primary_shard_size_bytes")]
	public long? MaxPrimaryShardSizeBytes { get; set; }
	[JsonInclude, JsonPropertyName("max_size")]
	public Elastic.Clients.Elasticsearch.Serverless.ByteSize? MaxSize { get; set; }
	[JsonInclude, JsonPropertyName("max_size_bytes")]
	public long? MaxSizeBytes { get; set; }
	[JsonInclude, JsonPropertyName("min_age")]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? MinAge { get; set; }
	[JsonInclude, JsonPropertyName("min_docs")]
	public long? MinDocs { get; set; }
	[JsonInclude, JsonPropertyName("min_primary_shard_docs")]
	public long? MinPrimaryShardDocs { get; set; }
	[JsonInclude, JsonPropertyName("min_primary_shard_size")]
	public Elastic.Clients.Elasticsearch.Serverless.ByteSize? MinPrimaryShardSize { get; set; }
	[JsonInclude, JsonPropertyName("min_primary_shard_size_bytes")]
	public long? MinPrimaryShardSizeBytes { get; set; }
	[JsonInclude, JsonPropertyName("min_size")]
	public Elastic.Clients.Elasticsearch.Serverless.ByteSize? MinSize { get; set; }
	[JsonInclude, JsonPropertyName("min_size_bytes")]
	public long? MinSizeBytes { get; set; }
}

public sealed partial class RolloverConditionsDescriptor : SerializableDescriptor<RolloverConditionsDescriptor>
{
	internal RolloverConditionsDescriptor(Action<RolloverConditionsDescriptor> configure) => configure.Invoke(this);

	public RolloverConditionsDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Serverless.Duration? MaxAgeValue { get; set; }
	private long? MaxAgeMillisValue { get; set; }
	private long? MaxDocsValue { get; set; }
	private long? MaxPrimaryShardDocsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.ByteSize? MaxPrimaryShardSizeValue { get; set; }
	private long? MaxPrimaryShardSizeBytesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.ByteSize? MaxSizeValue { get; set; }
	private long? MaxSizeBytesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Duration? MinAgeValue { get; set; }
	private long? MinDocsValue { get; set; }
	private long? MinPrimaryShardDocsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.ByteSize? MinPrimaryShardSizeValue { get; set; }
	private long? MinPrimaryShardSizeBytesValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.ByteSize? MinSizeValue { get; set; }
	private long? MinSizeBytesValue { get; set; }

	public RolloverConditionsDescriptor MaxAge(Elastic.Clients.Elasticsearch.Serverless.Duration? maxAge)
	{
		MaxAgeValue = maxAge;
		return Self;
	}

	public RolloverConditionsDescriptor MaxAgeMillis(long? maxAgeMillis)
	{
		MaxAgeMillisValue = maxAgeMillis;
		return Self;
	}

	public RolloverConditionsDescriptor MaxDocs(long? maxDocs)
	{
		MaxDocsValue = maxDocs;
		return Self;
	}

	public RolloverConditionsDescriptor MaxPrimaryShardDocs(long? maxPrimaryShardDocs)
	{
		MaxPrimaryShardDocsValue = maxPrimaryShardDocs;
		return Self;
	}

	public RolloverConditionsDescriptor MaxPrimaryShardSize(Elastic.Clients.Elasticsearch.Serverless.ByteSize? maxPrimaryShardSize)
	{
		MaxPrimaryShardSizeValue = maxPrimaryShardSize;
		return Self;
	}

	public RolloverConditionsDescriptor MaxPrimaryShardSizeBytes(long? maxPrimaryShardSizeBytes)
	{
		MaxPrimaryShardSizeBytesValue = maxPrimaryShardSizeBytes;
		return Self;
	}

	public RolloverConditionsDescriptor MaxSize(Elastic.Clients.Elasticsearch.Serverless.ByteSize? maxSize)
	{
		MaxSizeValue = maxSize;
		return Self;
	}

	public RolloverConditionsDescriptor MaxSizeBytes(long? maxSizeBytes)
	{
		MaxSizeBytesValue = maxSizeBytes;
		return Self;
	}

	public RolloverConditionsDescriptor MinAge(Elastic.Clients.Elasticsearch.Serverless.Duration? minAge)
	{
		MinAgeValue = minAge;
		return Self;
	}

	public RolloverConditionsDescriptor MinDocs(long? minDocs)
	{
		MinDocsValue = minDocs;
		return Self;
	}

	public RolloverConditionsDescriptor MinPrimaryShardDocs(long? minPrimaryShardDocs)
	{
		MinPrimaryShardDocsValue = minPrimaryShardDocs;
		return Self;
	}

	public RolloverConditionsDescriptor MinPrimaryShardSize(Elastic.Clients.Elasticsearch.Serverless.ByteSize? minPrimaryShardSize)
	{
		MinPrimaryShardSizeValue = minPrimaryShardSize;
		return Self;
	}

	public RolloverConditionsDescriptor MinPrimaryShardSizeBytes(long? minPrimaryShardSizeBytes)
	{
		MinPrimaryShardSizeBytesValue = minPrimaryShardSizeBytes;
		return Self;
	}

	public RolloverConditionsDescriptor MinSize(Elastic.Clients.Elasticsearch.Serverless.ByteSize? minSize)
	{
		MinSizeValue = minSize;
		return Self;
	}

	public RolloverConditionsDescriptor MinSizeBytes(long? minSizeBytes)
	{
		MinSizeBytesValue = minSizeBytes;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MaxAgeValue is not null)
		{
			writer.WritePropertyName("max_age");
			JsonSerializer.Serialize(writer, MaxAgeValue, options);
		}

		if (MaxAgeMillisValue is not null)
		{
			writer.WritePropertyName("max_age_millis");
			JsonSerializer.Serialize(writer, MaxAgeMillisValue, options);
		}

		if (MaxDocsValue.HasValue)
		{
			writer.WritePropertyName("max_docs");
			writer.WriteNumberValue(MaxDocsValue.Value);
		}

		if (MaxPrimaryShardDocsValue.HasValue)
		{
			writer.WritePropertyName("max_primary_shard_docs");
			writer.WriteNumberValue(MaxPrimaryShardDocsValue.Value);
		}

		if (MaxPrimaryShardSizeValue is not null)
		{
			writer.WritePropertyName("max_primary_shard_size");
			JsonSerializer.Serialize(writer, MaxPrimaryShardSizeValue, options);
		}

		if (MaxPrimaryShardSizeBytesValue.HasValue)
		{
			writer.WritePropertyName("max_primary_shard_size_bytes");
			writer.WriteNumberValue(MaxPrimaryShardSizeBytesValue.Value);
		}

		if (MaxSizeValue is not null)
		{
			writer.WritePropertyName("max_size");
			JsonSerializer.Serialize(writer, MaxSizeValue, options);
		}

		if (MaxSizeBytesValue.HasValue)
		{
			writer.WritePropertyName("max_size_bytes");
			writer.WriteNumberValue(MaxSizeBytesValue.Value);
		}

		if (MinAgeValue is not null)
		{
			writer.WritePropertyName("min_age");
			JsonSerializer.Serialize(writer, MinAgeValue, options);
		}

		if (MinDocsValue.HasValue)
		{
			writer.WritePropertyName("min_docs");
			writer.WriteNumberValue(MinDocsValue.Value);
		}

		if (MinPrimaryShardDocsValue.HasValue)
		{
			writer.WritePropertyName("min_primary_shard_docs");
			writer.WriteNumberValue(MinPrimaryShardDocsValue.Value);
		}

		if (MinPrimaryShardSizeValue is not null)
		{
			writer.WritePropertyName("min_primary_shard_size");
			JsonSerializer.Serialize(writer, MinPrimaryShardSizeValue, options);
		}

		if (MinPrimaryShardSizeBytesValue.HasValue)
		{
			writer.WritePropertyName("min_primary_shard_size_bytes");
			writer.WriteNumberValue(MinPrimaryShardSizeBytesValue.Value);
		}

		if (MinSizeValue is not null)
		{
			writer.WritePropertyName("min_size");
			JsonSerializer.Serialize(writer, MinSizeValue, options);
		}

		if (MinSizeBytesValue.HasValue)
		{
			writer.WritePropertyName("min_size_bytes");
			writer.WriteNumberValue(MinSizeBytesValue.Value);
		}

		writer.WriteEndObject();
	}
}