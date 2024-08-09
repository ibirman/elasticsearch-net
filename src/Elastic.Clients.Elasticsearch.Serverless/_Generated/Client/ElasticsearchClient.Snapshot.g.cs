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

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Elastic.Clients.Elasticsearch.Serverless.Snapshot;

public partial class SnapshotNamespacedClient : NamespacedClientProxy
{
	/// <summary>
	/// <para>
	/// Initializes a new instance of the <see cref="SnapshotNamespacedClient"/> class for mocking.
	/// </para>
	/// </summary>
	protected SnapshotNamespacedClient() : base()
	{
	}

	internal SnapshotNamespacedClient(ElasticsearchClient client) : base(client)
	{
	}

	/// <summary>
	/// <para>
	/// Triggers the review of a snapshot repository’s contents and deletes any stale data not referenced by existing snapshots.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/clean-up-snapshot-repo-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CleanupRepositoryResponse> CleanupRepositoryAsync(CleanupRepositoryRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<CleanupRepositoryRequest, CleanupRepositoryResponse, CleanupRepositoryRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Triggers the review of a snapshot repository’s contents and deletes any stale data not referenced by existing snapshots.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/clean-up-snapshot-repo-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CleanupRepositoryResponse> CleanupRepositoryAsync(CleanupRepositoryRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<CleanupRepositoryRequestDescriptor, CleanupRepositoryResponse, CleanupRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Triggers the review of a snapshot repository’s contents and deletes any stale data not referenced by existing snapshots.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/clean-up-snapshot-repo-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CleanupRepositoryResponse> CleanupRepositoryAsync(Elastic.Clients.Elasticsearch.Serverless.Name name, CancellationToken cancellationToken = default)
	{
		var descriptor = new CleanupRepositoryRequestDescriptor(name);
		descriptor.BeforeRequest();
		return DoRequestAsync<CleanupRepositoryRequestDescriptor, CleanupRepositoryResponse, CleanupRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Triggers the review of a snapshot repository’s contents and deletes any stale data not referenced by existing snapshots.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/clean-up-snapshot-repo-api.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CleanupRepositoryResponse> CleanupRepositoryAsync(Elastic.Clients.Elasticsearch.Serverless.Name name, Action<CleanupRepositoryRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new CleanupRepositoryRequestDescriptor(name);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<CleanupRepositoryRequestDescriptor, CleanupRepositoryResponse, CleanupRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Clones indices from one snapshot into another snapshot in the same repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CloneSnapshotResponse> CloneAsync(CloneSnapshotRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<CloneSnapshotRequest, CloneSnapshotResponse, CloneSnapshotRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Clones indices from one snapshot into another snapshot in the same repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CloneSnapshotResponse> CloneAsync(CloneSnapshotRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<CloneSnapshotRequestDescriptor, CloneSnapshotResponse, CloneSnapshotRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Clones indices from one snapshot into another snapshot in the same repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CloneSnapshotResponse> CloneAsync(Elastic.Clients.Elasticsearch.Serverless.Name repository, Elastic.Clients.Elasticsearch.Serverless.Name snapshot, Elastic.Clients.Elasticsearch.Serverless.Name targetSnapshot, CancellationToken cancellationToken = default)
	{
		var descriptor = new CloneSnapshotRequestDescriptor(repository, snapshot, targetSnapshot);
		descriptor.BeforeRequest();
		return DoRequestAsync<CloneSnapshotRequestDescriptor, CloneSnapshotResponse, CloneSnapshotRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Clones indices from one snapshot into another snapshot in the same repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CloneSnapshotResponse> CloneAsync(Elastic.Clients.Elasticsearch.Serverless.Name repository, Elastic.Clients.Elasticsearch.Serverless.Name snapshot, Elastic.Clients.Elasticsearch.Serverless.Name targetSnapshot, Action<CloneSnapshotRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new CloneSnapshotRequestDescriptor(repository, snapshot, targetSnapshot);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<CloneSnapshotRequestDescriptor, CloneSnapshotResponse, CloneSnapshotRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Creates a snapshot in a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CreateSnapshotResponse> CreateAsync(CreateSnapshotRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<CreateSnapshotRequest, CreateSnapshotResponse, CreateSnapshotRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Creates a snapshot in a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CreateSnapshotResponse> CreateAsync(CreateSnapshotRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<CreateSnapshotRequestDescriptor, CreateSnapshotResponse, CreateSnapshotRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Creates a snapshot in a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CreateSnapshotResponse> CreateAsync(Elastic.Clients.Elasticsearch.Serverless.Name repository, Elastic.Clients.Elasticsearch.Serverless.Name snapshot, CancellationToken cancellationToken = default)
	{
		var descriptor = new CreateSnapshotRequestDescriptor(repository, snapshot);
		descriptor.BeforeRequest();
		return DoRequestAsync<CreateSnapshotRequestDescriptor, CreateSnapshotResponse, CreateSnapshotRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Creates a snapshot in a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CreateSnapshotResponse> CreateAsync(Elastic.Clients.Elasticsearch.Serverless.Name repository, Elastic.Clients.Elasticsearch.Serverless.Name snapshot, Action<CreateSnapshotRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new CreateSnapshotRequestDescriptor(repository, snapshot);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<CreateSnapshotRequestDescriptor, CreateSnapshotResponse, CreateSnapshotRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Creates a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<CreateRepositoryRequest, CreateRepositoryResponse, CreateRepositoryRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Creates a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CreateRepositoryResponse> CreateRepositoryAsync(CreateRepositoryRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<CreateRepositoryRequestDescriptor, CreateRepositoryResponse, CreateRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Creates a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CreateRepositoryResponse> CreateRepositoryAsync(Elastic.Clients.Elasticsearch.Serverless.Snapshot.IRepository repository, Elastic.Clients.Elasticsearch.Serverless.Name name, CancellationToken cancellationToken = default)
	{
		var descriptor = new CreateRepositoryRequestDescriptor(repository, name);
		descriptor.BeforeRequest();
		return DoRequestAsync<CreateRepositoryRequestDescriptor, CreateRepositoryResponse, CreateRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Creates a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<CreateRepositoryResponse> CreateRepositoryAsync(Elastic.Clients.Elasticsearch.Serverless.Snapshot.IRepository repository, Elastic.Clients.Elasticsearch.Serverless.Name name, Action<CreateRepositoryRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new CreateRepositoryRequestDescriptor(repository, name);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<CreateRepositoryRequestDescriptor, CreateRepositoryResponse, CreateRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Deletes one or more snapshots.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteSnapshotResponse> DeleteAsync(DeleteSnapshotRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<DeleteSnapshotRequest, DeleteSnapshotResponse, DeleteSnapshotRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Deletes one or more snapshots.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteSnapshotResponse> DeleteAsync(DeleteSnapshotRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteSnapshotRequestDescriptor, DeleteSnapshotResponse, DeleteSnapshotRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Deletes one or more snapshots.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteSnapshotResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Serverless.Name repository, Elastic.Clients.Elasticsearch.Serverless.Name snapshot, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteSnapshotRequestDescriptor(repository, snapshot);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteSnapshotRequestDescriptor, DeleteSnapshotResponse, DeleteSnapshotRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Deletes one or more snapshots.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteSnapshotResponse> DeleteAsync(Elastic.Clients.Elasticsearch.Serverless.Name repository, Elastic.Clients.Elasticsearch.Serverless.Name snapshot, Action<DeleteSnapshotRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteSnapshotRequestDescriptor(repository, snapshot);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteSnapshotRequestDescriptor, DeleteSnapshotResponse, DeleteSnapshotRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Deletes a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<DeleteRepositoryRequest, DeleteRepositoryResponse, DeleteRepositoryRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Deletes a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteRepositoryResponse> DeleteRepositoryAsync(DeleteRepositoryRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteRepositoryRequestDescriptor, DeleteRepositoryResponse, DeleteRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Deletes a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteRepositoryResponse> DeleteRepositoryAsync(Elastic.Clients.Elasticsearch.Serverless.Names name, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteRepositoryRequestDescriptor(name);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteRepositoryRequestDescriptor, DeleteRepositoryResponse, DeleteRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Deletes a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<DeleteRepositoryResponse> DeleteRepositoryAsync(Elastic.Clients.Elasticsearch.Serverless.Names name, Action<DeleteRepositoryRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new DeleteRepositoryRequestDescriptor(name);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<DeleteRepositoryRequestDescriptor, DeleteRepositoryResponse, DeleteRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSnapshotResponse> GetAsync(GetSnapshotRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetSnapshotRequest, GetSnapshotResponse, GetSnapshotRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSnapshotResponse> GetAsync(GetSnapshotRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetSnapshotRequestDescriptor, GetSnapshotResponse, GetSnapshotRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSnapshotResponse> GetAsync(Elastic.Clients.Elasticsearch.Serverless.Name repository, Elastic.Clients.Elasticsearch.Serverless.Names snapshot, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetSnapshotRequestDescriptor(repository, snapshot);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetSnapshotRequestDescriptor, GetSnapshotResponse, GetSnapshotRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetSnapshotResponse> GetAsync(Elastic.Clients.Elasticsearch.Serverless.Name repository, Elastic.Clients.Elasticsearch.Serverless.Names snapshot, Action<GetSnapshotRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetSnapshotRequestDescriptor(repository, snapshot);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetSnapshotRequestDescriptor, GetSnapshotResponse, GetSnapshotRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetRepositoryResponse> GetRepositoryAsync(GetRepositoryRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<GetRepositoryRequest, GetRepositoryResponse, GetRepositoryRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetRepositoryResponse> GetRepositoryAsync(GetRepositoryRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<GetRepositoryRequestDescriptor, GetRepositoryResponse, GetRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetRepositoryResponse> GetRepositoryAsync(Elastic.Clients.Elasticsearch.Serverless.Names? name, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetRepositoryRequestDescriptor(name);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetRepositoryRequestDescriptor, GetRepositoryResponse, GetRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetRepositoryResponse> GetRepositoryAsync(Elastic.Clients.Elasticsearch.Serverless.Names? name, Action<GetRepositoryRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetRepositoryRequestDescriptor(name);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetRepositoryRequestDescriptor, GetRepositoryResponse, GetRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetRepositoryResponse> GetRepositoryAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new GetRepositoryRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<GetRepositoryRequestDescriptor, GetRepositoryResponse, GetRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<GetRepositoryResponse> GetRepositoryAsync(Action<GetRepositoryRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new GetRepositoryRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<GetRepositoryRequestDescriptor, GetRepositoryResponse, GetRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Restores a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<RestoreResponse> RestoreAsync(RestoreRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<RestoreRequest, RestoreResponse, RestoreRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Restores a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<RestoreResponse> RestoreAsync<TDocument>(RestoreRequestDescriptor<TDocument> descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<RestoreRequestDescriptor<TDocument>, RestoreResponse, RestoreRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Restores a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<RestoreResponse> RestoreAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Name repository, Elastic.Clients.Elasticsearch.Serverless.Name snapshot, CancellationToken cancellationToken = default)
	{
		var descriptor = new RestoreRequestDescriptor<TDocument>(repository, snapshot);
		descriptor.BeforeRequest();
		return DoRequestAsync<RestoreRequestDescriptor<TDocument>, RestoreResponse, RestoreRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Restores a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<RestoreResponse> RestoreAsync<TDocument>(Elastic.Clients.Elasticsearch.Serverless.Name repository, Elastic.Clients.Elasticsearch.Serverless.Name snapshot, Action<RestoreRequestDescriptor<TDocument>> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new RestoreRequestDescriptor<TDocument>(repository, snapshot);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<RestoreRequestDescriptor<TDocument>, RestoreResponse, RestoreRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Restores a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<RestoreResponse> RestoreAsync(RestoreRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<RestoreRequestDescriptor, RestoreResponse, RestoreRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Restores a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<RestoreResponse> RestoreAsync(Elastic.Clients.Elasticsearch.Serverless.Name repository, Elastic.Clients.Elasticsearch.Serverless.Name snapshot, CancellationToken cancellationToken = default)
	{
		var descriptor = new RestoreRequestDescriptor(repository, snapshot);
		descriptor.BeforeRequest();
		return DoRequestAsync<RestoreRequestDescriptor, RestoreResponse, RestoreRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Restores a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<RestoreResponse> RestoreAsync(Elastic.Clients.Elasticsearch.Serverless.Name repository, Elastic.Clients.Elasticsearch.Serverless.Name snapshot, Action<RestoreRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new RestoreRequestDescriptor(repository, snapshot);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<RestoreRequestDescriptor, RestoreResponse, RestoreRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about the status of a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SnapshotStatusResponse> StatusAsync(SnapshotStatusRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<SnapshotStatusRequest, SnapshotStatusResponse, SnapshotStatusRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about the status of a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SnapshotStatusResponse> StatusAsync(SnapshotStatusRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<SnapshotStatusRequestDescriptor, SnapshotStatusResponse, SnapshotStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about the status of a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SnapshotStatusResponse> StatusAsync(Elastic.Clients.Elasticsearch.Serverless.Name? repository, Elastic.Clients.Elasticsearch.Serverless.Names? snapshot, CancellationToken cancellationToken = default)
	{
		var descriptor = new SnapshotStatusRequestDescriptor(repository, snapshot);
		descriptor.BeforeRequest();
		return DoRequestAsync<SnapshotStatusRequestDescriptor, SnapshotStatusResponse, SnapshotStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about the status of a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SnapshotStatusResponse> StatusAsync(Elastic.Clients.Elasticsearch.Serverless.Name? repository, Elastic.Clients.Elasticsearch.Serverless.Names? snapshot, Action<SnapshotStatusRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new SnapshotStatusRequestDescriptor(repository, snapshot);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<SnapshotStatusRequestDescriptor, SnapshotStatusResponse, SnapshotStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about the status of a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SnapshotStatusResponse> StatusAsync(CancellationToken cancellationToken = default)
	{
		var descriptor = new SnapshotStatusRequestDescriptor();
		descriptor.BeforeRequest();
		return DoRequestAsync<SnapshotStatusRequestDescriptor, SnapshotStatusResponse, SnapshotStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Returns information about the status of a snapshot.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<SnapshotStatusResponse> StatusAsync(Action<SnapshotStatusRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new SnapshotStatusRequestDescriptor();
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<SnapshotStatusRequestDescriptor, SnapshotStatusResponse, SnapshotStatusRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Verifies a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<VerifyRepositoryResponse> VerifyRepositoryAsync(VerifyRepositoryRequest request, CancellationToken cancellationToken = default)
	{
		request.BeforeRequest();
		return DoRequestAsync<VerifyRepositoryRequest, VerifyRepositoryResponse, VerifyRepositoryRequestParameters>(request, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Verifies a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<VerifyRepositoryResponse> VerifyRepositoryAsync(VerifyRepositoryRequestDescriptor descriptor, CancellationToken cancellationToken = default)
	{
		descriptor.BeforeRequest();
		return DoRequestAsync<VerifyRepositoryRequestDescriptor, VerifyRepositoryResponse, VerifyRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Verifies a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<VerifyRepositoryResponse> VerifyRepositoryAsync(Elastic.Clients.Elasticsearch.Serverless.Name name, CancellationToken cancellationToken = default)
	{
		var descriptor = new VerifyRepositoryRequestDescriptor(name);
		descriptor.BeforeRequest();
		return DoRequestAsync<VerifyRepositoryRequestDescriptor, VerifyRepositoryResponse, VerifyRepositoryRequestParameters>(descriptor, cancellationToken);
	}

	/// <summary>
	/// <para>
	/// Verifies a repository.
	/// </para>
	/// <para><see href="https://www.elastic.co/guide/en/elasticsearch/reference/master/modules-snapshots.html">Learn more about this API in the Elasticsearch documentation.</see></para>
	/// </summary>
	public virtual Task<VerifyRepositoryResponse> VerifyRepositoryAsync(Elastic.Clients.Elasticsearch.Serverless.Name name, Action<VerifyRepositoryRequestDescriptor> configureRequest, CancellationToken cancellationToken = default)
	{
		var descriptor = new VerifyRepositoryRequestDescriptor(name);
		configureRequest?.Invoke(descriptor);
		descriptor.BeforeRequest();
		return DoRequestAsync<VerifyRepositoryRequestDescriptor, VerifyRepositoryResponse, VerifyRepositoryRequestParameters>(descriptor, cancellationToken);
	}
}