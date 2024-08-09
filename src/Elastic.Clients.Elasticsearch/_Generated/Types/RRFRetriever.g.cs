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

namespace Elastic.Clients.Elasticsearch;

public sealed partial class RRFRetriever
{
	/// <summary>
	/// <para>
	/// Query to filter the documents that can match.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("filter")]
	[SingleOrManyCollectionConverter(typeof(Elastic.Clients.Elasticsearch.QueryDsl.Query))]
	public ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? Filter { get; set; }

	/// <summary>
	/// <para>
	/// This value determines how much influence documents in individual result sets per query have over the final ranked result set.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("rank_constant")]
	public int? RankConstant { get; set; }

	/// <summary>
	/// <para>
	/// This value determines the size of the individual result sets per query.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("rank_window_size")]
	public int? RankWindowSize { get; set; }

	/// <summary>
	/// <para>
	/// A list of child retrievers to specify which sets of returned top documents will have the RRF formula applied to them.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("retrievers")]
	public ICollection<Elastic.Clients.Elasticsearch.Retriever> Retrievers { get; set; }

	public static implicit operator Elastic.Clients.Elasticsearch.Retriever(RRFRetriever rRFRetriever) => Elastic.Clients.Elasticsearch.Retriever.Rrf(rRFRetriever);
}

public sealed partial class RRFRetrieverDescriptor<TDocument> : SerializableDescriptor<RRFRetrieverDescriptor<TDocument>>
{
	internal RRFRetrieverDescriptor(Action<RRFRetrieverDescriptor<TDocument>> configure) => configure.Invoke(this);

