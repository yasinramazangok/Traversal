using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.SignalR;
using TraversalSignalRApi.Hubs;
using TraversalSignalRApi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalSignalRApi.Model
{
    public class VisitorService
    {
        private readonly TraversalSignalRApiContext _traversalSignalRApiContext;
        private readonly IHubContext<VisitorHub> _hubContext;

        public VisitorService(TraversalSignalRApiContext traversalSignalRApiContext, IHubContext<VisitorHub> hubContext)
        {
            _traversalSignalRApiContext = traversalSignalRApiContext;
            _hubContext = hubContext;
        }

        public IQueryable<Visitor> GetList()
        {
            return _traversalSignalRApiContext.Visitors.AsQueryable();
        }

        public async Task SaveVisitor(Visitor visitor)
        {
            await _traversalSignalRApiContext.Visitors.AddAsync(visitor);
            await _traversalSignalRApiContext.SaveChangesAsync();
            await _hubContext.Clients.All.SendAsync("CallVisitorList", "deneme");
        }

        public List<VisitorChart> GetVisitorChartList()
        {
            List<VisitorChart> visitorCharts = new List<VisitorChart>();
            using (var command = _traversalSignalRApiContext.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "Select * From crosstab ( 'Select Date,City,VisitCount From Visitors Order By 1, 2') As ct(Date date,City1 int, City2 int, City3 int, City4 int, City5 int);";
                command.CommandType = System.Data.CommandType.Text;
                _traversalSignalRApiContext.Database.OpenConnection();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        VisitorChart visitorChart = new VisitorChart();
                        visitorChart.Date = reader.GetDateTime(0).ToShortDateString();
                        Enumerable.Range(1, 5).ToList().ForEach(x =>
                        {
                            visitorChart.Counts.Add(reader.GetInt32(x));
                        });
                        visitorCharts.Add(visitorChart);
                    }
                }
                _traversalSignalRApiContext.Database.CloseConnection();
                return visitorCharts;
            }
        }
    }
}
