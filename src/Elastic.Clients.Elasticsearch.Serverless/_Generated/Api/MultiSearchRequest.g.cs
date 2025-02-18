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
using System.IO;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Elastic.Clients.Elasticsearch.Serverless;

public sealed partial class MultiSearchRequestParameters : RequestParameters
{
	/// <summary>
	/// <para>
	/// If false, the request returns an error if any wildcard expression, index alias, or _all value targets only missing or closed indices. This behavior applies even if the request targets other open indices. For example, a request targeting foo*,bar* returns an error if an index starts with foo but no index starts with bar.
	/// </para>
	/// </summary>
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>
	/// If true, network roundtrips between the coordinating node and remote clusters are minimized for cross-cluster search requests.
	/// </para>
	/// </summary>
	public bool? CcsMinimizeRoundtrips { get => Q<bool?>("ccs_minimize_roundtrips"); set => Q("ccs_minimize_roundtrips", value); }

	/// <summary>
	/// <para>
	/// Type of index that wildcard expressions can match. If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.
	/// </para>
	/// </summary>
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>
	/// If true, concrete, expanded or aliased indices are ignored when frozen.
	/// </para>
	/// </summary>
	public bool? IgnoreThrottled { get => Q<bool?>("ignore_throttled"); set => Q("ignore_throttled", value); }

	/// <summary>
	/// <para>
	/// If true, missing or closed indices are not included in the response.
	/// </para>
	/// </summary>
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>
	/// Maximum number of concurrent searches the multi search API can execute.
	/// </para>
	/// </summary>
	public long? MaxConcurrentSearches { get => Q<long?>("max_concurrent_searches"); set => Q("max_concurrent_searches", value); }

	/// <summary>
	/// <para>
	/// Maximum number of concurrent shard requests that each sub-search request executes per node.
	/// </para>
	/// </summary>
	public long? MaxConcurrentShardRequests { get => Q<long?>("max_concurrent_shard_requests"); set => Q("max_concurrent_shard_requests", value); }

	/// <summary>
	/// <para>
	/// Defines a threshold that enforces a pre-filter roundtrip to prefilter search shards based on query rewriting if the number of shards the search request expands to exceeds the threshold. This filter roundtrip can limit the number of shards significantly if for instance a shard can not match any documents based on its rewrite method i.e., if date filters are mandatory to match but the shard bounds and the query are disjoint.
	/// </para>
	/// </summary>
	public long? PreFilterShardSize { get => Q<long?>("pre_filter_shard_size"); set => Q("pre_filter_shard_size", value); }

	/// <summary>
	/// <para>
	/// If true, hits.total are returned as an integer in the response. Defaults to false, which returns an object.
	/// </para>
	/// </summary>
	public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

	/// <summary>
	/// <para>
	/// Custom routing value used to route search operations to a specific shard.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Serverless.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>
	/// Indicates whether global term and document frequencies should be used when scoring returned documents.
	/// </para>
	/// </summary>
	public Elastic.Clients.Elasticsearch.Serverless.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.Serverless.SearchType?>("search_type"); set => Q("search_type", value); }

	/// <summary>
	/// <para>
	/// Specifies whether aggregation and suggester names should be prefixed by their respective types in the response.
	/// </para>
	/// </summary>
	public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }
}

/// <summary>
/// <para>
/// Run multiple searches.
/// </para>
/// <para>
/// The format of the request is similar to the bulk API format and makes use of the newline delimited JSON (NDJSON) format.
/// The structure is as follows:
/// </para>
/// <code>
/// header\n
/// body\n
/// header\n
/// body\n
/// </code>
/// <para>
/// This structure is specifically optimized to reduce parsing if a specific search ends up redirected to another node.
/// </para>
/// <para>
/// IMPORTANT: The final line of data must end with a newline character <c>\n</c>.
/// Each newline character may be preceded by a carriage return <c>\r</c>.
/// When sending requests to this endpoint the <c>Content-Type</c> header should be set to <c>application/x-ndjson</c>.
/// </para>
/// </summary>
public sealed partial class MultiSearchRequest : PlainRequest<MultiSearchRequestParameters>, IStreamSerializable
{
	public MultiSearchRequest()
	{
	}

