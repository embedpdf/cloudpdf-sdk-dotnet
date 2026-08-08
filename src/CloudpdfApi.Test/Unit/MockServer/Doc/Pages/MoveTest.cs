using CloudpdfApi.Doc;
using CloudpdfApi.Test.Unit.MockServer;
using CloudpdfApi.Test.Utils;
using NUnit.Framework;

namespace CloudpdfApi.Test.Unit.MockServer.Doc.Pages;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class MoveTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "string": {
                "key": "value"
              }
            }
            """;

        const string mockResponse = """
            {
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
                    .WithPath("/v1/docs/docId/layers/layerName/pages/move")
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

        var response = await Client.Doc.Pages.MoveAsync(
            new MovePagesRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Body = new Dictionary<string, object?>()
                {
                    {
                        "string",
                        new Dictionary<object, object?>() { { "key", "value" } }
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
              "key": "value"
            }
            """;

        const string mockResponse = """
            {
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
                    .WithPath("/v1/docs/docId/layers/layerName/pages/move")
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

        var response = await Client.Doc.Pages.MoveAsync(
            new MovePagesRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Body = new Dictionary<string, object?>() { { "key", "value" } },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
