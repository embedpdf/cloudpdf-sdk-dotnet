using CloudPDF.Doc;
using CloudPDF.Test.Unit.MockServer;
using CloudPDF.Test.Utils;
using NUnit.Framework;

namespace CloudPDF.Test.Unit.MockServer.Doc.Versions;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "head": "head",
              "versions": [
                {
                  "sha256": "sha256",
                  "byteLength": 1,
                  "number": 1,
                  "parentSha256": "parentSha256",
                  "producer": "upload",
                  "signingId": "signingId",
                  "createdAt": 1
                },
                {
                  "sha256": "sha256",
                  "byteLength": 1,
                  "number": 1,
                  "parentSha256": "parentSha256",
                  "producer": "upload",
                  "signingId": "signingId",
                  "createdAt": 1
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/versions")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Versions.ListAsync(
            new ListVersionsRequest { DocId = "docId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "head": "head",
              "versions": [
                {
                  "sha256": "sha256",
                  "byteLength": 1,
                  "number": 1,
                  "parentSha256": "parentSha256",
                  "producer": "upload",
                  "signingId": "signingId",
                  "createdAt": 1
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/docs/docId/versions")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Doc.Versions.ListAsync(
            new ListVersionsRequest { DocId = "docId" }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
