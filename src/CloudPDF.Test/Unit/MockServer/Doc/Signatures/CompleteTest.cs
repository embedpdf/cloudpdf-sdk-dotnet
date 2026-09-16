using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Signatures;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class CompleteTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string requestJson = """
            {
              "cms": "cms",
              "expectedVersion": {
                "baseSha256": "baseSha256",
                "editsVersion": 1
              }
            }
            """;

        const string mockResponse = """
            {
              "status": "completed",
              "signature": {
                "index": 1,
                "field": {
                  "kind": "objectNumber",
                  "fieldObjectNumber": 1
                },
                "fieldName": "fieldName",
                "widget": {
                  "annotObjectNumber": 1,
                  "pageObjectNumber": 1
                },
                "signed": true,
                "kind": "signature",
                "filter": "filter",
                "subFilter": "subFilter",
                "byteRange": [
                  {
                    "key": "value"
                  },
                  {
                    "key": "value"
                  }
                ],
                "contentsSize": 1,
                "coverage": "whole-revision",
                "revisionIndex": 1,
                "signer": {
                  "name": "name",
                  "reason": "reason",
                  "location": "location",
                  "contactInfo": "contactInfo",
                  "claimedTime": "claimedTime"
                },
                "docMdp": 1.1,
                "catalogCertification": true,
                "fieldMdp": {
                  "action": "all",
                  "fields": [
                    "fields",
                    "fields"
                  ],
                  "permission": 1.1
                },
                "lock": {
                  "action": "all",
                  "fields": [
                    "fields",
                    "fields"
                  ],
                  "permission": 1.1
                },
                "seedValue": {
                  "requiredFlags": 1,
                  "presentFlags": 1,
                  "version": 1,
                  "mdp": 1.1,
                  "filter": "filter",
                  "subFilters": [
                    "subFilters",
                    "subFilters"
                  ],
                  "digestMethods": [
                    "digestMethods",
                    "digestMethods"
                  ],
                  "reasons": [
                    "reasons",
                    "reasons"
                  ],
                  "unsupportedRequired": true
                }
              },
              "version": {
                "sha256": "sha256",
                "byteLength": 1
              },
              "previous": {
                "baseSha256": "baseSha256",
                "editsVersion": 1
              },
              "protection": {
                "enforced": "none",
                "judged": "none",
                "certification": {
                  "signatureIndex": 1,
                  "permission": 1.1
                },
                "fieldLocks": [
                  {
                    "signatureIndex": 1,
                    "source": "fieldmdp",
                    "spec": {
                      "action": "all",
                      "fields": [
                        "fields",
                        "fields"
                      ],
                      "permission": 1.1
                    }
                  },
                  {
                    "signatureIndex": 1,
                    "source": "fieldmdp",
                    "spec": {
                      "action": "all",
                      "fields": [
                        "fields",
                        "fields"
                      ],
                      "permission": 1.1
                    }
                  }
                ],
                "policyVersion": 1
              },
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
                  "annotationsVersion": 1,
                  "layerVersion": 1,
                  "working": true,
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
                    .WithPath("/v1/docs/docId/layers/layerName/signatures/signingId/complete")
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

        var response = await Client.Doc.Signatures.CompleteAsync(
            new DocSignaturesCompleteRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                SigningId = "signingId",
                Cms = "cms",
                ExpectedVersion = new DocSignaturesCompleteRequestExpectedVersion
                {
                    BaseSha256 = "baseSha256",
                    EditsVersion = 1,
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
              "cms": "cms",
              "expectedVersion": {
                "baseSha256": "baseSha256",
                "editsVersion": 1
              }
            }
            """;

        const string mockResponse = """
            {
              "status": "completed",
              "signature": {
                "index": 1,
                "field": {
                  "kind": "objectNumber",
                  "fieldObjectNumber": 1
                },
                "fieldName": "fieldName",
                "widget": {
                  "annotObjectNumber": 1,
                  "pageObjectNumber": 1
                },
                "signed": true,
                "kind": "signature",
                "filter": "filter",
                "subFilter": "subFilter",
                "byteRange": [
                  {
                    "key": "value"
                  }
                ],
                "contentsSize": 1,
                "coverage": "whole-revision",
                "revisionIndex": 1,
                "signer": {
                  "name": "name",
                  "reason": "reason",
                  "location": "location",
                  "contactInfo": "contactInfo",
                  "claimedTime": "claimedTime"
                },
                "docMdp": 1.1,
                "catalogCertification": true,
                "fieldMdp": {
                  "action": "all",
                  "fields": [
                    "fields"
                  ],
                  "permission": 1.1
                },
                "lock": {
                  "action": "all",
                  "fields": [
                    "fields"
                  ],
                  "permission": 1.1
                },
                "seedValue": {
                  "requiredFlags": 1,
                  "presentFlags": 1,
                  "version": 1,
                  "mdp": 1.1,
                  "filter": "filter",
                  "subFilters": [
                    "subFilters"
                  ],
                  "digestMethods": [
                    "digestMethods"
                  ],
                  "reasons": [
                    "reasons"
                  ],
                  "unsupportedRequired": true
                }
              },
              "version": {
                "sha256": "sha256",
                "byteLength": 1
              },
              "previous": {
                "baseSha256": "baseSha256",
                "editsVersion": 1
              },
              "protection": {
                "enforced": "none",
                "judged": "none",
                "certification": {
                  "signatureIndex": 1,
                  "permission": 1.1
                },
                "fieldLocks": [
                  {
                    "signatureIndex": 1,
                    "source": "fieldmdp"
                  }
                ],
                "policyVersion": 1
              },
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
                  "annotationsVersion": 1,
                  "layerVersion": 1,
                  "working": true,
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
                    .WithPath("/v1/docs/docId/layers/layerName/signatures/signingId/complete")
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

        var response = await Client.Doc.Signatures.CompleteAsync(
            new DocSignaturesCompleteRequest
            {
                DocId = "docId",
                LayerName = "layerName",
                SigningId = "signingId",
                Cms = "cms",
                ExpectedVersion = new DocSignaturesCompleteRequestExpectedVersion
                {
                    BaseSha256 = "baseSha256",
                    EditsVersion = 1,
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
