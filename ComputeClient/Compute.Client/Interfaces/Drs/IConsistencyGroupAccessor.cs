namespace DD.CBU.Compute.Api.Client.Interfaces.Drs
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Contracts.Drs;
    using Contracts.General;
    using Contracts.Network20;
    using Contracts.Requests;
    using Contracts.Requests.Drs;

    /// <summary>
    /// The Consistency Group Interface.
    /// </summary>
    public interface IConsistencyGroupAccessor
    {
        /// <summary>
        /// The Get Consistency Group method.
        /// </summary>
        /// <param name="filteringOptions">The filtering options.</param>
        /// <returns>List of <see cref="ConsistencyGroupType"/></returns>
        Task<IEnumerable<ConsistencyGroupType>> GetConsistencyGroups(ConsistencyGroupListOptions filteringOptions = null);


        /// <summary>
        /// The Get Consistency Group menthod.
        /// </summary>
        /// <param name="filteringOptions">The filtering options.</param>
        /// <param name="pagingOptions">The pagination options.</param>
        /// <returns>Paginated result of <see cref="ConsistencyGroupType"/></returns>
        Task<PagedResponse<ConsistencyGroupType>> GetConsistencyGroupsPaginated(ConsistencyGroupListOptions filteringOptions = null, PageableRequest pagingOptions = null);

        /// <summary>
        /// The Get Consistency Group method.
        /// </summary>
        /// <param name="id">The Consistency group id.</param>
        /// <returns>The selected <see cref="ConsistencyGroupType"/></returns>
        Task<ConsistencyGroupDetailType> GetConsistencyGroup(System.Guid id);

		/// <summary>
		/// Set Re-IP rules for a DRS Target Server to override replicated network settings when entering DRS Preview mode.
		/// </summary>
		/// <param name="setDrsReIpAddressRules">Drs Target Server Re-IP details</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		Task<ResponseType> SetDrsReIpAddressRules(SetDrsReIpAddressRulesType setDrsReIpAddressRules);

		/// <summary>
		/// The purpose of this API is to allow a customer user to Delete the Re-IP Address Rules associated with a Consistency Group Server Pair.
		/// </summary>
		/// <param name="drsServerPairIdType"></param>
		/// <returns>The <see cref="ResponseType"/></returns>
		Task<ResponseType> DeleteReIpAddressRules(DrsServerPairIdType drsServerPairIdType);

		/// <summary>
		/// The Create Consistency Group
		/// </summary>
		/// <param name="createConsistencyGroup">The create consistency group type.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		Task<ResponseType> CreateConsistencyGroup(CreateConsistencyGroupType createConsistencyGroup);

        /// <summary>
        /// The Get Consistency Group Snapshots method.
        /// </summary>
        /// <returns>List of <see cref="ConsistencyGroupType"/></returns>
        Task<consistencyGroupSnapshots> GetConsistencyGroupSnapshots(ConsistencyGroupSnapshotListOptions filteringOptions = null);

        /// <summary>
        /// The stop preview snapshot of a consistency group.
        /// </summary>
        /// <param name="stopPreviewSnapshotType">The stop preview snapshot type.</param>
        /// <returns>The <see cref="ResponseType"/></returns>
        Task<ResponseType> StopPreviewSnapshot(StopPreviewSnapshotType stopPreviewSnapshotType);

		/// <summary>
		/// Start preview snapshot of a consistency group.
		/// </summary>
		/// <param name="startPreviewSnapshotType">The start preview snapshot type.</param>
		/// <returns>The <see cref="ResponseType"/></returns>
		Task<ResponseType> StartPreviewSnapshot(StartPreviewSnapshotType startPreviewSnapshotType);

        /// <summary>
        /// The Delete Consistency Group method.
        /// </summary>
        /// <param name="deleteConsistencyGroupType">The delete consistency group.</param>
        /// <returns><see cref="ResponseType"/></returns>
        Task<ResponseType> DeleteConsistencyGroup(DeleteConsistencyGroupType deleteConsistencyGroupType);

        /// <summary>
        /// The Clean Consistency Group method.
        /// </summary>
        /// <param name="cleanConsistencyGroupType">The delete consistency group.</param>
        /// <returns><see cref="ResponseType"/></returns>
        Task<ResponseType> CleanConsistencyGroup(CleanConsistencyGroupType cleanConsistencyGroupType);

        /// <summary>
        /// The initiate failover for a consistency group.
        /// </summary>
        /// <param name="InitiateFailover">The Initiate failover type.</param>
        /// <returns>The <see cref="ResponseType"/></returns>
        Task<ResponseType> InitiateFailoverForConsistencyGroup(InitiateFailoverType InitiateFailover);

	    /// <summary>
	    /// Expand journal
	    /// </summary>
	    /// <param name="expandJournalType">Expand journal type.</param>
	    /// <returns>The <see cref="ResponseType"/></returns>
	    Task<ResponseType> ExpandJournal(ExpandJournalType expandJournalType);

    }
}
