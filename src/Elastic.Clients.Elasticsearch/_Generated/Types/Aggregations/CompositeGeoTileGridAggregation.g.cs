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
using Elastic.Clients.Elasticsearch.Serialization;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Aggregations;

public sealed partial class CompositeGeoTileGridAggregation
{
	[JsonInclude, JsonPropertyName("bounds")]
	public Elastic.Clients.Elasticsearch.GeoBounds? Bounds { get; set; }

	/// <summary>
	/// <para>
	/// Either <c>field</c> or <c>script</c> must be present
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field")]
	public Elastic.Clients.Elasticsearch.Field? Field { get; set; }
	[JsonInclude, JsonPropertyName("missing_bucket")]
	public bool? MissingBucket { get; set; }
	[JsonInclude, JsonPropertyName("missing_order")]
	public Elastic.Clients.Elasticsearch.Aggregations.MissingOrder? MissingOrder { get; set; }
	[JsonInclude, JsonPropertyName("order")]
	public Elastic.Clients.Elasticsearch.SortOrder? Order { get; set; }
	[JsonInclude, JsonPropertyName("precision")]
	public int? Precision { get; set; }

	/// <summary>
	/// <para>
	/// Either <c>field</c> or <c>script</c> must be present
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("script")]
	public Elastic.Clients.Elasticsearch.Script? Script { get; set; }
	[JsonInclude, JsonPropertyName("value_type")]
	public Elastic.Clients.Elasticsearch.Aggregations.ValueType? ValueType { get; set; }
}

public sealed partial class CompositeGeoTileGridAggregationDescriptor<TDocument> : SerializableDescriptor<CompositeGeoTileGridAggregationDescriptor<TDocument>>
{
	internal CompositeGeoTileGridAggregationDescriptor(Action<CompositeGeoTileGridAggregationDescriptor<TDocument>> configure) => configure.Invoke(this);

	public CompositeGeoTileGridAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.GeoBounds? BoundsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private bool? MissingBucketValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.MissingOrder? MissingOrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortOrder? OrderValue { get; set; }
	private int? PrecisionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private Elastic.Clients.Elasticsearch.ScriptDescriptor ScriptDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> ScriptDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.ValueType? ValueTypeValue { get; set; }

