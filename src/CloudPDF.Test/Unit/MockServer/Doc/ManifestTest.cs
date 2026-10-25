using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ManifestTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "docVersion": 1,
              "layoutVersion": 1,
              "metadataVersion": 1,
              "actionsVersion": 1,
              "attachmentsVersion": 1,
              "annotationsVersion": 1,
              "formsVersion": 1,
              "outlineVersion": 1,
              "auditHead": 1,
              "baseSha": "baseSha",
              "layerVersion": 1,
              "working": true,
              "baseByteLength": 1,
              "scopes": {
                "content": "base",
                "annotations": "base",
                "forms": "base",
                "layout": "base",
                "attachments": "base",
                "metadata": "base",
                "actions": "base",
                "outline": "base"
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/manifest")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.ManifestAsync(
            new ManifestDocRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "docVersion": 1,
              "layoutVersion": 1,
              "metadataVersion": 1,
              "actionsVersion": 1,
              "attachmentsVersion": 1,
              "annotationsVersion": 1,
              "formsVersion": 1,
              "outlineVersion": 1,
              "auditHead": 1,
              "baseSha": "baseSha",
              "layerVersion": 1,
              "working": true,
              "baseByteLength": 1,
              "scopes": {
                "content": "base",
                "annotations": "base",
                "forms": "base",
                "layout": "base",
                "attachments": "base",
                "metadata": "base",
                "actions": "base",
                "outline": "base"
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
                        "fields"
                      ]
                    }
                  }
                ],
                "policyVersion": 1
              },
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
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/layers/layerName/manifest")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.ManifestAsync(
            new ManifestDocRequest { DocId = "docId", LayerName = "layerName" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
