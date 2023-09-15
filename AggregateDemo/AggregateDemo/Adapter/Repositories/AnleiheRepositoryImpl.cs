using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AggregateDemo.domain.Anleihe;

namespace AggregateDemo.Adapter.Repositories
{
    public class AnleiheRepositoryImpl: AnleiheRepository
    {
        public void Speichern(Anleihe anleihe)
        {
            Console.WriteLine("Anleihe wird physikalisch gespeichert!");
        }

        public void Aendern(Anleihe anleihe)
        {
            throw new NotImplementedException();
        }

        public void Loeschen(Anleihe anleihe)
        {
            throw new NotImplementedException();
        }

        public Anleihe? FindeAnleiheNachISIN(string ISIN)
        {
            throw new NotImplementedException();
        }

        public IList<Anleihe> FindeAlle()
        {
            throw new NotImplementedException();
        }
    }
}
