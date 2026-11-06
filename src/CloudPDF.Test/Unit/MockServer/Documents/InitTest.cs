using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Documents;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InitTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "sizeBytes": 1,
              "contentSha256": "contentSha256"
            }
            """;

        const string mockResponse = """
            {
              "status": "created",
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
              },
              "upload": {
                "kind": "presigned",
                "presigned": {
                  "url": "url",
                  "headers": {
                    "headers": "headers"
                  },
                  "method": "PUT",
                  "expiresAt": "2024-01-15T09:30:00.000Z"
                },
                "key": "key"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/documents/init")
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

        var response = await Client.Documents.InitAsync(
            new DocumentsInitRequest
            {
                TenantId = "tenantId",
                SizeBytes = 1,
                ContentSha256 = "contentSha256",
                Name = null,
                FolderId = null,
                Metadata = null,
                IdempotencyKey = null,
                DedupMode = null,
                DocId = null,
                UploadTtlSeconds = null,
                UploadPreference = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "sizeBytes": 1,
              "contentSha256": "contentSha256"
            }
            """;

        const string mockResponse = """
            {
              "status": "created",
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
              },
              "upload": {
                "kind": "presigned",
                "presigned": {
                  "url": "url",
                  "headers": {
                    "key": "value"
                  },
                  "method": "PUT",
                  "expiresAt": "2024-01-15T09:30:00.000Z"
                },
                "key": "key"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/documents/init")
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

        var response = await Client.Documents.InitAsync(
            new DocumentsInitRequest
            {
                TenantId = "tenantId",
                SizeBytes = 1,
                ContentSha256 = "contentSha256",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
