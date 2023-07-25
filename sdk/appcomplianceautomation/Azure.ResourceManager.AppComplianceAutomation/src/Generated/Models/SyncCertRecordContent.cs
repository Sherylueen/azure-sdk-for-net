// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> Synchronize certification record request. </summary>
    public partial class SyncCertRecordContent
    {
        /// <summary> Initializes a new instance of SyncCertRecordContent. </summary>
        /// <param name="certRecord"> certification record to be synchronized. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="certRecord"/> is null. </exception>
        public SyncCertRecordContent(CertSyncRecord certRecord)
        {
            Argument.AssertNotNull(certRecord, nameof(certRecord));

            CertRecord = certRecord;
        }

        /// <summary> certification record to be synchronized. </summary>
        public CertSyncRecord CertRecord { get; }
    }
}
