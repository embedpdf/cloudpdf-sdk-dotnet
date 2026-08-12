using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Shares;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "docId": "docId",
              "scope": [
                "scope",
                "scope"
              ]
            }
            """;

        const string mockResponse = """
            {
              "share": {
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/shares")
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

        var response = await Client.Shares.CreateAsync(
            new SharesCreateRequest
            {
                TenantId = "tenantId",
                DocId = "docId",
                LayerName = null,
                Scope = new List<string>() { "scope", "scope" },
                Origins = null,
                Password = null,
                SessionTtlSeconds = null,
                ExpiresAt = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "docId": "docId",
              "scope": [
                "scope"
              ]
            }
            """;

        const string mockResponse = """
            {
              "share": {
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/shares")
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

        var response = await Client.Shares.CreateAsync(
            new SharesCreateRequest
            {
                TenantId = "tenantId",
                DocId = "docId",
                Scope = new List<string>() { "scope" },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
