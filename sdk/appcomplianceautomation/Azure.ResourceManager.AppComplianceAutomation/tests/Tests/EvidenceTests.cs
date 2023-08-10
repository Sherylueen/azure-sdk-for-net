// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Security.Policy;
using System.Threading.Tasks;
using Azure.ResourceManager.AppComplianceAutomation.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppComplianceAutomation.Tests.Tests
{
    public class EvidenceTests : AppComplianceAutomationManagementTestBase
    {
        public EvidenceTests(bool isAsync) : base(isAsync)
        {
        }

        private TestContext testContextInstance;

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

        private static string reportName = "sdk-report";
        private static string evidenceName = "sdk-evidence";
        private static string controlId = "Operational_Security_27";
        private static string responsibilityId = "enforce_ssl_connection_should_be_enabled_for_mysql_database_servers";

        [TestCase]
        public async Task ListEvidences()
        {
            // List evidences
            int count = 0;
            ReportResource report = Client.GetReportResource(ReportResource.CreateResourceIdentifier(reportName));
            EvidenceResourceCollection evidences = report.GetEvidenceResources();
            await foreach (EvidenceResource resource in evidences.GetAllAsync(null))
            {
                count++;
            }
            Assert.AreEqual(count, 0);
        }

        [TestCase]
        public async Task CreateEvidence()
        {
            // Create evidence
            ReportResource report = Client.GetReportResource(ReportResource.CreateResourceIdentifier(reportName));
            EvidenceResourceCollection evidences = report.GetEvidenceResources();
            EvidenceProperties properties = new EvidenceProperties();
            properties.ControlId = controlId;
            properties.ResponsibilityId = responsibilityId;
            string filePath = String.Format("acatevidence/{0}/{1}/{2}/{3}/test.png", reportName, controlId, responsibilityId, evidenceName);
            properties.FilePath = filePath;
            EvidenceResourceData data = new EvidenceResourceData(properties);
            var _ = await evidences.CreateOrUpdateAsync(WaitUntil.Completed, evidenceName, data);

            Response<EvidenceResource> getResponse = await evidences.GetAsync(evidenceName);
            EvidenceResource evidence = getResponse.Value;
            Assert.IsNotNull(evidence);
        }

        [TestCase]
        public async Task DeleteEvidence()
        {
            ReportResource report = Client.GetReportResource(ReportResource.CreateResourceIdentifier(reportName));
            EvidenceResourceCollection evidences = report.GetEvidenceResources();
            // Get evidence
            Response<EvidenceResource> getResponse = await evidences.GetAsync(evidenceName);
            EvidenceResource evidence = getResponse.Value;
            // Delete evidence
            var operation = await evidence.DeleteAsync(WaitUntil.Completed);
            Assert.IsTrue(operation.HasCompleted);
        }
    }
}
