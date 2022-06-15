namespace EShopCore.DAL.Dto;

public class DataAccessLayerConfiguration
{
    public string ConnectionString { get; }

    public DataAccessLayerConfiguration(string connectionString)
    {
        ConnectionString = connectionString;
    }
}