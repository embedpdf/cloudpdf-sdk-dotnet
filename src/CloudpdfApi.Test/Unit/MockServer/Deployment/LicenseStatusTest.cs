using CloudpdfApi.Test.Unit.MockServer;
using CloudpdfApi.Test.Utils;
using NUnit.Framework;

namespace CloudpdfApi.Test.Unit.MockServer.Deployment;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class LicenseStatusTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "license": {
                "key": "value"
              },
              "reporting": {
                "key": "value"
              },
              "usage": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/deployment/license/status")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Deployment.LicenseStatusAsync();
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "license": {
                "key": "value"
              },
              "reporting": {
                "key": "value"
              },
              "usage": {
                "key": "value"
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/v1/deployment/license/status")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Deployment.LicenseStatusAsync();
        JsonAssert.AreEqual(response, mockResponse);
    }
}
