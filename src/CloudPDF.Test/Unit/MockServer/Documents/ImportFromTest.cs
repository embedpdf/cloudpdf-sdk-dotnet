using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Documents;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ImportFromTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "source": {
                "kind": "url",
                "url": "url"
              }
            }
            """;

        const string mockResponse = """
            {
              "tag": "imported",
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
                    .WithPath("/v1/tenants/tenantId/documents/import")
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

        var response = await Client.Documents.ImportFromAsync(
            new DocumentsImportFromRequest
            {
                TenantId = "tenantId",
                Source = new DocumentsImportFromRequestSource(
                    new DocumentsImportFromRequestSource.Url(
                        new DocumentsImportFromRequestSourceUrl { Url = "url" }
                    )
                ),
                Expected = null,
                Metadata = null,
                IdempotencyKey = null,
                DedupMode = null,
                DocId = null,
                Mode = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "source": {
                "kind": "url",
                "url": "url"
              }
            }
            """;

        const string mockResponse = """
            {
              "tag": "imported",
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
                    .WithPath("/v1/tenants/tenantId/documents/import")
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

        var response = await Client.Documents.ImportFromAsync(
            new DocumentsImportFromRequest
            {
                TenantId = "tenantId",
                Source = new DocumentsImportFromRequestSource(
                    new DocumentsImportFromRequestSource.Url(
                        new DocumentsImportFromRequestSourceUrl { Url = "url" }
                    )
                ),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
