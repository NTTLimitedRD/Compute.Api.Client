using System;
using System.Linq;
using System.Threading.Tasks;
using DD.CBU.Compute.Api.Client;
using DD.CBU.Compute.Api.Client.Server20;
using DD.CBU.Compute.Api.Contracts.Requests;
using DD.CBU.Compute.Api.Contracts.Requests.Snapshot;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Compute.Client.UnitTests.Snapshot
{
	[TestClass]
	public class SnapshotAccessorTests : BaseApiClientTestFixture
	{
		[TestMethod]
		public async Task ListSnapshotServicePlans()
		{
			requestsAndResponses.Add(ApiUris.ListSnapshotServicePlans(accountId), RequestFileResponseType.AsGoodResponse("ListSnapshotServicePlansResponse.xml"));

			var client = GetWebApiClient();
			var accessor = new SnapshotAccessor(client);
			var snapshotServicePlansPaginated = await accessor.ListSnapshotServicePlans();

			Assert.IsNotNull(snapshotServicePlansPaginated);
			Assert.AreEqual(1, snapshotServicePlansPaginated.pageCount);
			Assert.AreEqual(5, snapshotServicePlansPaginated.totalCount);
			Assert.AreEqual(5, snapshotServicePlansPaginated.pageSize);
			Assert.AreEqual(1, snapshotServicePlansPaginated.pageNumber);

			Assert.AreEqual(5, snapshotServicePlansPaginated.items.Count(), "There should be 5 snapshot service plans.");

			var snapshotPlans = snapshotServicePlansPaginated.items.OrderBy(snapshotPlan => snapshotPlan.id).ToList();

			var advancedSnapshotServicePlan = snapshotPlans.ElementAt(0);
			var essentialsSnapshotServicePlan = snapshotPlans.ElementAt(1);
			var oneMonthSnapshotServicePlan = snapshotPlans.ElementAt(2);
			var threeMonthSnapshotServicePlan = snapshotPlans.ElementAt(3);
			var twelveMonthSnapshotServicePlan = snapshotPlans.ElementAt(4);

			Assert.AreEqual("ADVANCED", advancedSnapshotServicePlan.id);
			Assert.AreEqual("Advanced: 31d-52w", advancedSnapshotServicePlan.displayName);
			Assert.AreEqual("Daily Snapshots for retained for 31 Days, Weekly Snapshots retained for 1 Year", advancedSnapshotServicePlan.description);
			Assert.AreEqual("DAILY", advancedSnapshotServicePlan.snapshotFrequency);
			Assert.IsFalse(advancedSnapshotServicePlan.supportsReplication);
			Assert.IsFalse(advancedSnapshotServicePlan.available);

			Assert.AreEqual("ESSENTIALS", essentialsSnapshotServicePlan.id);
			Assert.AreEqual("Essentials: 4w", essentialsSnapshotServicePlan.displayName);
			Assert.AreEqual("One snapshot each week, retained for 31 Days", essentialsSnapshotServicePlan.description);
			Assert.AreEqual("WEEKLY", essentialsSnapshotServicePlan.snapshotFrequency);
			Assert.IsFalse(essentialsSnapshotServicePlan.supportsReplication);
			Assert.IsFalse(essentialsSnapshotServicePlan.available);

			Assert.AreEqual("ONE_MONTH", oneMonthSnapshotServicePlan.id);
			Assert.AreEqual("One Month: 7d-4w", oneMonthSnapshotServicePlan.displayName);
			Assert.AreEqual("Daily Snapshots retained for 7 Days, Weekly Snapshots retained for 31 Days", oneMonthSnapshotServicePlan.description);
			Assert.AreEqual("DAILY", oneMonthSnapshotServicePlan.snapshotFrequency);
			Assert.IsFalse(oneMonthSnapshotServicePlan.supportsReplication);
			Assert.IsTrue(oneMonthSnapshotServicePlan.available);

			Assert.AreEqual("THREE_MONTH", threeMonthSnapshotServicePlan.id);
			Assert.AreEqual("Three Month: 14d-12w", threeMonthSnapshotServicePlan.displayName);
			Assert.AreEqual("Daily Snapshots retained for 14 Days, Weekly Snapshots retained for 90 Days", threeMonthSnapshotServicePlan.description);
			Assert.AreEqual("DAILY", threeMonthSnapshotServicePlan.snapshotFrequency);
			Assert.IsFalse(threeMonthSnapshotServicePlan.supportsReplication);
			Assert.IsTrue(threeMonthSnapshotServicePlan.available);

			Assert.AreEqual("TWELVE_MONTH", twelveMonthSnapshotServicePlan.id);
			Assert.AreEqual("Twelve Month: 31d-12w-12m", twelveMonthSnapshotServicePlan.displayName);
			Assert.AreEqual("Daily Snapshots retained for 31 Days, Weekly Snapshots retained for 90 Days, Monthly Snapshots retained for 1 Year", twelveMonthSnapshotServicePlan.description);
			Assert.AreEqual("DAILY", twelveMonthSnapshotServicePlan.snapshotFrequency);
			Assert.IsFalse(twelveMonthSnapshotServicePlan.supportsReplication);
			Assert.IsTrue(twelveMonthSnapshotServicePlan.available);
		}

		[TestMethod]
		public async Task ListSnapshotServicePlans_WithFiltersAndPagingOptions()
		{
			var filter = new SnapshotServicePlanListOptions();
			filter.Available = true;
			filter.Id = Guid.NewGuid();

			var pagingRequest = new PageableRequest();
			pagingRequest.PageNumber = 1;
			pagingRequest.PageSize = 10;

			var expectedRelativeUriPath = string.Format(ApiUris.ListSnapshotServicePlans(accountId) + "?available={0}&id={1}&pageSize={2}&pageNumber={3}", "true", filter.Id, pagingRequest.PageSize, pagingRequest.PageNumber);
			var expectedUri = new Uri(expectedRelativeUriPath, UriKind.Relative);

			requestsAndResponses.Add(expectedUri, RequestFileResponseType.AsGoodResponse("ListSnapshotServicePlansWithFilterResponse.xml"));

			var client = GetWebApiClient();
			var accessor = new SnapshotAccessor(client);

			var snapshotServicePlansPaginated = await accessor.ListSnapshotServicePlans(filter, pagingRequest);

			Assert.IsNotNull(snapshotServicePlansPaginated);
			Assert.IsNotNull(snapshotServicePlansPaginated);
			Assert.AreEqual(1, snapshotServicePlansPaginated.pageCount);
			Assert.AreEqual(1, snapshotServicePlansPaginated.totalCount);
			Assert.AreEqual(10, snapshotServicePlansPaginated.pageSize);
			Assert.AreEqual(1, snapshotServicePlansPaginated.pageNumber);

			var snapshotPlans = snapshotServicePlansPaginated.items.ToList();
			var oneMonthSnapshotServicePlan = snapshotPlans.ElementAt(0);

			Assert.AreEqual("ONE_MONTH", oneMonthSnapshotServicePlan.id);
			Assert.AreEqual("One Month: 7d-4w", oneMonthSnapshotServicePlan.displayName);
			Assert.AreEqual("Daily Snapshots retained for 7 Days, Weekly Snapshots retained for 31 Days", oneMonthSnapshotServicePlan.description);
			Assert.AreEqual("DAILY", oneMonthSnapshotServicePlan.snapshotFrequency);
			Assert.IsTrue(oneMonthSnapshotServicePlan.supportsReplication);
			Assert.IsTrue(oneMonthSnapshotServicePlan.available);
		}

		[TestMethod]
		public async Task ListSnapshots()
		{
			Guid serverId = new Guid("0fad8eeb-83d7-4703-b450-171c33a79682");

			requestsAndResponses.Add(ApiUris.ListSnapshots(accountId, serverId), RequestFileResponseType.AsGoodResponse("ListSnapshots.xml"));

			var client = GetWebApiClient();
			var accessor = new SnapshotAccessor(client);
			var snapshotsPaginated = await accessor.GetSnapshotsPaginated(serverId);

			Assert.IsNotNull(snapshotsPaginated);
			Assert.AreEqual(1, snapshotsPaginated.pageCount);
			Assert.AreEqual(4, snapshotsPaginated.totalCount);
			Assert.AreEqual(250, snapshotsPaginated.pageSize);
			Assert.AreEqual(1, snapshotsPaginated.pageNumber);

			Assert.AreEqual(4, snapshotsPaginated.items.Count(), "There should be 4 server snapshots.");

			var notArchivedSnapshot = snapshotsPaginated.items.ElementAt(0);
			var additonalNotArchivedSnapshot = snapshotsPaginated.items.ElementAt(1);

            var archivedSnapshot = snapshotsPaginated.items.ElementAt(2);
            var additonalArchivedSnapshot = snapshotsPaginated.items.ElementAt(3);

            Assert.AreEqual("43559921", notArchivedSnapshot.id);
            Assert.AreEqual("AVAILABLE_LOCALLY", notArchivedSnapshot.archiveStatus);
            Assert.IsFalse(notArchivedSnapshot.archived);
			Assert.IsTrue(notArchivedSnapshot.replica);
			Assert.AreEqual("NA1",notArchivedSnapshot.datacenterId);
			Assert.AreEqual("INDEX_VALID",notArchivedSnapshot.indexState);
			Assert.AreEqual("SYSTEM",notArchivedSnapshot.type);

            Assert.AreEqual("4349921", additonalNotArchivedSnapshot.id);
            Assert.IsNull(additonalNotArchivedSnapshot.archiveStatus);
            Assert.IsFalse(additonalNotArchivedSnapshot.archived);
            Assert.IsFalse(additonalNotArchivedSnapshot.replica);
			Assert.AreEqual("NA2",additonalNotArchivedSnapshot.datacenterId);
			Assert.AreEqual("MANUAL",additonalNotArchivedSnapshot.type);

            Assert.AreEqual("5559921", archivedSnapshot.id);
            Assert.AreEqual("ARCHIVED", archivedSnapshot.archiveStatus);
            Assert.IsTrue(archivedSnapshot.archived);
            Assert.AreEqual("SYSTEM",archivedSnapshot.type);

            Assert.AreEqual("888921", additonalArchivedSnapshot.id);
            Assert.AreEqual("DOWNLOAD_IN_PROGRESS", additonalArchivedSnapshot.archiveStatus);
            Assert.IsTrue(additonalArchivedSnapshot.archived);
            Assert.AreEqual("SYSTEM",additonalArchivedSnapshot.type);
        }

        [TestMethod]
        public async Task ListSnapshotsWithFilterOptions()
        {
			Guid serverId = new Guid("0fad8eeb-83d7-4703-b450-171c33a79682");
			var snapshotListOptions = new SnapshotListOptions
			    {
			         Filters =
			          {
				          new Filter { Field = SnapshotListOptions.TypeField,Value = "SYSTEM" },
				          new Filter { Field = SnapshotListOptions.IndexStateField,Value = "INDEX_INVALID" },
				          new Filter { Field = SnapshotListOptions.ArchiveStatusField,Value="ARCHIVED" }

			          }

			    };

			var queryString = "type=SYSTEM&indexState=INDEX_INVALID&archiveStatus=ARCHIVED";

			var listSnapshotsUri = new Uri(ApiUris.ListSnapshots(accountId, serverId) + "&" + queryString, UriKind.Relative);

			requestsAndResponses.Add(listSnapshotsUri, RequestFileResponseType.AsGoodResponse("ListSnapshotFiltered.xml"));

			var client = GetWebApiClient();
            var accessor = new SnapshotAccessor(client);
            var snapshotsPaginated = await accessor.GetSnapshotsPaginated(serverId, snapshotListOptions);

			Assert.IsNotNull(snapshotsPaginated);
			Assert.AreEqual(1, snapshotsPaginated.pageCount);
			Assert.AreEqual(1, snapshotsPaginated.totalCount);
			Assert.AreEqual(50, snapshotsPaginated.pageSize);
			Assert.AreEqual(1, snapshotsPaginated.pageNumber);

			Assert.AreEqual(1, snapshotsPaginated.items.Count(), "There should be 1 server snapshot.");
			var archivedSnapshot = snapshotsPaginated.items.ElementAt(0);
			Assert.AreEqual("5559921", archivedSnapshot.id);
			Assert.AreEqual("ARCHIVED", archivedSnapshot.archiveStatus);
			Assert.AreEqual("INDEX_INVALID", archivedSnapshot.indexState);
			Assert.AreEqual("SYSTEM", archivedSnapshot.type);
		}
        [TestMethod]
        public async Task ListSnapshotsWithFilterAndPagingOptions_differentOverload()
        {
	        Guid serverId = new Guid("0fad8eeb-83d7-4703-b450-171c33a79682");
	        var snapshotListOptions = new SnapshotListOptions
	        {
		        Filters =
		        {
			        new Filter { Field = SnapshotListOptions.TypeField,Value = "SYSTEM" },
			        new Filter { Field = SnapshotListOptions.IndexStateField,Value = "INDEX_INVALID" },
			        new Filter { Field = SnapshotListOptions.ArchiveStatusField,Value="ARCHIVED" },
			        new Filter { Field = SnapshotListOptions.ServerIdField,Value = serverId }

				}

			};
	        var pagingRequest = new PageableRequest();
	        pagingRequest.PageNumber = 1;
	        pagingRequest.PageSize = 50;

			var queryString = "type=SYSTEM&indexState=INDEX_INVALID&archiveStatus=ARCHIVED&serverId=0fad8eeb-83d7-4703-b450-171c33a79682&pageSize=50&pageNumber=1";

	        var listSnapshotsUri = new Uri(ApiUris.ListSnapshots(accountId, snapshotListOptions.ServerId.Value) + "&" + queryString, UriKind.Relative);

	        requestsAndResponses.Add(listSnapshotsUri, RequestFileResponseType.AsGoodResponse("ListSnapshotFiltered.xml"));

	        var client = GetWebApiClient();
	        var accessor = new SnapshotAccessor(client);
	        var snapshotsPaginated = await accessor.GetSnapshotsPaginated(snapshotListOptions, pagingRequest);

	        Assert.IsNotNull(snapshotsPaginated);
	        Assert.AreEqual(1, snapshotsPaginated.pageCount);
	        Assert.AreEqual(1, snapshotsPaginated.totalCount);
	        Assert.AreEqual(50, snapshotsPaginated.pageSize);
	        Assert.AreEqual(1, snapshotsPaginated.pageNumber);

	        Assert.AreEqual(1, snapshotsPaginated.items.Count(), "There should be 1 server snapshot.");
        }
	}

}
