//using System;

//N27 - HT2 - min, max, average, sum, group, distinct

//- Topics enum dan foydalaning(Fun, IT, Gaming, Business)

//- VideoPost modelidan foydalaning(id, title, description, likes, dislikes, topic )
//-VideoPost tipidagi listga 10 ta video qo'shing

//ulardan quyidagilarni ekranga chiqaring
//- eng ko'p like olgani
//- eng kam dislike olgani
//- likelar o'rtachasi
//- barcha videolardagi dislikelar soni
//- videolarni faqat title va description bo'yicha projetion qilib ( Select ) 
//- videolardan topic bo'yicha unique qilib ( Distinct ) 
//- videolarni topic bo'yicha guruhlab


using N27_HT2.Enums;
using N27_HT2.Models;
using N27_HT2.Services;

var videoPostService = new VideoPostService();
videoPostService.Add(new VideoPost("Video1 ", "Description1" , 15,5, Topics.Fun));
videoPostService.Add(new VideoPost("Video2 ", "Description2" ,10,2,Topics.IT ));
videoPostService.Add(new VideoPost("Video3 ", "Description3" ,20, 8, Topics.Gaming));
videoPostService.Add(new VideoPost("Video4 ", "Description4" ,8,3,Topics.Business ));
videoPostService.Add(new VideoPost("Video5 ", "Description5" ,12 ,1,Topics.Fun));
videoPostService.Add(new VideoPost("Video6 ", "Description6" ,18 ,4,Topics.IT));
videoPostService.Add(new VideoPost("Video7 ", "Description7" ,5 ,2,Topics.Gaming));
videoPostService.Add(new VideoPost("Video8 ", "Description8" ,30 ,10,Topics.Business));
videoPostService.Add(new VideoPost("Video9 ", "Description9" , 7,0,Topics.Fun));
videoPostService.Add(new VideoPost("Video10 ", "Description10",25,6,Topics.IT ));

videoPostService.MostLikedVideo();
videoPostService.LeastDislikedVideo();
videoPostService.AverageLikes();
videoPostService.TotalDislike();
videoPostService.VideoProjections();
videoPostService.UniqueTopics();
videoPostService.GroupedByTopic();