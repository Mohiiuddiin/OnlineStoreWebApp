using OnlineStore.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace OnlineStore.Core.Contracts
{
    public interface IBusketManager
    {
        void AddBusket(HttpContextBase httpContext, string productId);
        void RemoveBusket(HttpContextBase httpContext, string itemId);
        List<BusketItemView> GetBusketItems(HttpContextBase httpContextBase);
        BusketSummaryView GetBusketSummary(HttpContextBase httpContextBase);
    }
}
