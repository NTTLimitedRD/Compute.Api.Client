using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DD.CBU.Compute.Api.Client;
using DD.CBU.Compute.Api.Client.Drs;
using DD.CBU.Compute.Api.Contracts.Drs;
using DD.CBU.Compute.Api.Contracts.Requests;
using DD.CBU.Compute.Api.Contracts.Requests.Drs;

namespace Compute.Client.UnitTests.Drs
{
	[TestClass]
	public class ConsistencyGroupAccessorTests : BaseApiClientTestFixture
	{
		[TestMethod]
		public async Task GetConsistencyGroups_ReturnsResponse()
		{
			requestsAndResponses.Add(ApiUris.GetConsistencyGroups(accountId), RequestFileResponseType.AsGoodResponse("GetConsistencyGroupsResponse.xml"));

			var client = GetWebApiClient();
			var accessor = new ConsistencyGroupAccessor(client);
			var consistencyGroups = await accessor.GetConsistencyGroups();

			Assert.IsNotNull(consistencyGroups);
			Assert.AreEqual(3, consistencyGroups.Count());
			Assert.AreEqual("GoodCGNoReIp", consistencyGroups.ElementAt(0).name);

			// Check the progress item for the second CG
			var consistencyGroupWithProgress = consistencyGroups.ElementAt(1);

			// Check the progress object.
			Assert.IsNotNull(consistencyGroupWithProgress.progress);
			Assert.AreEqual("CREATE_CONSISTENCY_GROUP", consistencyGroupWithProgress.progress.action);

			// Check the progress step mapping.
			Assert.IsNotNull(consistencyGroupWithProgress.progress.step);
			Assert.AreEqual(10, consistencyGroupWithProgress.progress.step.number);

			// Check the serverpair mapping.
			Assert.IsNotNull(consistencyGroupWithProgress.serverPair);
			Assert.AreEqual(1, consistencyGroupWithProgress.serverPair.Count());

			var serverPair = consistencyGroupWithProgress.serverPair.ElementAt(0);
			Assert.AreEqual("2861363d-1f66-4bce-b568-82c4d3582ed7", serverPair.id);
			Assert.IsNotNull(serverPair.sourceServer);
			Assert.IsNotNull(serverPair.targetServer);
			Assert.AreEqual("e55a4707-e7cd-4dad-9c03-ef834b6e4528", serverPair.sourceServer.id);
			Assert.AreEqual("SourceServer1", serverPair.sourceServer.name);
			Assert.AreEqual("f3174580-2d51-400f-9584-f0e32784e7e7", serverPair.targetServer.id);
			Assert.AreEqual("TargetServer1", serverPair.targetServer.name);

			// Check the ReIp Rules defined
			var consistencyGroupWithReIp = consistencyGroups.ElementAt(2);
			Assert.IsNotNull(consistencyGroupWithReIp.serverPair);
			Assert.AreEqual(1, consistencyGroupWithReIp.serverPair.Count());
			var serverPairWithReIp = consistencyGroupWithReIp.serverPair.ElementAt(0);
			Assert.IsTrue(serverPairWithReIp.reIpAddressRulesDefined);
		}

		[TestMethod]
		public async Task GetConsistencyGroups_PaginatedResponse()
		{
			var pagingOptions = new DD.CBU.Compute.Api.Contracts.Requests.PageableRequest
			{
				PageSize = 3,
				PageNumber = 1,
				Order = "sourceDataCenterId"
			};

			var baseUriBuilder = new UriBuilder(ApiUris.GetConsistencyGroups(accountId).ToString());
			baseUriBuilder.Query = "pageSize=3&pageNumber=1&orderBy=sourceDataCenterId";
			requestsAndResponses.Add(new Uri(baseUriBuilder.Host + baseUriBuilder.Uri.PathAndQuery, UriKind.Relative), RequestFileResponseType.AsGoodResponse("GetConsistencyGroupsPaginatedResponse.xml"));

			var client = GetWebApiClient();
			var accessor = new ConsistencyGroupAccessor(client);

			var consistencyGroups = await accessor.GetConsistencyGroupsPaginated(null, pagingOptions);

			Assert.IsNotNull(consistencyGroups);
			Assert.AreEqual(3, consistencyGroups.pageCount);
			Assert.AreEqual(1, consistencyGroups.pageNumber);
			Assert.AreEqual(3, consistencyGroups.pageSize);
			Assert.AreEqual(8, consistencyGroups.totalCount);

			Assert.IsNotNull(consistencyGroups.items);
			Assert.AreEqual(3, consistencyGroups.items.Count());
		}

