using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalSignalRApi.Model
{
    public class VisitorChart
    {
        public VisitorChart()
        {
            Counts = new List<int>();
        }

        public string Date { get; set; }

        public List<int> Counts { get; set; }
    }
}
