using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Deployment;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ModulesTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "modules": [
                {
                  "id": "id",
                  "name": "name",
                  "description": "description",
                  "permissions": [
                    {
                      "name": "name",
                      "level": "document",
                      "label": "label",
                      "description": "description",
                      "replaces": "replaces",
                      "bypassedBy": [
                        "bypassedBy",
                        "bypassedBy"
                      ]
                    },
                    {
                      "name": "name",
                      "level": "document",
                      "label": "label",
                      "description": "description",
                      "replaces": "replaces",
                      "bypassedBy": [
                        "bypassedBy",
                        "bypassedBy"
                      ]
                    }
                  ],
                  "meters": [
                    {
                      "name": "name",
                      "label": "label",
                      "unit": "unit",
                      "description": "description"
                    },
                    {
                      "name": "name",
                      "label": "label",
                      "unit": "unit",
                      "description": "description"
                    }
                  ],
                  "requires": {
                    "document": [
                      "document",
                      "document"
                    ]
                  }
                },
                {
                  "id": "id",
                  "name": "name",
                  "description": "description",
                  "permissions": [
                    {
                      "name": "name",
                      "level": "document",
                      "label": "label",
                      "description": "description",
                      "replaces": "replaces",
                      "bypassedBy": [
                        "bypassedBy",
                        "bypassedBy"
                      ]
                    },
                    {
                      "name": "name",
                      "level": "document",
                      "label": "label",
                      "description": "description",
                      "replaces": "replaces",
                      "bypassedBy": [
                        "bypassedBy",
                        "bypassedBy"
                      ]
                    }
                  ],
                  "meters": [
                    {
                      "name": "name",
                      "label": "label",
                      "unit": "unit",
                      "description": "description"
                    },
                    {
                      "name": "name",
                      "label": "label",
                      "unit": "unit",
                      "description": "description"
                    }
                  ],
                  "requires": {
                    "document": [
                      "document",
                      "document"
                    ]
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/deployment/modules")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Deployment.ModulesAsync();
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "modules": [
                {
                  "id": "id",
                  "name": "name",
                  "description": "description",
                  "permissions": [
                    {
                      "name": "name",
                      "level": "document",
                      "label": "label"
                    }
                  ],
                  "meters": [
                    {
                      "name": "name",
                      "label": "label",
                      "unit": "unit"
                    }
                  ],
                  "requires": {
                    "document": [
                      "document"
                    ]
                  }
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/deployment/modules")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Deployment.ModulesAsync();
        JsonAssert.AreEqual(response, mockResponse);
    }
}
