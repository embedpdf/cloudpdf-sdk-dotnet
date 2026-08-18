using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class TextTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "text": "text",
              "charCount": 1,
              "charMap": [
                [
                  {
                    "key": "value"
                  },
                  {
                    "key": "value"
                  }
                ],
                [
                  {
                    "key": "value"
                  },
                  {
                    "key": "value"
                  }
                ]
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/text/pages/1/data")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.TextAsync(
            new TextDocRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Pon = 1,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "text": "text",
              "charCount": 1,
              "charMap": [
                [
                  {
                    "key": "value"
                  }
                ]
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/text/pages/1/data")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.TextAsync(
            new TextDocRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Pon = 1,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
