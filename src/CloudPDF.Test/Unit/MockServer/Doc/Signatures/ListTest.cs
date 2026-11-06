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
                    "objectNumber": 1
                  },
                  "fieldName": "fieldName",
                  "widget": {
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
                  "contentsSizeBytes": 1,
                  "coverage": "whole-revision",
                  "revisionIndex": 1,
                  "signer": {
                    "name": "name",
                    "reason": "reason",
                    "location": "location",
                    "contactInfo": "contactInfo",
                    "signedAt": "2024-01-15T09:30:00.000Z"
                  },
                  "docMdp": 1,
                  "catalogCertification": true,
                  "fieldMdp": {
                    "action": "all",
                    "fields": [
                      "fields",
                      "fields"
                    ],
                    "permission": 1
                  },
                  "lock": {
                    "action": "all",
                    "fields": [
                      "fields",
                      "fields"
                    ],
                    "permission": 1
                  },
                  "seedValue": {
                    "parserVersion": 1,
                    "parserVersionRequired": true,
                    "mdp": 1,
                    "filter": "filter",
                    "filterRequired": true,
                    "subFilters": [
                      "subFilters",
                      "subFilters"
                    ],
                    "subFiltersRequired": true,
                    "digestMethods": [
                      "digestMethods",
                      "digestMethods"
                    ],
                    "digestMethodsRequired": true,
                    "reasons": [
                      "reasons",
                      "reasons"
                    ],
                    "reasonsRequired": true,
                    "unsupportedRequired": true
                  }
                },
                {
                  "index": 1,
                  "field": {
                    "kind": "objectNumber",
                    "objectNumber": 1
                  },
                  "fieldName": "fieldName",
                  "widget": {
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
                  "contentsSizeBytes": 1,
                  "coverage": "whole-revision",
                  "revisionIndex": 1,
                  "signer": {
                    "name": "name",
                    "reason": "reason",
                    "location": "location",
                    "contactInfo": "contactInfo",
                    "signedAt": "2024-01-15T09:30:00.000Z"
                  },
                  "docMdp": 1,
                  "catalogCertification": true,
                  "fieldMdp": {
                    "action": "all",
                    "fields": [
                      "fields",
                      "fields"
                    ],
                    "permission": 1
                  },
                  "lock": {
                    "action": "all",
                    "fields": [
                      "fields",
                      "fields"
                    ],
                    "permission": 1
                  },
                  "seedValue": {
                    "parserVersion": 1,
                    "parserVersionRequired": true,
                    "mdp": 1,
                    "filter": "filter",
                    "filterRequired": true,
                    "subFilters": [
                      "subFilters",
                      "subFilters"
                    ],
                    "subFiltersRequired": true,
                    "digestMethods": [
                      "digestMethods",
                      "digestMethods"
                    ],
                    "digestMethodsRequired": true,
                    "reasons": [
                      "reasons",
                      "reasons"
                    ],
                    "reasonsRequired": true,
                    "unsupportedRequired": true
                  }
                }
              ],
              "protection": {
                "enforced": "none",
                "judged": "none",
                "certification": {
                  "signatureIndex": 1,
                  "permission": 1
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
                      "permission": 1
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
                      "permission": 1
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
                    "objectNumber": 1
                  },
                  "fieldName": "fieldName",
                  "widget": {
                    "objectNumber": 1
                  },
                  "signed": true,
                  "kind": "signature",
                  "filter": "filter",
                  "subFilter": "subFilter",
                  "byteRange": [],
                  "contentsSizeBytes": 1,
                  "coverage": "whole-revision",
                  "revisionIndex": 1,
                  "signer": {},
                  "docMdp": 1,
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
                    "parserVersionRequired": true,
                    "filterRequired": true,
                    "subFilters": [
                      "subFilters"
                    ],
                    "subFiltersRequired": true,
                    "digestMethods": [
                      "digestMethods"
                    ],
                    "digestMethodsRequired": true,
                    "reasons": [
                      "reasons"
                    ],
                    "reasonsRequired": true,
                    "unsupportedRequired": true
                  }
                }
              ],
              "protection": {
                "enforced": "none",
                "judged": "none",
                "certification": {
                  "signatureIndex": 1,
                  "permission": 1
                },
                "fieldLocks": [
                  {
                    "signatureIndex": 1,
                    "source": "fieldmdp",
                    "spec": {
                      "action": "all",
                      "fields": [
                        "fields"
                      ]
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
}
