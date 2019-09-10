using System;
using System.Collections.Generic;

namespace Compute.Client.UnitTests.Models
{
    public struct Server
    {
         /// <summary>
		///     Gets or sets the name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		///     Gets or sets the description.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		///     Gets or sets the CPU count.
		/// </summary>
		public int CpuCount { get; set; }

		/// <summary>
		///     Gets or sets the memory gb.
		/// </summary>
		public int MemoryGb { get; set; }

        public IList<string> SpecialTrait { get; set; }

		/// <summary>
		///     Gets or sets the software label.
		/// </summary>
		public IList<string> SoftwareLabels { get; set; }

		/// <summary>
		///     Gets or sets the source image id.
		/// </summary>
		public string SourceImageId { get; set; }

		/// <summary>
		///     Gets or sets the Deployment Mode.
		/// </summary>
		public string DeploymentMode { get; set; }

		/// <summary>
		///     Gets or sets the create time.
		/// </summary>
		public DateTime CreateTime { get; set; }

		/// <summary>
		///     Gets or sets a value indicating whether deployed.
		/// </summary>
		public bool Deployed { get; set; }

		/// <summary>
		///     Gets or sets a value indicating whether started.
		/// </summary>
		public bool Started { get; set; }

		/// <summary>
		///     Gets or sets the state.
		/// </summary>
		public string State { get; set; }

        /// <summary>
        ///     Gets or sets the id.
        /// </summary>
        public Guid Id { get; set; }

		/// <summary>
		///     Gets or sets the data center id.
		/// </summary>
		public string DatacenterId { get; set; }

		/// <summary>
		///     Gets or sets the NIC 's.
		/// </summary>
		public ServerNic Nic { get; set; }

		/// <summary>
		///     Gets or sets the network.
		/// </summary>
		public ServerNetwork Network { get; set; }
    }
}