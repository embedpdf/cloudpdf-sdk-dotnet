using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Documents;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "document": {
                "id": "id",
                "tenantId": "tenantId",
                "name": "name",
                "folderId": "folderId",
                "state": "pending",
                "baseSha256": "baseSha256",
                "sizeBytes": 1,
                "metadata": {
                  "metadata": {
                    "key": "value"
                  }
                },
                "idempotencyKey": "idempotencyKey",
                "failureReason": "failureReason",
                "thumbnailState": "pending",
                "thumbnailUrl": "thumbnailUrl",
                "createdAt": "2024-01-15T09:30:00.000Z",
                "updatedAt": "2024-01-15T09:30:00.000Z",
                "createdBy": "createdBy"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/documents/docId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Documents.GetAsync(
            new GetDocumentsRequest { TenantId = "tenantId", DocId = "docId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "document": {
                "id": "id",
                "tenantId": "tenantId",
                "name": "name",
                "folderId": "folderId",
                "state": "pending",
                "baseSha256": "baseSha256",
                "sizeBytes": 1,
                "metadata": {
                  "key": "value"
                },
                "idempotencyKey": "idempotencyKey",
                "failureReason": "failureReason",
                "thumbnailState": "pending",
                "thumbnailUrl": "thumbnailUrl",
                "createdAt": "2024-01-15T09:30:00.000Z",
                "updatedAt": "2024-01-15T09:30:00.000Z",
                "createdBy": "createdBy"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/documents/docId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Documents.GetAsync(
            new GetDocumentsRequest { TenantId = "tenantId", DocId = "docId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
