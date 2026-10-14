using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Redactions;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ApplyTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {}
            """;

        const string mockResponse = """
            {
              "scope": {
                "pages": [
                  {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  }
                ],
                "annotations": [
                  {
                    "kind": "objectNumber",
                    "page": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    },
                    "objectNumber": 1
                  },
                  {
                    "kind": "objectNumber",
                    "page": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    },
                    "objectNumber": 1
                  }
                ]
              },
              "results": [
                {
                  "page": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "status": "applied",
                  "removedAnnotationCount": 1
                },
                {
                  "page": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "status": "applied",
                  "removedAnnotationCount": 1
                }
              ],
              "removedAnnotationCount": 1,
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
                    .WithPath("/v1/docs/docId/layers/layerName/redactions/apply")
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

        var response = await Client.Doc.Redactions.ApplyAsync(
            new DocRedactionsApplyRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Pages = null,
                Annotations = null,
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
              "scope": {
                "pages": [
                  {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  }
                ],
                "annotations": [
                  {
                    "kind": "objectNumber",
                    "page": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    },
                    "objectNumber": 1
                  }
                ]
              },
              "results": [
                {
                  "page": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "status": "applied",
                  "removedAnnotationCount": 1
                }
              ],
              "removedAnnotationCount": 1,
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
                    .WithPath("/v1/docs/docId/layers/layerName/redactions/apply")
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

        var response = await Client.Doc.Redactions.ApplyAsync(
            new DocRedactionsApplyRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
