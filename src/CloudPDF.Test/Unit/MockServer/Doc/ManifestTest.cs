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
              "auditHead": 1,
              "baseSha": "baseSha",
              "scopes": {
                "content": "base",
                "annotations": "base",
                "layout": "base",
                "attachments": "base",
                "metadata": "base",
                "actions": "base"
              },
              "pages": [
                {
                  "state": {
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
                  "cache": {
                    "contentVersion": 1,
                    "annotationVersion": 1
                  }
                },
                {
                  "state": {
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
                  "cache": {
                    "contentVersion": 1,
                    "annotationVersion": 1
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
              "auditHead": 1,
              "baseSha": "baseSha",
              "scopes": {
                "content": "base",
                "annotations": "base",
                "layout": "base",
                "attachments": "base",
                "metadata": "base",
                "actions": "base"
              },
              "pages": [
                {
                  "state": {
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
                  "cache": {
                    "contentVersion": 1,
                    "annotationVersion": 1
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
