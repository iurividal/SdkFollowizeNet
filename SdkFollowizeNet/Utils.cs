using Microsoft.Extensions.Configuration;

namespace SdkFollowizeNet
{
    public static class Utils
    {
        public static string GetBrandId(this string marca)
        {
            switch (marca.ToUpper())
            {
                case "MARCA1":
                    return ((int)Brand.Marca1).ToString();
                case "MARCA2":
                    return ((int)Brand.Marca2).ToString();
                default:
                    throw new Exception("Marca não implementada");
            }

        }

        public static IConfiguration Config()
        {
            var configurationBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "jsconfig.json");
            var configuration = configurationBuilder.AddJsonFile(path, false);
            return configurationBuilder.Build();
        }

        public static string GetKeyTeam(string team)
        {
            var item = Config().GetSection("Teamkey").AsEnumerable().ToArray();

            return item.FirstOrDefault(a => a.Key.ToUpper().Contains(team.ToUpper())).Value;


            ;
        }
    }
}
