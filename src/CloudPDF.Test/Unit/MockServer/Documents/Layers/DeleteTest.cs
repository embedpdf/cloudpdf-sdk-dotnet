using CloudPDF.Documents;
using CloudPDF.Test.Unit.MockServer;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Documents.Layers;

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
                    .WithPath("/v1/tenants/tenantId/documents/docId/layers/layerName")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Documents.Layers.DeleteAsync(
                new DeleteLayersRequest
                {
                    TenantId = "tenantId",
                    DocId = "docId",
                    LayerName = "layerName",
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
                    .WithPath("/v1/tenants/tenantId/documents/docId/layers/layerName")
                    .UsingDelete()
            )
            .RespondWith(WireMock.ResponseBuilders.Response.Create().WithStatusCode(200));

        Assert.DoesNotThrowAsync(async () =>
            await Client.Documents.Layers.DeleteAsync(
                new DeleteLayersRequest
                {
                    TenantId = "tenantId",
                    DocId = "docId",
                    LayerName = "layerName",
                }
            )
        );
    }
}
