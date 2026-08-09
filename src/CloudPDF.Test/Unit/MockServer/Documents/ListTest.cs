using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Documents;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "documents": [
                {
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
                },
                {
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
              ],
              "nextCursor": "nextCursor"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/documents")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Documents.ListAsync(
            new ListDocumentsRequest { TenantId = "tenantId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "documents": [
                {
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
              ],
              "nextCursor": "nextCursor"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/documents")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Documents.ListAsync(
            new ListDocumentsRequest { TenantId = "tenantId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
