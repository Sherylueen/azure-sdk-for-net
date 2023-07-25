// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Object that includes all the possible response for the evidence file download operation. </summary>
    public partial class EvidenceFileDownloadResponse
    {
        /// <summary> Initializes a new instance of EvidenceFileDownloadResponse. </summary>
        internal EvidenceFileDownloadResponse()
        {
        }

        /// <summary> Initializes a new instance of EvidenceFileDownloadResponse. </summary>
        /// <param name="evidenceFile"> The uri of evidence file. </param>
        internal EvidenceFileDownloadResponse(EvidenceFileDownloadResponseEvidenceFile evidenceFile)
        {
            EvidenceFile = evidenceFile;
        }

        /// <summary> The uri of evidence file. </summary>
        internal EvidenceFileDownloadResponseEvidenceFile EvidenceFile { get; }
        /// <summary> The url of evidence file. </summary>
        public Uri EvidenceFileUri
        {
            get => EvidenceFile?.Uri;
        }
    }
}
