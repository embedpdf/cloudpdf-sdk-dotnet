using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Annotations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class FlattenTest : BaseMockServerTest
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
              "page": {
                "kind": "objectNumber",
                "objectNumber": 1
              },
              "usage": "display",
              "results": [
                {
                  "ref": {
                    "kind": "objectNumber",
                    "page": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    },
                    "objectNumber": 1
                  },
                  "status": "applied"
                },
                {
                  "ref": {
                    "kind": "objectNumber",
                    "page": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    },
                    "objectNumber": 1
                  },
                  "status": "applied"
                }
              ],
              "meta": {
                "affectedPages": [
                  {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  }
                ],
                "cacheDelta": {
                  "previousDocVersion": 1,
                  "docVersion": 1,
                  "annotationsVersion": 1,
                  "formsVersion": 1,
                  "layoutVersion": 1,
                  "metadataVersion": 1,
                  "attachmentsVersion": 1,
                  "layerVersion": 1,
                  "working": true,
                  "pages": [
                    {
                      "page": {
                        "kind": "objectNumber",
                        "objectNumber": 1
                      },
                      "cache": {
                        "contentVersion": 1,
                        "annotationVersion": 1,
                        "widgetVersion": 1
                      }
                    },
                    {
                      "page": {
                        "kind": "objectNumber",
                        "objectNumber": 1
                      },
                      "cache": {
                        "contentVersion": 1,
                        "annotationVersion": 1,
                        "widgetVersion": 1
                      }
                    }
                  ]
                },
                "opId": "opId",
                "undoable": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/v1/docs/docId/layers/layerName/annotations/pages/pageKey/items/flatten"
                    )
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

        var response = await Client.Doc.Annotations.FlattenAsync(
            new FlattenAnnotationsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                PageKey = "pageKey",
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
              "page": {
                "kind": "objectNumber",
                "objectNumber": 1
              },
              "usage": "display",
              "results": [
                {
                  "ref": {
                    "kind": "objectNumber",
                    "page": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    },
                    "objectNumber": 1
                  },
                  "status": "applied"
                }
              ],
              "meta": {
                "affectedPages": [
                  {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  }
                ],
                "cacheDelta": {
                  "previousDocVersion": 1,
                  "docVersion": 1,
                  "annotationsVersion": 1,
                  "formsVersion": 1,
                  "layoutVersion": 1,
                  "metadataVersion": 1,
                  "attachmentsVersion": 1,
                  "layerVersion": 1,
                  "working": true,
                  "pages": [
                    {
                      "page": {
                        "kind": "objectNumber",
                        "objectNumber": 1
                      },
                      "cache": {
                        "contentVersion": 1,
                        "annotationVersion": 1,
                        "widgetVersion": 1
                      }
                    }
                  ]
                },
                "opId": "opId",
                "undoable": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath(
                        "/v1/docs/docId/layers/layerName/annotations/pages/pageKey/items/flatten"
                    )
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

        var response = await Client.Doc.Annotations.FlattenAsync(
            new FlattenAnnotationsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                PageKey = "pageKey",
                Body = new Dictionary<string, object?>() { { "key", "value" } },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
