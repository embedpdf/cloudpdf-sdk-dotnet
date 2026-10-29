using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Folders;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "folder": {
                "id": "id",
                "tenantId": "tenantId",
                "parentId": "parentId",
                "name": "name",
                "createdAt": 1.1,
                "updatedAt": 1.1,
                "createdBy": "createdBy"
              },
              "path": [
                {
                  "id": "id",
                  "name": "name"
                },
                {
                  "id": "id",
                  "name": "name"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/folders/folderId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Folders.GetAsync(
            new GetFoldersRequest { TenantId = "tenantId", FolderId = "folderId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "folder": {
                "id": "id",
                "tenantId": "tenantId",
                "parentId": "parentId",
                "name": "name",
                "createdAt": 1.1,
                "updatedAt": 1.1,
                "createdBy": "createdBy"
              },
              "path": [
                {
                  "id": "id",
                  "name": "name"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/folders/folderId")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Folders.GetAsync(
            new GetFoldersRequest { TenantId = "tenantId", FolderId = "folderId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
