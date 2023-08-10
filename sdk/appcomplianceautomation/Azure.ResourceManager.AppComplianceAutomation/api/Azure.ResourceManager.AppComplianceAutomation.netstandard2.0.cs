namespace Azure.ResourceManager.AppComplianceAutomation
{
    public static partial class AppComplianceAutomationExtensions
    {
        public static Azure.Response<Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityResponse> CheckNameAvailabilityReport(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityResponse>> CheckNameAvailabilityReportAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppComplianceAutomation.Models.GetCollectionCountResponse> GetCollectionCountReport(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.ResourceManager.AppComplianceAutomation.Models.GetCollectionCountContent content, string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.Models.GetCollectionCountResponse>> GetCollectionCountReportAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.ResourceManager.AppComplianceAutomation.Models.GetCollectionCountContent content, string filter = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.EvidenceResource GetEvidenceResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppComplianceAutomation.Models.ListInUseStorageAccountsResponse> GetInUseStorageAccountReport(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.ResourceManager.AppComplianceAutomation.Models.ListInUseStorageAccountsContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.Models.ListInUseStorageAccountsResponse>> GetInUseStorageAccountReportAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.ResourceManager.AppComplianceAutomation.Models.ListInUseStorageAccountsContent content = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppComplianceAutomation.Models.GetOverviewStatusResponse> GetOverviewStatusReport(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.ResourceManager.AppComplianceAutomation.Models.GetOverviewStatusContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.Models.GetOverviewStatusResponse>> GetOverviewStatusReportAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.ResourceManager.AppComplianceAutomation.Models.GetOverviewStatusContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.ReportResource GetReportResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.Response<Azure.ResourceManager.AppComplianceAutomation.ReportResource> GetReportResource(this Azure.ResourceManager.Resources.TenantResource tenantResource, string reportName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.ReportResource>> GetReportResourceAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, string reportName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.ReportResourceCollection GetReportResources(this Azure.ResourceManager.Resources.TenantResource tenantResource) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.SnapshotResource GetSnapshotResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.WebhookResource GetWebhookResource(this Azure.ResourceManager.ArmClient client, Azure.Core.ResourceIdentifier id) { throw null; }
        public static Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.Models.OnboardResponse> Onboard(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.WaitUntil waitUntil, Azure.ResourceManager.AppComplianceAutomation.Models.OnboardContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.Models.OnboardResponse>> OnboardAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.WaitUntil waitUntil, Azure.ResourceManager.AppComplianceAutomation.Models.OnboardContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.Models.TriggerEvaluationResponse> TriggerEvaluation(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.WaitUntil waitUntil, Azure.ResourceManager.AppComplianceAutomation.Models.TriggerEvaluationContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public static System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.Models.TriggerEvaluationResponse>> TriggerEvaluationAsync(this Azure.ResourceManager.Resources.TenantResource tenantResource, Azure.WaitUntil waitUntil, Azure.ResourceManager.AppComplianceAutomation.Models.TriggerEvaluationContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EvidenceResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected EvidenceResource() { }
        public virtual Azure.ResourceManager.AppComplianceAutomation.EvidenceResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string reportName, string evidenceName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceFileDownloadResponse> Download(Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceFileDownloadContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceFileDownloadResponse>> DownloadAsync(Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceFileDownloadContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource> Get(string offerGuid = null, string reportCreatorTenantId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource>> GetAsync(string offerGuid = null, string reportCreatorTenantId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppComplianceAutomation.EvidenceResourceData data, string offerGuid = null, string reportCreatorTenantId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppComplianceAutomation.EvidenceResourceData data, string offerGuid = null, string reportCreatorTenantId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class EvidenceResourceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource>, System.Collections.IEnumerable
    {
        protected EvidenceResourceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string evidenceName, Azure.ResourceManager.AppComplianceAutomation.EvidenceResourceData data, string offerGuid = null, string reportCreatorTenantId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string evidenceName, Azure.ResourceManager.AppComplianceAutomation.EvidenceResourceData data, string offerGuid = null, string reportCreatorTenantId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string evidenceName, string offerGuid = null, string reportCreatorTenantId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string evidenceName, string offerGuid = null, string reportCreatorTenantId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource> Get(string evidenceName, string offerGuid = null, string reportCreatorTenantId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource> GetAll(Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceResourceCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource> GetAllAsync(Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceResourceCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource>> GetAsync(string evidenceName, string offerGuid = null, string reportCreatorTenantId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class EvidenceResourceData : Azure.ResourceManager.Models.ResourceData
    {
        public EvidenceResourceData(Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceProperties properties) { }
        public Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceProperties Properties { get { throw null; } set { } }
    }
    public partial class ReportResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected ReportResource() { }
        public virtual Azure.ResourceManager.AppComplianceAutomation.ReportResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string reportName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppComplianceAutomation.ReportResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.ReportResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource> GetEvidenceResource(string evidenceName, string offerGuid = null, string reportCreatorTenantId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.EvidenceResource>> GetEvidenceResourceAsync(string evidenceName, string offerGuid = null, string reportCreatorTenantId = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppComplianceAutomation.EvidenceResourceCollection GetEvidenceResources() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppComplianceAutomation.SnapshotResource> GetSnapshotResource(string snapshotName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.SnapshotResource>> GetSnapshotResourceAsync(string snapshotName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppComplianceAutomation.SnapshotResourceCollection GetSnapshotResources() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppComplianceAutomation.WebhookResource> GetWebhookResource(string webhookName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.WebhookResource>> GetWebhookResourceAsync(string webhookName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.AppComplianceAutomation.WebhookResourceCollection GetWebhookResources() { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityResponse> NestedResourceCheckNameAvailability(Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityResponse>> NestedResourceCheckNameAvailabilityAsync(Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityRequest body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation SyncCertRecord(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppComplianceAutomation.Models.SyncCertRecordContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> SyncCertRecordAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppComplianceAutomation.Models.SyncCertRecordContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.ReportResource> Update(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppComplianceAutomation.Models.ReportResourcePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.ReportResource>> UpdateAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppComplianceAutomation.Models.ReportResourcePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class ReportResourceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppComplianceAutomation.ReportResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.ReportResource>, System.Collections.IEnumerable
    {
        protected ReportResourceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.ReportResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string reportName, Azure.ResourceManager.AppComplianceAutomation.ReportResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.ReportResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string reportName, Azure.ResourceManager.AppComplianceAutomation.ReportResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string reportName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string reportName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppComplianceAutomation.ReportResource> Get(string reportName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppComplianceAutomation.ReportResource> GetAll(Azure.ResourceManager.AppComplianceAutomation.Models.ReportResourceCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppComplianceAutomation.ReportResource> GetAllAsync(Azure.ResourceManager.AppComplianceAutomation.Models.ReportResourceCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.ReportResource>> GetAsync(string reportName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppComplianceAutomation.ReportResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppComplianceAutomation.ReportResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppComplianceAutomation.ReportResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.ReportResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class ReportResourceData : Azure.ResourceManager.Models.ResourceData
    {
        public ReportResourceData(Azure.ResourceManager.AppComplianceAutomation.Models.ReportProperties properties) { }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ReportProperties Properties { get { throw null; } set { } }
    }
    public partial class SnapshotResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected SnapshotResource() { }
        public virtual Azure.ResourceManager.AppComplianceAutomation.SnapshotResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string reportName, string snapshotName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.Models.DownloadResponse> Download(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppComplianceAutomation.Models.SnapshotDownloadContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.Models.DownloadResponse>> DownloadAsync(Azure.WaitUntil waitUntil, Azure.ResourceManager.AppComplianceAutomation.Models.SnapshotDownloadContent content, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppComplianceAutomation.SnapshotResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.SnapshotResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class SnapshotResourceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppComplianceAutomation.SnapshotResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.SnapshotResource>, System.Collections.IEnumerable
    {
        protected SnapshotResourceCollection() { }
        public virtual Azure.Response<bool> Exists(string snapshotName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string snapshotName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppComplianceAutomation.SnapshotResource> Get(string snapshotName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppComplianceAutomation.SnapshotResource> GetAll(Azure.ResourceManager.AppComplianceAutomation.Models.SnapshotResourceCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppComplianceAutomation.SnapshotResource> GetAllAsync(Azure.ResourceManager.AppComplianceAutomation.Models.SnapshotResourceCollectionGetAllOptions options, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.SnapshotResource>> GetAsync(string snapshotName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppComplianceAutomation.SnapshotResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppComplianceAutomation.SnapshotResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppComplianceAutomation.SnapshotResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.SnapshotResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class SnapshotResourceData : Azure.ResourceManager.Models.ResourceData
    {
        public SnapshotResourceData() { }
        public Azure.ResourceManager.AppComplianceAutomation.Models.SnapshotProperties Properties { get { throw null; } }
    }
    public partial class WebhookResource : Azure.ResourceManager.ArmResource
    {
        public static readonly Azure.Core.ResourceType ResourceType;
        protected WebhookResource() { }
        public virtual Azure.ResourceManager.AppComplianceAutomation.WebhookResourceData Data { get { throw null; } }
        public virtual bool HasData { get { throw null; } }
        public static Azure.Core.ResourceIdentifier CreateResourceIdentifier(string reportName, string webhookName) { throw null; }
        public virtual Azure.ResourceManager.ArmOperation Delete(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation> DeleteAsync(Azure.WaitUntil waitUntil, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppComplianceAutomation.WebhookResource> Get(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.WebhookResource>> GetAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppComplianceAutomation.WebhookResource> Update(Azure.ResourceManager.AppComplianceAutomation.Models.WebhookResourcePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.WebhookResource>> UpdateAsync(Azure.ResourceManager.AppComplianceAutomation.Models.WebhookResourcePatch patch, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
    }
    public partial class WebhookResourceCollection : Azure.ResourceManager.ArmCollection, System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppComplianceAutomation.WebhookResource>, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.WebhookResource>, System.Collections.IEnumerable
    {
        protected WebhookResourceCollection() { }
        public virtual Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.WebhookResource> CreateOrUpdate(Azure.WaitUntil waitUntil, string webhookName, Azure.ResourceManager.AppComplianceAutomation.WebhookResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.ResourceManager.ArmOperation<Azure.ResourceManager.AppComplianceAutomation.WebhookResource>> CreateOrUpdateAsync(Azure.WaitUntil waitUntil, string webhookName, Azure.ResourceManager.AppComplianceAutomation.WebhookResourceData data, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<bool> Exists(string webhookName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<bool>> ExistsAsync(string webhookName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Response<Azure.ResourceManager.AppComplianceAutomation.WebhookResource> Get(string webhookName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.Pageable<Azure.ResourceManager.AppComplianceAutomation.WebhookResource> GetAll(string skipToken = null, int? top = default(int?), string select = null, string filter = null, string orderby = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual Azure.AsyncPageable<Azure.ResourceManager.AppComplianceAutomation.WebhookResource> GetAllAsync(string skipToken = null, int? top = default(int?), string select = null, string filter = null, string orderby = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        public virtual System.Threading.Tasks.Task<Azure.Response<Azure.ResourceManager.AppComplianceAutomation.WebhookResource>> GetAsync(string webhookName, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken)) { throw null; }
        System.Collections.Generic.IAsyncEnumerator<Azure.ResourceManager.AppComplianceAutomation.WebhookResource> System.Collections.Generic.IAsyncEnumerable<Azure.ResourceManager.AppComplianceAutomation.WebhookResource>.GetAsyncEnumerator(System.Threading.CancellationToken cancellationToken) { throw null; }
        System.Collections.Generic.IEnumerator<Azure.ResourceManager.AppComplianceAutomation.WebhookResource> System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.WebhookResource>.GetEnumerator() { throw null; }
        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator() { throw null; }
    }
    public partial class WebhookResourceData : Azure.ResourceManager.Models.ResourceData
    {
        public WebhookResourceData(Azure.ResourceManager.AppComplianceAutomation.Models.WebhookProperties properties) { }
        public Azure.ResourceManager.AppComplianceAutomation.Models.WebhookProperties Properties { get { throw null; } set { } }
    }
}
namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public static partial class ArmAppComplianceAutomationModelFactory
    {
        public static Azure.ResourceManager.AppComplianceAutomation.Models.Category Category(string categoryName = null, Azure.ResourceManager.AppComplianceAutomation.Models.CategoryStatus? categoryStatus = default(Azure.ResourceManager.AppComplianceAutomation.Models.CategoryStatus?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamily> controlFamilies = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityResponse CheckNameAvailabilityResponse(bool? nameAvailable = default(bool?), Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityReason? reason = default(Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityReason?), string message = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ComplianceReportItem ComplianceReportItem(string categoryName = null, string controlFamilyName = null, string controlId = null, string controlName = null, Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus? controlStatus = default(Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus?), string responsibilityTitle = null, string responsibilityDescription = null, string resourceId = null, string resourceType = null, Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin? resourceOrigin = default(Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin?), Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus? resourceStatus = default(Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus?), System.DateTimeOffset? resourceStatusChangeOn = default(System.DateTimeOffset?)) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ComplianceResult ComplianceResult(string complianceName = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.Category> categories = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.Control Control(string controlId = null, string controlName = null, string controlFullName = null, string controlDescription = null, string controlDescriptionHyperLink = null, Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus? controlStatus = default(Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.Responsibility> responsibilities = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamily ControlFamily(string controlFamilyName = null, Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamilyStatus? controlFamilyStatus = default(Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamilyStatus?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.Control> controls = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.DownloadResponse DownloadResponse(System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.ResourceItem> resourceList = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.ComplianceReportItem> complianceReport = null, System.Uri compliancePdfReportSasUri = null, System.Uri complianceDetailedPdfReportSasUri = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceFileDownloadResponse EvidenceFileDownloadResponse(System.Uri evidenceFileUri = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceProperties EvidenceProperties(Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceType? evidenceType = default(Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceType?), string evidenceName = null, string filePath = null, string controlId = null, string responsibilityId = null, string reportName = null, Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.EvidenceResourceData EvidenceResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceProperties properties = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.GetCollectionCountResponse GetCollectionCountResponse(int? count = default(int?)) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.GetOverviewStatusResponse GetOverviewStatusResponse(System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.StatusItem> statusList = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ListInUseStorageAccountsResponse ListInUseStorageAccountsResponse(System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.StorageInfo> storageAccountList = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.OnboardResponse OnboardResponse(System.Collections.Generic.IEnumerable<string> subscriptionIds = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.OverviewStatus OverviewStatus(int? passedCount = default(int?), int? failedCount = default(int?), int? manualCount = default(int?), int? notApplicableCount = default(int?), int? pendingCount = default(int?)) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.QuickAssessment QuickAssessment(string resourceId = null, string responsibilityId = null, System.DateTimeOffset? timestamp = default(System.DateTimeOffset?), Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus? resourceStatus = default(Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus?), string displayName = null, string description = null, string remediationLink = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.Recommendation Recommendation(string recommendationId = null, string recommendationShortName = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.RecommendationSolution> recommendationSolutions = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.RecommendationSolution RecommendationSolution(string recommendationSolutionIndex = null, string recommendationSolutionContent = null, Azure.ResourceManager.AppComplianceAutomation.Models.IsRecommendSolution? isRecommendSolution = default(Azure.ResourceManager.AppComplianceAutomation.Models.IsRecommendSolution?)) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ReportProperties ReportProperties(string id = null, Azure.ResourceManager.AppComplianceAutomation.Models.ReportStatus? status = default(Azure.ResourceManager.AppComplianceAutomation.Models.ReportStatus?), System.Guid? tenantId = default(System.Guid?), string reportName = null, string offerGuid = null, string timeZone = null, System.DateTimeOffset? triggerOn = default(System.DateTimeOffset?), System.DateTimeOffset? nextTriggerOn = default(System.DateTimeOffset?), System.DateTimeOffset? lastTriggerOn = default(System.DateTimeOffset?), System.Collections.Generic.IEnumerable<string> subscriptions = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.ResourceMetadata> resources = null, Azure.ResourceManager.AppComplianceAutomation.Models.OverviewStatus complianceStatusM365 = null, Azure.ResourceManager.AppComplianceAutomation.Models.StorageInfo storageInfo = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.CertSyncRecord> certRecords = null, Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.ReportResourceData ReportResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.AppComplianceAutomation.Models.ReportProperties properties = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResourceItem ResourceItem(string subscriptionId = null, string resourceGroup = null, string resourceType = null, string resourceId = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.Responsibility Responsibility(string responsibilityId = null, string responsibilityTitle = null, string responsibilityDescription = null, Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityType? responsibilityType = default(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityType?), Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilitySeverity? responsibilitySeverity = default(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilitySeverity?), Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityStatus? responsibilityStatus = default(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityStatus?), Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityEnvironment? responsibilityEnvironment = default(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityEnvironment?), int? failedResourceCount = default(int?), int? totalResourceCount = default(int?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityResource> resourceList = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.Recommendation> recommendationList = null, string guidance = null, string justification = null, System.Collections.Generic.IEnumerable<string> evidenceFiles = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityResource ResponsibilityResource(string resourceId = null, string accountId = null, string resourceType = null, Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin? resourceOrigin = default(Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin?), Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus? resourceStatus = default(Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus?), System.DateTimeOffset? resourceStatusChangeOn = default(System.DateTimeOffset?), System.Collections.Generic.IEnumerable<string> recommendationIds = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.SnapshotProperties SnapshotProperties(string id = null, string snapshotName = null, System.DateTimeOffset? createdOn = default(System.DateTimeOffset?), Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState?), Azure.ResourceManager.AppComplianceAutomation.Models.ReportProperties reportProperties = null, Azure.ResourceManager.Models.SystemData reportSystemData = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.ComplianceResult> complianceResults = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.SnapshotResourceData SnapshotResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.AppComplianceAutomation.Models.SnapshotProperties properties = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.StatusItem StatusItem(string statusName = null, string statusValue = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.TriggerEvaluationProperty TriggerEvaluationProperty(System.DateTimeOffset? triggerOn = default(System.DateTimeOffset?), System.DateTimeOffset? evaluationEndOn = default(System.DateTimeOffset?), System.Collections.Generic.IEnumerable<string> resourceIds = null, System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.QuickAssessment> quickAssessments = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.TriggerEvaluationResponse TriggerEvaluationResponse(Azure.ResourceManager.AppComplianceAutomation.Models.TriggerEvaluationProperty properties = null) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.WebhookProperties WebhookProperties(string webhookId = null, string webhookName = null, Azure.ResourceManager.AppComplianceAutomation.Models.WebhookStatus? status = default(Azure.ResourceManager.AppComplianceAutomation.Models.WebhookStatus?), System.Guid? tenantId = default(System.Guid?), Azure.ResourceManager.AppComplianceAutomation.Models.SendAllEvent? sendAllEvents = default(Azure.ResourceManager.AppComplianceAutomation.Models.SendAllEvent?), System.Collections.Generic.IEnumerable<Azure.ResourceManager.AppComplianceAutomation.Models.NotificationEvent> events = null, System.Uri payloadUri = null, Azure.ResourceManager.AppComplianceAutomation.Models.ContentType? contentType = default(Azure.ResourceManager.AppComplianceAutomation.Models.ContentType?), string webhookKey = null, Azure.ResourceManager.AppComplianceAutomation.Models.UpdateWebhookKey? updateWebhookKey = default(Azure.ResourceManager.AppComplianceAutomation.Models.UpdateWebhookKey?), Azure.ResourceManager.AppComplianceAutomation.Models.WebhookKeyEnabled? webhookKeyEnabled = default(Azure.ResourceManager.AppComplianceAutomation.Models.WebhookKeyEnabled?), Azure.ResourceManager.AppComplianceAutomation.Models.EnableSslVerification? enableSslVerification = default(Azure.ResourceManager.AppComplianceAutomation.Models.EnableSslVerification?), Azure.ResourceManager.AppComplianceAutomation.Models.WebhookPropertiesDeliveryStatus? deliveryStatus = default(Azure.ResourceManager.AppComplianceAutomation.Models.WebhookPropertiesDeliveryStatus?), Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState? provisioningState = default(Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState?)) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.WebhookResourceData WebhookResourceData(Azure.Core.ResourceIdentifier id = null, string name = null, Azure.Core.ResourceType resourceType = default(Azure.Core.ResourceType), Azure.ResourceManager.Models.SystemData systemData = null, Azure.ResourceManager.AppComplianceAutomation.Models.WebhookProperties properties = null) { throw null; }
    }
    public partial class Category
    {
        internal Category() { }
        public string CategoryName { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.CategoryStatus? CategoryStatus { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamily> ControlFamilies { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CategoryStatus : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.CategoryStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CategoryStatus(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.CategoryStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.CategoryStatus NotApplicable { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.CategoryStatus Passed { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.CategoryStatus PendingApproval { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.CategoryStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.CategoryStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.CategoryStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.CategoryStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.CategoryStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.CategoryStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CertSyncRecord
    {
        public CertSyncRecord() { }
        public string CertificationStatus { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppComplianceAutomation.Models.ControlSyncRecord> Controls { get { throw null; } }
        public string IngestionStatus { get { throw null; } set { } }
        public string OfferGuid { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct CheckNameAvailabilityReason : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityReason>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public CheckNameAvailabilityReason(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityReason AlreadyExists { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityReason Invalid { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityReason other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityReason left, Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityReason right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityReason (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityReason left, Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityReason right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class CheckNameAvailabilityRequest
    {
        public CheckNameAvailabilityRequest() { }
        public string Name { get { throw null; } set { } }
        public string ResourceType { get { throw null; } set { } }
    }
    public partial class CheckNameAvailabilityResponse
    {
        internal CheckNameAvailabilityResponse() { }
        public string Message { get { throw null; } }
        public bool? NameAvailable { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.CheckNameAvailabilityReason? Reason { get { throw null; } }
    }
    public partial class ComplianceReportItem
    {
        internal ComplianceReportItem() { }
        public string CategoryName { get { throw null; } }
        public string ControlFamilyName { get { throw null; } }
        public string ControlId { get { throw null; } }
        public string ControlName { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus? ControlStatus { get { throw null; } }
        public string ResourceId { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin? ResourceOrigin { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus? ResourceStatus { get { throw null; } }
        public System.DateTimeOffset? ResourceStatusChangeOn { get { throw null; } }
        public string ResourceType { get { throw null; } }
        public string ResponsibilityDescription { get { throw null; } }
        public string ResponsibilityTitle { get { throw null; } }
    }
    public partial class ComplianceResult
    {
        internal ComplianceResult() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppComplianceAutomation.Models.Category> Categories { get { throw null; } }
        public string ComplianceName { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ContentType : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.ContentType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ContentType(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ContentType ApplicationJson { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.ContentType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.ContentType left, Azure.ResourceManager.AppComplianceAutomation.Models.ContentType right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.ContentType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.ContentType left, Azure.ResourceManager.AppComplianceAutomation.Models.ContentType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Control
    {
        internal Control() { }
        public string ControlDescription { get { throw null; } }
        public string ControlDescriptionHyperLink { get { throw null; } }
        public string ControlFullName { get { throw null; } }
        public string ControlId { get { throw null; } }
        public string ControlName { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus? ControlStatus { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppComplianceAutomation.Models.Responsibility> Responsibilities { get { throw null; } }
    }
    public partial class ControlFamily
    {
        internal ControlFamily() { }
        public string ControlFamilyName { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamilyStatus? ControlFamilyStatus { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppComplianceAutomation.Models.Control> Controls { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ControlFamilyStatus : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamilyStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ControlFamilyStatus(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamilyStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamilyStatus NotApplicable { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamilyStatus Passed { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamilyStatus PendingApproval { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamilyStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamilyStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamilyStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamilyStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamilyStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.ControlFamilyStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ControlStatus : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ControlStatus(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus NotApplicable { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus Passed { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus PendingApproval { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.ControlStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ControlSyncRecord
    {
        public ControlSyncRecord() { }
        public string ControlId { get { throw null; } set { } }
        public string ControlStatus { get { throw null; } set { } }
    }
    public partial class DownloadResponse
    {
        internal DownloadResponse() { }
        public System.Uri ComplianceDetailedPdfReportSasUri { get { throw null; } }
        public System.Uri CompliancePdfReportSasUri { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppComplianceAutomation.Models.ComplianceReportItem> ComplianceReport { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppComplianceAutomation.Models.ResourceItem> ResourceList { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct DownloadType : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.DownloadType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public DownloadType(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.DownloadType ComplianceDetailedPdfReport { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.DownloadType CompliancePdfReport { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.DownloadType ComplianceReport { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.DownloadType ResourceList { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.DownloadType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.DownloadType left, Azure.ResourceManager.AppComplianceAutomation.Models.DownloadType right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.DownloadType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.DownloadType left, Azure.ResourceManager.AppComplianceAutomation.Models.DownloadType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EnableSslVerification : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.EnableSslVerification>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EnableSslVerification(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.EnableSslVerification False { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.EnableSslVerification True { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.EnableSslVerification other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.EnableSslVerification left, Azure.ResourceManager.AppComplianceAutomation.Models.EnableSslVerification right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.EnableSslVerification (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.EnableSslVerification left, Azure.ResourceManager.AppComplianceAutomation.Models.EnableSslVerification right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class EvidenceFileDownloadContent
    {
        public EvidenceFileDownloadContent() { }
        public string OfferGuid { get { throw null; } set { } }
        public string ReportCreatorTenantId { get { throw null; } set { } }
    }
    public partial class EvidenceFileDownloadResponse
    {
        internal EvidenceFileDownloadResponse() { }
        public System.Uri EvidenceFileUri { get { throw null; } }
    }
    public partial class EvidenceProperties
    {
        public EvidenceProperties() { }
        public string ControlId { get { throw null; } set { } }
        public string EvidenceName { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceType? EvidenceType { get { throw null; } set { } }
        public string FilePath { get { throw null; } set { } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string ReportName { get { throw null; } }
        public string ResponsibilityId { get { throw null; } set { } }
    }
    public partial class EvidenceResourceCollectionGetAllOptions
    {
        public EvidenceResourceCollectionGetAllOptions() { }
        public string Filter { get { throw null; } set { } }
        public string OfferGuid { get { throw null; } set { } }
        public string Orderby { get { throw null; } set { } }
        public string ReportCreatorTenantId { get { throw null; } set { } }
        public string Select { get { throw null; } set { } }
        public string SkipToken { get { throw null; } set { } }
        public int? Top { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct EvidenceType : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public EvidenceType(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceType File { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceType left, Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceType right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceType left, Azure.ResourceManager.AppComplianceAutomation.Models.EvidenceType right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class GetCollectionCountContent
    {
        public GetCollectionCountContent() { }
        public string GetCollectionCountRequestType { get { throw null; } set { } }
    }
    public partial class GetCollectionCountResponse
    {
        internal GetCollectionCountResponse() { }
        public int? Count { get { throw null; } }
    }
    public partial class GetOverviewStatusContent
    {
        public GetOverviewStatusContent() { }
        public string GetOverviewStatusRequestType { get { throw null; } set { } }
    }
    public partial class GetOverviewStatusResponse
    {
        internal GetOverviewStatusResponse() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppComplianceAutomation.Models.StatusItem> StatusList { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct IsRecommendSolution : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.IsRecommendSolution>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public IsRecommendSolution(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.IsRecommendSolution False { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.IsRecommendSolution True { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.IsRecommendSolution other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.IsRecommendSolution left, Azure.ResourceManager.AppComplianceAutomation.Models.IsRecommendSolution right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.IsRecommendSolution (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.IsRecommendSolution left, Azure.ResourceManager.AppComplianceAutomation.Models.IsRecommendSolution right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ListInUseStorageAccountsContent
    {
        public ListInUseStorageAccountsContent() { }
        public System.Collections.Generic.IList<string> SubscriptionIds { get { throw null; } }
    }
    public partial class ListInUseStorageAccountsResponse
    {
        internal ListInUseStorageAccountsResponse() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppComplianceAutomation.Models.StorageInfo> StorageAccountList { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct NotificationEvent : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.NotificationEvent>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public NotificationEvent(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.NotificationEvent AssessmentFailure { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.NotificationEvent GenerateSnapshotFailed { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.NotificationEvent GenerateSnapshotSuccess { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.NotificationEvent ReportConfigurationChanges { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.NotificationEvent ReportDeletion { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.NotificationEvent other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.NotificationEvent left, Azure.ResourceManager.AppComplianceAutomation.Models.NotificationEvent right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.NotificationEvent (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.NotificationEvent left, Azure.ResourceManager.AppComplianceAutomation.Models.NotificationEvent right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class OnboardContent
    {
        public OnboardContent(System.Collections.Generic.IEnumerable<string> subscriptionIds) { }
        public System.Collections.Generic.IList<string> SubscriptionIds { get { throw null; } }
    }
    public partial class OnboardResponse
    {
        internal OnboardResponse() { }
        public System.Collections.Generic.IReadOnlyList<string> SubscriptionIds { get { throw null; } }
    }
    public partial class OverviewStatus
    {
        internal OverviewStatus() { }
        public int? FailedCount { get { throw null; } }
        public int? ManualCount { get { throw null; } }
        public int? NotApplicableCount { get { throw null; } }
        public int? PassedCount { get { throw null; } }
        public int? PendingCount { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ProvisioningState : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ProvisioningState(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState Canceled { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState Creating { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState Deleting { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState Failed { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState Succeeded { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState Updating { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState left, Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState left, Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class QuickAssessment
    {
        internal QuickAssessment() { }
        public string Description { get { throw null; } }
        public string DisplayName { get { throw null; } }
        public string RemediationLink { get { throw null; } }
        public string ResourceId { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus? ResourceStatus { get { throw null; } }
        public string ResponsibilityId { get { throw null; } }
        public System.DateTimeOffset? Timestamp { get { throw null; } }
    }
    public partial class Recommendation
    {
        internal Recommendation() { }
        public string RecommendationId { get { throw null; } }
        public string RecommendationShortName { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppComplianceAutomation.Models.RecommendationSolution> RecommendationSolutions { get { throw null; } }
    }
    public partial class RecommendationSolution
    {
        internal RecommendationSolution() { }
        public Azure.ResourceManager.AppComplianceAutomation.Models.IsRecommendSolution? IsRecommendSolution { get { throw null; } }
        public string RecommendationSolutionContent { get { throw null; } }
        public string RecommendationSolutionIndex { get { throw null; } }
    }
    public partial class ReportProperties
    {
        public ReportProperties() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppComplianceAutomation.Models.CertSyncRecord> CertRecords { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.OverviewStatus ComplianceStatusM365 { get { throw null; } }
        public string Id { get { throw null; } }
        public System.DateTimeOffset? LastTriggerOn { get { throw null; } }
        public System.DateTimeOffset? NextTriggerOn { get { throw null; } }
        public string OfferGuid { get { throw null; } set { } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public string ReportName { get { throw null; } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppComplianceAutomation.Models.ResourceMetadata> Resources { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ReportStatus? Status { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.StorageInfo StorageInfo { get { throw null; } set { } }
        public System.Collections.Generic.IReadOnlyList<string> Subscriptions { get { throw null; } }
        public System.Guid? TenantId { get { throw null; } }
        public string TimeZone { get { throw null; } set { } }
        public System.DateTimeOffset? TriggerOn { get { throw null; } set { } }
    }
    public partial class ReportResourceCollectionGetAllOptions
    {
        public ReportResourceCollectionGetAllOptions() { }
        public string Filter { get { throw null; } set { } }
        public string OfferGuid { get { throw null; } set { } }
        public string Orderby { get { throw null; } set { } }
        public string ReportCreatorTenantId { get { throw null; } set { } }
        public string Select { get { throw null; } set { } }
        public string SkipToken { get { throw null; } set { } }
        public int? Top { get { throw null; } set { } }
    }
    public partial class ReportResourcePatch
    {
        public ReportResourcePatch() { }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ReportProperties Properties { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ReportStatus : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.ReportStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ReportStatus(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ReportStatus Active { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ReportStatus Disabled { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ReportStatus Failed { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.ReportStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.ReportStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.ReportStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.ReportStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.ReportStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.ReportStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ResourceItem
    {
        internal ResourceItem() { }
        public string ResourceGroup { get { throw null; } }
        public string ResourceId { get { throw null; } }
        public string ResourceType { get { throw null; } }
        public string SubscriptionId { get { throw null; } }
    }
    public partial class ResourceMetadata
    {
        public ResourceMetadata(string resourceId) { }
        public string AccountId { get { throw null; } set { } }
        public string ResourceId { get { throw null; } set { } }
        public string ResourceKind { get { throw null; } set { } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin? ResourceOrigin { get { throw null; } set { } }
        public string ResourceType { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResourceOrigin : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResourceOrigin(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin AWS { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin Azure { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin GCP { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin left, Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin left, Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResourceStatus : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResourceStatus(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus Healthy { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus Unhealthy { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class Responsibility
    {
        internal Responsibility() { }
        public System.Collections.Generic.IReadOnlyList<string> EvidenceFiles { get { throw null; } }
        public int? FailedResourceCount { get { throw null; } }
        public string Guidance { get { throw null; } }
        public string Justification { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppComplianceAutomation.Models.Recommendation> RecommendationList { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityResource> ResourceList { get { throw null; } }
        public string ResponsibilityDescription { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityEnvironment? ResponsibilityEnvironment { get { throw null; } }
        public string ResponsibilityId { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilitySeverity? ResponsibilitySeverity { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityStatus? ResponsibilityStatus { get { throw null; } }
        public string ResponsibilityTitle { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityType? ResponsibilityType { get { throw null; } }
        public int? TotalResourceCount { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResponsibilityEnvironment : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityEnvironment>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResponsibilityEnvironment(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityEnvironment AWS { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityEnvironment Azure { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityEnvironment GCP { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityEnvironment General { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityEnvironment other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityEnvironment left, Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityEnvironment right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityEnvironment (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityEnvironment left, Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityEnvironment right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class ResponsibilityResource
    {
        internal ResponsibilityResource() { }
        public string AccountId { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> RecommendationIds { get { throw null; } }
        public string ResourceId { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ResourceOrigin? ResourceOrigin { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ResourceStatus? ResourceStatus { get { throw null; } }
        public System.DateTimeOffset? ResourceStatusChangeOn { get { throw null; } }
        public string ResourceType { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResponsibilitySeverity : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilitySeverity>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResponsibilitySeverity(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilitySeverity High { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilitySeverity Low { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilitySeverity Medium { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilitySeverity other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilitySeverity left, Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilitySeverity right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilitySeverity (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilitySeverity left, Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilitySeverity right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResponsibilityStatus : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResponsibilityStatus(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityStatus NotApplicable { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityStatus Passed { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityStatus PendingApproval { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct ResponsibilityType : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityType>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public ResponsibilityType(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityType Automated { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityType Manual { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityType other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityType left, Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityType right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityType (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityType left, Azure.ResourceManager.AppComplianceAutomation.Models.ResponsibilityType right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct SendAllEvent : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.SendAllEvent>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public SendAllEvent(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.SendAllEvent False { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.SendAllEvent True { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.SendAllEvent other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.SendAllEvent left, Azure.ResourceManager.AppComplianceAutomation.Models.SendAllEvent right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.SendAllEvent (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.SendAllEvent left, Azure.ResourceManager.AppComplianceAutomation.Models.SendAllEvent right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class SnapshotDownloadContent
    {
        public SnapshotDownloadContent(Azure.ResourceManager.AppComplianceAutomation.Models.DownloadType downloadType) { }
        public Azure.ResourceManager.AppComplianceAutomation.Models.DownloadType DownloadType { get { throw null; } }
        public string OfferGuid { get { throw null; } set { } }
        public string ReportCreatorTenantId { get { throw null; } set { } }
    }
    public partial class SnapshotProperties
    {
        internal SnapshotProperties() { }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppComplianceAutomation.Models.ComplianceResult> ComplianceResults { get { throw null; } }
        public System.DateTimeOffset? CreatedOn { get { throw null; } }
        public string Id { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ReportProperties ReportProperties { get { throw null; } }
        public Azure.ResourceManager.Models.SystemData ReportSystemData { get { throw null; } }
        public string SnapshotName { get { throw null; } }
    }
    public partial class SnapshotResourceCollectionGetAllOptions
    {
        public SnapshotResourceCollectionGetAllOptions() { }
        public string Filter { get { throw null; } set { } }
        public string OfferGuid { get { throw null; } set { } }
        public string Orderby { get { throw null; } set { } }
        public string ReportCreatorTenantId { get { throw null; } set { } }
        public string Select { get { throw null; } set { } }
        public string SkipToken { get { throw null; } set { } }
        public int? Top { get { throw null; } set { } }
    }
    public partial class StatusItem
    {
        internal StatusItem() { }
        public string StatusName { get { throw null; } }
        public string StatusValue { get { throw null; } }
    }
    public partial class StorageInfo
    {
        public StorageInfo() { }
        public string AccountName { get { throw null; } set { } }
        public Azure.Core.AzureLocation? Location { get { throw null; } set { } }
        public string ResourceGroup { get { throw null; } set { } }
        public string SubscriptionId { get { throw null; } set { } }
    }
    public partial class SyncCertRecordContent
    {
        public SyncCertRecordContent(Azure.ResourceManager.AppComplianceAutomation.Models.CertSyncRecord certRecord) { }
        public Azure.ResourceManager.AppComplianceAutomation.Models.CertSyncRecord CertRecord { get { throw null; } }
    }
    public partial class TriggerEvaluationContent
    {
        public TriggerEvaluationContent(System.Collections.Generic.IEnumerable<string> resourceIds) { }
        public System.Collections.Generic.IList<string> ResourceIds { get { throw null; } }
    }
    public partial class TriggerEvaluationProperty
    {
        internal TriggerEvaluationProperty() { }
        public System.DateTimeOffset? EvaluationEndOn { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<Azure.ResourceManager.AppComplianceAutomation.Models.QuickAssessment> QuickAssessments { get { throw null; } }
        public System.Collections.Generic.IReadOnlyList<string> ResourceIds { get { throw null; } }
        public System.DateTimeOffset? TriggerOn { get { throw null; } }
    }
    public partial class TriggerEvaluationResponse
    {
        internal TriggerEvaluationResponse() { }
        public Azure.ResourceManager.AppComplianceAutomation.Models.TriggerEvaluationProperty Properties { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct UpdateWebhookKey : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.UpdateWebhookKey>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public UpdateWebhookKey(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.UpdateWebhookKey False { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.UpdateWebhookKey True { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.UpdateWebhookKey other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.UpdateWebhookKey left, Azure.ResourceManager.AppComplianceAutomation.Models.UpdateWebhookKey right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.UpdateWebhookKey (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.UpdateWebhookKey left, Azure.ResourceManager.AppComplianceAutomation.Models.UpdateWebhookKey right) { throw null; }
        public override string ToString() { throw null; }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WebhookKeyEnabled : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.WebhookKeyEnabled>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WebhookKeyEnabled(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.WebhookKeyEnabled False { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.WebhookKeyEnabled True { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.WebhookKeyEnabled other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.WebhookKeyEnabled left, Azure.ResourceManager.AppComplianceAutomation.Models.WebhookKeyEnabled right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.WebhookKeyEnabled (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.WebhookKeyEnabled left, Azure.ResourceManager.AppComplianceAutomation.Models.WebhookKeyEnabled right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WebhookProperties
    {
        public WebhookProperties() { }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ContentType? ContentType { get { throw null; } set { } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.WebhookPropertiesDeliveryStatus? DeliveryStatus { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.EnableSslVerification? EnableSslVerification { get { throw null; } set { } }
        public System.Collections.Generic.IList<Azure.ResourceManager.AppComplianceAutomation.Models.NotificationEvent> Events { get { throw null; } }
        public System.Uri PayloadUri { get { throw null; } set { } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.ProvisioningState? ProvisioningState { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.SendAllEvent? SendAllEvents { get { throw null; } set { } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.WebhookStatus? Status { get { throw null; } set { } }
        public System.Guid? TenantId { get { throw null; } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.UpdateWebhookKey? UpdateWebhookKey { get { throw null; } set { } }
        public string WebhookId { get { throw null; } }
        public string WebhookKey { get { throw null; } set { } }
        public Azure.ResourceManager.AppComplianceAutomation.Models.WebhookKeyEnabled? WebhookKeyEnabled { get { throw null; } }
        public string WebhookName { get { throw null; } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WebhookPropertiesDeliveryStatus : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.WebhookPropertiesDeliveryStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WebhookPropertiesDeliveryStatus(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.WebhookPropertiesDeliveryStatus Failed { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.WebhookPropertiesDeliveryStatus NotStarted { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.WebhookPropertiesDeliveryStatus Succeeded { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.WebhookPropertiesDeliveryStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.WebhookPropertiesDeliveryStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.WebhookPropertiesDeliveryStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.WebhookPropertiesDeliveryStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.WebhookPropertiesDeliveryStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.WebhookPropertiesDeliveryStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
    public partial class WebhookResourcePatch
    {
        public WebhookResourcePatch() { }
        public Azure.ResourceManager.AppComplianceAutomation.Models.WebhookProperties Properties { get { throw null; } set { } }
    }
    [System.Runtime.InteropServices.StructLayoutAttribute(System.Runtime.InteropServices.LayoutKind.Sequential)]
    public readonly partial struct WebhookStatus : System.IEquatable<Azure.ResourceManager.AppComplianceAutomation.Models.WebhookStatus>
    {
        private readonly object _dummy;
        private readonly int _dummyPrimitive;
        public WebhookStatus(string value) { throw null; }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.WebhookStatus Disabled { get { throw null; } }
        public static Azure.ResourceManager.AppComplianceAutomation.Models.WebhookStatus Enabled { get { throw null; } }
        public bool Equals(Azure.ResourceManager.AppComplianceAutomation.Models.WebhookStatus other) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool Equals(object obj) { throw null; }
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        public override int GetHashCode() { throw null; }
        public static bool operator ==(Azure.ResourceManager.AppComplianceAutomation.Models.WebhookStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.WebhookStatus right) { throw null; }
        public static implicit operator Azure.ResourceManager.AppComplianceAutomation.Models.WebhookStatus (string value) { throw null; }
        public static bool operator !=(Azure.ResourceManager.AppComplianceAutomation.Models.WebhookStatus left, Azure.ResourceManager.AppComplianceAutomation.Models.WebhookStatus right) { throw null; }
        public override string ToString() { throw null; }
    }
}
