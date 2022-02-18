using Microsoft.Extensions.Configuration;

namespace StreamFile.Core.Configs
{
    public class SystemSettingModel
    {
        public static SystemSettingModel Instance { get; set; }

        public static IConfiguration Configs { get; set; }
        public string Domain { get; set; }
        public string Sentry { get; set; }

    }
  
    public class ClientSettingModel
    {
        public static ClientSettingModel Instance { get; set; }
        public string BaseUrlIp { get; set; }
        public string BaseUrlRegist { get; set; }
        public string BaseUrlPortal { get; set; }
        public string BaseUrlSso { get; set; }
    }
}
