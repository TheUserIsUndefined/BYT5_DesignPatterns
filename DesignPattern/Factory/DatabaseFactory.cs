namespace DesignPattern.Factory
{
    public static class DatabaseFactory
    {
        public static IDatabase CreateDatabase(DatabaseType databaseType)
        {
            return databaseType switch
            {
                DatabaseType.Oracle => new OracleDatabase(),
                DatabaseType.SqlServer => new SqlServerDatabase(),
                _ => throw new ArgumentOutOfRangeException(nameof(databaseType), databaseType, null)
            };
        }
    }
}
