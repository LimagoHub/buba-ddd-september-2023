using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AggregateDemo.domain.Anleihe.impl
{
    public class AnleiheServiceImpl : IAnleiheService
    {
        private readonly IAnleiheRepository repository;
        //private readonly RatingService ratingService;

        public AnleiheServiceImpl(IAnleiheRepository repository)
        {
            this.repository = repository;
        }

        public void erfasseAnleihe(Anleihe anleihe)
        {
            try
            {
                repository.Speichern(anleihe);
            }
            catch (Exception ex)
            {
                throw new AnleiheServiceException(ex.ToString());
            }
        }

        public void ErmitteleUndSetzeRatingFuerAnleihe(string ISIN)
        {
            //try
            //{
            //    String rating = ratingService.findForIsin(ISIN);
            //    Anleihe anleihe = repository.FindeAnleiheNachISIN(ISIN);
            //    anleihe.Rating = rating;
            //    repository.Speichern(anleihe);
            //}
            //catch (Exception ex)
            //{
            //    throw new AnleiheServiceException(ex);
            //}
        }
    }
}
