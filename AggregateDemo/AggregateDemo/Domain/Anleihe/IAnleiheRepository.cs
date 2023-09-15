using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateDemo.domain.Anleihe
{
    public interface IAnleiheRepository
    {
        void Speichern(Anleihe anleihe);
        void Aendern(Anleihe anleihe);
        void Loeschen(Anleihe anleihe);

        Anleihe? FindeAnleiheNachISIN(String ISIN);

        IList<Anleihe> FindeAlle();


    }
}
