using CloudpdfApi.Doc;
using CloudpdfApi.Test.Unit.MockServer;
using CloudpdfApi.Test.Utils;
using NUnit.Framework;

namespace CloudpdfApi.Test.Unit.MockServer.Doc.Metadata;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "title": "title",
              "author": "author",
              "subject": "subject",
              "keywords": "keywords",
              "producer": "producer",
              "creator": "creator",
              "created": "2024-01-15T09:30:00.000Z",
              "modified": "2024-01-15T09:30:00.000Z",
              "trapped": "true",
              "custom": {
                "custom": "custom"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/metadata")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Metadata.GetAsync(
            new GetMetadataRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "title": "title",
              "author": "author",
              "subject": "subject",
              "keywords": "keywords",
              "producer": "producer",
              "creator": "creator",
              "created": "2024-01-15T09:30:00.000Z",
              "modified": "2024-01-15T09:30:00.000Z",
              "trapped": "true",
              "custom": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/metadata")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Metadata.GetAsync(
            new GetMetadataRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
