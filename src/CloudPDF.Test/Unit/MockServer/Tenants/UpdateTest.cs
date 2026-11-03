using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Tenants;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "features": [
                {
                  "id": "id"
                },
                {
                  "id": "id"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "tenant": {
                "id": "id",
                "name": "name",
                "autoProvisioned": true,
                "status": "active",
                "features": [
                  {
                    "id": "id",
                    "stopped": "cap"
                  },
                  {
                    "id": "id",
                    "stopped": "cap"
                  }
                ],
                "createdAt": 1.1
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Tenants.UpdateAsync(
            new TenantsUpdateRequest
            {
                TenantId = "tenantId",
                Features = new List<TenantFeature>()
                {
                    new TenantFeature { Id = "id", Stopped = null },
                    new TenantFeature { Id = "id", Stopped = null },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "features": [
                {
                  "id": "id"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "tenant": {
                "id": "id",
                "name": "name",
                "autoProvisioned": true,
                "status": "active",
                "features": [
                  {
                    "id": "id"
                  }
                ],
                "createdAt": 1.1
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPatch()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Tenants.UpdateAsync(
            new TenantsUpdateRequest
            {
                TenantId = "tenantId",
                Features = new List<TenantFeature>() { new TenantFeature { Id = "id" } },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
