using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateDemo.domain.Anleihe
{
    public interface AnleiheService
    {
        void erfasseAnleihe(Anleihe anleihe);
        void ErmitteleUndSetzeRatingFuerAnleihe(string ISIN);
    }
}
