using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Attachments;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "attachments": [
                {
                  "ref": {
                    "kind": "key",
                    "key": "key"
                  },
                  "name": "name",
                  "mimeType": "mimeType",
                  "description": "description",
                  "size": 1,
                  "checksum": "checksum",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "modifiedAt": "2024-01-15T09:30:00.000Z",
                  "index": 1
                },
                {
                  "ref": {
                    "kind": "key",
                    "key": "key"
                  },
                  "name": "name",
                  "mimeType": "mimeType",
                  "description": "description",
                  "size": 1,
                  "checksum": "checksum",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "modifiedAt": "2024-01-15T09:30:00.000Z",
                  "index": 1
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/attachments")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Attachments.ListAsync(
            new ListAttachmentsRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "attachments": [
                {
                  "ref": {
                    "kind": "key",
                    "key": "key"
                  },
                  "name": "name",
                  "mimeType": "mimeType",
                  "description": "description",
                  "size": 1,
                  "checksum": "checksum",
                  "createdAt": "2024-01-15T09:30:00.000Z",
                  "modifiedAt": "2024-01-15T09:30:00.000Z",
                  "index": 1
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/attachments")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Attachments.ListAsync(
            new ListAttachmentsRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
