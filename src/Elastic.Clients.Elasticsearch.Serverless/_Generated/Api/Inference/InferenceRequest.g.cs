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
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Elastic.Clients.Elasticsearch.Serverless.Inference;

public sealed partial class InferenceRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// Specifies the amount of time to wait for the inference request to complete.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }
}

/// <summary>
/// <para>
/// Perform inference on the service
/// </para>
/// </summary>
public sealed partial class InferenceRequest : PlainRequest<InferenceRequestParameters>
{
	public InferenceRequest(Elastic.Clients.Elasticsearch.Serverless.Id inferenceId) : base(r => r.Required("inference_id", inferenceId))
	{
	}

	public InferenceRequest(Elastic.Clients.Elasticsearch.Serverless.Inference.TaskType? taskType, Elastic.Clients.Elasticsearch.Serverless.Id inferenceId) : base(r => r.Optional("task_type", taskType).Required("inference_id", inferenceId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.InferenceInference;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "inference.inference";

	/// <summary>
	/// <para>
	/// Specifies the amount of time to wait for the inference request to complete.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Duration? Timeout { get => Q<Elastic.Clients.Elasticsearch.Serverless.Duration?>("timeout"); set => Q("timeout", value); }

	/// <summary>
	/// <para>
	/// Inference input.
	/// Either a string or an array of strings.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("input")]
	[SingleOrManyCollectionConverter(typeof(string))]
	public ICollection<string> Input { get; set; }

	/// <summary>
	/// <para>
	/// Query input, required for rerank task.
	/// Not required for other tasks.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("query")]
	public string? Query { get; set; }

	/// <summary>
	/// <para>
	/// Optional task settings
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("task_settings")]
	public object? TaskSettings { get; set; }
}

/// <summary>
/// <para>
/// Perform inference on the service
/// </para>
/// </summary>
public sealed partial class InferenceRequestDescriptor : RequestDescriptor<InferenceRequestDescriptor, InferenceRequestParameters>
{
	internal InferenceRequestDescriptor(Action<InferenceRequestDescriptor> configure) => configure.Invoke(this);

	public InferenceRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Inference.TaskType? taskType, Elastic.Clients.Elasticsearch.Serverless.Id inferenceId) : base(r => r.Optional("task_type", taskType).Required("inference_id", inferenceId))
	{
	}

	public InferenceRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Id inferenceId) : base(r => r.Required("inference_id", inferenceId))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.InferenceInference;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "inference.inference";

	public InferenceRequestDescriptor Timeout(Elastic.Clients.Elasticsearch.Serverless.Duration? timeout) => Qs("timeout", timeout);

	public InferenceRequestDescriptor InferenceId(Elastic.Clients.Elasticsearch.Serverless.Id inferenceId)
	{
		RouteValues.Required("inference_id", inferenceId);
		return Self;
	}

	public InferenceRequestDescriptor TaskType(Elastic.Clients.Elasticsearch.Serverless.Inference.TaskType? taskType)
	{
		RouteValues.Optional("task_type", taskType);
		return Self;
	}

	private ICollection<string> InputValue { get; set; }
	private string? QueryValue { get; set; }
	private object? TaskSettingsValue { get; set; }

	/// <summary>
	/// <para>
	/// Inference input.
	/// Either a string or an array of strings.
	/// </para>
	/// </summary>
	public InferenceRequestDescriptor Input(ICollection<string> input)
	{
		InputValue = input;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Query input, required for rerank task.
	/// Not required for other tasks.
	/// </para>
	/// </summary>
	public InferenceRequestDescriptor Query(string? query)
	{
		QueryValue = query;
		return Self;
	}

	/// <summary>
	/// <para>
	/// Optional task settings
	/// </para>
	/// </summary>
	public InferenceRequestDescriptor TaskSettings(object? taskSettings)
	{
		TaskSettingsValue = taskSettings;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("input");
		SingleOrManySerializationHelper.Serialize<string>(InputValue, writer, options);
		if (!string.IsNullOrEmpty(QueryValue))
		{
			writer.WritePropertyName("query");
			writer.WriteStringValue(QueryValue);
		}

		if (TaskSettingsValue is not null)
		{
			writer.WritePropertyName("task_settings");
			JsonSerializer.Serialize(writer, TaskSettingsValue, options);
		}

		writer.WriteEndObject();
	}
}