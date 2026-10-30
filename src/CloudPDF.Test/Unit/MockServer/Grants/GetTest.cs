using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Grants;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
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
                    .WithPath("/v1/tenants/tenantId/grants/grantId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Grants.GetAsync(
            new GetGrantsRequest { TenantId = "tenantId", GrantId = "grantId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
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
                    .WithPath("/v1/tenants/tenantId/grants/grantId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Grants.GetAsync(
            new GetGrantsRequest { TenantId = "tenantId", GrantId = "grantId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
