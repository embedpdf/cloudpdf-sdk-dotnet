using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Tenants;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UsageTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "tenantId": "tenantId",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "metrics": {
                "pdf.views": 1.1,
                "pdf.uploads": 1.1,
                "storage.bytes": 1.1
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/usage")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Tenants.UsageAsync(
            new UsageTenantsRequest { TenantId = "tenantId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "tenantId": "tenantId",
              "periodStart": "periodStart",
              "periodEnd": "periodEnd",
              "metrics": {
                "pdf.views": 1.1,
                "pdf.uploads": 1.1,
                "storage.bytes": 1.1
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/usage")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Tenants.UsageAsync(
            new UsageTenantsRequest { TenantId = "tenantId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
