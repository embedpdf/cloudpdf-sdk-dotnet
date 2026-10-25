using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Outline;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class GetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "items": [
                {
                  "ref": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "parent": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "title": "title",
                  "target": {
                    "kind": "goto",
                    "destination": {
                      "kind": "xyz",
                      "page": {
                        "kind": "objectNumber",
                        "objectNumber": 1
                      },
                      "x": 1.1,
                      "y": 1.1,
                      "zoom": 1.1
                    }
                  },
                  "action": {
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
                  "open": true,
                  "color": "color",
                  "bold": true,
                  "italic": true
                },
                {
                  "ref": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "parent": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "title": "title",
                  "target": {
                    "kind": "goto",
                    "destination": {
                      "kind": "xyz",
                      "page": {
                        "kind": "objectNumber",
                        "objectNumber": 1
                      },
                      "x": 1.1,
                      "y": 1.1,
                      "zoom": 1.1
                    }
                  },
                  "action": {
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
                  "open": true,
                  "color": "color",
                  "bold": true,
                  "italic": true
                }
              ],
              "incomplete": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/outline")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Outline.GetAsync(
            new GetOutlineRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "items": [
                {
                  "ref": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "parent": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "title": "title",
                  "target": {
                    "kind": "goto",
                    "destination": {
                      "kind": "xyz",
                      "page": {
                        "kind": "objectNumber",
                        "objectNumber": 1
                      }
                    }
                  },
                  "action": {
                    "incomplete": true,
                    "warningFlags": 1,
                    "warnings": [
                      "cycle-dropped"
                    ]
                  },
                  "open": true,
                  "color": "color",
                  "bold": true,
                  "italic": true
                }
              ],
              "incomplete": true
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/outline")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Outline.GetAsync(
            new GetOutlineRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
