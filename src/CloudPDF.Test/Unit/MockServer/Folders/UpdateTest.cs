using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Folders;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class UpdateTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "name": "x"
            }
            """;

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
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/folders/folderId")
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

        var response = await Client.Folders.UpdateAsync(
            new FoldersUpdateRequest
            {
                TenantId = "tenantId",
                FolderId = "folderId",
                Name = "x",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "name": "name"
            }
            """;

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
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/tenants/tenantId/folders/folderId")
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

        var response = await Client.Folders.UpdateAsync(
            new FoldersUpdateRequest
            {
                TenantId = "tenantId",
                FolderId = "folderId",
                Name = "name",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
