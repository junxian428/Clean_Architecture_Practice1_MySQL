using Project5.Api;

CreateHostBuilder(args).Build().Run();

IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureWebHostDefaults(webBuilder =>
        {
            webBuilder
                // TODO: Remove this line if you want to return the Server header
                .ConfigureKestrel(config => config.AddServerHeader = false)
                .UseStartup<Startup>();
        });
