using CloudPDF;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class HeadTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "id": "id",
              "baseSha256": "baseSha256",
              "sizeBytes": 1,
              "docVersion": 1,
              "state": "pending",
              "encryption": {
                "state": "unknown",
                "requiresPassword": true
              },
              "permissions": {
                "known": true,
                "flags": {
                  "print": true,
                  "modifyContents": true,
                  "copy": true,
                  "modifyAnnotations": true,
                  "fillForms": true,
                  "copyForAccessibility": true,
                  "assemble": true,
                  "printHighQuality": true
                },
                "allAllowed": true,
                "openedAs": "none",
                "securityHandlerRevision": 1,
                "canUpgradeToOwner": true
              },
              "access": {
                "required": true,
                "reasons": [
                  "password",
                  "password"
                ],
                "endpoint": "endpoint"
              },
              "engine": {
                "engine": "engine"
              }
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/v1/docs/docId/head").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.HeadAsync(new HeadDocRequest { DocId = "docId" });
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "id": "id",
              "baseSha256": "baseSha256",
              "sizeBytes": 1,
              "docVersion": 1,
              "state": "pending",
              "encryption": {
                "state": "unknown",
                "requiresPassword": true
              },
              "permissions": {
                "known": true,
                "flags": {
                  "print": true,
                  "modifyContents": true,
                  "copy": true,
                  "modifyAnnotations": true,
                  "fillForms": true,
                  "copyForAccessibility": true,
                  "assemble": true,
                  "printHighQuality": true
                },
                "allAllowed": true,
                "openedAs": "none",
                "securityHandlerRevision": 1,
                "canUpgradeToOwner": true
              },
              "access": {
                "required": true,
                "reasons": [
                  "password"
                ],
                "endpoint": "endpoint"
              },
              "engine": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock.RequestBuilders.Request.Create().WithPath("/v1/docs/docId/head").UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.HeadAsync(new HeadDocRequest { DocId = "docId" });
        JsonAssert.AreEqual(response, mockResponse);
    }
}
