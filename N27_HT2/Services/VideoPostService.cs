using N27_HT2.Enums;
using N27_HT2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N27_HT2.Services
{
    public class VideoPostService
    {
        //-VideoPost tipidagi listga 10 ta video qo'shing

        //ulardan quyidagilarni ekranga chiqaring
        //- eng ko'p like olgani
        //- eng kam dislike olgani
        //- likelar o'rtachasi
        //- barcha videolardagi dislikelar soni
        //- videolarni faqat title va description bo'yicha projetion qilib ( Select ) 
        //- videolardan topic bo'yicha unique qilib ( Distinct ) 
        //- videolarni topic bo'yicha guruhlab
        private List<VideoPost> _videoPostList;

        public VideoPostService()
        {
            _videoPostList = new List<VideoPost>();
        }
        public void Add(VideoPost videoPsot)
        {
            _videoPostList.Add(videoPsot);
        }

        public void MostLikedVideo() 
        {
            Console.WriteLine( _videoPostList.OrderByDescending(post => post.Likes).First());
        }

        public void LeastDislikedVideo()
        {
            Console.WriteLine(_videoPostList.OrderBy(post => post.Dislikes).First());
        }

        public void AverageLikes()
        {
            Console.WriteLine(_videoPostList.Average(post => post.Likes));
        }

        public void TotalDislike()
        {
            Console.WriteLine( _videoPostList.Sum(post => post.Dislikes));
        }

        public void VideoProjections()
        {
            _videoPostList.Select(post
                => new { post.Title, post.Description })
                .ToList().ForEach(post
                => Console.WriteLine(post.Title + "  " + post.Description));
        }

        public void UniqueTopics()
        {
            _videoPostList.Select(post => post.Topic).Distinct()
                .ToList().ForEach(post => Console.WriteLine(post.ToString()));
        }

        public void GroupedByTopic()
        {
            var groupedByTopic = _videoPostList.GroupBy(post => post.Topic);
            Console.WriteLine("\nVideolarni topic bo'yicha guruhlab:");
            foreach (var group in groupedByTopic)
            {
                Console.WriteLine($"Topic: {group.Key}");
                foreach (var video in group)
                {
                    Console.WriteLine($"  {video.Title}");
                }
            }
        }


    }
}
