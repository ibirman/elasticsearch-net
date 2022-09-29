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

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

#nullable restore
namespace Elastic.Clients.Elasticsearch.Ml
{
	public sealed partial class RegressionInferenceOptions
	{
		[JsonInclude]
		[JsonPropertyName("num_top_feature_importance_values")]
		public int? NumTopFeatureImportanceValues { get; set; }

		[JsonInclude]
		[JsonPropertyName("results_field")]
		public Elastic.Clients.Elasticsearch.Field? ResultsField { get; set; }
	}

	public sealed partial class RegressionInferenceOptionsDescriptor<TDocument> : SerializableDescriptorBase<RegressionInferenceOptionsDescriptor<TDocument>>
	{
		internal RegressionInferenceOptionsDescriptor(Action<RegressionInferenceOptionsDescriptor<TDocument>> configure) => configure.Invoke(this);
		public RegressionInferenceOptionsDescriptor() : base()
		{
		}

		private int? NumTopFeatureImportanceValuesValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? ResultsFieldValue { get; set; }

		public RegressionInferenceOptionsDescriptor<TDocument> NumTopFeatureImportanceValues(int? numTopFeatureImportanceValues)
		{
			NumTopFeatureImportanceValuesValue = numTopFeatureImportanceValues;
			return Self;
		}

		public RegressionInferenceOptionsDescriptor<TDocument> ResultsField(Elastic.Clients.Elasticsearch.Field? resultsField)
		{
			ResultsFieldValue = resultsField;
			return Self;
		}

		public RegressionInferenceOptionsDescriptor<TDocument> ResultsField<TValue>(Expression<Func<TDocument, TValue>> resultsField)
		{
			ResultsFieldValue = resultsField;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (NumTopFeatureImportanceValuesValue.HasValue)
			{
				writer.WritePropertyName("num_top_feature_importance_values");
				writer.WriteNumberValue(NumTopFeatureImportanceValuesValue.Value);
			}

			if (ResultsFieldValue is not null)
			{
				writer.WritePropertyName("results_field");
				JsonSerializer.Serialize(writer, ResultsFieldValue, options);
			}

			writer.WriteEndObject();
		}
	}

	public sealed partial class RegressionInferenceOptionsDescriptor : SerializableDescriptorBase<RegressionInferenceOptionsDescriptor>
	{
		internal RegressionInferenceOptionsDescriptor(Action<RegressionInferenceOptionsDescriptor> configure) => configure.Invoke(this);
		public RegressionInferenceOptionsDescriptor() : base()
		{
		}

		private int? NumTopFeatureImportanceValuesValue { get; set; }

		private Elastic.Clients.Elasticsearch.Field? ResultsFieldValue { get; set; }

		public RegressionInferenceOptionsDescriptor NumTopFeatureImportanceValues(int? numTopFeatureImportanceValues)
		{
			NumTopFeatureImportanceValuesValue = numTopFeatureImportanceValues;
			return Self;
		}

		public RegressionInferenceOptionsDescriptor ResultsField(Elastic.Clients.Elasticsearch.Field? resultsField)
		{
			ResultsFieldValue = resultsField;
			return Self;
		}

		public RegressionInferenceOptionsDescriptor ResultsField<TDocument, TValue>(Expression<Func<TDocument, TValue>> resultsField)
		{
			ResultsFieldValue = resultsField;
			return Self;
		}

		public RegressionInferenceOptionsDescriptor ResultsField<TDocument>(Expression<Func<TDocument, object>> resultsField)
		{
			ResultsFieldValue = resultsField;
			return Self;
		}

		protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
		{
			writer.WriteStartObject();
			if (NumTopFeatureImportanceValuesValue.HasValue)
			{
				writer.WritePropertyName("num_top_feature_importance_values");
				writer.WriteNumberValue(NumTopFeatureImportanceValuesValue.Value);
			}

			if (ResultsFieldValue is not null)
			{
				writer.WritePropertyName("results_field");
				JsonSerializer.Serialize(writer, ResultsFieldValue, options);
			}

			writer.WriteEndObject();
		}
	}
}