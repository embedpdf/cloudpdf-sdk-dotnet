using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Folders;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "folders": [
                {
                  "id": "id",
                  "tenantId": "tenantId",
                  "parentId": "parentId",
                  "name": "name",
                  "createdAt": 1.1,
                  "updatedAt": 1.1,
                  "createdBy": "createdBy"
                },
                {
                  "id": "id",
                  "tenantId": "tenantId",
                  "parentId": "parentId",
                  "name": "name",
                  "createdAt": 1.1,
                  "updatedAt": 1.1,
                  "createdBy": "createdBy"
                }
              ],
              "nextCursor": "nextCursor"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/folders")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Folders.ListAsync(
            new ListFoldersRequest { TenantId = "tenantId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "folders": [
                {
                  "id": "id",
                  "tenantId": "tenantId",
                  "parentId": "parentId",
                  "name": "name",
                  "createdAt": 1.1,
                  "updatedAt": 1.1,
                  "createdBy": "createdBy"
                }
              ],
              "nextCursor": "nextCursor"
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/folders")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Folders.ListAsync(
            new ListFoldersRequest { TenantId = "tenantId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
