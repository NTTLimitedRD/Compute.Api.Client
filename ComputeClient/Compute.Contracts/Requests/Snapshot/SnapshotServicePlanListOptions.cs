using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DD.CBU.Compute.Api.Contracts.Requests.Snapshot
{
	using System;

	/// <summary>
	/// Filtering options for the Snapshot Server Plan List request.
	/// </summary>
	public sealed class SnapshotServicePlanListOptions : FilterableRequest
	{
		/// <summary>
		/// The "id" field name.
		/// </summary>
		public const string IdField = "id";

		/// <summary>
		/// The "available" field name.
		/// </summary>
		public const string availableField = "available";

		/// <summary>	
		/// Identifies an individual Snapshot Service Plan.
		/// </summary>
		public Guid? Id
		{
			get { return GetFilter<Guid?>(IdField); }
			set { SetFilter(IdField, value); }
		}


		/// <summary>
		/// Gets or sets the available filter.
		/// </summary>
		public bool? available
		{
			get { return GetFilter<bool?>(availableField); }
			set { SetFilter(availableField, value); }
		}
	}
}
