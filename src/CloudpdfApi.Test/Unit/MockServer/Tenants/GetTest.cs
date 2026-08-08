using CloudpdfApi;
using CloudpdfApi.Test.Unit.MockServer;
using CloudpdfApi.Test.Utils;
using NUnit.Framework;

namespace CloudpdfApi.Test.Unit.MockServer.Tenants;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "tenant": {
                "id": "id",
                "name": "name",
                "autoProvisioned": true,
                "createdAt": 1.1
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Tenants.GetAsync(
            new GetTenantsRequest { TenantId = "tenantId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "tenant": {
                "id": "id",
                "name": "name",
                "autoProvisioned": true,
                "createdAt": 1.1
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Tenants.GetAsync(
            new GetTenantsRequest { TenantId = "tenantId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
