using NotificationScheduler.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Text;


namespace NotificationScheduler.Business.Market.Factory
{
    public static class MarketFactory
    {
        public static IMarketFactory GetMarketFactory(NotificationSchedulerContext context, NotificationScheduler.Domain.Enum.Market market)
        {
            if (market == Domain.Enum.Market.Denmark)
            {
                return new DenmarkMarket(context);
            }
            else if (market == Domain.Enum.Market.Finland)
            {
                return new FinlandMarket(context);
            }
            else if (market == Domain.Enum.Market.Norway)
            {
                return new NorwayMarket(context);
            }
            else if (market == Domain.Enum.Market.Sweden)
            {
                return new SwedenMarket(context);
            }
            else
            {
                throw new Exception("Market code not found ");
            }
        }
    }
}
