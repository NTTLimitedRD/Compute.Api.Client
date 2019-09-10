using System.Collections.Generic;

namespace Compute.Client.UnitTests.Models
{
    public class ServerNetwork
    {
         /// <summary>
        ///     Gets or sets the primary nic.
        /// </summary>
        public Nic PrimaryNic { get; set; }

        /// <summary>
        ///     Gets or sets the additional nic.
        /// </summary>
        public IList<Nic> AdditionalNics { get; set; }

        /// <summary>
        ///     Gets or sets the network domain id.
        /// </summary>
        public string NetworkDomainId { get; set; }

        /// <summary>
        /// Gets or sets the network domain name.
        /// </summary>
        public string NetworkDomainName { get; set; }
    }
}