using CloudPDF.Documents;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Documents.Layers;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "layers": [
                {
                  "docId": "docId",
                  "layerName": "layerName",
                  "grantId": "grantId",
                  "visitorId": "visitorId",
                  "sizeBytes": 1,
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z",
                  "lastSeenAt": "2024-01-15T09:30:00.000Z"
                },
                {
                  "docId": "docId",
                  "layerName": "layerName",
                  "grantId": "grantId",
                  "visitorId": "visitorId",
                  "sizeBytes": 1,
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z",
                  "lastSeenAt": "2024-01-15T09:30:00.000Z"
                }
              ],
              "nextCursor": "nextCursor"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/documents/docId/layers")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Documents.Layers.ListAsync(
            new ListLayersRequest { TenantId = "tenantId", DocId = "docId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "layers": [
                {
                  "docId": "docId",
                  "layerName": "layerName",
                  "grantId": "grantId",
                  "visitorId": "visitorId",
                  "sizeBytes": 1,
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "updatedAt": "2024-01-15T09:30:00.000Z",
                  "lastSeenAt": "2024-01-15T09:30:00.000Z"
                }
              ],
              "nextCursor": "nextCursor"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/documents/docId/layers")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Documents.Layers.ListAsync(
            new ListLayersRequest { TenantId = "tenantId", DocId = "docId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
