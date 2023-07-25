// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.AppComplianceAutomation.Models;

namespace Azure.ResourceManager.AppComplianceAutomation
{
    internal class OnboardResponseOperationSource : IOperationSource<OnboardResponse>
    {
        OnboardResponse IOperationSource<OnboardResponse>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return OnboardResponse.DeserializeOnboardResponse(document.RootElement);
        }

        async ValueTask<OnboardResponse> IOperationSource<OnboardResponse>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return OnboardResponse.DeserializeOnboardResponse(document.RootElement);
        }
    }
}
