using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Signatures;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "chainValid": true,
              "revisions": [
                {
                  "index": 1,
                  "end": 1,
                  "xrefOffset": 1,
                  "signatureIndex": 1
                },
                {
                  "index": 1,
                  "end": 1,
                  "xrefOffset": 1,
                  "signatureIndex": 1
                }
              ],
              "signatures": [
                {
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
                {
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
                }
              ],
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
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/signatures")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Signatures.ListAsync(
            new ListSignaturesRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "chainValid": true,
              "revisions": [
                {
                  "index": 1,
                  "end": 1,
                  "xrefOffset": 1,
                  "signatureIndex": 1
                }
              ],
              "signatures": [
                {
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
                  "byteRange": [],
                  "contentsSize": 1,
                  "coverage": "whole-revision",
                  "revisionIndex": 1,
                  "signer": {},
                  "docMdp": 1.1,
                  "catalogCertification": true,
                  "fieldMdp": {
                    "action": "all",
                    "fields": [
                      "fields"
                    ]
                  },
                  "lock": {
                    "action": "all",
                    "fields": [
                      "fields"
                    ]
                  },
                  "seedValue": {
                    "requiredFlags": 1,
                    "presentFlags": 1,
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
                }
              ],
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
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/signatures")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Signatures.ListAsync(
            new ListSignaturesRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
