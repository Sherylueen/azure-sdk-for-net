// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.AppComplianceAutomation;
using NUnit.Framework;
using Azure.ResourceManager.AppComplianceAutomation.Models;
using System.Collections.Generic;
using Azure.Core;
using Newtonsoft.Json;
using static System.Formats.Asn1.AsnWriter;

namespace Azure.ResourceManager.AppComplianceAutomation.Tests.Tests
{
    public class SnapshotTests : AppComplianceAutomationManagementTestBase
    {
        public SnapshotTests(bool isAsync) : base(isAsync)
        {
        }

        private TestContext testContextInstance;
        private static string reportName = "sdk-report";
        private static string snapshotName = "sdk-report_20230809T150952.401Z";

        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

        [SetUp]
        public void Init()
        {
            InitializeUserTokenClients();
        }

        [OneTimeTearDown]
        public void Cleanup()
        {
        }
        private static string latestSnapshotName;

        [TestCase]
        public async Task ListSnapshot()
        {
            // List snapshots
            int count = 0;
            latestSnapshotName = "";
            ReportResource report = Client.GetReportResource(ReportResource.CreateResourceIdentifier(reportName));
            SnapshotResourceCollection snapshots = report.GetSnapshotResources();
            await foreach (SnapshotResource resource in snapshots.GetAllAsync(null))
            {
                count++;
                if (latestSnapshotName == "")
                {
                    latestSnapshotName = resource.Data.Name;
                }
                Console.WriteLine(resource.Data.Name);
            }
            Assert.Greater(count, 0);
        }
        [TestCase]
        public async Task GetSnapshot()
        {
            ReportResource report = Client.GetReportResource(ReportResource.CreateResourceIdentifier(reportName));
            SnapshotResourceCollection snapshots = report.GetSnapshotResources();
            // Get snapshot
            SnapshotResource snapshot = await snapshots.GetAsync(snapshotName);
            Assert.IsNotNull(snapshot);
        }

        [TestCase]
        public async Task DownloadSnapshot()
        {
            ReportResource report = Client.GetReportResource(ReportResource.CreateResourceIdentifier(reportName));
            SnapshotResourceCollection snapshots = report.GetSnapshotResources();
            // Get snapshot
            SnapshotResource snapshot = await snapshots.GetAsync(snapshotName);
            // Download snapshot
            SnapshotDownloadContent content = new SnapshotDownloadContent(DownloadType.CompliancePdfReport);

            ArmOperation<DownloadResponse> response = await snapshot.DownloadAsync(WaitUntil.Completed, content);
            Assert.IsNotNull(response);
        }
    }
}
