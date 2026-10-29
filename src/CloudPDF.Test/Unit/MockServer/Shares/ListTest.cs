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
                  "layerMode": "shared",
                  "layerName": "layerName",
                  "keepVisitorLayers": true,
                  "visitorIdleSeconds": 1.1,
                  "visitorIdentity": {
                    "fields": {
                      "displayName": "required",
                      "email": "required",
                      "title": "required",
                      "organization": "required",
                      "organizationalUnit": "required"
                    },
                    "ask": "on-open",
                    "purpose": "x",
                    "privacyUrl": "privacyUrl"
                  },
                  "identity": {
                    "userId": "x",
                    "displayName": "x",
                    "email": "x",
                    "title": "x",
                    "organization": "x",
                    "organizationalUnit": "x",
                    "groupId": "x"
                  },
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
                  "archivedAt": 1.1,
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
                  "layerMode": "shared",
                  "layerName": "layerName",
                  "keepVisitorLayers": true,
                  "visitorIdleSeconds": 1.1,
                  "visitorIdentity": {
                    "fields": {
                      "displayName": "required",
                      "email": "required",
                      "title": "required",
                      "organization": "required",
                      "organizationalUnit": "required"
                    },
                    "ask": "on-open",
                    "purpose": "x",
                    "privacyUrl": "privacyUrl"
                  },
                  "identity": {
                    "userId": "x",
                    "displayName": "x",
                    "email": "x",
                    "title": "x",
                    "organization": "x",
                    "organizationalUnit": "x",
                    "groupId": "x"
                  },
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
                  "archivedAt": 1.1,
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
                  "layerMode": "shared",
                  "layerName": "layerName",
                  "keepVisitorLayers": true,
                  "visitorIdleSeconds": 1.1,
                  "visitorIdentity": {
                    "fields": {},
                    "ask": "on-open"
                  },
                  "identity": {},
                  "scope": [
                    "scope"
                  ],
                  "origins": [
                    "origins"
                  ],
                  "passwordProtected": true,
                  "sessionTtlSeconds": 1.1,
                  "disabled": true,
                  "archivedAt": 1.1,
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