		[TestMethod]
		public async Task GetConsistencyGroup_ReturnsResponse()
		{
			var consistencyGroupId = Guid.Parse("720ca33a-77bf-4d1f-8974-10ee6ec93034");
			requestsAndResponses.Add(ApiUris.GetConsistencyGroup(accountId, consistencyGroupId), RequestFileResponseType.AsGoodResponse("GetConsistencyGroupResponse.xml"));

			var client = GetWebApiClient();
			var accessor = new ConsistencyGroupAccessor(client);
			var consistencyGroup = await accessor.GetConsistencyGroup(consistencyGroupId);

			Assert.IsNotNull(consistencyGroup);
			Assert.AreEqual("Test-ConsistencyGroup", consistencyGroup.name);

			Assert.IsNotNull(consistencyGroup.serverPair);
			Assert.AreEqual(1, consistencyGroup.serverPair.Count());
			var serverPair = consistencyGroup.serverPair.ElementAt(0);
			Assert.AreEqual("eddf417d-dbf3-4858-a6fa-c44faa6eae66", serverPair.id);
			Assert.IsNotNull(serverPair.sourceServer);
			Assert.IsNotNull(serverPair.targetServer);

			Assert.AreEqual("2f275809-f279-43fe-8edb-bd3dafbdcb19", serverPair.sourceServer.id);
			Assert.AreEqual("CM-DRS-Source-2", serverPair.sourceServer.name);
			Assert.AreEqual("6d7ff46e-a677-4ffb-92dc-a7150d478104", serverPair.targetServer.id);
			Assert.AreEqual("CM-DRS-Target-2", serverPair.targetServer.name);

			Assert.IsNotNull(serverPair.sourceServer.nic);
			Assert.AreEqual("5915c011-5576-4c39-9567-bea67f4e02a5", serverPair.sourceServer.nic.ElementAt(0).id);
			// Checks for new vlan need to go in here.

			Assert.IsNotNull(serverPair.targetServer.nic);
			Assert.AreEqual("a2c5e55b-c9b5-4170-b025-3e3b6e2cbd2f", serverPair.targetServer.nic.ElementAt(0).id);

			Assert.IsNotNull(serverPair.reIpAddressRules);
			Assert.AreEqual("myHostName", serverPair.reIpAddressRules.hostName);
			Assert.AreEqual("my.domain.com", serverPair.reIpAddressRules.domain);
			Assert.IsNotNull(serverPair.reIpAddressRules.nicRule);
			Assert.AreEqual("a2c5e55b-c9b5-4170-b025-3e3b6e2cbd2f", serverPair.reIpAddressRules.nicRule.ElementAt(0).targetNicId);
			Assert.AreEqual("10.111.111.222", serverPair.reIpAddressRules.nicRule.ElementAt(0).privateIpv4Address);
		}

		[TestMethod]
		public async Task CreateConsistencyGroup_ReturnsResponse()
		{
			requestsAndResponses.Add(ApiUris.CreateConsistencyGroups(accountId), RequestFileResponseType.AsGoodResponse("CreateConsistencyGroupResponse.xml"));

			var consistencyGroupType = new CreateConsistencyGroupType();
			consistencyGroupType.name = "TestGroup";

			var client = GetWebApiClient();
			var accessor = new ConsistencyGroupAccessor(client);
			var response = await accessor.CreateConsistencyGroup(consistencyGroupType);

			Assert.IsNotNull(response);
			Assert.AreEqual("CREATE_CONSISTENCY_GROUP", response.operation);
			Assert.AreEqual("3389ffe8-c3fc-11e3-b29c-001517c4643e", response.info.ElementAt(0).value);
		}

		[TestMethod]
		public async Task GetConsistencyGroupSnapshots_Returns()
		{
			var baseUriBuilder = new UriBuilder(ApiUris.GetConsistencyGroupSnapshots(accountId).ToString());
			baseUriBuilder.Query = "consistencyGroupId=3389ffe8-c3fc-11e3-b29c-001517c4643e";
			requestsAndResponses.Add(new Uri(baseUriBuilder.Host + baseUriBuilder.Uri.PathAndQuery, UriKind.Relative), RequestFileResponseType.AsGoodResponse("GetConsistencyGroupSnapshotsResponse.xml"));

			var filteringOptions = new ConsistencyGroupSnapshotListOptions();
			var filter = new Filter();
			filter.Field = "consistencyGroupId";
			filter.Operator = FilterOperator.Equals;
			filter.Value = "3389ffe8-c3fc-11e3-b29c-001517c4643e";
			filteringOptions.Filters.Add(filter);

			var client = GetWebApiClient();
			var accessor = new ConsistencyGroupAccessor(client);
			var response = await accessor.GetConsistencyGroupSnapshots(filteringOptions);

			Assert.IsNotNull(response);
			Assert.AreEqual(6, response.totalCount);
			Assert.AreEqual(6, response.snapshot.Count());
			Assert.AreEqual("870146", response.snapshot.ElementAt(0).id);
			Assert.AreEqual("2019-06-21T08:24:55.944-04:00", response.snapshot.ElementAt(0).createTime);
			Assert.AreEqual(DateTimeOffset.Parse(response.snapshot.ElementAt(0).createTime), response.snapshot.ElementAt(0).createTimeOffset);
		}

