using CloudpdfApi;
using CloudpdfApi.Test.Unit.MockServer;
using NUnit.Framework;

namespace CloudpdfApi.Test.Unit.MockServer.Documents;

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
                    .WithPath("/v1/tenants/tenantId/documents/id")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Documents.DeleteAsync(
                new DeleteDocumentsRequest { TenantId = "tenantId", Id = "id" }
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
                    .WithPath("/v1/tenants/tenantId/documents/id")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Documents.DeleteAsync(
                new DeleteDocumentsRequest { TenantId = "tenantId", Id = "id" }
            )
        );
    }
}
