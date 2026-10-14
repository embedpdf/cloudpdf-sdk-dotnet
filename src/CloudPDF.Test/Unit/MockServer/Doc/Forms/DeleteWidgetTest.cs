using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Forms;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class DeleteWidgetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "widget": {
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
                    .WithPath("/v1/docs/docId/layers/layerName/form/widgets/pageKey/annotKey")
                    .UsingDelete()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Forms.DeleteWidgetAsync(
            new DeleteWidgetFormsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                PageKey = "pageKey",
                AnnotKey = "annotKey",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "widget": {
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
                    .WithPath("/v1/docs/docId/layers/layerName/form/widgets/pageKey/annotKey")
                    .UsingDelete()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Forms.DeleteWidgetAsync(
            new DeleteWidgetFormsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                PageKey = "pageKey",
                AnnotKey = "annotKey",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
