namespace EShop.Catalog.Domain.Dto;

public class DataAccessConfiguration
{
    public string ConnectionString { get; }

    public DataAccessConfiguration(string connectionString)
    {
        ConnectionString = connectionString;
    }
}