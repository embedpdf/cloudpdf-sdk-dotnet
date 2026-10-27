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
                  "shareId": "shareId",
                  "visitorId": "visitorId",
                  "storageSizeBytes": 1.1,
                  "createdAt": 1.1,
                  "updatedAt": 1.1,
                  "lastSeenAt": 1.1
                },
                {
                  "docId": "docId",
                  "layerName": "layerName",
                  "shareId": "shareId",
                  "visitorId": "visitorId",
                  "storageSizeBytes": 1.1,
                  "createdAt": 1.1,
                  "updatedAt": 1.1,
                  "lastSeenAt": 1.1
                }
              ],
              "nextCursor": "nextCursor"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/documents/id/layers")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Documents.Layers.ListAsync(
            new ListLayersRequest { TenantId = "tenantId", Id = "id" }
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
                  "shareId": "shareId",
                  "visitorId": "visitorId",
                  "storageSizeBytes": 1.1,
                  "createdAt": 1.1,
                  "updatedAt": 1.1,
                  "lastSeenAt": 1.1
                }
              ],
              "nextCursor": "nextCursor"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/documents/id/layers")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Documents.Layers.ListAsync(
            new ListLayersRequest { TenantId = "tenantId", Id = "id" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
