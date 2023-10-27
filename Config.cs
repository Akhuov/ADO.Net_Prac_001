using System.Configuration;

namespace ADO.Net;

public class Config
{
    public static void CreateConfig()
    {
        var setting = new ConnectionStringSettings
        {
            Name = "config_01",
            ConnectionString = @"Server=WIN-F7NIMF7A3VO;
                                    Database=BootCamp_N7;
                                    Trusted_Connection=True;
                                    Pooling = True;"
        };
        Configuration config;
        config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        config.ConnectionStrings.ConnectionStrings.Add(setting);
        config.Save();
    }
}
