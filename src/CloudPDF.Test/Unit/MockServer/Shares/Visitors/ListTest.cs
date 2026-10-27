using CloudPDF.Shares;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Shares.Visitors;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "visitors": [
                {
                  "visitorId": "visitorId",
                  "answers": {
                    "displayName": "displayName",
                    "email": "email",
                    "title": "title",
                    "organization": "organization",
                    "organizationalUnit": "organizationalUnit"
                  },
                  "emailVerified": true,
                  "consentedAt": 1.1,
                  "firstSeenAt": 1.1,
                  "lastSeenAt": 1.1,
                  "layer": {
                    "layerName": "layerName",
                    "storageSizeBytes": 1.1
                  }
                },
                {
                  "visitorId": "visitorId",
                  "answers": {
                    "displayName": "displayName",
                    "email": "email",
                    "title": "title",
                    "organization": "organization",
                    "organizationalUnit": "organizationalUnit"
                  },
                  "emailVerified": true,
                  "consentedAt": 1.1,
                  "firstSeenAt": 1.1,
                  "lastSeenAt": 1.1,
                  "layer": {
                    "layerName": "layerName",
                    "storageSizeBytes": 1.1
                  }
                }
              ],
              "nextCursor": "nextCursor"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/shares/shareId/visitors")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Shares.Visitors.ListAsync(
            new ListVisitorsRequest { TenantId = "tenantId", ShareId = "shareId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "visitors": [
                {
                  "visitorId": "visitorId",
                  "answers": {},
                  "emailVerified": true,
                  "consentedAt": 1.1,
                  "firstSeenAt": 1.1,
                  "lastSeenAt": 1.1,
                  "layer": {
                    "layerName": "layerName"
                  }
                }
              ],
              "nextCursor": "nextCursor"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/shares/shareId/visitors")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Shares.Visitors.ListAsync(
            new ListVisitorsRequest { TenantId = "tenantId", ShareId = "shareId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
