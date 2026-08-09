using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Tokens;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class RevokeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/tokens/jti/revoke")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Tokens.RevokeAsync(
                new TokensRevokeRequest
                {
                    TenantId = "tenantId",
                    Jti = "jti",
                    Reason = null,
                    ExpiresAtSeconds = null,
                }
            )
        );
    }

    [NUnit.Framework.Test]
    public void MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/tokens/jti/revoke")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Tokens.RevokeAsync(
                new TokensRevokeRequest { TenantId = "tenantId", Jti = "jti" }
            )
        );
    }
}