	public CompositeGeoTileGridAggregationDescriptor<TDocument> Bounds(Elastic.Clients.Elasticsearch.GeoBounds? bounds)
	{
		BoundsValue = bounds;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Either <c>field</c> or <c>script</c> must be present
	/// </para>
	/// </summary>
	public CompositeGeoTileGridAggregationDescriptor<TDocument> Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Either <c>field</c> or <c>script</c> must be present
	/// </para>
	/// </summary>
	public CompositeGeoTileGridAggregationDescriptor<TDocument> Field<TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Either <c>field</c> or <c>script</c> must be present
	/// </para>
	/// </summary>
	public CompositeGeoTileGridAggregationDescriptor<TDocument> Field(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public CompositeGeoTileGridAggregationDescriptor<TDocument> MissingBucket(bool? missingBucket = true)
	{
		MissingBucketValue = missingBucket;
		return Self;
	}

	public CompositeGeoTileGridAggregationDescriptor<TDocument> MissingOrder(Elastic.Clients.Elasticsearch.Aggregations.MissingOrder? missingOrder)
	{
		MissingOrderValue = missingOrder;
		return Self;
	}

	public CompositeGeoTileGridAggregationDescriptor<TDocument> Order(Elastic.Clients.Elasticsearch.SortOrder? order)
	{
		OrderValue = order;
		return Self;
	}

	public CompositeGeoTileGridAggregationDescriptor<TDocument> Precision(int? precision)
	{
		PrecisionValue = precision;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Either <c>field</c> or <c>script</c> must be present
	/// </para>
	/// </summary>
	public CompositeGeoTileGridAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public CompositeGeoTileGridAggregationDescriptor<TDocument> Script(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public CompositeGeoTileGridAggregationDescriptor<TDocument> Script(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	public CompositeGeoTileGridAggregationDescriptor<TDocument> ValueType(Elastic.Clients.Elasticsearch.Aggregations.ValueType? valueType)
	{
		ValueTypeValue = valueType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BoundsValue is not null)
		{
			writer.WritePropertyName("bounds");
			JsonSerializer.Serialize(writer, BoundsValue, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (MissingBucketValue.HasValue)
		{
			writer.WritePropertyName("missing_bucket");
			writer.WriteBooleanValue(MissingBucketValue.Value);
		}

		if (MissingOrderValue is not null)
		{
			writer.WritePropertyName("missing_order");
			JsonSerializer.Serialize(writer, MissingOrderValue, options);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			JsonSerializer.Serialize(writer, OrderValue, options);
		}

		if (PrecisionValue.HasValue)
		{
			writer.WritePropertyName("precision");
			writer.WriteNumberValue(PrecisionValue.Value);
		}

		if (ScriptDescriptor is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptDescriptor, options);
		}
		else if (ScriptDescriptorAction is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(ScriptDescriptorAction), options);
		}
		else if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (ValueTypeValue is not null)
		{
			writer.WritePropertyName("value_type");
			JsonSerializer.Serialize(writer, ValueTypeValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class CompositeGeoTileGridAggregationDescriptor : SerializableDescriptor<CompositeGeoTileGridAggregationDescriptor>
{
	internal CompositeGeoTileGridAggregationDescriptor(Action<CompositeGeoTileGridAggregationDescriptor> configure) => configure.Invoke(this);

	public CompositeGeoTileGridAggregationDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.GeoBounds? BoundsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? FieldValue { get; set; }
	private bool? MissingBucketValue { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.MissingOrder? MissingOrderValue { get; set; }
	private Elastic.Clients.Elasticsearch.SortOrder? OrderValue { get; set; }
	private int? PrecisionValue { get; set; }
	private Elastic.Clients.Elasticsearch.Script? ScriptValue { get; set; }
	private Elastic.Clients.Elasticsearch.ScriptDescriptor ScriptDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> ScriptDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Aggregations.ValueType? ValueTypeValue { get; set; }

	public CompositeGeoTileGridAggregationDescriptor Bounds(Elastic.Clients.Elasticsearch.GeoBounds? bounds)
	{
		BoundsValue = bounds;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Either <c>field</c> or <c>script</c> must be present
	/// </para>
	/// </summary>
	public CompositeGeoTileGridAggregationDescriptor Field(Elastic.Clients.Elasticsearch.Field? field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Either <c>field</c> or <c>script</c> must be present
	/// </para>
	/// </summary>
	public CompositeGeoTileGridAggregationDescriptor Field<TDocument, TValue>(Expression<Func<TDocument, TValue>> field)
	{
		FieldValue = field;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Either <c>field</c> or <c>script</c> must be present
	/// </para>
	/// </summary>
	public CompositeGeoTileGridAggregationDescriptor Field<TDocument>(Expression<Func<TDocument, object>> field)
	{
		FieldValue = field;
		return Self;
	}

	public CompositeGeoTileGridAggregationDescriptor MissingBucket(bool? missingBucket = true)
	{
		MissingBucketValue = missingBucket;
		return Self;
	}

	public CompositeGeoTileGridAggregationDescriptor MissingOrder(Elastic.Clients.Elasticsearch.Aggregations.MissingOrder? missingOrder)
	{
		MissingOrderValue = missingOrder;
		return Self;
	}

	public CompositeGeoTileGridAggregationDescriptor Order(Elastic.Clients.Elasticsearch.SortOrder? order)
	{
		OrderValue = order;
		return Self;
	}

	public CompositeGeoTileGridAggregationDescriptor Precision(int? precision)
	{
		PrecisionValue = precision;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Either <c>field</c> or <c>script</c> must be present
	/// </para>
	/// </summary>
	public CompositeGeoTileGridAggregationDescriptor Script(Elastic.Clients.Elasticsearch.Script? script)
	{
		ScriptDescriptor = null;
		ScriptDescriptorAction = null;
		ScriptValue = script;
		return Self;
	}

	public CompositeGeoTileGridAggregationDescriptor Script(Elastic.Clients.Elasticsearch.ScriptDescriptor descriptor)
	{
		ScriptValue = null;
		ScriptDescriptorAction = null;
		ScriptDescriptor = descriptor;
		return Self;
	}

	public CompositeGeoTileGridAggregationDescriptor Script(Action<Elastic.Clients.Elasticsearch.ScriptDescriptor> configure)
	{
		ScriptValue = null;
		ScriptDescriptor = null;
		ScriptDescriptorAction = configure;
		return Self;
	}

	public CompositeGeoTileGridAggregationDescriptor ValueType(Elastic.Clients.Elasticsearch.Aggregations.ValueType? valueType)
	{
		ValueTypeValue = valueType;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (BoundsValue is not null)
		{
			writer.WritePropertyName("bounds");
			JsonSerializer.Serialize(writer, BoundsValue, options);
		}

		if (FieldValue is not null)
		{
			writer.WritePropertyName("field");
			JsonSerializer.Serialize(writer, FieldValue, options);
		}

		if (MissingBucketValue.HasValue)
		{
			writer.WritePropertyName("missing_bucket");
			writer.WriteBooleanValue(MissingBucketValue.Value);
		}

		if (MissingOrderValue is not null)
		{
			writer.WritePropertyName("missing_order");
			JsonSerializer.Serialize(writer, MissingOrderValue, options);
		}

		if (OrderValue is not null)
		{
			writer.WritePropertyName("order");
			JsonSerializer.Serialize(writer, OrderValue, options);
		}

		if (PrecisionValue.HasValue)
		{
			writer.WritePropertyName("precision");
			writer.WriteNumberValue(PrecisionValue.Value);
		}

		if (ScriptDescriptor is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptDescriptor, options);
		}
		else if (ScriptDescriptorAction is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.ScriptDescriptor(ScriptDescriptorAction), options);
		}
		else if (ScriptValue is not null)
		{
			writer.WritePropertyName("script");
			JsonSerializer.Serialize(writer, ScriptValue, options);
		}

		if (ValueTypeValue is not null)
		{
			writer.WritePropertyName("value_type");
			JsonSerializer.Serialize(writer, ValueTypeValue, options);
		}

		writer.WriteEndObject();
	}
}