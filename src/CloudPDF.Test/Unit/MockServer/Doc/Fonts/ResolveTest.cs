using CloudPDF;
using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Fonts;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ResolveTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "runs": [
                {
                  "text": "text"
                },
                {
                  "text": "text"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "runs": [
                {
                  "font": "font",
                  "weight": 1.1,
                  "italic": true,
                  "substituted": true,
                  "program": "program",
                  "fallbacks": [
                    "fallbacks",
                    "fallbacks"
                  ]
                },
                {
                  "font": "font",
                  "weight": 1.1,
                  "italic": true,
                  "substituted": true,
                  "program": "program",
                  "fallbacks": [
                    "fallbacks",
                    "fallbacks"
                  ]
                }
              ],
              "missingCharacters": [
                "missingCharacters",
                "missingCharacters"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/fonts/resolve")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Fonts.ResolveAsync(
            new ResolveFontsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Body = new FontResolveRequest
                {
                    Annotation = null,
                    Runs = new List<FontResolveRun>()
                    {
                        new FontResolveRun
                        {
                            Text = "text",
                            FontFamily = null,
                            Family = null,
                            Weight = null,
                            Italic = null,
                        },
                        new FontResolveRun
                        {
                            Text = "text",
                            FontFamily = null,
                            Family = null,
                            Weight = null,
                            Italic = null,
                        },
                    },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "runs": [
                {
                  "text": "text"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "runs": [
                {
                  "font": "font",
                  "weight": 1.1,
                  "italic": true,
                  "substituted": true,
                  "program": "program",
                  "fallbacks": [
                    "fallbacks"
                  ]
                }
              ],
              "missingCharacters": [
                "missingCharacters"
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/fonts/resolve")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Fonts.ResolveAsync(
            new ResolveFontsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Body = new FontResolveRequest
                {
                    Runs = new List<FontResolveRun>() { new FontResolveRun { Text = "text" } },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
