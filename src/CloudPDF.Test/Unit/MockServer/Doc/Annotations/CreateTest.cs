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
                "structurePosition": [
                  1,
                  1
                ],
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
                    "warnings": [
                      "cycle-dropped",
                      "cycle-dropped"
                    ]
                  }
                },
                "richText": {
                  "body": {
                    "family": "x",
                    "weight": 900,
                    "italic": true,
                    "size": 1.1,
                    "color": "color",
                    "decoration": [
                      "underline",
                      "underline"
                    ],
                    "script": "normal",
                    "letterSpacing": 1.1,
                    "horizontalScale": 1.1,
                    "unknown": "unknown",
                    "align": "left",
                    "dir": "ltr",
                    "lineHeight": 1.1,
                    "margins": {
                      "top": 1.1,
                      "bottom": 1.1,
                      "left": 1.1,
                      "right": 1.1
                    },
                    "textIndent": 1.1
                  },
                  "paragraphs": [
                    {
                      "align": "left",
                      "dir": "ltr",
                      "lineHeight": 1.1,
                      "margins": {
                        "top": 1.1,
                        "bottom": 1.1,
                        "left": 1.1,
                        "right": 1.1
                      },
                      "textIndent": 1.1,
                      "unknown": "unknown",
                      "runs": [
                        {
                          "text": "text",
                          "style": {}
                        },
                        {
                          "text": "text",
                          "style": {}
                        }
                      ]
                    },
                    {
                      "align": "left",
                      "dir": "ltr",
                      "lineHeight": 1.1,
                      "margins": {
                        "top": 1.1,
                        "bottom": 1.1,
                        "left": 1.1,
                        "right": 1.1
                      },
                      "textIndent": 1.1,
                      "unknown": "unknown",
                      "runs": [
                        {
                          "text": "text",
                          "style": {}
                        },
                        {
                          "text": "text",
                          "style": {}
                        }
                      ]
                    }
                  ]
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
                  "outlineVersion": 1,
                  "viewportsVersion": 1,
                  "fontsVersion": 1,
                  "contentsVersion": 1,
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
                "missingCharacters": [
                  "missingCharacters",
                  "missingCharacters"
                ],
                "changedRefs": [
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
                "structurePosition": [
                  1
                ],
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
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "cursorEnter": {
                    "incomplete": true,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "cursorExit": {
                    "incomplete": true,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "mouseDown": {
                    "incomplete": true,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "mouseUp": {
                    "incomplete": true,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "focus": {
                    "incomplete": true,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "blur": {
                    "incomplete": true,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "pageOpen": {
                    "incomplete": true,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "pageClose": {
                    "incomplete": true,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "pageVisible": {
                    "incomplete": true,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "pageInvisible": {
                    "incomplete": true,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  }
                },
                "richText": {
                  "body": {
                    "family": "family",
                    "weight": 1,
                    "italic": true,
                    "size": 1.1,
                    "color": "color",
                    "decoration": [
                      "underline"
                    ],
                    "script": "normal",
                    "letterSpacing": 1.1,
                    "horizontalScale": 1.1,
                    "align": "left",
                    "dir": "ltr"
                  },
                  "paragraphs": [
                    {
                      "runs": [
                        {
                          "text": "text"
                        }
                      ]
                    }
                  ]
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
                  "outlineVersion": 1,
                  "viewportsVersion": 1,
                  "fontsVersion": 1,
                  "contentsVersion": 1,
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
                "missingCharacters": [
                  "missingCharacters"
                ],
                "changedRefs": [
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