	public RRFRetrieverDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> FilterDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] FilterDescriptorActions { get; set; }
	private int? RankConstantValue { get; set; }
	private int? RankWindowSizeValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Retriever> RetrieversValue { get; set; }
	private Elastic.Clients.Elasticsearch.RetrieverDescriptor<TDocument> RetrieversDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.RetrieverDescriptor<TDocument>> RetrieversDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.RetrieverDescriptor<TDocument>>[] RetrieversDescriptorActions { get; set; }

	/// <summary>
	/// <para>
	/// Query to filter the documents that can match.
	/// </para>
	/// </summary>
	public RRFRetrieverDescriptor<TDocument> Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public RRFRetrieverDescriptor<TDocument> Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument> descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public RRFRetrieverDescriptor<TDocument> Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public RRFRetrieverDescriptor<TDocument> Filter(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// This value determines how much influence documents in individual result sets per query have over the final ranked result set.
	/// </para>
	/// </summary>
	public RRFRetrieverDescriptor<TDocument> RankConstant(int? rankConstant)
	{
		RankConstantValue = rankConstant;
		return Self;
	}

	/// <summary>
	/// <para>
	/// This value determines the size of the individual result sets per query.
	/// </para>
	/// </summary>
	public RRFRetrieverDescriptor<TDocument> RankWindowSize(int? rankWindowSize)
	{
		RankWindowSizeValue = rankWindowSize;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A list of child retrievers to specify which sets of returned top documents will have the RRF formula applied to them.
	/// </para>
	/// </summary>
	public RRFRetrieverDescriptor<TDocument> Retrievers(ICollection<Elastic.Clients.Elasticsearch.Retriever> retrievers)
	{
		RetrieversDescriptor = null;
		RetrieversDescriptorAction = null;
		RetrieversDescriptorActions = null;
		RetrieversValue = retrievers;
		return Self;
	}

	public RRFRetrieverDescriptor<TDocument> Retrievers(Elastic.Clients.Elasticsearch.RetrieverDescriptor<TDocument> descriptor)
	{
		RetrieversValue = null;
		RetrieversDescriptorAction = null;
		RetrieversDescriptorActions = null;
		RetrieversDescriptor = descriptor;
		return Self;
	}

	public RRFRetrieverDescriptor<TDocument> Retrievers(Action<Elastic.Clients.Elasticsearch.RetrieverDescriptor<TDocument>> configure)
	{
		RetrieversValue = null;
		RetrieversDescriptor = null;
		RetrieversDescriptorActions = null;
		RetrieversDescriptorAction = configure;
		return Self;
	}

	public RRFRetrieverDescriptor<TDocument> Retrievers(params Action<Elastic.Clients.Elasticsearch.RetrieverDescriptor<TDocument>>[] configure)
	{
		RetrieversValue = null;
		RetrieversDescriptor = null;
		RetrieversDescriptorAction = null;
		RetrieversDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(FilterDescriptorAction), options);
		}
		else if (FilterDescriptorActions is not null)
		{
			writer.WritePropertyName("filter");
			if (FilterDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in FilterDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor<TDocument>(action), options);
			}

			if (FilterDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(FilterValue, writer, options);
		}

		if (RankConstantValue.HasValue)
		{
			writer.WritePropertyName("rank_constant");
			writer.WriteNumberValue(RankConstantValue.Value);
		}

		if (RankWindowSizeValue.HasValue)
		{
			writer.WritePropertyName("rank_window_size");
			writer.WriteNumberValue(RankWindowSizeValue.Value);
		}

		if (RetrieversDescriptor is not null)
		{
			writer.WritePropertyName("retrievers");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, RetrieversDescriptor, options);
			writer.WriteEndArray();
		}
		else if (RetrieversDescriptorAction is not null)
		{
			writer.WritePropertyName("retrievers");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.RetrieverDescriptor<TDocument>(RetrieversDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (RetrieversDescriptorActions is not null)
		{
			writer.WritePropertyName("retrievers");
			writer.WriteStartArray();
			foreach (var action in RetrieversDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.RetrieverDescriptor<TDocument>(action), options);
			}

			writer.WriteEndArray();
		}
		else
		{
			writer.WritePropertyName("retrievers");
			JsonSerializer.Serialize(writer, RetrieversValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class RRFRetrieverDescriptor : SerializableDescriptor<RRFRetrieverDescriptor>
{
	internal RRFRetrieverDescriptor(Action<RRFRetrieverDescriptor> configure) => configure.Invoke(this);

	public RRFRetrieverDescriptor() : base()
	{
	}

	private ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? FilterValue { get; set; }
	private Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor FilterDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> FilterDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] FilterDescriptorActions { get; set; }
	private int? RankConstantValue { get; set; }
	private int? RankWindowSizeValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Retriever> RetrieversValue { get; set; }
	private Elastic.Clients.Elasticsearch.RetrieverDescriptor RetrieversDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.RetrieverDescriptor> RetrieversDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.RetrieverDescriptor>[] RetrieversDescriptorActions { get; set; }

	/// <summary>
	/// <para>
	/// Query to filter the documents that can match.
	/// </para>
	/// </summary>
	public RRFRetrieverDescriptor Filter(ICollection<Elastic.Clients.Elasticsearch.QueryDsl.Query>? filter)
	{
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterValue = filter;
		return Self;
	}

	public RRFRetrieverDescriptor Filter(Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor descriptor)
	{
		FilterValue = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = null;
		FilterDescriptor = descriptor;
		return Self;
	}

	public RRFRetrieverDescriptor Filter(Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor> configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorActions = null;
		FilterDescriptorAction = configure;
		return Self;
	}

	public RRFRetrieverDescriptor Filter(params Action<Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor>[] configure)
	{
		FilterValue = null;
		FilterDescriptor = null;
		FilterDescriptorAction = null;
		FilterDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// This value determines how much influence documents in individual result sets per query have over the final ranked result set.
	/// </para>
	/// </summary>
	public RRFRetrieverDescriptor RankConstant(int? rankConstant)
	{
		RankConstantValue = rankConstant;
		return Self;
	}

	/// <summary>
	/// <para>
	/// This value determines the size of the individual result sets per query.
	/// </para>
	/// </summary>
	public RRFRetrieverDescriptor RankWindowSize(int? rankWindowSize)
	{
		RankWindowSizeValue = rankWindowSize;
		return Self;
	}

	/// <summary>
	/// <para>
	/// A list of child retrievers to specify which sets of returned top documents will have the RRF formula applied to them.
	/// </para>
	/// </summary>
	public RRFRetrieverDescriptor Retrievers(ICollection<Elastic.Clients.Elasticsearch.Retriever> retrievers)
	{
		RetrieversDescriptor = null;
		RetrieversDescriptorAction = null;
		RetrieversDescriptorActions = null;
		RetrieversValue = retrievers;
		return Self;
	}

	public RRFRetrieverDescriptor Retrievers(Elastic.Clients.Elasticsearch.RetrieverDescriptor descriptor)
	{
		RetrieversValue = null;
		RetrieversDescriptorAction = null;
		RetrieversDescriptorActions = null;
		RetrieversDescriptor = descriptor;
		return Self;
	}

	public RRFRetrieverDescriptor Retrievers(Action<Elastic.Clients.Elasticsearch.RetrieverDescriptor> configure)
	{
		RetrieversValue = null;
		RetrieversDescriptor = null;
		RetrieversDescriptorActions = null;
		RetrieversDescriptorAction = configure;
		return Self;
	}

	public RRFRetrieverDescriptor Retrievers(params Action<Elastic.Clients.Elasticsearch.RetrieverDescriptor>[] configure)
	{
		RetrieversValue = null;
		RetrieversDescriptor = null;
		RetrieversDescriptorAction = null;
		RetrieversDescriptorActions = configure;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		if (FilterDescriptor is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, FilterDescriptor, options);
		}
		else if (FilterDescriptorAction is not null)
		{
			writer.WritePropertyName("filter");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(FilterDescriptorAction), options);
		}
		else if (FilterDescriptorActions is not null)
		{
			writer.WritePropertyName("filter");
			if (FilterDescriptorActions.Length != 1)
				writer.WriteStartArray();
			foreach (var action in FilterDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.QueryDsl.QueryDescriptor(action), options);
			}

			if (FilterDescriptorActions.Length != 1)
				writer.WriteEndArray();
		}
		else if (FilterValue is not null)
		{
			writer.WritePropertyName("filter");
			SingleOrManySerializationHelper.Serialize<Elastic.Clients.Elasticsearch.QueryDsl.Query>(FilterValue, writer, options);
		}

		if (RankConstantValue.HasValue)
		{
			writer.WritePropertyName("rank_constant");
			writer.WriteNumberValue(RankConstantValue.Value);
		}

		if (RankWindowSizeValue.HasValue)
		{
			writer.WritePropertyName("rank_window_size");
			writer.WriteNumberValue(RankWindowSizeValue.Value);
		}

		if (RetrieversDescriptor is not null)
		{
			writer.WritePropertyName("retrievers");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, RetrieversDescriptor, options);
			writer.WriteEndArray();
		}
		else if (RetrieversDescriptorAction is not null)
		{
			writer.WritePropertyName("retrievers");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.RetrieverDescriptor(RetrieversDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (RetrieversDescriptorActions is not null)
		{
			writer.WritePropertyName("retrievers");
			writer.WriteStartArray();
			foreach (var action in RetrieversDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.RetrieverDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else
		{
			writer.WritePropertyName("retrievers");
			JsonSerializer.Serialize(writer, RetrieversValue, options);
		}

		writer.WriteEndObject();
	}
}