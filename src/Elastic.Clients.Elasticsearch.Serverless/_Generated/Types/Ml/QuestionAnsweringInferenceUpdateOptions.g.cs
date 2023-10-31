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

namespace Elastic.Clients.Elasticsearch.Serverless.Ml;

public sealed partial class QuestionAnsweringInferenceUpdateOptions
{
	/// <summary>
	/// <para>The maximum answer length to consider for extraction</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("max_answer_length")]
	public int? MaxAnswerLength { get; set; }

	/// <summary>
	/// <para>Specifies the number of top class predictions to return. Defaults to 0.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("num_top_classes")]
	public int? NumTopClasses { get; set; }

	/// <summary>
	/// <para>The question to answer given the inference context</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("question")]
	public string Question { get; set; }

	/// <summary>
	/// <para>The field that is added to incoming documents to contain the inference prediction. Defaults to predicted_value.</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("results_field")]
	public string? ResultsField { get; set; }

	/// <summary>
	/// <para>The tokenization options to update when inferring</para>
	/// </summary>
	[JsonInclude, JsonPropertyName("tokenization")]
	public Elastic.Clients.Elasticsearch.Serverless.Ml.NlpTokenizationUpdateOptions? Tokenization { get; set; }

	public static implicit operator InferenceConfigUpdate(QuestionAnsweringInferenceUpdateOptions questionAnsweringInferenceUpdateOptions) => Ml.InferenceConfigUpdate.QuestionAnswering(questionAnsweringInferenceUpdateOptions);
}

public sealed partial class QuestionAnsweringInferenceUpdateOptionsDescriptor : SerializableDescriptor<QuestionAnsweringInferenceUpdateOptionsDescriptor>
{
	internal QuestionAnsweringInferenceUpdateOptionsDescriptor(Action<QuestionAnsweringInferenceUpdateOptionsDescriptor> configure) => configure.Invoke(this);

	public QuestionAnsweringInferenceUpdateOptionsDescriptor() : base()
	{
	}

	private int? MaxAnswerLengthValue { get; set; }
	private int? NumTopClassesValue { get; set; }
	private string QuestionValue { get; set; }
	private string? ResultsFieldValue { get; set; }
	private Elastic.Clients.Elasticsearch.Serverless.Ml.NlpTokenizationUpdateOptions? TokenizationValue { get; set; }
	private NlpTokenizationUpdateOptionsDescriptor TokenizationDescriptor { get; set; }
	private Action<NlpTokenizationUpdateOptionsDescriptor> TokenizationDescriptorAction { get; set; }

	/// <summary>
	/// <para>The maximum answer length to consider for extraction</para>
	/// </summary>
	public QuestionAnsweringInferenceUpdateOptionsDescriptor MaxAnswerLength(int? maxAnswerLength)
	{
		MaxAnswerLengthValue = maxAnswerLength;
		return Self;
	}

	/// <summary>
	/// <para>Specifies the number of top class predictions to return. Defaults to 0.</para>
	/// </summary>
	public QuestionAnsweringInferenceUpdateOptionsDescriptor NumTopClasses(int? numTopClasses)
	{
		NumTopClassesValue = numTopClasses;
		return Self;
	}

	/// <summary>
	/// <para>The question to answer given the inference context</para>
	/// </summary>
	public QuestionAnsweringInferenceUpdateOptionsDescriptor Question(string question)
	{
		QuestionValue = question;
		return Self;
	}

	/// <summary>
	/// <para>The field that is added to incoming documents to contain the inference prediction. Defaults to predicted_value.</para>
	/// </summary>
	public QuestionAnsweringInferenceUpdateOptionsDescriptor ResultsField(string? resultsField)
	{
		ResultsFieldValue = resultsField;
		return Self;
	}

	/// <summary>
	/// <para>The tokenization options to update when inferring</para>
	/// </summary>
	public QuestionAnsweringInferenceUpdateOptionsDescriptor Tokenization(Elastic.Clients.Elasticsearch.Serverless.Ml.NlpTokenizationUpdateOptions? tokenization)
	{
		TokenizationDescriptor = null;
		TokenizationDescriptorAction = null;
		TokenizationValue = tokenization;
		return Self;
	}

	public QuestionAnsweringInferenceUpdateOptionsDescriptor Tokenization(NlpTokenizationUpdateOptionsDescriptor descriptor)
	{
		TokenizationValue = null;
		TokenizationDescriptorAction = null;
		TokenizationDescriptor = descriptor;
		return Self;
	}

	public QuestionAnsweringInferenceUpdateOptionsDescriptor Tokenization(Action<NlpTokenizationUpdateOptionsDescriptor> configure)
	{
		TokenizationValue = null;
		TokenizationDescriptor = null;
		TokenizationDescriptorAction = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (MaxAnswerLengthValue.HasValue)
		{
			writer.WritePropertyName("max_answer_length");
			writer.WriteNumberValue(MaxAnswerLengthValue.Value);
		}

		if (NumTopClassesValue.HasValue)
		{
			writer.WritePropertyName("num_top_classes");
			writer.WriteNumberValue(NumTopClassesValue.Value);
		}

		writer.WritePropertyName("question");
		writer.WriteStringValue(QuestionValue);
		if (!string.IsNullOrEmpty(ResultsFieldValue))
		{
			writer.WritePropertyName("results_field");
			writer.WriteStringValue(ResultsFieldValue);
		}

		if (TokenizationDescriptor is not null)
		{
			writer.WritePropertyName("tokenization");
			JsonSerializer.Serialize(writer, TokenizationDescriptor, options);
		}
		else if (TokenizationDescriptorAction is not null)
		{
			writer.WritePropertyName("tokenization");
			JsonSerializer.Serialize(writer, new NlpTokenizationUpdateOptionsDescriptor(TokenizationDescriptorAction), options);
		}
		else if (TokenizationValue is not null)
		{
			writer.WritePropertyName("tokenization");
			JsonSerializer.Serialize(writer, TokenizationValue, options);
		}

		writer.WriteEndObject();
	}
}