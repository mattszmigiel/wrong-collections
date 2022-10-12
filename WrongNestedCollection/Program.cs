using WrongNestedCollection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCrystallizeClient()
    .ConfigureHttpClient(client => { 
        client.BaseAddress = new Uri("https://pim.crystallize.com/graphql");
        client.DefaultRequestHeaders.Add("X-Crystallize-Access-Token-Id", "");
        client.DefaultRequestHeaders.Add("X-Crystallize-Access-Token-Secret", "");
    });

var app = builder.Build();

app.MapGet("/", async (CrystallizeClient crystallizeClient) =>
{
    var result = await crystallizeClient.GetCustomerSubscriptions.ExecuteAsync("", "");
    var meteredVariables = result.Data.SubscriptionContract.GetMany.Edges.Select(x => x.Node).Select(x => x.Recurring.MeteredVariables);
    return true;
});


app.Run();