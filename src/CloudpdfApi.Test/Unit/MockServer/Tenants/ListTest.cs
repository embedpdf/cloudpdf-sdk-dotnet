using CloudpdfApi;
using CloudpdfApi.Test.Unit.MockServer;
using CloudpdfApi.Test.Utils;
using NUnit.Framework;

namespace CloudpdfApi.Test.Unit.MockServer.Tenants;

[TestFixture]
[Parallelizable(ParallelScope.Self)]
public class ListTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest_1()
    {
        const string mockResponse = """
            {
              "tenants": [
                {
                  "id": "id",
                  "name": "name",
                  "autoProvisioned": true,
                  "createdAt": 1.1
                },
                {
                  "id": "id",
                  "name": "name",
                  "autoProvisioned": true,
                  "createdAt": 1.1
                }
              ],
              "nextCursor": "nextCursor"
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/v1/tenants").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Tenants.ListAsync(new ListTenantsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }

    [NUnit.Framework.Test]
    public async Task MockServerTest_2()
    {
        const string mockResponse = """
            {
              "tenants": [
                {
                  "id": "id",
                  "name": "name",
                  "autoProvisioned": true,
                  "createdAt": 1.1
                }
              ],
              "nextCursor": "nextCursor"
            }
            """;

        Server
            .Given(WireMock.RequestBuilders.Request.Create().WithPath("/v1/tenants").UsingGet())
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.Tenants.ListAsync(new ListTenantsRequest());
        JsonAssert.AreEqual(response, mockResponse);
    }
}
