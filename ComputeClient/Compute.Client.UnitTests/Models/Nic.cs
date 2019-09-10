namespace Compute.Client.UnitTests.Models
{
    public class Nic
    {
         /// <summary>
		///     Gets or sets the id.
		/// </summary>
		public string Id { get; set; }

		/// <summary>
		///     Gets or sets the private IP v4.
		/// </summary>
		public string PrivateIPv4 { get; set; }

		/// <summary>
		///     Gets or sets the IP v6.
		/// </summary>
		public string IPv6 { get; set; }

		/// <summary>
		///     Gets or sets the vlan id.
		/// </summary>
		public string VlanId { get; set; }

		/// <summary>
		///     Gets or sets the vlan name.
		/// </summary>
		public string VlanName { get; set; }

		/// <summary>
		///     Gets or sets the mac address.
		/// </summary>
		public string MacAddress { get; set; }

		/// <summary>
		///     Gets or sets the state.
		/// </summary>
		public string State { get; set; }

        /// <summary>
		///     Gets or sets the Network Adapter.
		/// </summary>
		public string NetworkAdapter { get; set; }

		/// <summary>
		///     Gets or sets the Key.
		/// </summary>
		public int Key { get; set; }

		/// <summary>
		///     Gets or sets the Connected.
		/// </summary>
		public bool Connected { get; set; }
    }
}