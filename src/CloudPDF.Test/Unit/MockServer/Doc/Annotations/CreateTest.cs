using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Annotations;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CreateTest : BaseMockServerTest
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
              "annotation": {
                "subtype": "highlight",
                "ref": {
                  "kind": "objectNumber",
                  "page": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "objectNumber": 1
                },
                "page": {
                  "kind": "objectNumber",
                  "objectNumber": 1
                },
                "hasAppearance": true,
                "appearanceState": "appearanceState",
                "nm": "nm",
                "rect": {
                  "x": 1.1,
                  "y": 1.1,
                  "width": 1.1,
                  "height": 1.1
                },
                "contents": "contents",
                "subject": "subject",
                "blendMode": "normal",
                "invisible": true,
                "hidden": true,
                "print": true,
                "noZoom": true,
                "noRotate": true,
                "noView": true,
                "readOnly": true,
                "locked": true,
                "toggleNoView": true,
                "lockedContents": true,
                "reply": {
                  "to": {
                    "kind": "objectNumber",
                    "page": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    },
                    "objectNumber": 1
                  },
                  "type": "reply"
                },
                "popup": {
                  "kind": "objectNumber",
                  "page": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "objectNumber": 1
                },
                "groupId": "x",
                "author": "author",
                "createdAt": "2024-01-15T09:30:00.000Z",
                "modifiedAt": "2024-01-15T09:30:00.000Z",
                "userId": "userId",
                "createdBy": "createdBy",
                "modifiedBy": "modifiedBy",
                "importedBy": "importedBy",
                "actions": {
                  "activate": {
                    "root": {
                      "type": "javascript",
                      "subtype": "subtype",
                      "next": [
                        {
                          "key": "value"
                        },
                        {
                          "key": "value"
                        }
                      ],
                      "script": "script"
                    },
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped",
                      "cycle-dropped"
                    ]
                  },
                  "cursorEnter": {
                    "root": {
                      "type": "javascript",
                      "subtype": "subtype",
                      "next": [
                        {
                          "key": "value"
                        },
                        {
                          "key": "value"
                        }
                      ],
                      "script": "script"
                    },
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped",
                      "cycle-dropped"
                    ]
                  },
                  "cursorExit": {
                    "root": {
                      "type": "javascript",
                      "subtype": "subtype",
                      "next": [
                        {
                          "key": "value"
                        },
                        {
                          "key": "value"
                        }
                      ],
                      "script": "script"
                    },
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped",
                      "cycle-dropped"
                    ]
                  },
                  "mouseDown": {
                    "root": {
                      "type": "javascript",
                      "subtype": "subtype",
                      "next": [
                        {
                          "key": "value"
                        },
                        {
                          "key": "value"
                        }
                      ],
                      "script": "script"
                    },
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped",
                      "cycle-dropped"
                    ]
                  },
                  "mouseUp": {
                    "root": {
                      "type": "javascript",
                      "subtype": "subtype",
                      "next": [
                        {
                          "key": "value"
                        },
                        {
                          "key": "value"
                        }
                      ],
                      "script": "script"
                    },
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped",
                      "cycle-dropped"
                    ]
                  },
                  "focus": {
                    "root": {
                      "type": "javascript",
                      "subtype": "subtype",
                      "next": [
                        {
                          "key": "value"
                        },
                        {
                          "key": "value"
                        }
                      ],
                      "script": "script"
                    },
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped",
                      "cycle-dropped"
                    ]
                  },
                  "blur": {
                    "root": {
                      "type": "javascript",
                      "subtype": "subtype",
                      "next": [
                        {
                          "key": "value"
                        },
                        {
                          "key": "value"
                        }
                      ],
                      "script": "script"
                    },
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped",
                      "cycle-dropped"
                    ]
                  },
                  "pageOpen": {
                    "root": {
                      "type": "javascript",
                      "subtype": "subtype",
                      "next": [
                        {
                          "key": "value"
                        },
                        {
                          "key": "value"
                        }
                      ],
                      "script": "script"
                    },
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped",
                      "cycle-dropped"
                    ]
                  },
                  "pageClose": {
                    "root": {
                      "type": "javascript",
                      "subtype": "subtype",
                      "next": [
                        {
                          "key": "value"
                        },
                        {
                          "key": "value"
                        }
                      ],
                      "script": "script"
                    },
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped",
                      "cycle-dropped"
                    ]
                  },
                  "pageVisible": {
                    "root": {
                      "type": "javascript",
                      "subtype": "subtype",
                      "next": [
                        {
                          "key": "value"
                        },
                        {
                          "key": "value"
                        }
                      ],
                      "script": "script"
                    },
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped",
                      "cycle-dropped"
                    ]
                  },
                  "pageInvisible": {
                    "root": {
                      "type": "javascript",
                      "subtype": "subtype",
                      "next": [
                        {
                          "key": "value"
                        },
                        {
                          "key": "value"
                        }
                      ],
                      "script": "script"
                    },
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped",
                      "cycle-dropped"
                    ]
                  }
                },
                "color": "color",
                "opacity": 1,
                "quadPoints": [
                  {
                    "upperLeft": {
                      "x": 1.1,
                      "y": 1.1
                    },
                    "upperRight": {
                      "x": 1.1,
                      "y": 1.1
                    },
                    "lowerLeft": {
                      "x": 1.1,
                      "y": 1.1
                    },
                    "lowerRight": {
                      "x": 1.1,
                      "y": 1.1
                    }
                  },
                  {
                    "upperLeft": {
                      "x": 1.1,
                      "y": 1.1
                    },
                    "upperRight": {
                      "x": 1.1,
                      "y": 1.1
                    },
                    "lowerLeft": {
                      "x": 1.1,
                      "y": 1.1
                    },
                    "lowerRight": {
                      "x": 1.1,
                      "y": 1.1
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
                "changed": [
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
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/annotations/pages/pageKey/items")
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

        var response = await Client.Doc.Annotations.CreateAsync(
            new CreateAnnotationsRequest
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
              "annotation": {
                "subtype": "highlight",
                "ref": {
                  "kind": "objectNumber",
                  "page": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "objectNumber": 1
                },
                "page": {
                  "kind": "objectNumber",
                  "objectNumber": 1
                },
                "hasAppearance": true,
                "appearanceState": "appearanceState",
                "nm": "nm",
                "rect": {
                  "x": 1.1,
                  "y": 1.1,
                  "width": 1.1,
                  "height": 1.1
                },
                "contents": "contents",
                "subject": "subject",
                "blendMode": "normal",
                "invisible": true,
                "hidden": true,
                "print": true,
                "noZoom": true,
                "noRotate": true,
                "noView": true,
                "readOnly": true,
                "locked": true,
                "toggleNoView": true,
                "lockedContents": true,
                "reply": {
                  "to": {
                    "kind": "objectNumber",
                    "page": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    },
                    "objectNumber": 1
                  },
                  "type": "reply"
                },
                "popup": {
                  "kind": "objectNumber",
                  "page": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "objectNumber": 1
                },
                "groupId": "groupId",
                "author": "author",
                "createdAt": "2024-01-15T09:30:00.000Z",
                "modifiedAt": "2024-01-15T09:30:00.000Z",
                "userId": "userId",
                "createdBy": "createdBy",
                "modifiedBy": "modifiedBy",
                "importedBy": "importedBy",
                "actions": {
                  "activate": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "cursorEnter": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "cursorExit": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "mouseDown": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "mouseUp": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "focus": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "blur": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "pageOpen": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "pageClose": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "pageVisible": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "pageInvisible": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  }
                },
                "color": "color",
                "opacity": 1.1,
                "quadPoints": [
                  {
                    "upperLeft": {
                      "x": 1.1,
                      "y": 1.1
                    },
                    "upperRight": {
                      "x": 1.1,
                      "y": 1.1
                    },
                    "lowerLeft": {
                      "x": 1.1,
                      "y": 1.1
                    },
                    "lowerRight": {
                      "x": 1.1,
                      "y": 1.1
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
                "changed": [
                  {
                    "kind": "objectNumber",
                    "page": {
                      "kind": "objectNumber",
                      "objectNumber": 1
                    },
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
                    .WithPath("/v1/docs/docId/layers/layerName/annotations/pages/pageKey/items")
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

        var response = await Client.Doc.Annotations.CreateAsync(
            new CreateAnnotationsRequest
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
