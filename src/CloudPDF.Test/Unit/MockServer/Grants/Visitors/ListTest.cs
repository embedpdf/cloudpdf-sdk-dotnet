using CloudPDF.Grants;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Grants.Visitors;

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
                  "consentedAt": "2024-01-15T09:30:00.000Z",
                  "firstSeenAt": "2024-01-15T09:30:00.000Z",
                  "lastSeenAt": "2024-01-15T09:30:00.000Z",
                  "layer": {
                    "layerName": "layerName",
                    "sizeBytes": 1
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
                  "consentedAt": "2024-01-15T09:30:00.000Z",
                  "firstSeenAt": "2024-01-15T09:30:00.000Z",
                  "lastSeenAt": "2024-01-15T09:30:00.000Z",
                  "layer": {
                    "layerName": "layerName",
                    "sizeBytes": 1
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
                    .WithPath("/v1/tenants/tenantId/grants/grantId/visitors")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Grants.Visitors.ListAsync(
            new ListVisitorsRequest { TenantId = "tenantId", GrantId = "grantId" }
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
                  "consentedAt": "2024-01-15T09:30:00.000Z",
                  "firstSeenAt": "2024-01-15T09:30:00.000Z",
                  "lastSeenAt": "2024-01-15T09:30:00.000Z",
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
                    .WithPath("/v1/tenants/tenantId/grants/grantId/visitors")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Grants.Visitors.ListAsync(
            new ListVisitorsRequest { TenantId = "tenantId", GrantId = "grantId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
