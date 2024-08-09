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

namespace Elastic.Clients.Elasticsearch.Ingest;

public sealed partial class InferenceProcessor
{
	/// <summary>
	/// <para>
	/// Description of the processor.
	/// Useful for describing the purpose of the processor or its configuration.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("description")]
	public string? Description { get; set; }

	/// <summary>
	/// <para>
	/// Maps the document field names to the known field names of the model.
	/// This mapping takes precedence over any default mappings provided in the model configuration.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("field_map")]
	public IDictionary<Elastic.Clients.Elasticsearch.Field, object>? FieldMap { get; set; }

	/// <summary>
	/// <para>
	/// Conditionally execute the processor.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("if")]
	public string? If { get; set; }

	/// <summary>
	/// <para>
	/// Ignore failures for the processor.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ignore_failure")]
	public bool? IgnoreFailure { get; set; }

	/// <summary>
	/// <para>
	/// Contains the inference type and its options.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("inference_config")]
	public Elastic.Clients.Elasticsearch.Ingest.InferenceConfig? InferenceConfig { get; set; }

	/// <summary>
	/// <para>
	/// The ID or alias for the trained model, or the ID of the deployment.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("model_id")]
	public Elastic.Clients.Elasticsearch.Id ModelId { get; set; }

	/// <summary>
	/// <para>
	/// Handle failures for the processor.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("on_failure")]
	public ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailure { get; set; }

	/// <summary>
	/// <para>
	/// Identifier for the processor.
	/// Useful for debugging and metrics.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tag")]
	public string? Tag { get; set; }

	/// <summary>
	/// <para>
	/// Field added to incoming documents to contain results objects.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("target_field")]
	public Elastic.Clients.Elasticsearch.Field? TargetField { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Ingest.Processor(InferenceProcessor inferenceProcessor) => Elastic.Clients.Elasticsearch.Ingest.Processor.Inference(inferenceProcessor);
}

public sealed partial class InferenceProcessorDescriptor<TDocument> : SerializableDescriptor<InferenceProcessorDescriptor<TDocument>>
{
	internal InferenceProcessorDescriptor(Action<InferenceProcessorDescriptor<TDocument>> configure) => configure.Invoke(this);

	public InferenceProcessorDescriptor() : base()
	{
	}

