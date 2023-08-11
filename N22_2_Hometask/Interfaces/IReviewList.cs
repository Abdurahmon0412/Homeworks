using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_2_Hometask.Interfaces
{
    public interface IReviewList<TRewiew>where TRewiew : IRewiev
    {
        public void Add(TRewiew rewiew);
        public void Update(Guid id, int star, string massage);

        public void Remove(TRewiew rewiew);
        public void Remove(Guid id);
        public TRewiew? GetReview(Guid id);
        public TRewiew GetReview(string massage);

        public void GetOverallReview();

    }
}
