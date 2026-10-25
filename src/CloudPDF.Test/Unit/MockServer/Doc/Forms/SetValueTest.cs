using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Forms;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class SetValueTest : BaseMockServerTest
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
              "field": {
                "family": "text",
                "ref": {
                  "kind": "objectNumber",
                  "objectNumber": 1
                },
                "name": "name",
                "origin": "acroform",
                "readOnly": true,
                "required": true,
                "noExport": true,
                "alternateName": "alternateName",
                "mappingName": "mappingName",
                "valueEntry": {
                  "kind": "none"
                },
                "defaultValueEntry": {
                  "kind": "none"
                },
                "actions": {
                  "keystroke": {
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
                  "format": {
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
                  "validate": {
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
                  "calculate": {
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
                "groupId": "groupId",
                "createdBy": "createdBy",
                "createdAt": "2024-01-15T09:30:00.000Z",
                "filledBy": "filledBy",
                "filledByName": "filledByName",
                "filledAt": "2024-01-15T09:30:00.000Z",
                "importedBy": "importedBy",
                "widgets": [
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
                "value": "value",
                "defaultValue": "defaultValue",
                "maxLength": 1,
                "multiline": true,
                "password": true,
                "comb": true
              },
              "widgets": [
                {
                  "subtype": "widget",
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
                  "box": {
                    "x": 1.1,
                    "y": 1.1,
                    "width": 1.1,
                    "height": 1.1
                  },
                  "rotation": 1.1,
                  "color": "color",
                  "interiorColor": "interiorColor",
                  "strokeWidth": 1.1,
                  "borderStyle": "solid",
                  "dashArray": [
                    1.1,
                    1.1
                  ],
                  "fontFamily": "x",
                  "fontSize": 1.1,
                  "fontColor": "fontColor",
                  "textAlign": "left",
                  "caption": "caption",
                  "checkStyle": "check",
                  "field": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "fieldFamily": "text"
                },
                {
                  "subtype": "widget",
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
                  "box": {
                    "x": 1.1,
                    "y": 1.1,
                    "width": 1.1,
                    "height": 1.1
                  },
                  "rotation": 1.1,
                  "color": "color",
                  "interiorColor": "interiorColor",
                  "strokeWidth": 1.1,
                  "borderStyle": "solid",
                  "dashArray": [
                    1.1,
                    1.1
                  ],
                  "fontFamily": "x",
                  "fontSize": 1.1,
                  "fontColor": "fontColor",
                  "textAlign": "left",
                  "caption": "caption",
                  "checkStyle": "check",
                  "field": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "fieldFamily": "text"
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
                    .WithPath("/v1/docs/docId/layers/layerName/form/fields/fieldKey/value")
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

        var response = await Client.Doc.Forms.SetValueAsync(
            new SetValueFormsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                FieldKey = "fieldKey",
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
              "field": {
                "family": "text",
                "ref": {
                  "kind": "objectNumber",
                  "objectNumber": 1
                },
                "name": "name",
                "origin": "acroform",
                "readOnly": true,
                "required": true,
                "noExport": true,
                "alternateName": "alternateName",
                "mappingName": "mappingName",
                "valueEntry": {
                  "kind": "none"
                },
                "defaultValueEntry": {
                  "kind": "none"
                },
                "actions": {
                  "keystroke": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "format": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "validate": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "calculate": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  }
                },
                "groupId": "groupId",
                "createdBy": "createdBy",
                "createdAt": "2024-01-15T09:30:00.000Z",
                "filledBy": "filledBy",
                "filledByName": "filledByName",
                "filledAt": "2024-01-15T09:30:00.000Z",
                "importedBy": "importedBy",
                "widgets": [
                  {
                    "objectNumber": 1
                  }
                ],
                "value": "value",
                "defaultValue": "defaultValue",
                "maxLength": 1,
                "multiline": true,
                "password": true,
                "comb": true
              },
              "widgets": [
                {
                  "subtype": "widget",
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
                  "actions": {},
                  "box": {
                    "x": 1.1,
                    "y": 1.1,
                    "width": 1.1,
                    "height": 1.1
                  },
                  "rotation": 1.1,
                  "color": "color",
                  "interiorColor": "interiorColor",
                  "strokeWidth": 1.1,
                  "borderStyle": "solid",
                  "dashArray": [
                    1.1
                  ],
                  "fontFamily": "fontFamily",
                  "fontSize": 1.1,
                  "fontColor": "fontColor",
                  "textAlign": "left",
                  "caption": "caption",
                  "checkStyle": "check",
                  "field": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "fieldFamily": "text"
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
                    .WithPath("/v1/docs/docId/layers/layerName/form/fields/fieldKey/value")
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

        var response = await Client.Doc.Forms.SetValueAsync(
            new SetValueFormsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                FieldKey = "fieldKey",
                Body = new Dictionary<string, object?>() { { "key", "value" } },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
