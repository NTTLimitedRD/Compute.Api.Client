using System;

namespace Compute.Client.UnitTests.Models
{
    public class ServerNic
    {
         /// <summary>
		///     Gets or sets the id.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		///     Gets or sets the private IP v4.
		/// </summary>
		public string PrivateIpv4 { get; set; }

		/// <summary>
		///     Gets or sets the network id.
		/// </summary>
		public Guid NetworkId { get; set; }

		/// <summary>
		///     Gets or sets the network name.
		/// </summary>
		public string NetworkName { get; set; }

		/// <summary>
		///     Gets or sets the state.
		/// </summary>
		public string State { get; set; }
    }
}