	private string? DescriptionValue { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Field, object>? FieldMapValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.InferenceConfig? InferenceConfigValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.InferenceConfigDescriptor<TDocument> InferenceConfigDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.InferenceConfigDescriptor<TDocument>> InferenceConfigDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Id ModelIdValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument> OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>>[] OnFailureDescriptorActions { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? TargetFieldValue { get; set; }

	/// <summary>
	/// <para>
	/// Description of the processor.
	/// Useful for describing the purpose of the processor or its configuration.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor<TDocument> Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maps the document field names to the known field names of the model.
	/// This mapping takes precedence over any default mappings provided in the model configuration.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor<TDocument> FieldMap(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, object>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, object>> selector)
	{
		FieldMapValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, object>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// Conditionally execute the processor.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor<TDocument> If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Ignore failures for the processor.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor<TDocument> IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Contains the inference type and its options.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor<TDocument> InferenceConfig(Elastic.Clients.Elasticsearch.Ingest.InferenceConfig? inferenceConfig)
	{
		InferenceConfigDescriptor = null;
		InferenceConfigDescriptorAction = null;
		InferenceConfigValue = inferenceConfig;
		return Self;
	}

	public InferenceProcessorDescriptor<TDocument> InferenceConfig(Elastic.Clients.Elasticsearch.Ingest.InferenceConfigDescriptor<TDocument> descriptor)
	{
		InferenceConfigValue = null;
		InferenceConfigDescriptorAction = null;
		InferenceConfigDescriptor = descriptor;
		return Self;
	}

	public InferenceProcessorDescriptor<TDocument> InferenceConfig(Action<Elastic.Clients.Elasticsearch.Ingest.InferenceConfigDescriptor<TDocument>> configure)
	{
		InferenceConfigValue = null;
		InferenceConfigDescriptor = null;
		InferenceConfigDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The ID or alias for the trained model, or the ID of the deployment.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor<TDocument> ModelId(Elastic.Clients.Elasticsearch.Id modelId)
	{
		ModelIdValue = modelId;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Handle failures for the processor.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor<TDocument> OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public InferenceProcessorDescriptor<TDocument> OnFailure(Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument> descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public InferenceProcessorDescriptor<TDocument> OnFailure(Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public InferenceProcessorDescriptor<TDocument> OnFailure(params Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Identifier for the processor.
	/// Useful for debugging and metrics.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor<TDocument> Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Field added to incoming documents to contain results objects.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor<TDocument> TargetField(Elastic.Clients.Elasticsearch.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Field added to incoming documents to contain results objects.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor<TDocument> TargetField<TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Field added to incoming documents to contain results objects.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor<TDocument> TargetField(Expression<Func<TDocument, object>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (FieldMapValue is not null)
		{
			writer.WritePropertyName("field_map");
			JsonSerializer.Serialize(writer, FieldMapValue, options);
		}

		if (!string.IsNullOrEmpty(IfValue))
		{
			writer.WritePropertyName("if");
			writer.WriteStringValue(IfValue);
		}

		if (IgnoreFailureValue.HasValue)
		{
			writer.WritePropertyName("ignore_failure");
			writer.WriteBooleanValue(IgnoreFailureValue.Value);
		}

		if (InferenceConfigDescriptor is not null)
		{
			writer.WritePropertyName("inference_config");
			JsonSerializer.Serialize(writer, InferenceConfigDescriptor, options);
		}
		else if (InferenceConfigDescriptorAction is not null)
		{
			writer.WritePropertyName("inference_config");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.InferenceConfigDescriptor<TDocument>(InferenceConfigDescriptorAction), options);
		}
		else if (InferenceConfigValue is not null)
		{
			writer.WritePropertyName("inference_config");
			JsonSerializer.Serialize(writer, InferenceConfigValue, options);
		}

		writer.WritePropertyName("model_id");
		JsonSerializer.Serialize(writer, ModelIdValue, options);
		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class InferenceProcessorDescriptor : SerializableDescriptor<InferenceProcessorDescriptor>
{
	internal InferenceProcessorDescriptor(Action<InferenceProcessorDescriptor> configure) => configure.Invoke(this);

	public InferenceProcessorDescriptor() : base()
	{
	}

	private string? DescriptionValue { get; set; }
	private IDictionary<Elastic.Clients.Elasticsearch.Field, object>? FieldMapValue { get; set; }
	private string? IfValue { get; set; }
	private bool? IgnoreFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.InferenceConfig? InferenceConfigValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.InferenceConfigDescriptor InferenceConfigDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.InferenceConfigDescriptor> InferenceConfigDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Id ModelIdValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? OnFailureValue { get; set; }
	private Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor OnFailureDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor> OnFailureDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor>[] OnFailureDescriptorActions { get; set; }
	private string? TagValue { get; set; }
	private Elastic.Clients.Elasticsearch.Field? TargetFieldValue { get; set; }

	/// <summary>
	/// <para>
	/// Description of the processor.
	/// Useful for describing the purpose of the processor or its configuration.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor Description(string? description)
	{
		DescriptionValue = description;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Maps the document field names to the known field names of the model.
	/// This mapping takes precedence over any default mappings provided in the model configuration.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor FieldMap(Func<FluentDictionary<Elastic.Clients.Elasticsearch.Field, object>, FluentDictionary<Elastic.Clients.Elasticsearch.Field, object>> selector)
	{
		FieldMapValue = selector?.Invoke(new FluentDictionary<Elastic.Clients.Elasticsearch.Field, object>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// Conditionally execute the processor.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor If(string? value)
	{
		IfValue = value;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Ignore failures for the processor.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor IgnoreFailure(bool? ignoreFailure = true)
	{
		IgnoreFailureValue = ignoreFailure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Contains the inference type and its options.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor InferenceConfig(Elastic.Clients.Elasticsearch.Ingest.InferenceConfig? inferenceConfig)
	{
		InferenceConfigDescriptor = null;
		InferenceConfigDescriptorAction = null;
		InferenceConfigValue = inferenceConfig;
		return Self;
	}

	public InferenceProcessorDescriptor InferenceConfig(Elastic.Clients.Elasticsearch.Ingest.InferenceConfigDescriptor descriptor)
	{
		InferenceConfigValue = null;
		InferenceConfigDescriptorAction = null;
		InferenceConfigDescriptor = descriptor;
		return Self;
	}

	public InferenceProcessorDescriptor InferenceConfig(Action<Elastic.Clients.Elasticsearch.Ingest.InferenceConfigDescriptor> configure)
	{
		InferenceConfigValue = null;
		InferenceConfigDescriptor = null;
		InferenceConfigDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The ID or alias for the trained model, or the ID of the deployment.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor ModelId(Elastic.Clients.Elasticsearch.Id modelId)
	{
		ModelIdValue = modelId;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Handle failures for the processor.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor OnFailure(ICollection<Elastic.Clients.Elasticsearch.Ingest.Processor>? onFailure)
	{
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureValue = onFailure;
		return Self;
	}

	public InferenceProcessorDescriptor OnFailure(Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor descriptor)
	{
		OnFailureValue = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptor = descriptor;
		return Self;
	}

	public InferenceProcessorDescriptor OnFailure(Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor> configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorActions = null;
		OnFailureDescriptorAction = configure;
		return Self;
	}

	public InferenceProcessorDescriptor OnFailure(params Action<Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor>[] configure)
	{
		OnFailureValue = null;
		OnFailureDescriptor = null;
		OnFailureDescriptorAction = null;
		OnFailureDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Identifier for the processor.
	/// Useful for debugging and metrics.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor Tag(string? tag)
	{
		TagValue = tag;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Field added to incoming documents to contain results objects.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor TargetField(Elastic.Clients.Elasticsearch.Field? targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Field added to incoming documents to contain results objects.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor TargetField<TDocument, TValue>(Expression<Func<TDocument, TValue>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Field added to incoming documents to contain results objects.
	/// </para>
	/// </summary>
	public InferenceProcessorDescriptor TargetField<TDocument>(Expression<Func<TDocument, object>> targetField)
	{
		TargetFieldValue = targetField;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (!string.IsNullOrEmpty(DescriptionValue))
		{
			writer.WritePropertyName("description");
			writer.WriteStringValue(DescriptionValue);
		}

		if (FieldMapValue is not null)
		{
			writer.WritePropertyName("field_map");
			JsonSerializer.Serialize(writer, FieldMapValue, options);
		}

		if (!string.IsNullOrEmpty(IfValue))
		{
			writer.WritePropertyName("if");
			writer.WriteStringValue(IfValue);
		}

		if (IgnoreFailureValue.HasValue)
		{
			writer.WritePropertyName("ignore_failure");
			writer.WriteBooleanValue(IgnoreFailureValue.Value);
		}

		if (InferenceConfigDescriptor is not null)
		{
			writer.WritePropertyName("inference_config");
			JsonSerializer.Serialize(writer, InferenceConfigDescriptor, options);
		}
		else if (InferenceConfigDescriptorAction is not null)
		{
			writer.WritePropertyName("inference_config");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.InferenceConfigDescriptor(InferenceConfigDescriptorAction), options);
		}
		else if (InferenceConfigValue is not null)
		{
			writer.WritePropertyName("inference_config");
			JsonSerializer.Serialize(writer, InferenceConfigValue, options);
		}

		writer.WritePropertyName("model_id");
		JsonSerializer.Serialize(writer, ModelIdValue, options);
		if (OnFailureDescriptor is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, OnFailureDescriptor, options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorAction is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor(OnFailureDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (OnFailureDescriptorActions is not null)
		{
			writer.WritePropertyName("on_failure");
			writer.WriteStartArray();
			foreach (var action in OnFailureDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Ingest.ProcessorDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else if (OnFailureValue is not null)
		{
			writer.WritePropertyName("on_failure");
			JsonSerializer.Serialize(writer, OnFailureValue, options);
		}

		if (!string.IsNullOrEmpty(TagValue))
		{
			writer.WritePropertyName("tag");
			writer.WriteStringValue(TagValue);
		}

		if (TargetFieldValue is not null)
		{
			writer.WritePropertyName("target_field");
			JsonSerializer.Serialize(writer, TargetFieldValue, options);
		}

		writer.WriteEndObject();
	}
}