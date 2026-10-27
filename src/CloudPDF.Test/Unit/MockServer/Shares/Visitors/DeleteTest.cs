using CloudPDF.Shares;
using CloudPDF.Test.Unit.MockServer;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Shares.Visitors;

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
                    .WithPath("/v1/tenants/tenantId/shares/shareId/visitors/visitorId")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Shares.Visitors.DeleteAsync(
                new DeleteVisitorsRequest
                {
                    TenantId = "tenantId",
                    ShareId = "shareId",
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
                    .WithPath("/v1/tenants/tenantId/shares/shareId/visitors/visitorId")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Shares.Visitors.DeleteAsync(
                new DeleteVisitorsRequest
                {
                    TenantId = "tenantId",
                    ShareId = "shareId",
                    VisitorId = "visitorId",
                }
            )
        );
    }
}
