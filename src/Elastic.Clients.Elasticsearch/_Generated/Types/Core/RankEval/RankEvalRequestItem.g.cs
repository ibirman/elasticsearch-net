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

namespace Elastic.Clients.Elasticsearch.Core.RankEval;

public sealed partial class RankEvalRequestItem
{
	/// <summary>
	/// <para>
	/// The search request’s ID, used to group result details later.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("id")]
	public Elastic.Clients.Elasticsearch.Id Id { get; set; }

	/// <summary>
	/// <para>
	/// The search template parameters.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("params")]
	public IDictionary<string, object>? Params { get; set; }

	/// <summary>
	/// <para>
	/// List of document ratings
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("ratings")]
	public ICollection<Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRating> Ratings { get; set; }

	/// <summary>
	/// <para>
	/// The query being evaluated.
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("request")]
	public Elastic.Clients.Elasticsearch.Core.RankEval.RankEvalQuery? Request { get; set; }

	/// <summary>
	/// <para>
	/// The search template Id
	/// </para>
	/// </summary>
	[JsonInclude, JsonPropertyName("template_id")]
	public Elastic.Clients.Elasticsearch.Id? TemplateId { get; set; }
}

public sealed partial class RankEvalRequestItemDescriptor<TDocument> : SerializableDescriptor<RankEvalRequestItemDescriptor<TDocument>>
{
	internal RankEvalRequestItemDescriptor(Action<RankEvalRequestItemDescriptor<TDocument>> configure) => configure.Invoke(this);

	public RankEvalRequestItemDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Id IdValue { get; set; }
	private IDictionary<string, object>? ParamsValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRating> RatingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor RatingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor> RatingsDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor>[] RatingsDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Core.RankEval.RankEvalQuery? RequestValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.RankEval.RankEvalQueryDescriptor<TDocument> RequestDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Core.RankEval.RankEvalQueryDescriptor<TDocument>> RequestDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Id? TemplateIdValue { get; set; }

