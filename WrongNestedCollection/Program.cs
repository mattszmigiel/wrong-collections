
using WrongNestedCollection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddTestClient()
    .ConfigureHttpClient(client => { 
        client.BaseAddress = new Uri("https://localhost:7089/graphql/");
    });

var app = builder.Build();

app.MapGet("/", async (TestClient testClient) =>
{
    var result = await testClient.GetEntities.ExecuteAsync();
    return true;
});


app.Run();