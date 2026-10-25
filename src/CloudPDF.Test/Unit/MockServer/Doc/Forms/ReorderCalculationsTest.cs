using CloudPDF;
using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Forms;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ReorderCalculationsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "fields": [
                {
                  "kind": "objectNumber",
                  "objectNumber": 1
                },
                {
                  "kind": "objectNumber",
                  "objectNumber": 1
                }
              ],
              "position": "start"
            }
            """;

        const string mockResponse = """
            {
              "calculationOrder": [
                {
                  "kind": "objectNumber",
                  "objectNumber": 1
                },
                {
                  "kind": "objectNumber",
                  "objectNumber": 1
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
                  "outlineVersion": 1,
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
                "undoable": true,
                "changedFields": [
                  {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  }
                ],
                "changedWidgets": [
                  {
                    "ref": {
                      "kind": "objectNumber",
                      "page": {
                        "kind": "objectNumber",
                        "objectNumber": 1
                      },
                      "objectNumber": 1
                    },
                    "objectNumber": 1,
                    "page": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    }
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
                    "objectNumber": 1,
                    "page": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    }
                  }
                ],
                "redrawnWidgets": [
                  {
                    "ref": {
                      "kind": "objectNumber",
                      "page": {
                        "kind": "objectNumber",
                        "objectNumber": 1
                      },
                      "objectNumber": 1
                    },
                    "objectNumber": 1,
                    "page": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    }
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
                    "objectNumber": 1,
                    "page": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    }
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/form/calculations/reorder")
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

        var response = await Client.Doc.Forms.ReorderCalculationsAsync(
            new DocFormsReorderCalculationsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Fields = new List<FormFieldRef>()
                {
                    new FormFieldRef(
                        new FormFieldRef.ObjectNumber(
                            new FormFieldRefObjectNumber { ObjectNumber = 1 }
                        )
                    ),
                    new FormFieldRef(
                        new FormFieldRef.ObjectNumber(
                            new FormFieldRefObjectNumber { ObjectNumber = 1 }
                        )
                    ),
                },
                Position = FieldPositionZero.Start,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string requestJson = """
            {
              "fields": [
                {
                  "kind": "objectNumber",
                  "objectNumber": 1
                }
              ],
              "position": "start"
            }
            """;

        const string mockResponse = """
            {
              "calculationOrder": [
                {
                  "kind": "objectNumber",
                  "objectNumber": 1
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
                  "outlineVersion": 1,
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
                "undoable": true,
                "changedFields": [
                  {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  }
                ],
                "changedWidgets": [
                  {
                    "objectNumber": 1
                  }
                ],
                "redrawnWidgets": [
                  {
                    "objectNumber": 1
                  }
                ]
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/form/calculations/reorder")
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

        var response = await Client.Doc.Forms.ReorderCalculationsAsync(
            new DocFormsReorderCalculationsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Fields = new List<FormFieldRef>()
                {
                    new FormFieldRef(
                        new FormFieldRef.ObjectNumber(
                            new FormFieldRefObjectNumber { ObjectNumber = 1 }
                        )
                    ),
                },
                Position = FieldPositionZero.Start,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
