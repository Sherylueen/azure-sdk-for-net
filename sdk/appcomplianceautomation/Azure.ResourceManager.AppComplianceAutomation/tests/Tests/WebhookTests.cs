// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.ResourceManager.AppComplianceAutomation.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.AppComplianceAutomation.Tests.Tests
{
    public class WebhookTests : AppComplianceAutomationManagementTestBase
    {
        public WebhookTests(bool isAsync) : base(isAsync)
        {
        }

        private TestContext testContextInstance;
        private static string reportName = "sdk-report";
        private static string webhookName = "sdk-webhook";

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

        [TestCase]
        public async Task WebhookGet()
        {
            // List webhooks
            int count = 0;
            ReportResource report = Client.GetReportResource(ReportResource.CreateResourceIdentifier(reportName));
            WebhookResourceCollection webhooks = report.GetWebhookResources();
            await foreach (WebhookResource resource in webhooks.GetAllAsync())
            {
                count++;
            }
            Assert.AreEqual(1, count);
        }

        [TestCase]
        public async Task WebhookCreate()
        {
            ReportResource report = Client.GetReportResource(ReportResource.CreateResourceIdentifier(reportName));
            WebhookResourceCollection webhooks = report.GetWebhookResources();
            // create webhook
            WebhookProperties properties = new WebhookProperties();
            properties.SendAllEvents = "true";
            properties.Events.Add(new NotificationEvent("generate_snapshot_success"));
            properties.Status = WebhookStatus.Enabled;
            properties.ContentType = "application/json";
            properties.EnableSslVerification = EnableSslVerification.True;
            properties.PayloadUri = new Uri("https://localhest:2000");
            WebhookResourceData data = new WebhookResourceData(properties);
            var _ = await webhooks.CreateOrUpdateAsync(WaitUntil.Completed, webhookName, data);
            // Get webhook
            Response<WebhookResource> getResponse = await webhooks.GetAsync(webhookName);
            WebhookResource webhook = getResponse.Value;
            Assert.IsNotNull(webhook);
        }

        [TestCase]
        public async Task WebhookDelete()
        {
            ReportResource report = Client.GetReportResource(ReportResource.CreateResourceIdentifier(reportName));
            WebhookResourceCollection webhooks = report.GetWebhookResources();
            Response<WebhookResource> getResponse = await webhooks.GetAsync(webhookName);
            WebhookResource webhook = getResponse.Value;
            // Delete webhook
            var operation = await webhook.DeleteAsync(WaitUntil.Completed);
            Assert.IsTrue(operation.HasCompleted);
        }
    }
}
