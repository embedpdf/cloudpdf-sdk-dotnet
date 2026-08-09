using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Documents;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CommitTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "sha256": "sha256"
            }
            """;

        const string mockResponse = """
            {
              "document": {
                "id": "id",
                "tenantId": "tenantId",
                "state": "pending",
                "baseSha": "baseSha",
                "storageSizeBytes": 1.1,
                "metadata": {
                  "metadata": {
                    "key": "value"
                  }
                },
                "idempotencyKey": "idempotencyKey",
                "failureReason": "failureReason",
                "thumbnailState": "pending",
                "thumbnailUrl": "thumbnailUrl",
                "createdAt": 1.1,
                "updatedAt": 1.1,
                "createdBy": "createdBy"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/documents/id/commit")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Documents.CommitAsync(
            new DocumentsCommitRequest
            {
                TenantId = "tenantId",
                Id = "id",
                Sha256 = "sha256",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "sha256": "sha256"
            }
            """;

        const string mockResponse = """
            {
              "document": {
                "id": "id",
                "tenantId": "tenantId",
                "state": "pending",
                "baseSha": "baseSha",
                "storageSizeBytes": 1.1,
                "metadata": {
                  "key": "value"
                },
                "idempotencyKey": "idempotencyKey",
                "failureReason": "failureReason",
                "thumbnailState": "pending",
                "thumbnailUrl": "thumbnailUrl",
                "createdAt": 1.1,
                "updatedAt": 1.1,
                "createdBy": "createdBy"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/documents/id/commit")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Documents.CommitAsync(
            new DocumentsCommitRequest
            {
                TenantId = "tenantId",
                Id = "id",
                Sha256 = "sha256",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
