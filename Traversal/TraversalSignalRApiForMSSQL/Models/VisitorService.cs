using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using TraversalSignalRApiForMSSQL.DAL;
using TraversalSignalRApiForMSSQL.Hubs;

namespace TraversalSignalRApiForMSSQL.Models
{
    public class VisitorService
    {
        private readonly TraversalSignalRApiForMSSQLContext _traversalSignalRApiForMSSQLContext;
        private readonly IHubContext<VisitorHub> _hubContext;

        public VisitorService(TraversalSignalRApiForMSSQLContext traversalSignalRApiForMSSQLContext, IHubContext<VisitorHub> hubContext)
        {
            _traversalSignalRApiForMSSQLContext = traversalSignalRApiForMSSQLContext;
            _hubContext = hubContext;
        }

        public IQueryable<Visitor> GetList()
        {
            return _traversalSignalRApiForMSSQLContext.Visitors.AsQueryable();
        }

        public async Task SaveVisitor(Visitor visitor)
        {
            await _traversalSignalRApiForMSSQLContext.Visitors.AddAsync(visitor);
            await _traversalSignalRApiForMSSQLContext.SaveChangesAsync();
            await _hubContext.Clients.All.SendAsync("ReceiveVisitorList", GetVisitorChartList());
        }

        public List<VisitorChart> GetVisitorChartList()
        {
            List<VisitorChart> visitorCharts = new List<VisitorChart>();
            using (var command = _traversalSignalRApiForMSSQLContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "Select tarih,[1],[2],[3],[4],[5] from (select[City],VisitCount,Cast([Date] as Date) as tarih from Visitors) as visitTable Pivot (Sum(VisitCount) For City in([1],[2],[3],[4],[5])) as pivottable order by tarih asc";
                command.CommandType = System.Data.CommandType.Text;
                _traversalSignalRApiForMSSQLContext.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        VisitorChart visitorChart = new VisitorChart();
                        visitorChart.Date = reader.GetDateTime(0).ToShortDateString();
                        Enumerable.Range(1, 5).ToList().ForEach(x =>
                        {
                            if (DBNull.Value.Equals(reader[x]))
                            {
                                visitorChart.Counts.Add(0);
                            }
                            else
                            {
                                visitorChart.Counts.Add(reader.GetInt32(x));
                            }
                        });
                        visitorCharts.Add(visitorChart);
                    }
                }
                _traversalSignalRApiForMSSQLContext.Database.CloseConnection();
                return visitorCharts;
            }
        }
    }
}
