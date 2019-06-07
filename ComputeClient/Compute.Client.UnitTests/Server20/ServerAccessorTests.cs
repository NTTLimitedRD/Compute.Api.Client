using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using DD.CBU.Compute.Api.Client;
using DD.CBU.Compute.Api.Client.Exceptions;
using DD.CBU.Compute.Api.Client.Server20;
using DD.CBU.Compute.Api.Contracts.Network20;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Compute.Client.UnitTests.Server20
{
    [TestClass]
    public class ServerAccessorTests : BaseApiClientTestFixture
    {
        [TestMethod]
        public async Task GetServers_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.GetMcp2Servers(accountId), RequestFileResponseType.AsGoodResponse("GetServersResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var servers = await accessor.GetServers();

            Assert.IsNotNull(servers);
            Assert.AreEqual(5, servers.Count());
            Assert.AreEqual("0fad8eeb-83d7-4703-b450-171c33a79682", servers.First().id);
            Assert.AreEqual("AU10", servers.First().datacenterId);
            Assert.AreEqual("6ac5f462-f611-4590-bd3a-b3f66ea93815", servers.First().networkInfo.primaryNic.id);
            Assert.AreEqual("ecf85a96-e753-429f-a7b7-a455767ac1bd", servers.First().networkInfo.additionalNic.First().id);
        }

        [TestMethod]
        public async Task ListServers_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.ListServers(accountId), RequestFileResponseType.AsGoodResponse("ListServersResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var servers = await accessor.ListServers();

            Assert.IsNotNull(servers);
            Assert.AreEqual(23, servers.Count());
            Assert.AreEqual("c4e80cb1-e819-4dbf-97aa-020a7f1d9fd3", servers.First().id);
            Assert.AreEqual("QA1_N1_VMWARE_1", servers.First().datacenterId);
        }


        [TestMethod]
        public async Task GetServer_ReturnsResponse()
        {
            Guid serverId = new Guid("0fad8eeb-83d7-4703-b450-171c33a79682");

            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.GetMcp2Server(accountId, serverId), RequestFileResponseType.AsGoodResponse("GetServerResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var server = await accessor.GetServer(serverId);

            Assert.IsNotNull(server);
            Assert.AreEqual("0fad8eeb-83d7-4703-b450-171c33a79682", server.id);
            Assert.AreEqual("AU10", server.datacenterId);
            Assert.AreEqual("6ac5f462-f611-4590-bd3a-b3f66ea93815", server.networkInfo.primaryNic.id);
            Assert.AreEqual("ecf85a96-e753-429f-a7b7-a455767ac1bd", server.networkInfo.additionalNic.First().id);
        }

        [TestMethod]
        [ExpectedException(typeof(BadRequestException))]
        public async Task GetServer_NotFound()
        {
            Guid serverId = new Guid("0ab41d5f-4c0f-4804-a807-7015ee2adb61");
            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.GetMcp2Server(accountId, serverId), new RequestFileResponseType { ResponseFile = "GetServerNotFound.xml", Status = HttpStatusCode.BadRequest });

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            await accessor.GetServer(serverId);
        }

        [TestMethod]
        public async Task DeleteServer_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.DeleteServer(accountId), RequestFileResponseType.AsGoodResponse("DeleteServerResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var response = await accessor.DeleteServer(Guid.NewGuid());

            Assert.IsNotNull(response);
            Assert.AreEqual("DELETE_SERVER", response.operation);
            Assert.AreEqual("IN_PROGRESS", response.responseCode);
        }

        [TestMethod]
        public async Task StartServer_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.StartServer(accountId), RequestFileResponseType.AsGoodResponse("StartServerResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var response = await accessor.StartServer(Guid.NewGuid());

            Assert.IsNotNull(response);
            Assert.AreEqual("START_SERVER", response.operation);
            Assert.AreEqual("IN_PROGRESS", response.responseCode);
        }

        [TestMethod]
        public async Task ShutdownServer_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.ShutdownServer(accountId), RequestFileResponseType.AsGoodResponse("ShutdownServerResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var response = await accessor.ShutdownServer(Guid.NewGuid());

            Assert.IsNotNull(response);
            Assert.AreEqual("SHUTDOWN_SERVER", response.operation);
            Assert.AreEqual("IN_PROGRESS", response.responseCode);
        }

        [TestMethod]
        public async Task RebootServer_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.RebootServer(accountId), RequestFileResponseType.AsGoodResponse("RebootServerResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var response = await accessor.RebootServer(Guid.NewGuid());

            Assert.IsNotNull(response);
            Assert.AreEqual("REBOOT_SERVER", response.operation);
            Assert.AreEqual("IN_PROGRESS", response.responseCode);
        }

        [TestMethod]
        public async Task ResetServer_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.ResetServer(accountId), RequestFileResponseType.AsGoodResponse("ResetServerResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var response = await accessor.ResetServer(Guid.NewGuid());

            Assert.IsNotNull(response);
            Assert.AreEqual("RESET_SERVER", response.operation);
            Assert.AreEqual("IN_PROGRESS", response.responseCode);
        }

        [TestMethod]
        public async Task PowerOffServer_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.PowerOffServer(accountId), RequestFileResponseType.AsGoodResponse("PowerOffServerResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var response = await accessor.PowerOffServer(Guid.NewGuid());

            Assert.IsNotNull(response);
            Assert.AreEqual("POWER_OFF_SERVER", response.operation);
            Assert.AreEqual("IN_PROGRESS", response.responseCode);
        }

        [TestMethod]
        public async Task UpdateVmwareTools_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.UpdateVmwareTools(accountId), RequestFileResponseType.AsGoodResponse("UpdateVmwareToolsResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var response = await accessor.UpdateVmwareTools(Guid.NewGuid());

            Assert.IsNotNull(response);
            Assert.AreEqual("UPDATE_VMWARE_TOOLS", response.operation);
            Assert.AreEqual("IN_PROGRESS", response.responseCode);
        }

        [TestMethod]
        public async Task DeployServer_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.DeployMCP20Server(accountId), RequestFileResponseType.AsGoodResponse("DeployServerResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var response = await accessor.DeployServer(new DeployServerType());

            Assert.IsNotNull(response);
            Assert.AreEqual("DEPLOY_SERVER", response.operation);
            Assert.AreEqual("IN_PROGRESS", response.responseCode);
        }

        [TestMethod]
        public async Task CleanServer_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.CleanServer(accountId), RequestFileResponseType.AsGoodResponse("CleanServerResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var response = await accessor.CleanServer(Guid.NewGuid());

            Assert.IsNotNull(response);
            Assert.AreEqual("CLEAN_SERVER", response.operation);
            Assert.AreEqual("IN_PROGRESS", response.responseCode);
        }

        [TestMethod]
        public async Task AddNic_ReturnsResponse()
        {
            Guid serverId = new Guid("d577a691-e116-4913-a440-022d2729fc84");

            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.AddNic(accountId), RequestFileResponseType.AsGoodResponse("AddNicResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var response = await accessor.AddNic(serverId, Guid.NewGuid(), "10.10.10.10", "E1000");

            Assert.IsNotNull(response);
            Assert.AreEqual("ADD_NIC", response.operation);
            Assert.AreEqual("IN_PROGRESS", response.responseCode);
            Assert.AreEqual("a202e51b-41c0-4cfc-add0-b1c62fc0ecf6", response.info.First().value);
        }

        [TestMethod]
        public async Task RemoveNic_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.RemoveNic(accountId), RequestFileResponseType.AsGoodResponse("RemoveNicResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var response = await accessor.RemoveNic(Guid.NewGuid());

            Assert.IsNotNull(response);
            Assert.AreEqual("REMOVE_NIC", response.operation);
            Assert.AreEqual("IN_PROGRESS", response.responseCode);
        }

        [TestMethod]
        public async Task NotifyNicIpChange_ReturnsResponse()
        {
            requestsAndResponses.Add(ApiUris.MyAccount, RequestFileResponseType.AsGoodResponse("GetMyAccountDetails.xml"));
            requestsAndResponses.Add(ApiUris.NotifyNicIpChange(accountId), RequestFileResponseType.AsGoodResponse("NotifyNicIpChangeResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var response = await accessor.NotifyNicIpChange(new NotifyNicIpChangeType());

            Assert.IsNotNull(response);
            Assert.AreEqual("NOTIFY_NIC_IP_ADDRESS_CHANGE", response.operation);
            Assert.AreEqual("IN_PROGRESS", response.responseCode);
        }

        [TestMethod]
        public async Task ListHistoricalServerConfigurationsPaginated_ReturnsResponse()
        {
            var serverId = Guid.NewGuid();

            requestsAndResponses.Add(ApiUris.ListHistoricalServerConfigurations(accountId, serverId), RequestFileResponseType.AsGoodResponse("ListHistoricalServerConfigurationResponse.xml"));

            var client = GetWebApiClient();
            var accessor = new ServerAccessor(client);
            var historicalServerConfigurations = await accessor.ListHistoricalServerConfigurationsPaginated(serverId);

            Assert.IsNotNull(historicalServerConfigurations);
            Assert.AreEqual(4, historicalServerConfigurations.pageCount);
            Assert.AreEqual(4, historicalServerConfigurations.totalCount);
            Assert.AreEqual(250, historicalServerConfigurations.pageSize);
            Assert.AreEqual(1, historicalServerConfigurations.pageNumber);

            var historicalServerConfiguration = historicalServerConfigurations.items.First();
            Assert.AreEqual("127ac602-1f59-815d-9126-22f256417dc2", historicalServerConfiguration.serverId);
            Assert.AreEqual("DATACENTER_ID", historicalServerConfiguration.datacenterId);

            var actualAdvancedVirtualizationSettings = historicalServerConfiguration.advancedVirtualizationSetting.ToList();
            Assert.AreEqual(4, actualAdvancedVirtualizationSettings.Count());
            Assert.AreEqual("nestedHardwareVirtualization", actualAdvancedVirtualizationSettings[0].name);
            Assert.AreEqual("true", actualAdvancedVirtualizationSettings[0].value);
            Assert.AreEqual("cpuLatencySensitivity", actualAdvancedVirtualizationSettings[1].name);
            Assert.AreEqual("HIGH", actualAdvancedVirtualizationSettings[1].value);
            Assert.AreEqual("numaAutosize", actualAdvancedVirtualizationSettings[2].name);
            Assert.AreEqual("true", actualAdvancedVirtualizationSettings[2].value);
            Assert.AreEqual("enableHostInfoToVmTools", actualAdvancedVirtualizationSettings[3].name);
            Assert.AreEqual("true", actualAdvancedVirtualizationSettings[3].value);

            var actualServerConfigurationTypeCluster = historicalServerConfiguration.cluster;
            Assert.AreEqual("Cluster-01-id", actualServerConfigurationTypeCluster.id);
            Assert.AreEqual("Cluster-01", actualServerConfigurationTypeCluster.name);

            var actualCpuType = historicalServerConfiguration.cpu;
            Assert.AreEqual((uint)1, actualCpuType.coresPerSocket);
            Assert.AreEqual((uint)2, actualCpuType.count);
            Assert.AreEqual("STANDARD", actualCpuType.speed);
            Assert.AreEqual("test-server-1", historicalServerConfiguration.name);

            var actualServerConfigurationTypeScsiControllers = historicalServerConfiguration.scsiController;
            Assert.AreEqual(1, actualServerConfigurationTypeScsiControllers.Length);
            Assert.AreEqual("BUS_LOGIC", actualServerConfigurationTypeScsiControllers[0].adapterType);
            Assert.AreEqual("NORMAL", actualServerConfigurationTypeScsiControllers[0].state);
            Assert.AreEqual(0, actualServerConfigurationTypeScsiControllers[0].busNumber);
            Assert.AreEqual("bd7e6517-12fc-43ff-86c0-6b617f5649b6", actualServerConfigurationTypeScsiControllers[0].id);

            var actualServerConfigurationTypeScsiControllerDisks = actualServerConfigurationTypeScsiControllers[0].disk;
            Assert.AreEqual(3, actualServerConfigurationTypeScsiControllerDisks.Length);
            Assert.AreEqual("9d99bb9e-baeb-4e7e-9f4a-3f40be970f81", actualServerConfigurationTypeScsiControllerDisks[0].id);
            Assert.AreEqual(10, actualServerConfigurationTypeScsiControllerDisks[0].sizeGb);
            Assert.AreEqual("STANDARD", actualServerConfigurationTypeScsiControllerDisks[0].speed);
            Assert.AreEqual("NORMAL", actualServerConfigurationTypeScsiControllerDisks[0].state);
            Assert.AreEqual("DISK", actualServerConfigurationTypeScsiControllerDisks[0].driveType);

            Assert.AreEqual("3219df0d-701e-4ae4-8954-c6aa29b8c6ee", actualServerConfigurationTypeScsiControllerDisks[1].id);
            Assert.AreEqual(3, actualServerConfigurationTypeScsiControllerDisks[1].sizeGb);
            Assert.AreEqual("NORMAL", actualServerConfigurationTypeScsiControllerDisks[1].state);
            Assert.AreEqual("DISK", actualServerConfigurationTypeScsiControllerDisks[1].driveType);
            Assert.AreEqual("STANDARD", actualServerConfigurationTypeScsiControllerDisks[1].speed);

            Assert.AreEqual("ea7f174a-92e0-4466-9394-f43797d3a0a7", actualServerConfigurationTypeScsiControllerDisks[2].id);
            Assert.AreEqual(3, actualServerConfigurationTypeScsiControllerDisks[2].sizeGb);
            Assert.AreEqual("NORMAL", actualServerConfigurationTypeScsiControllerDisks[2].state);
            Assert.AreEqual("DISK", actualServerConfigurationTypeScsiControllerDisks[2].driveType);
            Assert.AreEqual("PROVISIONEDIOPS", actualServerConfigurationTypeScsiControllerDisks[2].speed);
            Assert.AreEqual("ea7f174a-92e0-4466-9394-f43797d3a0a7", actualServerConfigurationTypeScsiControllerDisks[2].id);

            var actualServerConfigurationTypeIdeControllers = historicalServerConfiguration.ideController;
            Assert.AreEqual(2, actualServerConfigurationTypeIdeControllers.Length);

            var actualServerConfigurationTypeIdeController = actualServerConfigurationTypeIdeControllers[0];
            Assert.AreEqual("ee000ad6-3129-4c04-a175-661510ab7976", actualServerConfigurationTypeIdeController.id);
            Assert.AreEqual(2, actualServerConfigurationTypeIdeController.Items.Length);
            Assert.AreEqual(0, actualServerConfigurationTypeIdeController.channel);
            Assert.AreEqual("IDE", actualServerConfigurationTypeIdeController.adapterType);
            Assert.AreEqual("NORMAL", actualServerConfigurationTypeIdeController.state);

            var ideDevices = actualServerConfigurationTypeIdeController.Items;
            Assert.AreEqual(2, ideDevices.Length);

            Assert.AreEqual("30b1e3ce-75cb-4df2-a9d5-ca3850550fe2", actualServerConfigurationTypeIdeControllers[1].id);
            Assert.AreEqual(1, actualServerConfigurationTypeIdeControllers[1].Items.Length);
            Assert.AreEqual("IDE", actualServerConfigurationTypeIdeControllers[1].adapterType);
            Assert.AreEqual(1, actualServerConfigurationTypeIdeControllers[1].channel);

            var actualServerConfigurationTypeFloppies = historicalServerConfiguration.floppy;
            Assert.AreEqual(1, actualServerConfigurationTypeFloppies.Length);
            Assert.AreEqual("436f7594-7012-4e2d-8113-657c832383cd", actualServerConfigurationTypeFloppies[0].id);
            Assert.AreEqual(0, actualServerConfigurationTypeFloppies[0].driveNumber);
            Assert.AreEqual(0, actualServerConfigurationTypeFloppies[0].sizeGb);
            Assert.AreEqual("NORMAL", actualServerConfigurationTypeFloppies[0].state);

            var actualNetworkInfo = historicalServerConfiguration.networkInfo;
            Assert.AreEqual("71021ef9-9c42-4af5-b525-a5c6bf0472fb", actualNetworkInfo.networkDomainId);
            Assert.AreEqual("Network Domain Name", actualNetworkInfo.networkDomainName);
            Assert.AreEqual("6ae07976-66eb-4fac-95e6-dfa4ee5451b9", actualNetworkInfo.primaryNic.id);
            Assert.AreEqual("10.0.0.9", actualNetworkInfo.primaryNic.privateIpv4);
            Assert.AreEqual("2607:f480:1111:1214:2673:7a77:de6a:dd7d", actualNetworkInfo.primaryNic.ipv6);
            Assert.AreEqual("f58fe7f7-ef09-4bdd-b70d-14f85be278d6", actualNetworkInfo.primaryNic.vlanId);
            Assert.AreEqual("vlan name", actualNetworkInfo.primaryNic.vlanName);
            Assert.AreEqual("E1000", actualNetworkInfo.primaryNic.networkAdapter);
            Assert.IsTrue(actualNetworkInfo.primaryNic.connected);
            Assert.AreEqual("NORMAL", actualNetworkInfo.primaryNic.state);
            Assert.IsNull(actualNetworkInfo.additionalNic);

            var actualGuest = historicalServerConfiguration.guest;
            Assert.IsFalse(actualGuest.osCustomization);
            Assert.AreEqual("CENTOS664", actualGuest.operatingSystem.id);
            Assert.AreEqual("CENTOS6/64", actualGuest.operatingSystem.displayName);
            Assert.AreEqual("UNIX", actualGuest.operatingSystem.family);

            Assert.AreEqual("vmx-08", historicalServerConfiguration.virtualHardwareVersion);
            Assert.AreEqual("test-server-1", historicalServerConfiguration.name);
        }
    }
}
