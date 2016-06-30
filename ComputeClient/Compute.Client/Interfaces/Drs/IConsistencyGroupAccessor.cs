﻿namespace DD.CBU.Compute.Api.Client.Interfaces.Drs
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Contracts.Drs;
    using Contracts.General;
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
    }
}