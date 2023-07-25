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
    internal class TriggerEvaluationResponseOperationSource : IOperationSource<TriggerEvaluationResponse>
    {
        TriggerEvaluationResponse IOperationSource<TriggerEvaluationResponse>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return TriggerEvaluationResponse.DeserializeTriggerEvaluationResponse(document.RootElement);
        }

        async ValueTask<TriggerEvaluationResponse> IOperationSource<TriggerEvaluationResponse>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return TriggerEvaluationResponse.DeserializeTriggerEvaluationResponse(document.RootElement);
        }
    }
}
