using CloudpdfApi;
using CloudpdfApi.Test.Unit.MockServer;
using CloudpdfApi.Test.Utils;
using NUnit.Framework;

namespace CloudpdfApi.Test.Unit.MockServer.Tokens;

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
              "expiresIn": 7776000
            }
            """;

        const string mockResponse = """
            {
              "token": "token",
              "jti": "jti",
              "expiresAt": 1.1
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
                    new TokensIssueRequest.Doc(
                        new TokensIssueRequestDoc
                        {
                            Sub = "x",
                            DocId = "docId",
                            LayerName = null,
                            Scope = new List<string>() { "scope", "scope" },
                            UserId = null,
                            DisplayName = null,
                            GroupId = null,
                            Groups = null,
                            ExpiresIn = 7776000,
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
              "expiresIn": 1
            }
            """;

        const string mockResponse = """
            {
              "token": "token",
              "jti": "jti",
              "expiresAt": 1.1
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
                    new TokensIssueRequest.Doc(
                        new TokensIssueRequestDoc
                        {
                            Sub = "sub",
                            DocId = "docId",
                            Scope = new List<string>() { "scope" },
                            ExpiresIn = 1,
                        }
                    )
                ),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