	public MultiSearchRequest(Elastic.Clients.Elasticsearch.Serverless.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceMultiSearch;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "msearch";

	/// <summary>
	/// <para>
	/// If false, the request returns an error if any wildcard expression, index alias, or _all value targets only missing or closed indices. This behavior applies even if the request targets other open indices. For example, a request targeting foo*,bar* returns an error if an index starts with foo but no index starts with bar.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? AllowNoIndices { get => Q<bool?>("allow_no_indices"); set => Q("allow_no_indices", value); }

	/// <summary>
	/// <para>
	/// If true, network roundtrips between the coordinating node and remote clusters are minimized for cross-cluster search requests.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? CcsMinimizeRoundtrips { get => Q<bool?>("ccs_minimize_roundtrips"); set => Q("ccs_minimize_roundtrips", value); }

	/// <summary>
	/// <para>
	/// Type of index that wildcard expressions can match. If the request can target data streams, this argument determines whether wildcard expressions match hidden data streams.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? ExpandWildcards { get => Q<ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>?>("expand_wildcards"); set => Q("expand_wildcards", value); }

	/// <summary>
	/// <para>
	/// If true, concrete, expanded or aliased indices are ignored when frozen.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreThrottled { get => Q<bool?>("ignore_throttled"); set => Q("ignore_throttled", value); }

	/// <summary>
	/// <para>
	/// If true, missing or closed indices are not included in the response.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? IgnoreUnavailable { get => Q<bool?>("ignore_unavailable"); set => Q("ignore_unavailable", value); }

	/// <summary>
	/// <para>
	/// Maximum number of concurrent searches the multi search API can execute.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public long? MaxConcurrentSearches { get => Q<long?>("max_concurrent_searches"); set => Q("max_concurrent_searches", value); }

	/// <summary>
	/// <para>
	/// Maximum number of concurrent shard requests that each sub-search request executes per node.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public long? MaxConcurrentShardRequests { get => Q<long?>("max_concurrent_shard_requests"); set => Q("max_concurrent_shard_requests", value); }

	/// <summary>
	/// <para>
	/// Defines a threshold that enforces a pre-filter roundtrip to prefilter search shards based on query rewriting if the number of shards the search request expands to exceeds the threshold. This filter roundtrip can limit the number of shards significantly if for instance a shard can not match any documents based on its rewrite method i.e., if date filters are mandatory to match but the shard bounds and the query are disjoint.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public long? PreFilterShardSize { get => Q<long?>("pre_filter_shard_size"); set => Q("pre_filter_shard_size", value); }

	/// <summary>
	/// <para>
	/// If true, hits.total are returned as an integer in the response. Defaults to false, which returns an object.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? RestTotalHitsAsInt { get => Q<bool?>("rest_total_hits_as_int"); set => Q("rest_total_hits_as_int", value); }

	/// <summary>
	/// <para>
	/// Custom routing value used to route search operations to a specific shard.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.Routing? Routing { get => Q<Elastic.Clients.Elasticsearch.Serverless.Routing?>("routing"); set => Q("routing", value); }

	/// <summary>
	/// <para>
	/// Indicates whether global term and document frequencies should be used when scoring returned documents.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public Elastic.Clients.Elasticsearch.Serverless.SearchType? SearchType { get => Q<Elastic.Clients.Elasticsearch.Serverless.SearchType?>("search_type"); set => Q("search_type", value); }

	/// <summary>
	/// <para>
	/// Specifies whether aggregation and suggester names should be prefixed by their respective types in the response.
	/// </para>
	/// </summary>
	[JsonIgnore]
	public bool? TypedKeys { get => Q<bool?>("typed_keys"); set => Q("typed_keys", value); }
	public List<Elastic.Clients.Elasticsearch.Serverless.Core.MSearch.SearchRequestItem> Searches { get; set; }

	void IStreamSerializable.Serialize(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (Searches is null)
			return;
		foreach (var item in Searches)
		{
			if (item is IStreamSerializable serializable)
				serializable.Serialize(stream, settings, formatting);
		}
	}

	async Task IStreamSerializable.SerializeAsync(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (Searches is null)
			return;
		foreach (var item in Searches)
		{
			if (item is IStreamSerializable serializable)
				await serializable.SerializeAsync(stream, settings, formatting).ConfigureAwait(false);
		}
	}
}

/// <summary>
/// <para>
/// Run multiple searches.
/// </para>
/// <para>
/// The format of the request is similar to the bulk API format and makes use of the newline delimited JSON (NDJSON) format.
/// The structure is as follows:
/// </para>
/// <code>
/// header\n
/// body\n
/// header\n
/// body\n
/// </code>
/// <para>
/// This structure is specifically optimized to reduce parsing if a specific search ends up redirected to another node.
/// </para>
/// <para>
/// IMPORTANT: The final line of data must end with a newline character <c>\n</c>.
/// Each newline character may be preceded by a carriage return <c>\r</c>.
/// When sending requests to this endpoint the <c>Content-Type</c> header should be set to <c>application/x-ndjson</c>.
/// </para>
/// </summary>
public sealed partial class MultiSearchRequestDescriptor<TDocument> : RequestDescriptor<MultiSearchRequestDescriptor<TDocument>, MultiSearchRequestParameters>, IStreamSerializable
{
	internal MultiSearchRequestDescriptor(Action<MultiSearchRequestDescriptor<TDocument>> configure) => configure.Invoke(this);

