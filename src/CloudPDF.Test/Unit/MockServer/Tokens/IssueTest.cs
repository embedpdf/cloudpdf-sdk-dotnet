using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Tokens;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class IssueTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "kind": "doc",
              "sub": "x",
              "docId": "docId",
              "scope": [
                "scope",
                "scope"
              ],
              "expiresInSeconds": 7776000
            }
            """;

        const string mockResponse = """
            {
              "token": "token",
              "jti": "jti",
              "expiresAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/tokens")
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

        var response = await Client.Tokens.IssueAsync(
            new IssueTokensRequest
            {
                TenantId = "tenantId",
                Body = new TokensIssueRequest(
                    new CloudPDF.TokensIssueRequest.Doc(
                        new TokensIssueRequestDoc
                        {
                            Sub = "x",
                            DocId = "docId",
                            LayerName = null,
                            Scope = new List<string>() { "scope", "scope" },
                            Identity = null,
                            Origins = null,
                            ExpiresInSeconds = 7776000,
                        }
                    )
                ),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "kind": "doc",
              "sub": "sub",
              "docId": "docId",
              "scope": [
                "scope"
              ],
              "expiresInSeconds": 1
            }
            """;

        const string mockResponse = """
            {
              "token": "token",
              "jti": "jti",
              "expiresAt": "2024-01-15T09:30:00.000Z"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/tokens")
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

        var response = await Client.Tokens.IssueAsync(
            new IssueTokensRequest
            {
                TenantId = "tenantId",
                Body = new TokensIssueRequest(
                    new CloudPDF.TokensIssueRequest.Doc(
                        new TokensIssueRequestDoc
                        {
                            Sub = "sub",
                            DocId = "docId",
                            Scope = new List<string>() { "scope" },
                            ExpiresInSeconds = 1,
                        }
                    )
                ),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
