using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
			filter.available = true;
			filter.Id = Guid.NewGuid();

			var pagingRequest = new PageableRequest();
			pagingRequest.PageNumber = 1;
			pagingRequest.PageSize = 5;

			var expectedRelativeUriPath = string.Format(ApiUris.ListSnapshotServicePlans(accountId) +"?available={0}&id={1}&pageSize={2}&pageNumber={3}", "true", filter.Id, pagingRequest.PageSize, pagingRequest.PageNumber);
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
			Assert.IsFalse(oneMonthSnapshotServicePlan.supportsReplication);
			Assert.IsTrue(oneMonthSnapshotServicePlan.available);
		}
	}
}
