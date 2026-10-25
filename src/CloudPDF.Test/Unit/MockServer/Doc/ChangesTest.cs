using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ChangesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "changes": [
                {
                  "opId": "opId"
                },
                {
                  "opId": "opId"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "changes": [
                {
                  "status": "applied",
                  "opId": "opId",
                  "result": {
                    "items": [
                      {
                        "type": "skipped",
                        "op": "annotations.create",
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
                            "pages": []
                          },
                          "opId": "opId",
                          "undoable": true
                        }
                      },
                      {
                        "type": "skipped",
                        "op": "annotations.create",
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
                            "pages": []
                          },
                          "opId": "opId",
                          "undoable": true
                        }
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
                      "undoable": true
                    }
                  }
                },
                {
                  "status": "applied",
                  "opId": "opId",
                  "result": {
                    "items": [
                      {
                        "type": "skipped",
                        "op": "annotations.create",
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
                            "pages": []
                          },
                          "opId": "opId",
                          "undoable": true
                        }
                      },
                      {
                        "type": "skipped",
                        "op": "annotations.create",
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
                            "pages": []
                          },
                          "opId": "opId",
                          "undoable": true
                        }
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
                      "undoable": true
                    }
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/changes")
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

        var response = await Client.Doc.ChangesAsync(
            new DocChangesRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Changes = new List<DocChangesRequestChangesItem>()
                {
                    new DocChangesRequestChangesItem
                    {
                        OpId = "opId",
                        Ops = null,
                        UndoOf = null,
                    },
                    new DocChangesRequestChangesItem
                    {
                        OpId = "opId",
                        Ops = null,
                        UndoOf = null,
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
              "changes": [
                {
                  "opId": "opId"
                }
              ]
            }
            """;

        const string mockResponse = """
            {
              "changes": [
                {
                  "status": "applied",
                  "opId": "opId",
                  "result": {
                    "items": [
                      {
                        "type": "skipped",
                        "op": "annotations.create",
                        "meta": {
                          "affectedPages": [
                            {
                              "kind": "objectNumber",
                              "objectNumber": 1
                            }
                          ],
                          "opId": "opId",
                          "undoable": true
                        }
                      }
                    ],
                    "meta": {
                      "affectedPages": [
                        {
                          "kind": "objectNumber",
                          "objectNumber": 1
                        }
                      ],
                      "opId": "opId",
                      "undoable": true
                    }
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/changes")
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

        var response = await Client.Doc.ChangesAsync(
            new DocChangesRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Changes = new List<DocChangesRequestChangesItem>()
                {
                    new DocChangesRequestChangesItem { OpId = "opId" },
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