		[TestMethod]
		public async Task StopPreviewSnapshot_Returns()
		{
			requestsAndResponses.Add(ApiUris.StopPreviewSnapshot(accountId), RequestFileResponseType.AsGoodResponse("StopPreviewSnapshotResponse.xml"));

			var stopPreviewSnapshotType = new StopPreviewSnapshotType();
			stopPreviewSnapshotType.consistencyGroupId = "3389ffe8-c3fc-11e3-b29c-001517c4643e";

			var client = GetWebApiClient();
			var accessor = new ConsistencyGroupAccessor(client);
			var response = await accessor.StopPreviewSnapshot(stopPreviewSnapshotType);

			Assert.IsNotNull(response);
			Assert.AreEqual("STOP_PREVIEW_SNAPSHOT", response.operation);
		}

		[TestMethod]
		public async Task StartPreviewSnapshot_ReturnsSuccess()
		{
			requestsAndResponses.Add(ApiUris.StartPreviewSnapshot(accountId), RequestFileResponseType.AsGoodResponse("StartPreviewSnapshotResponse.xml"));

			var startPreviewSnapshotType = new StartPreviewSnapshotType();
			startPreviewSnapshotType.consistencyGroupId = "3389ffe8-c3fc-11e3-b29c-001517c4643e";

			var client = GetWebApiClient();
			var accessor = new ConsistencyGroupAccessor(client);
			var response = await accessor.StartPreviewSnapshot(startPreviewSnapshotType);

			Assert.IsNotNull(response);
			Assert.AreEqual("START_PREVIEW_SNAPSHOT", response.operation);
		}

		[TestMethod]
		public async Task DeleteConsistencyGroup_ReturnsResponse()
		{
			requestsAndResponses.Add(ApiUris.DeleteConsistencyGroup(accountId), RequestFileResponseType.AsGoodResponse("DeleteConsistencyGroupResponse.xml"));

			var deleteConsistencyGroupType = new DeleteConsistencyGroupType();
			deleteConsistencyGroupType.id = "3389ffe8-c3fc-11e3-b29c-001517c4643e";

			var client = GetWebApiClient();
			var accessor = new ConsistencyGroupAccessor(client);
			var response = await accessor.DeleteConsistencyGroup(deleteConsistencyGroupType);

			Assert.IsNotNull(response);
			Assert.AreEqual("DELETE_CONSISTENCY_GROUP", response.operation);
		}

		[TestMethod]
		public async Task CleanConsistencyGroup_ReturnsResponse()
		{
			requestsAndResponses.Add(ApiUris.CleanConsistencyGroup(accountId), RequestFileResponseType.AsGoodResponse("CleanConsistencyGroupResponse.xml"));

			var cleanConsistencyGroupType = new CleanConsistencyGroupType();
			cleanConsistencyGroupType.id = "3389ffe8-c3fc-11e3-b29c-001517c4643e";

			var client = GetWebApiClient();
			var accessor = new ConsistencyGroupAccessor(client);
			var response = await accessor.CleanConsistencyGroup(cleanConsistencyGroupType);

			Assert.IsNotNull(response);
			Assert.AreEqual("CLEAN_CONSISTENCY_GROUP", response.operation);
		}

		[TestMethod]
		public async Task InitiateFailover_ReturnsResponse()
		{
			requestsAndResponses.Add(ApiUris.InitiateFailover(accountId), RequestFileResponseType.AsGoodResponse("InitiateFailoverResponse.xml"));

			var initiateFailoverType = new InitiateFailoverType();
			initiateFailoverType.consistencyGroupId = "3389ffe8-c3fc-11e3-b29c-001517c4643e";

			var client = GetWebApiClient();
			var accessor = new ConsistencyGroupAccessor(client);
			var response = await accessor.InitiateFailoverForConsistencyGroup(initiateFailoverType);

			Assert.IsNotNull(response);
			Assert.AreEqual("INITIATE_FAILOVER", response.operation);
		}

		[TestMethod]
		public async Task ExpandJournal_ReturnsResponse()
		{
			requestsAndResponses.Add(ApiUris.ExpandJournal(accountId), RequestFileResponseType.AsGoodResponse("ExpandJournalResponse.xml"));

			var expandJournalType = new ExpandJournalType();
			expandJournalType.id = "3389ffe8-c3fc-11e3-b29c-001517c4643e";
			expandJournalType.sizeGb = 30;

			var client = GetWebApiClient();
			var accessor = new ConsistencyGroupAccessor(client);
			var response = await accessor.ExpandJournal(expandJournalType);

			Assert.IsNotNull(response);
			Assert.AreEqual("EXPAND_JOURNAL", response.operation);
		}

		[TestMethod]
		public async Task DeleteDrsReIpAddressRules_ReturnsResponse()
		{
			requestsAndResponses.Add(ApiUris.DeleteDrsReIpAddressRules(accountId), RequestFileResponseType.AsGoodResponse("DeleteReIpAddressRulesResponse.xml"));

			var drsServerPairIdType = new DrsServerPairIdType();
			drsServerPairIdType.serverPairId = "eddf417d-dbf3-4858-a6fa-c44faa6eae66";

			var client = GetWebApiClient();
			var accessor = new ConsistencyGroupAccessor(client);
			var response = await accessor.DeleteReIpAddressRules(drsServerPairIdType);

			Assert.IsNotNull(response);
			Assert.AreEqual("DELETE_DRS_RE_IP_ADDRESS_RULES", response.operation);
		}
	}
}
