using CloudPDF.Doc.Fonts;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Fonts.Programs;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "displaySha256": "displaySha256",
              "sourceSha256": "sourceSha256",
              "embedded": "whole",
              "format": "truetype",
              "embeddingPermission": "installable",
              "canDownload": true,
              "covers": [
                {
                  "start": 1,
                  "count": 1
                },
                {
                  "start": 1,
                  "count": 1
                }
              ],
              "ascent": 1.1,
              "descent": 1.1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/font-programs/displaySha256")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Fonts.Programs.GetAsync(
            new GetProgramsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                DisplaySha256 = "displaySha256",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "displaySha256": "displaySha256",
              "sourceSha256": "sourceSha256",
              "embedded": "whole",
              "format": "truetype",
              "embeddingPermission": "installable",
              "canDownload": true,
              "covers": [
                {
                  "start": 1,
                  "count": 1
                }
              ],
              "ascent": 1.1,
              "descent": 1.1
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/font-programs/displaySha256")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Fonts.Programs.GetAsync(
            new GetProgramsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                DisplaySha256 = "displaySha256",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
