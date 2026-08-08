using CloudpdfApi;
using CloudpdfApi.Test.Unit.MockServer;
using CloudpdfApi.Test.Utils;
using NUnit.Framework;

namespace CloudpdfApi.Test.Unit.MockServer.Documents;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class InitTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "contentLength": 1,
              "contentSha256": "contentSha256"
            }
            """;

        const string mockResponse = """
            {
              "tag": "created",
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
              },
              "upload": {
                "kind": "presigned",
                "presigned": {
                  "url": "url",
                  "headers": {
                    "headers": "headers"
                  },
                  "method": "PUT",
                  "expiresAt": 1.1
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
                ContentLength = 1,
                ContentSha256 = "contentSha256",
                Metadata = null,
                IdempotencyKey = null,
                DedupMode = null,
                DocId = null,
                UploadTtlSec = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "contentLength": 1.1,
              "contentSha256": "contentSha256"
            }
            """;

        const string mockResponse = """
            {
              "tag": "created",
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
              },
              "upload": {
                "kind": "presigned",
                "presigned": {
                  "url": "url",
                  "headers": {
                    "key": "value"
                  },
                  "method": "PUT",
                  "expiresAt": 1.1
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
                ContentLength = 1.1,
                ContentSha256 = "contentSha256",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
