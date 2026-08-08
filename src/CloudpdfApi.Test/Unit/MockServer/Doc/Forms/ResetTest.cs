using CloudpdfApi.Doc;
using CloudpdfApi.Test.Unit.MockServer;
using CloudpdfApi.Test.Utils;
using NUnit.Framework;

namespace CloudpdfApi.Test.Unit.MockServer.Doc.Forms;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ResetTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "meta": {
                "affectedPages": [
                  {
                    "pageObjectNumber": 1,
                    "revision": {
                      "docSessionId": "docSessionId",
                      "pageObjectNumber": 1,
                      "generation": 1
                    },
                    "weakAnnotationState": {
                      "kind": "unknown"
                    }
                  },
                  {
                    "pageObjectNumber": 1,
                    "revision": {
                      "docSessionId": "docSessionId",
                      "pageObjectNumber": 1,
                      "generation": 1
                    },
                    "weakAnnotationState": {
                      "kind": "unknown"
                    }
                  }
                ],
                "cacheDelta": {
                  "previousDocVersion": 1,
                  "docVersion": 1,
                  "pages": [
                    {
                      "pageObjectNumber": 1,
                      "cache": {
                        "contentVersion": 1,
                        "annotationVersion": 1
                      }
                    },
                    {
                      "pageObjectNumber": 1,
                      "cache": {
                        "contentVersion": 1,
                        "annotationVersion": 1
                      }
                    }
                  ]
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/form/fields/fieldKey/reset")
                    .UsingPost()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Forms.ResetAsync(
            new ResetFormsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                FieldKey = "fieldKey",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "meta": {
                "affectedPages": [
                  {
                    "pageObjectNumber": 1,
                    "revision": {
                      "docSessionId": "docSessionId",
                      "pageObjectNumber": 1,
                      "generation": 1
                    },
                    "weakAnnotationState": {
                      "kind": "unknown"
                    }
                  }
                ],
                "cacheDelta": {
                  "previousDocVersion": 1,
                  "docVersion": 1,
                  "pages": [
                    {
                      "pageObjectNumber": 1,
                      "cache": {
                        "contentVersion": 1,
                        "annotationVersion": 1
                      }
                    }
                  ]
                }
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/form/fields/fieldKey/reset")
                    .UsingPost()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Forms.ResetAsync(
            new ResetFormsRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                FieldKey = "fieldKey",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
