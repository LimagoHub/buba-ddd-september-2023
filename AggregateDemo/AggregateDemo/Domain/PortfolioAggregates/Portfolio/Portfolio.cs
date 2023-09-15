using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateDemo.Domain.PortfolioAggregates.Portfolio
{
    public class Portfolio
    {
        private IEnumerable<Position> positions = new List<Position>();
        public IEnumerable<Position> Positions
        {
            get
            {
                return new ReadOnlyCollection<Position>(positions);
            }

        }
    }
}
