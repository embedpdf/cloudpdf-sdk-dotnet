using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Shares;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ExchangeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "shareToken": "shareToken"
            }
            """;

        const string mockResponse = """
            {
              "token": "token",
              "docId": "docId",
              "layerName": "layerName",
              "layerMode": "shared",
              "visitor": {
                "handle": "handle",
                "keep": true,
                "identityRequest": {
                  "fields": {
                    "displayName": "required",
                    "email": "required",
                    "title": "required",
                    "organization": "required",
                    "organizationalUnit": "required"
                  },
                  "missing": [
                    "displayName",
                    "displayName"
                  ],
                  "invalid": [
                    "displayName",
                    "displayName"
                  ],
                  "purpose": "purpose",
                  "privacyUrl": "privacyUrl"
                }
              },
              "expiresAt": 1.1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/share-sessions")
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

        var response = await Client.Shares.ExchangeAsync(
            new SharesExchangeRequest
            {
                ShareToken = "shareToken",
                Password = null,
                VisitorHandle = null,
                Restart = null,
                VisitorIdentity = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "shareToken": "shareToken"
            }
            """;

        const string mockResponse = """
            {
              "token": "token",
              "docId": "docId",
              "layerName": "layerName",
              "layerMode": "shared",
              "visitor": {
                "handle": "handle",
                "keep": true,
                "identityRequest": {
                  "fields": {},
                  "missing": [
                    "displayName"
                  ],
                  "invalid": [
                    "displayName"
                  ],
                  "purpose": "purpose",
                  "privacyUrl": "privacyUrl"
                }
              },
              "expiresAt": 1.1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/share-sessions")
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

        var response = await Client.Shares.ExchangeAsync(
            new SharesExchangeRequest { ShareToken = "shareToken" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
