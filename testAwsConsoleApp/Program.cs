using Microsoft.Extensions.Configuration;

namespace testAwsConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfigurationBuilder configBuilder = new ConfigurationBuilder().AddJsonFile("appsettings.json");
            IConfiguration configuration = configBuilder.Build();

            var cloudwatchParam = new AWSCloudWatch(configuration);

            cloudwatchParam.TimerStart();
        }

    }
}


