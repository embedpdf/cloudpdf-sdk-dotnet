using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Forms;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "formKind": "none",
              "needsAppearances": true,
              "fields": [
                {
                  "family": "text",
                  "ref": {
                    "kind": "objectNumber",
                    "fieldObjectNumber": 1
                  },
                  "fieldObjectNumber": 1,
                  "name": "name",
                  "origin": "acroform",
                  "flags": {
                    "readOnly": true,
                    "required": true,
                    "noExport": true,
                    "raw": 1
                  },
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
                  "widgets": [
                    {
                      "annotObjectNumber": 1,
                      "pageObjectNumber": 1
                    },
                    {
                      "annotObjectNumber": 1,
                      "pageObjectNumber": 1
                    }
                  ],
                  "value": "value",
                  "defaultValue": "defaultValue",
                  "maxLength": 1,
                  "multiline": true,
                  "password": true,
                  "comb": true
                },
                {
                  "family": "text",
                  "ref": {
                    "kind": "objectNumber",
                    "fieldObjectNumber": 1
                  },
                  "fieldObjectNumber": 1,
                  "name": "name",
                  "origin": "acroform",
                  "flags": {
                    "readOnly": true,
                    "required": true,
                    "noExport": true,
                    "raw": 1
                  },
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
                  "widgets": [
                    {
                      "annotObjectNumber": 1,
                      "pageObjectNumber": 1
                    },
                    {
                      "annotObjectNumber": 1,
                      "pageObjectNumber": 1
                    }
                  ],
                  "value": "value",
                  "defaultValue": "defaultValue",
                  "maxLength": 1,
                  "multiline": true,
                  "password": true,
                  "comb": true
                }
              ],
              "calculationOrder": [
                {
                  "kind": "objectNumber",
                  "fieldObjectNumber": 1
                },
                {
                  "kind": "objectNumber",
                  "fieldObjectNumber": 1
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/form")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Forms.GetAsync(
            new GetFormsRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "formKind": "none",
              "needsAppearances": true,
              "fields": [
                {
                  "family": "text",
                  "ref": {
                    "kind": "objectNumber",
                    "fieldObjectNumber": 1
                  },
                  "fieldObjectNumber": 1,
                  "name": "name",
                  "origin": "acroform",
                  "flags": {
                    "readOnly": true,
                    "required": true,
                    "noExport": true,
                    "raw": 1
                  },
                  "alternateName": "alternateName",
                  "mappingName": "mappingName",
                  "valueEntry": {
                    "kind": "none"
                  },
                  "defaultValueEntry": {
                    "kind": "none"
                  },
                  "widgets": [
                    {
                      "annotObjectNumber": 1,
                      "pageObjectNumber": 1
                    }
                  ],
                  "value": "value",
                  "defaultValue": "defaultValue",
                  "maxLength": 1,
                  "multiline": true,
                  "password": true,
                  "comb": true
                }
              ],
              "calculationOrder": [
                {
                  "kind": "objectNumber",
                  "fieldObjectNumber": 1
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/form")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Forms.GetAsync(
            new GetFormsRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
