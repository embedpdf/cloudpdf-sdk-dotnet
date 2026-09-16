using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Signatures;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class AnalysisTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "mode": "authoritative",
              "policyVersion": 1,
              "basis": {
                "version": {
                  "sha256": "sha256",
                  "byteLength": 1
                },
                "editsVersion": 1,
                "source": "persisted"
              },
              "since": {
                "revisionIndex": 1,
                "signatureIndex": 1
              },
              "until": {
                "revisionIndex": 1
              },
              "restrictions": [
                {
                  "signatureIndex": 1,
                  "revisionIndex": 1,
                  "source": "docmdp",
                  "own": true,
                  "permission": 1.1,
                  "fields": {
                    "key": "value"
                  }
                },
                {
                  "signatureIndex": 1,
                  "revisionIndex": 1,
                  "source": "docmdp",
                  "own": true,
                  "permission": 1.1,
                  "fields": {
                    "key": "value"
                  }
                }
              ],
              "current": {
                "verdict": "unchanged",
                "complete": true,
                "primary": {
                  "rule": "rule",
                  "verdict": "permitted",
                  "objectNumber": 1,
                  "edge": "edge",
                  "detail": "detail"
                },
                "findings": [
                  {
                    "rule": "rule",
                    "verdict": "permitted",
                    "objectNumber": 1,
                    "edge": "edge",
                    "detail": "detail"
                  },
                  {
                    "rule": "rule",
                    "verdict": "permitted",
                    "objectNumber": 1,
                    "edge": "edge",
                    "detail": "detail"
                  }
                ],
                "method": "net-state"
              },
              "later": {
                "revisionCount": 1,
                "undoneObjectNumbers": [
                  1,
                  1
                ]
              },
              "verdict": "unchanged",
              "steps": [
                {
                  "key": "value"
                },
                {
                  "key": "value"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/signatures/analysis")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Signatures.AnalysisAsync(
            new AnalysisSignaturesRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "mode": "authoritative",
              "policyVersion": 1,
              "basis": {
                "version": {
                  "sha256": "sha256",
                  "byteLength": 1
                },
                "editsVersion": 1,
                "source": "persisted"
              },
              "since": {
                "revisionIndex": 1,
                "signatureIndex": 1
              },
              "until": {
                "revisionIndex": 1
              },
              "restrictions": [
                {
                  "signatureIndex": 1,
                  "revisionIndex": 1,
                  "source": "docmdp",
                  "own": true,
                  "permission": 1.1,
                  "fields": {
                    "key": "value"
                  }
                }
              ],
              "current": {
                "verdict": "unchanged",
                "complete": true,
                "primary": {
                  "rule": "rule",
                  "verdict": "permitted",
                  "objectNumber": 1,
                  "edge": "edge",
                  "detail": "detail"
                },
                "findings": [
                  {
                    "rule": "rule",
                    "verdict": "permitted",
                    "objectNumber": 1
                  }
                ],
                "method": "net-state"
              },
              "later": {
                "revisionCount": 1,
                "undoneObjectNumbers": [
                  1
                ]
              },
              "verdict": "unchanged",
              "steps": [
                {
                  "key": "value"
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/signatures/analysis")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Signatures.AnalysisAsync(
            new AnalysisSignaturesRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
