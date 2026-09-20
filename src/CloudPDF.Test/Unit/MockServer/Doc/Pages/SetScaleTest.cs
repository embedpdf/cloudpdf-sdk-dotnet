using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Pages;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SetScaleTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "pageObjectNumber": 1,
              "meta": {
                "affectedPages": [
                  {
                    "pageObjectNumber": 1,
                    "revision": {
                      "docSessionId": "docSessionId",
                      "pageObjectNumber": 1,
                      "generation": 1
                    },
                    "weakAnnotationState": {
                      "kind": "unknown"
                    }
                  },
                  {
                    "pageObjectNumber": 1,
                    "revision": {
                      "docSessionId": "docSessionId",
                      "pageObjectNumber": 1,
                      "generation": 1
                    },
                    "weakAnnotationState": {
                      "kind": "unknown"
                    }
                  }
                ],
                "cacheDelta": {
                  "previousDocVersion": 1,
                  "docVersion": 1,
                  "annotationsVersion": 1,
                  "layerVersion": 1,
                  "working": true,
                  "pages": [
                    {
                      "pageObjectNumber": 1,
                      "cache": {
                        "contentVersion": 1,
                        "annotationVersion": 1
                      }
                    },
                    {
                      "pageObjectNumber": 1,
                      "cache": {
                        "contentVersion": 1,
                        "annotationVersion": 1
                      }
                    }
                  ]
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/pages/1/scale")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPut()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Pages.SetScaleAsync(
            new DocPagesSetScaleRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Pon = 1,
                Measure = null,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "pageObjectNumber": 1,
              "meta": {
                "affectedPages": [
                  {
                    "pageObjectNumber": 1,
                    "revision": {
                      "docSessionId": "docSessionId",
                      "pageObjectNumber": 1,
                      "generation": 1
                    },
                    "weakAnnotationState": {
                      "kind": "unknown"
                    }
                  }
                ],
                "cacheDelta": {
                  "previousDocVersion": 1,
                  "docVersion": 1,
                  "annotationsVersion": 1,
                  "layerVersion": 1,
                  "working": true,
                  "pages": [
                    {
                      "pageObjectNumber": 1,
                      "cache": {
                        "contentVersion": 1,
                        "annotationVersion": 1
                      }
                    }
                  ]
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/pages/1/scale")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPut()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Pages.SetScaleAsync(
            new DocPagesSetScaleRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Pon = 1,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
