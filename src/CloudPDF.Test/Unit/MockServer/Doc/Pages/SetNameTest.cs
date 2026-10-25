using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Pages;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SetNameTest : BaseMockServerTest
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
              "layout": {
                "pageCount": 1,
                "pages": [
                  {
                    "index": 1,
                    "ref": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    },
                    "label": "label",
                    "size": {
                      "width": 1.1,
                      "height": 1.1
                    },
                    "rotation": 1.1,
                    "userUnit": 1.1,
                    "tabOrder": "rows",
                    "boxes": {
                      "media": {
                        "x": 1.1,
                        "y": 1.1,
                        "width": 1.1,
                        "height": 1.1
                      },
                      "crop": {
                        "x": 1.1,
                        "y": 1.1,
                        "width": 1.1,
                        "height": 1.1
                      },
                      "bleed": {
                        "x": 1.1,
                        "y": 1.1,
                        "width": 1.1,
                        "height": 1.1
                      },
                      "trim": {
                        "x": 1.1,
                        "y": 1.1,
                        "width": 1.1,
                        "height": 1.1
                      },
                      "art": {
                        "x": 1.1,
                        "y": 1.1,
                        "width": 1.1,
                        "height": 1.1
                      }
                    },
                    "pdfCropBox": {
                      "left": 1.1,
                      "bottom": 1.1,
                      "right": 1.1,
                      "top": 1.1
                    },
                    "actions": {
                      "open": {
                        "root": {
                          "type": "javascript",
                          "subtype": "subtype",
                          "next": [],
                          "script": "script"
                        },
                        "incomplete": true,
                        "warningFlags": 1,
                        "warnings": [
                          "cycle-dropped",
                          "cycle-dropped"
                        ]
                      },
                      "close": {
                        "root": {
                          "type": "javascript",
                          "subtype": "subtype",
                          "next": [],
                          "script": "script"
                        },
                        "incomplete": true,
                        "warningFlags": 1,
                        "warnings": [
                          "cycle-dropped",
                          "cycle-dropped"
                        ]
                      }
                    }
                  },
                  {
                    "index": 1,
                    "ref": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    },
                    "label": "label",
                    "size": {
                      "width": 1.1,
                      "height": 1.1
                    },
                    "rotation": 1.1,
                    "userUnit": 1.1,
                    "tabOrder": "rows",
                    "boxes": {
                      "media": {
                        "x": 1.1,
                        "y": 1.1,
                        "width": 1.1,
                        "height": 1.1
                      },
                      "crop": {
                        "x": 1.1,
                        "y": 1.1,
                        "width": 1.1,
                        "height": 1.1
                      },
                      "bleed": {
                        "x": 1.1,
                        "y": 1.1,
                        "width": 1.1,
                        "height": 1.1
                      },
                      "trim": {
                        "x": 1.1,
                        "y": 1.1,
                        "width": 1.1,
                        "height": 1.1
                      },
                      "art": {
                        "x": 1.1,
                        "y": 1.1,
                        "width": 1.1,
                        "height": 1.1
                      }
                    },
                    "pdfCropBox": {
                      "left": 1.1,
                      "bottom": 1.1,
                      "right": 1.1,
                      "top": 1.1
                    },
                    "actions": {
                      "open": {
                        "root": {
                          "type": "javascript",
                          "subtype": "subtype",
                          "next": [],
                          "script": "script"
                        },
                        "incomplete": true,
                        "warningFlags": 1,
                        "warnings": [
                          "cycle-dropped",
                          "cycle-dropped"
                        ]
                      },
                      "close": {
                        "root": {
                          "type": "javascript",
                          "subtype": "subtype",
                          "next": [],
                          "script": "script"
                        },
                        "incomplete": true,
                        "warningFlags": 1,
                        "warnings": [
                          "cycle-dropped",
                          "cycle-dropped"
                        ]
                      }
                    }
                  }
                ],
                "namedPages": [
                  {
                    "name": "name",
                    "target": {
                      "kind": "page",
                      "page": {
                        "kind": "objectNumber",
                        "objectNumber": 1
                      }
                    }
                  },
                  {
                    "name": "name",
                    "target": {
                      "kind": "page",
                      "page": {
                        "kind": "objectNumber",
                        "objectNumber": 1
                      }
                    }
                  }
                ]
              },
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
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/pages/names")
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

        var response = await Client.Doc.Pages.SetNameAsync(
            new SetNamePagesRequest
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
              "layout": {
                "pageCount": 1,
                "pages": [
                  {
                    "index": 1,
                    "ref": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    },
                    "size": {
                      "width": 1.1,
                      "height": 1.1
                    },
                    "rotation": 1.1,
                    "userUnit": 1.1,
                    "boxes": {
                      "media": {
                        "x": 1.1,
                        "y": 1.1,
                        "width": 1.1,
                        "height": 1.1
                      },
                      "crop": {
                        "x": 1.1,
                        "y": 1.1,
                        "width": 1.1,
                        "height": 1.1
                      },
                      "bleed": {
                        "x": 1.1,
                        "y": 1.1,
                        "width": 1.1,
                        "height": 1.1
                      },
                      "trim": {
                        "x": 1.1,
                        "y": 1.1,
                        "width": 1.1,
                        "height": 1.1
                      },
                      "art": {
                        "x": 1.1,
                        "y": 1.1,
                        "width": 1.1,
                        "height": 1.1
                      }
                    },
                    "pdfCropBox": {
                      "left": 1.1,
                      "bottom": 1.1,
                      "right": 1.1,
                      "top": 1.1
                    }
                  }
                ],
                "namedPages": [
                  {
                    "name": "name",
                    "target": {
                      "kind": "page",
                      "page": {
                        "kind": "objectNumber",
                        "objectNumber": 1
                      }
                    }
                  }
                ]
              },
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
                "undoable": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/pages/names")
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

        var response = await Client.Doc.Pages.SetNameAsync(
            new SetNamePagesRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Body = new Dictionary<string, object?>() { { "key", "value" } },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
