using N22_2_Hometask.Interfaces;
using N22_2_Hometask.Model;

ReviewList<IRewiev> RewievList = new ReviewList<IRewiev>();
RewievList.GetOverallReview();

var review1 = new Rewiev(5, "MEssage 1 uchun");
var review2 = new Rewiev(2, "MEssage 2 uchun");
var review3 = new Rewiev(5, "MEssage 3 uchun");

var crash1 = new CrashReport(5, "For crash1 ", "bu path1");
var crash2 = new CrashReport(5, "For crash2 ", "bu path2");
var crash3 = new CrashReport(5, "For crash3 ", "bu path3");

RewievList.Add(review1);
RewievList.Add(review2);
RewievList.Add(review3);
RewievList.Add(crash1);
RewievList.Add(crash2);
RewievList.Add(crash3);

Console.WriteLine(RewievList.GetReview(review1.Id));
Console.WriteLine(RewievList.GetReview("MEssage 1 uchun"));
RewievList.Update(review2.Id, 1, "bu yangi 2 message");
RewievList.GetOverallReview();








