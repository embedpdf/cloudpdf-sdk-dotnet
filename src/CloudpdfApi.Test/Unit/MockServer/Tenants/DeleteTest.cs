using CloudpdfApi;
using CloudpdfApi.Test.Unit.MockServer;
using NUnit.Framework;

namespace CloudpdfApi.Test.Unit.MockServer.Tenants;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DeleteTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public void MockServerTest_1()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Tenants.DeleteAsync(new DeleteTenantsRequest { TenantId = "tenantId" })
        );
    }

    [NUnit.Framework.Test]
    public void MockServerTest_2()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Tenants.DeleteAsync(new DeleteTenantsRequest { TenantId = "tenantId" })
        );
    }
}