	public MultiSearchRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	public MultiSearchRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceMultiSearch;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "msearch";

	public MultiSearchRequestDescriptor<TDocument> AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public MultiSearchRequestDescriptor<TDocument> CcsMinimizeRoundtrips(bool? ccsMinimizeRoundtrips = true) => Qs("ccs_minimize_roundtrips", ccsMinimizeRoundtrips);
	public MultiSearchRequestDescriptor<TDocument> ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public MultiSearchRequestDescriptor<TDocument> IgnoreThrottled(bool? ignoreThrottled = true) => Qs("ignore_throttled", ignoreThrottled);
	public MultiSearchRequestDescriptor<TDocument> IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public MultiSearchRequestDescriptor<TDocument> MaxConcurrentSearches(long? maxConcurrentSearches) => Qs("max_concurrent_searches", maxConcurrentSearches);
	public MultiSearchRequestDescriptor<TDocument> MaxConcurrentShardRequests(long? maxConcurrentShardRequests) => Qs("max_concurrent_shard_requests", maxConcurrentShardRequests);
	public MultiSearchRequestDescriptor<TDocument> PreFilterShardSize(long? preFilterShardSize) => Qs("pre_filter_shard_size", preFilterShardSize);
	public MultiSearchRequestDescriptor<TDocument> RestTotalHitsAsInt(bool? restTotalHitsAsInt = true) => Qs("rest_total_hits_as_int", restTotalHitsAsInt);
	public MultiSearchRequestDescriptor<TDocument> Routing(Elastic.Clients.Elasticsearch.Serverless.Routing? routing) => Qs("routing", routing);
	public MultiSearchRequestDescriptor<TDocument> SearchType(Elastic.Clients.Elasticsearch.Serverless.SearchType? searchType) => Qs("search_type", searchType);
	public MultiSearchRequestDescriptor<TDocument> TypedKeys(bool? typedKeys = true) => Qs("typed_keys", typedKeys);

	public MultiSearchRequestDescriptor<TDocument> Indices(Elastic.Clients.Elasticsearch.Serverless.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}

	List<Elastic.Clients.Elasticsearch.Serverless.Core.MSearch.SearchRequestItem> _items = new();

	void IStreamSerializable.Serialize(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (_items is null)
			return;
		foreach (var item in _items)
		{
			if (item is IStreamSerializable serializable)
				serializable.Serialize(stream, settings, formatting);
		}
	}

	async Task IStreamSerializable.SerializeAsync(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (_items is null)
			return;
		foreach (var item in _items)
		{
			if (item is IStreamSerializable serializable)
				await serializable.SerializeAsync(stream, settings, formatting).ConfigureAwait(false);
		}
	}

	public MultiSearchRequestDescriptor<TDocument> AddSearches(Elastic.Clients.Elasticsearch.Serverless.Core.MSearch.SearchRequestItem searches)
	{
		_items.Add(searches);
		return this;
	}
}

/// <summary>
/// <para>
/// Run multiple searches.
/// </para>
/// <para>
/// The format of the request is similar to the bulk API format and makes use of the newline delimited JSON (NDJSON) format.
/// The structure is as follows:
/// </para>
/// <code>
/// header\n
/// body\n
/// header\n
/// body\n
/// </code>
/// <para>
/// This structure is specifically optimized to reduce parsing if a specific search ends up redirected to another node.
/// </para>
/// <para>
/// IMPORTANT: The final line of data must end with a newline character <c>\n</c>.
/// Each newline character may be preceded by a carriage return <c>\r</c>.
/// When sending requests to this endpoint the <c>Content-Type</c> header should be set to <c>application/x-ndjson</c>.
/// </para>
/// </summary>
public sealed partial class MultiSearchRequestDescriptor : RequestDescriptor<MultiSearchRequestDescriptor, MultiSearchRequestParameters>, IStreamSerializable
{
	internal MultiSearchRequestDescriptor(Action<MultiSearchRequestDescriptor> configure) => configure.Invoke(this);

