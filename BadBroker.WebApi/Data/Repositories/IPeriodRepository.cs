namespace BadBroker.WebApi.Data.Repositories
{
    public interface IPeriodRepository
    {
        public Task<string> GetHistoricalRates(DateTimeOffset stardate, DateTimeOffset endDate, CurrencyType currencyType);
    }
}
