using System.Linq;

namespace Homeworks
{
    public class Program
    {
        public static void Main(string[] args)
        {

            #region Trim and Padding 

            string Text = "In a world filled with endless possibilities, curiosity. remains the driving force behind human progress. " +
                "It is the insatiable thirst for knowledge and the relentless pursuit of answers that fuels our desire to explore, discover," +
                " and innovate.From the moment we are born, curiosity is ingrained within us. It is the spark that ignites our " +
                "imaginations and propels us forward into uncharted territories. With every question asked, a new door opens, revealing a world" +
                " of endless wonders waiting to be explored.Curiosity is not limited by age or boundaries. It transcends disciplines and " +
                "encompasses every aspect of our lives. It is what drives scientists to delve deeper into the mysteries of the universe, artists " +
                "to create breathtaking masterpieces, and entrepreneurs to take risks and build groundbreaking companies.Throughout " +
                "history, curiosity has been the catalyst for some of humanity's greatest achievements. From the first steps on the moon to the " +
                "invention of the internet, curiosity has been the driving force behind these monumental leaps forward. It is the curiosity to" +
                " know what lies beyond our reach that compels us to pushurewwhfrqphfapiuefai;fehaupefai;efupa;efcnacdpac the boundaries of what is possible.But curiosity is not only " +
                "about grand discoveries or groundbreaking inventions. It IS also about the small moments of wonder that enrich our daily lives." +
                " It is the joy of discovering a new book, trying a new recipe, or exploring a new hobby. Curiosity allows us to find beauty in " +
                "the ordinary and to approach each day with a sense of awe and excitement.Unfortunately, curiosity can sometimes be " +
                "stifled by fear or complacency. We may hesitate to ask questions for fear of appearing ignorant or foolish. We may settle for " +
                "what we already know instead of seeking new knowledge. But it is in those moments when we embrace our curiosity that we truly " +
                "come alive.Nurturing curiosity is essential for personal and collective growth. It encourages empathy, as it pushes us" +
                " to understand different perspectives and seek common ground. it fosters creativity, as it inspires us to think outside the box" +
                " and challenge the status quo. It cultivates resilience, as it teaches us to embrace failure as an opportunity to learn and " +
                "grow.So, let us celebrate curiosity and embrace its power. Let us encourage ourselves and others to never stop asking" +
                " questions, to never stop seeking answers. For it is through curiosity that we can unlock the boundless potential within" +
                " ourselves and shape a future filled with endless possibilities.to understand different perspectives and seek common ground. " +
                "It fosters creativity, as it inspires to understand different perspectives and seek common ground. It fosters creativity," +
                "to understand different perspectives and seek common ground. It fosters creativity, as it inspires us as it inspires" +
                "to understand different perspectives and seek common ground. It fosters creativity, as it inspires usto understand different" +
                "to understand different perspectives and seek common ground. It fosters creativity, as it inspires us perspectives and seek" +
                " common ground. It fosters creativity, as it inspires us us to understand different perspectives and seek common ground. " +
                "It fosters creativity, as it inspires to understand different perspectives and seek common ground. It fosters creativity," +
                " as it inspires ususus";
            #endregion
           
            int wordCount = 0;
            int grade = 100;
            bool check = true;
            bool check2 = true;
            string[] words = Text.Split();
            string[] sentences = Text.Split('.', '!', '?');
           
            if (words.Length < 500)
            {
                grade -= 5;
            }

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = i; j < words.Length; j++)
                {
                    if (words[i] == words[j])
                    {
                        wordCount++;
                    }
                    if (wordCount >= words.Length / 5 && check == true)
                    {
                        grade -= 5;
                        check = false;
                    }
                }
                wordCount = 0;
                if (words[i].Length > 20 && check2 == true)
                {
                    grade = grade - 20;
                    check = false;

                }
            }
            check = true;
            
            
            
            foreach (var sen in sentences)
            {
                var sentence = sen.Trim();
                if (Convert.ToChar(sentence[0]) < 55 && Convert.ToChar(sentence[0]) > 122 && check == true)
                {
                    grade -= 5;
                    check = false;
                }
            }
            check = true;
            foreach(var sentence in sentences)
            {
                var senWords =  sentence.Split(' ');
                for (int i = 0;i < senWords.Length;i++)
                {
                    foreach (var capital in senWords[i])
                    {
                        if (i > 0 && capital >= 'A' && capital <= 'Z' && check == true)
                        {
                            grade -= 10;
                            check = false;
                        }
                    }
                }
            }
            Console.WriteLine(grade);
        }
    }
}
