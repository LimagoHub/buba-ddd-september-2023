using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AggregateDemo.domain.Anleihe;

namespace AggregateDemo.Domain.PortfolioAggregates.Portfolio
{
    public class Position
    {
        public Anleihe Anleihe { get; init; }
        public decimal Nominal { get; init; }



    }
}
