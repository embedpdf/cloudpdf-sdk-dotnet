using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Tenants;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ResumeTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest_1()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/resume")
                    .UsingPost()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Tenants.ResumeAsync(new ResumeTenantsRequest { TenantId = "tenantId" })
        );
    }

    [NUnit.Framework.Test]
    public void MockServerTest_2()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/resume")
                    .UsingPost()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Tenants.ResumeAsync(new ResumeTenantsRequest { TenantId = "tenantId" })
        );
    }
}
