using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Grants;

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
              "grant": {
                "id": "id",
                "tenantId": "tenantId",
                "docId": "docId",
                "name": "name",
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
                "passphraseProtected": true,
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/grants")
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

        var response = await Client.Grants.CreateAsync(
            new GrantsCreateRequest
            {
                TenantId = "tenantId",
                DocId = "docId",
                Name = null,
                LayerMode = null,
                LayerName = null,
                KeepVisitorLayers = null,
                VisitorIdleSeconds = null,
                VisitorIdentity = null,
                Identity = null,
                Scope = new List<string>() { "scope", "scope" },
                Origins = null,
                Passphrase = null,
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
              "grant": {
                "id": "id",
                "tenantId": "tenantId",
                "docId": "docId",
                "name": "name",
                "layerMode": "shared",
                "layerName": "layerName",
                "keepVisitorLayers": true,
                "visitorIdleSeconds": 1.1,
                "visitorIdentity": {
                  "fields": {},
                  "ask": "on-open",
                  "purpose": "purpose",
                  "privacyUrl": "privacyUrl"
                },
                "identity": {
                  "userId": "userId",
                  "displayName": "displayName",
                  "email": "email",
                  "title": "title",
                  "organization": "organization",
                  "organizationalUnit": "organizationalUnit",
                  "groupId": "groupId"
                },
                "scope": [
                  "scope"
                ],
                "origins": [
                  "origins"
                ],
                "passphraseProtected": true,
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/grants")
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

        var response = await Client.Grants.CreateAsync(
            new GrantsCreateRequest
            {
                TenantId = "tenantId",
                DocId = "docId",
                Scope = new List<string>() { "scope" },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
