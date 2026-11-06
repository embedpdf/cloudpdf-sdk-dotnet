using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Fonts;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "fonts": [
                {
                  "name": "name",
                  "source": "standard",
                  "builtIn": true,
                  "familyName": "familyName",
                  "weight": 1,
                  "italic": true,
                  "postScriptName": "postScriptName",
                  "canChoose": true,
                  "restrictions": [
                    "subset",
                    "subset"
                  ],
                  "programs": [
                    {
                      "displaySha256": "displaySha256",
                      "sourceSha256": "sourceSha256",
                      "embedded": "whole",
                      "format": "truetype",
                      "embeddingPermission": "installable",
                      "canDownload": true
                    },
                    {
                      "displaySha256": "displaySha256",
                      "sourceSha256": "sourceSha256",
                      "embedded": "whole",
                      "format": "truetype",
                      "embeddingPermission": "installable",
                      "canDownload": true
                    }
                  ]
                },
                {
                  "name": "name",
                  "source": "standard",
                  "builtIn": true,
                  "familyName": "familyName",
                  "weight": 1,
                  "italic": true,
                  "postScriptName": "postScriptName",
                  "canChoose": true,
                  "restrictions": [
                    "subset",
                    "subset"
                  ],
                  "programs": [
                    {
                      "displaySha256": "displaySha256",
                      "sourceSha256": "sourceSha256",
                      "embedded": "whole",
                      "format": "truetype",
                      "embeddingPermission": "installable",
                      "canDownload": true
                    },
                    {
                      "displaySha256": "displaySha256",
                      "sourceSha256": "sourceSha256",
                      "embedded": "whole",
                      "format": "truetype",
                      "embeddingPermission": "installable",
                      "canDownload": true
                    }
                  ]
                }
              ],
              "fallbacks": [
                "fallbacks",
                "fallbacks"
              ],
              "lastResort": {
                "displaySha256": "displaySha256",
                "sourceSha256": "sourceSha256",
                "embedded": "whole",
                "format": "truetype",
                "embeddingPermission": "installable",
                "canDownload": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/fonts")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Fonts.ListAsync(
            new ListFontsRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "fonts": [
                {
                  "name": "name",
                  "source": "standard",
                  "builtIn": true,
                  "familyName": "familyName",
                  "weight": 1,
                  "italic": true,
                  "postScriptName": "postScriptName",
                  "canChoose": true,
                  "restrictions": [
                    "subset"
                  ],
                  "programs": [
                    {
                      "embedded": "whole",
                      "canDownload": true
                    }
                  ]
                }
              ],
              "fallbacks": [
                "fallbacks"
              ],
              "lastResort": {
                "displaySha256": "displaySha256",
                "sourceSha256": "sourceSha256",
                "embedded": "whole",
                "format": "truetype",
                "embeddingPermission": "installable",
                "canDownload": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/fonts")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Fonts.ListAsync(
            new ListFontsRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
