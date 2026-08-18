using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Shares;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "shares": [
                {
                  "id": "id",
                  "tenantId": "tenantId",
                  "docId": "docId",
                  "layerName": "layerName",
                  "scope": [
                    "scope",
                    "scope"
                  ],
                  "origins": [
                    "origins",
                    "origins"
                  ],
                  "passwordProtected": true,
                  "sessionTtlSeconds": 1.1,
                  "disabled": true,
                  "expiresAt": 1.1,
                  "exchangeCount": 1.1,
                  "lastExchangedAt": 1.1,
                  "createdBy": "createdBy",
                  "createdAt": 1.1,
                  "updatedAt": 1.1
                },
                {
                  "id": "id",
                  "tenantId": "tenantId",
                  "docId": "docId",
                  "layerName": "layerName",
                  "scope": [
                    "scope",
                    "scope"
                  ],
                  "origins": [
                    "origins",
                    "origins"
                  ],
                  "passwordProtected": true,
                  "sessionTtlSeconds": 1.1,
                  "disabled": true,
                  "expiresAt": 1.1,
                  "exchangeCount": 1.1,
                  "lastExchangedAt": 1.1,
                  "createdBy": "createdBy",
                  "createdAt": 1.1,
                  "updatedAt": 1.1
                }
              ],
              "nextCursor": "nextCursor"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/shares")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Shares.ListAsync(
            new ListSharesRequest { TenantId = "tenantId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "shares": [
                {
                  "id": "id",
                  "tenantId": "tenantId",
                  "docId": "docId",
                  "layerName": "layerName",
                  "scope": [
                    "scope"
                  ],
                  "origins": [
                    "origins"
                  ],
                  "passwordProtected": true,
                  "sessionTtlSeconds": 1.1,
                  "disabled": true,
                  "expiresAt": 1.1,
                  "exchangeCount": 1.1,
                  "lastExchangedAt": 1.1,
                  "createdBy": "createdBy",
                  "createdAt": 1.1,
                  "updatedAt": 1.1
                }
              ],
              "nextCursor": "nextCursor"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/shares")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Shares.ListAsync(
            new ListSharesRequest { TenantId = "tenantId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
