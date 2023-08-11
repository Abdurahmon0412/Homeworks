using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N22_2_Hometask.Interfaces
{
    public class ReviewList<TRewiev> : IReviewList<TRewiev> where TRewiev : IRewiev
    {
        public ReviewList()
        {
            _reviewList = new List<TRewiev>();
        }
        private  List<TRewiev> _reviewList;
        public void Add(TRewiev rewiew)
        {
            _reviewList.Add(rewiew);
        }


        public TRewiev GetReview(Guid id)
        {
            var review = _reviewList.FirstOrDefault(rewiev => rewiev.Id == id);
            if (review != null) return review;
            return default(TRewiev);
        }

        public TRewiev GetReview(string massage)
        {
            var review = _reviewList.FirstOrDefault(rewiev => rewiev.Massage == massage);
            if(review != null) return review;
            return default(TRewiev);
        }

        public void Remove(Guid id)
        {
           var review =  _reviewList.FirstOrDefault(review => review.Id == id);
           _reviewList.Remove(review);

        }

        public void Remove(TRewiev rewiew)
        {
            _reviewList.Remove(rewiew);
        }

        public void Update(Guid id, int star, string massage)
        {
            var update = _reviewList.First(rewiev => rewiev.Id == id);
            update.Star = star;
            update.Massage = massage;
        }

        public void GetOverallReview()
        {
            var allReviewStar = true;

            bool anyAdult = _reviewList.Any();
            if (anyAdult == default)
            {
                Console.WriteLine("Be the first to leave a review for this product");
                return;
            }
            bool allAdults = _reviewList.All(rewiev => rewiev.Star == 5);

            if(allAdults == true)
            {
                Console.WriteLine("Great news! All reviews for this product are 5 - star ratings.");
            }
            var review = _reviewList.FirstOrDefault(review => review.Star == 1);
            if(review != null)
            {
                Console.WriteLine(review.Massage);
            }
        }


    }
}
