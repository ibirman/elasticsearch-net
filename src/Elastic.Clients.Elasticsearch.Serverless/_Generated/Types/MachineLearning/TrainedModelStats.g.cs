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

namespace Elastic.Clients.Elasticsearch.Serverless.MachineLearning;

public sealed partial class TrainedModelStats
{
	/// <summary>
	/// <para>
	/// A collection of deployment stats, which is present when the models are deployed.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("deployment_stats")]
	public Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TrainedModelDeploymentStats? DeploymentStats { get; init; }

	/// <summary>
	/// <para>
	/// A collection of inference stats fields.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("inference_stats")]
	public Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TrainedModelInferenceStats? InferenceStats { get; init; }

	/// <summary>
	/// <para>
	/// A collection of ingest stats for the model across all nodes.
	/// The values are summations of the individual node statistics.
	/// The format matches the ingest section in the nodes stats API.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ingest")]
	public IReadOnlyDictionary<string, object>? Ingest { get; init; }

	/// <summary>
	/// <para>
	/// The unique identifier of the trained model.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("model_id")]
	public string ModelId { get; init; }

	/// <summary>
	/// <para>
	/// A collection of model size stats.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("model_size_stats")]
	public Elastic.Clients.Elasticsearch.Serverless.MachineLearning.TrainedModelSizeStats ModelSizeStats { get; init; }

	/// <summary>
	/// <para>
	/// The number of ingest pipelines that currently refer to the model.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("pipeline_count")]
	public int PipelineCount { get; init; }
}