	/// <summary>
	/// <para>
	/// The search request’s ID, used to group result details later.
	/// </para>
	/// </summary>
	public RankEvalRequestItemDescriptor<TDocument> Id(Elastic.Clients.Elasticsearch.Id id)
	{
		IdValue = id;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The search template parameters.
	/// </para>
	/// </summary>
	public RankEvalRequestItemDescriptor<TDocument> Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// List of document ratings
	/// </para>
	/// </summary>
	public RankEvalRequestItemDescriptor<TDocument> Ratings(ICollection<Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRating> ratings)
	{
		RatingsDescriptor = null;
		RatingsDescriptorAction = null;
		RatingsDescriptorActions = null;
		RatingsValue = ratings;
		return Self;
	}

	public RankEvalRequestItemDescriptor<TDocument> Ratings(Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor descriptor)
	{
		RatingsValue = null;
		RatingsDescriptorAction = null;
		RatingsDescriptorActions = null;
		RatingsDescriptor = descriptor;
		return Self;
	}

	public RankEvalRequestItemDescriptor<TDocument> Ratings(Action<Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor> configure)
	{
		RatingsValue = null;
		RatingsDescriptor = null;
		RatingsDescriptorActions = null;
		RatingsDescriptorAction = configure;
		return Self;
	}

	public RankEvalRequestItemDescriptor<TDocument> Ratings(params Action<Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor>[] configure)
	{
		RatingsValue = null;
		RatingsDescriptor = null;
		RatingsDescriptorAction = null;
		RatingsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The query being evaluated.
	/// </para>
	/// </summary>
	public RankEvalRequestItemDescriptor<TDocument> Request(Elastic.Clients.Elasticsearch.Core.RankEval.RankEvalQuery? request)
	{
		RequestDescriptor = null;
		RequestDescriptorAction = null;
		RequestValue = request;
		return Self;
	}

	public RankEvalRequestItemDescriptor<TDocument> Request(Elastic.Clients.Elasticsearch.Core.RankEval.RankEvalQueryDescriptor<TDocument> descriptor)
	{
		RequestValue = null;
		RequestDescriptorAction = null;
		RequestDescriptor = descriptor;
		return Self;
	}

	public RankEvalRequestItemDescriptor<TDocument> Request(Action<Elastic.Clients.Elasticsearch.Core.RankEval.RankEvalQueryDescriptor<TDocument>> configure)
	{
		RequestValue = null;
		RequestDescriptor = null;
		RequestDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The search template Id
	/// </para>
	/// </summary>
	public RankEvalRequestItemDescriptor<TDocument> TemplateId(Elastic.Clients.Elasticsearch.Id? templateId)
	{
		TemplateIdValue = templateId;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("id");
		JsonSerializer.Serialize(writer, IdValue, options);
		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (RatingsDescriptor is not null)
		{
			writer.WritePropertyName("ratings");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, RatingsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (RatingsDescriptorAction is not null)
		{
			writer.WritePropertyName("ratings");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor(RatingsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (RatingsDescriptorActions is not null)
		{
			writer.WritePropertyName("ratings");
			writer.WriteStartArray();
			foreach (var action in RatingsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else
		{
			writer.WritePropertyName("ratings");
			JsonSerializer.Serialize(writer, RatingsValue, options);
		}

		if (RequestDescriptor is not null)
		{
			writer.WritePropertyName("request");
			JsonSerializer.Serialize(writer, RequestDescriptor, options);
		}
		else if (RequestDescriptorAction is not null)
		{
			writer.WritePropertyName("request");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Core.RankEval.RankEvalQueryDescriptor<TDocument>(RequestDescriptorAction), options);
		}
		else if (RequestValue is not null)
		{
			writer.WritePropertyName("request");
			JsonSerializer.Serialize(writer, RequestValue, options);
		}

		if (TemplateIdValue is not null)
		{
			writer.WritePropertyName("template_id");
			JsonSerializer.Serialize(writer, TemplateIdValue, options);
		}

		writer.WriteEndObject();
	}
}

public sealed partial class RankEvalRequestItemDescriptor : SerializableDescriptor<RankEvalRequestItemDescriptor>
{
	internal RankEvalRequestItemDescriptor(Action<RankEvalRequestItemDescriptor> configure) => configure.Invoke(this);

	public RankEvalRequestItemDescriptor() : base()
	{
	}

	private Elastic.Clients.Elasticsearch.Id IdValue { get; set; }
	private IDictionary<string, object>? ParamsValue { get; set; }
	private ICollection<Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRating> RatingsValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor RatingsDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor> RatingsDescriptorAction { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor>[] RatingsDescriptorActions { get; set; }
	private Elastic.Clients.Elasticsearch.Core.RankEval.RankEvalQuery? RequestValue { get; set; }
	private Elastic.Clients.Elasticsearch.Core.RankEval.RankEvalQueryDescriptor RequestDescriptor { get; set; }
	private Action<Elastic.Clients.Elasticsearch.Core.RankEval.RankEvalQueryDescriptor> RequestDescriptorAction { get; set; }
	private Elastic.Clients.Elasticsearch.Id? TemplateIdValue { get; set; }

	/// <summary>
	/// <para>
	/// The search request’s ID, used to group result details later.
	/// </para>
	/// </summary>
	public RankEvalRequestItemDescriptor Id(Elastic.Clients.Elasticsearch.Id id)
	{
		IdValue = id;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The search template parameters.
	/// </para>
	/// </summary>
	public RankEvalRequestItemDescriptor Params(Func<FluentDictionary<string, object>, FluentDictionary<string, object>> selector)
	{
		ParamsValue = selector?.Invoke(new FluentDictionary<string, object>());
		return Self;
	}

	/// <summary>
	/// <para>
	/// List of document ratings
	/// </para>
	/// </summary>
	public RankEvalRequestItemDescriptor Ratings(ICollection<Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRating> ratings)
	{
		RatingsDescriptor = null;
		RatingsDescriptorAction = null;
		RatingsDescriptorActions = null;
		RatingsValue = ratings;
		return Self;
	}

	public RankEvalRequestItemDescriptor Ratings(Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor descriptor)
	{
		RatingsValue = null;
		RatingsDescriptorAction = null;
		RatingsDescriptorActions = null;
		RatingsDescriptor = descriptor;
		return Self;
	}

	public RankEvalRequestItemDescriptor Ratings(Action<Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor> configure)
	{
		RatingsValue = null;
		RatingsDescriptor = null;
		RatingsDescriptorActions = null;
		RatingsDescriptorAction = configure;
		return Self;
	}

	public RankEvalRequestItemDescriptor Ratings(params Action<Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor>[] configure)
	{
		RatingsValue = null;
		RatingsDescriptor = null;
		RatingsDescriptorAction = null;
		RatingsDescriptorActions = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The query being evaluated.
	/// </para>
	/// </summary>
	public RankEvalRequestItemDescriptor Request(Elastic.Clients.Elasticsearch.Core.RankEval.RankEvalQuery? request)
	{
		RequestDescriptor = null;
		RequestDescriptorAction = null;
		RequestValue = request;
		return Self;
	}

	public RankEvalRequestItemDescriptor Request(Elastic.Clients.Elasticsearch.Core.RankEval.RankEvalQueryDescriptor descriptor)
	{
		RequestValue = null;
		RequestDescriptorAction = null;
		RequestDescriptor = descriptor;
		return Self;
	}

	public RankEvalRequestItemDescriptor Request(Action<Elastic.Clients.Elasticsearch.Core.RankEval.RankEvalQueryDescriptor> configure)
	{
		RequestValue = null;
		RequestDescriptor = null;
		RequestDescriptorAction = configure;
		return Self;
	}

	/// <summary>
	/// <para>
	/// The search template Id
	/// </para>
	/// </summary>
	public RankEvalRequestItemDescriptor TemplateId(Elastic.Clients.Elasticsearch.Id? templateId)
	{
		TemplateIdValue = templateId;
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
		writer.WriteStartObject();
		writer.WritePropertyName("id");
		JsonSerializer.Serialize(writer, IdValue, options);
		if (ParamsValue is not null)
		{
			writer.WritePropertyName("params");
			JsonSerializer.Serialize(writer, ParamsValue, options);
		}

		if (RatingsDescriptor is not null)
		{
			writer.WritePropertyName("ratings");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, RatingsDescriptor, options);
			writer.WriteEndArray();
		}
		else if (RatingsDescriptorAction is not null)
		{
			writer.WritePropertyName("ratings");
			writer.WriteStartArray();
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor(RatingsDescriptorAction), options);
			writer.WriteEndArray();
		}
		else if (RatingsDescriptorActions is not null)
		{
			writer.WritePropertyName("ratings");
			writer.WriteStartArray();
			foreach (var action in RatingsDescriptorActions)
			{
				JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Core.RankEval.DocumentRatingDescriptor(action), options);
			}

			writer.WriteEndArray();
		}
		else
		{
			writer.WritePropertyName("ratings");
			JsonSerializer.Serialize(writer, RatingsValue, options);
		}

		if (RequestDescriptor is not null)
		{
			writer.WritePropertyName("request");
			JsonSerializer.Serialize(writer, RequestDescriptor, options);
		}
		else if (RequestDescriptorAction is not null)
		{
			writer.WritePropertyName("request");
			JsonSerializer.Serialize(writer, new Elastic.Clients.Elasticsearch.Core.RankEval.RankEvalQueryDescriptor(RequestDescriptorAction), options);
		}
		else if (RequestValue is not null)
		{
			writer.WritePropertyName("request");
			JsonSerializer.Serialize(writer, RequestValue, options);
		}

		if (TemplateIdValue is not null)
		{
			writer.WritePropertyName("template_id");
			JsonSerializer.Serialize(writer, TemplateIdValue, options);
		}

		writer.WriteEndObject();
	}
}