	public MultiSearchRequestDescriptor(Elastic.Clients.Elasticsearch.Serverless.Indices? indices) : base(r => r.Optional("index", indices))
	{
	}

	public MultiSearchRequestDescriptor()
	{
	}

	internal override ApiUrls ApiUrls => ApiUrlLookup.NoNamespaceMultiSearch;

	protected override HttpMethod StaticHttpMethod => HttpMethod.POST;

	internal override bool SupportsBody => true;

	internal override string OperationName => "msearch";

	public MultiSearchRequestDescriptor AllowNoIndices(bool? allowNoIndices = true) => Qs("allow_no_indices", allowNoIndices);
	public MultiSearchRequestDescriptor CcsMinimizeRoundtrips(bool? ccsMinimizeRoundtrips = true) => Qs("ccs_minimize_roundtrips", ccsMinimizeRoundtrips);
	public MultiSearchRequestDescriptor ExpandWildcards(ICollection<Elastic.Clients.Elasticsearch.Serverless.ExpandWildcard>? expandWildcards) => Qs("expand_wildcards", expandWildcards);
	public MultiSearchRequestDescriptor IgnoreThrottled(bool? ignoreThrottled = true) => Qs("ignore_throttled", ignoreThrottled);
	public MultiSearchRequestDescriptor IgnoreUnavailable(bool? ignoreUnavailable = true) => Qs("ignore_unavailable", ignoreUnavailable);
	public MultiSearchRequestDescriptor MaxConcurrentSearches(long? maxConcurrentSearches) => Qs("max_concurrent_searches", maxConcurrentSearches);
	public MultiSearchRequestDescriptor MaxConcurrentShardRequests(long? maxConcurrentShardRequests) => Qs("max_concurrent_shard_requests", maxConcurrentShardRequests);
	public MultiSearchRequestDescriptor PreFilterShardSize(long? preFilterShardSize) => Qs("pre_filter_shard_size", preFilterShardSize);
	public MultiSearchRequestDescriptor RestTotalHitsAsInt(bool? restTotalHitsAsInt = true) => Qs("rest_total_hits_as_int", restTotalHitsAsInt);
	public MultiSearchRequestDescriptor Routing(Elastic.Clients.Elasticsearch.Serverless.Routing? routing) => Qs("routing", routing);
	public MultiSearchRequestDescriptor SearchType(Elastic.Clients.Elasticsearch.Serverless.SearchType? searchType) => Qs("search_type", searchType);
	public MultiSearchRequestDescriptor TypedKeys(bool? typedKeys = true) => Qs("typed_keys", typedKeys);

	public MultiSearchRequestDescriptor Indices(Elastic.Clients.Elasticsearch.Serverless.Indices? indices)
	{
		RouteValues.Optional("index", indices);
		return Self;
	}

	protected override void Serialize(Utf8JsonWriter writer, JsonSerializerOptions options, IElasticsearchClientSettings settings)
	{
	}

	List<Elastic.Clients.Elasticsearch.Serverless.Core.MSearch.SearchRequestItem> _items = new();

	void IStreamSerializable.Serialize(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (_items is null)
			return;
		foreach (var item in _items)
		{
			if (item is IStreamSerializable serializable)
				serializable.Serialize(stream, settings, formatting);
		}
	}

	async Task IStreamSerializable.SerializeAsync(Stream stream, IElasticsearchClientSettings settings, SerializationFormatting formatting)
	{
		if (_items is null)
			return;
		foreach (var item in _items)
		{
			if (item is IStreamSerializable serializable)
				await serializable.SerializeAsync(stream, settings, formatting).ConfigureAwait(false);
		}
	}

	public MultiSearchRequestDescriptor AddSearches(Elastic.Clients.Elasticsearch.Serverless.Core.MSearch.SearchRequestItem searches)
	{
		_items.Add(searches);
		return this;
	}
}