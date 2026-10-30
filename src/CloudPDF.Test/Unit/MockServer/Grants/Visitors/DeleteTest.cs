using CloudPDF.Grants;
using CloudPDF.Test.Unit.MockServer;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Grants.Visitors;

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
                    .WithPath("/v1/tenants/tenantId/grants/grantId/visitors/visitorId")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Grants.Visitors.DeleteAsync(
                new DeleteVisitorsRequest
                {
                    TenantId = "tenantId",
                    GrantId = "grantId",
                    VisitorId = "visitorId",
                }
            )
        );
    }

    [NUnit.Framework.Test]
    public void MockServerTest_2()
    {
        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/grants/grantId/visitors/visitorId")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Grants.Visitors.DeleteAsync(
                new DeleteVisitorsRequest
                {
                    TenantId = "tenantId",
                    GrantId = "grantId",
                    VisitorId = "visitorId",
                }
            )
        );
    }
}
