using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Pages;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ViewportsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            [
              {
                "bbox": {
                  "left": 1.1,
                  "bottom": 1.1,
                  "right": 1.1,
                  "top": 1.1
                },
                "name": "name",
                "measure": {
                  "subtype": "RL",
                  "ratio": "ratio",
                  "x": [
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    },
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    }
                  ],
                  "y": [
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    },
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    }
                  ],
                  "distance": [
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    },
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    }
                  ],
                  "area": [
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    },
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    }
                  ],
                  "angle": [
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    },
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    }
                  ],
                  "slope": [
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    },
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    }
                  ],
                  "origin": {
                    "x": 1.1,
                    "y": 1.1
                  },
                  "cyx": 1.1
                },
                "owned": true
              },
              {
                "bbox": {
                  "left": 1.1,
                  "bottom": 1.1,
                  "right": 1.1,
                  "top": 1.1
                },
                "name": "name",
                "measure": {
                  "subtype": "RL",
                  "ratio": "ratio",
                  "x": [
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    },
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    }
                  ],
                  "y": [
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    },
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    }
                  ],
                  "distance": [
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    },
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    }
                  ],
                  "area": [
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    },
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    }
                  ],
                  "angle": [
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    },
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    }
                  ],
                  "slope": [
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    },
                    {
                      "unit": "unit",
                      "conversion": 1.1,
                      "fraction": "decimal",
                      "precision": 1,
                      "fixed": true,
                      "thousands": "thousands",
                      "decimal": "decimal",
                      "prefixSpacing": "prefixSpacing",
                      "suffixSpacing": "suffixSpacing",
                      "labelPosition": "suffix"
                    }
                  ],
                  "origin": {
                    "x": 1.1,
                    "y": 1.1
                  },
                  "cyx": 1.1
                },
                "owned": true
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/pages/1/viewports")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Pages.ViewportsAsync(
            new ViewportsPagesRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Pon = 1,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            [
              {
                "bbox": {
                  "left": 1.1,
                  "bottom": 1.1,
                  "right": 1.1,
                  "top": 1.1
                },
                "name": "name",
                "measure": {
                  "subtype": "RL",
                  "ratio": "ratio",
                  "x": [
                    {
                      "unit": "unit"
                    }
                  ],
                  "y": [
                    {
                      "unit": "unit"
                    }
                  ],
                  "distance": [
                    {
                      "unit": "unit"
                    }
                  ],
                  "area": [
                    {
                      "unit": "unit"
                    }
                  ],
                  "angle": [
                    {
                      "unit": "unit"
                    }
                  ],
                  "slope": [
                    {
                      "unit": "unit"
                    }
                  ],
                  "origin": {
                    "x": 1.1,
                    "y": 1.1
                  },
                  "cyx": 1.1
                },
                "owned": true
              }
            ]
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/pages/1/viewports")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Pages.ViewportsAsync(
            new ViewportsPagesRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                Pon = 1,
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
