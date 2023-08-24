using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace N30_HT1
{
    public class DocumentAnalyzer
    {
        public int Analyze(string filePath)
        {
            int _essayScore = 100;
            var Text = File.ReadAllText(filePath);
            var words = Text.Split(' ');
            var sentances = Text.Split('?', '.', '!');
            var task1 = Task.Run(() => { ValidLenghtAsync(ref _essayScore, words); });
            Task.Run(() => { OneWordCountIsValidAsync(ref _essayScore, words); });
            var task2 = Task.Run(() => { SentenceOneWordIsCapitalAsync(ref _essayScore, sentances); });
            var task3 = Task.Run(() => { AllwordsIscapitalAsync(ref _essayScore, sentances); });
            var task4 =  Task.Run(() => { AnyWordInvalidAsync(ref _essayScore, words); });
            
            Task.WaitAll(task1, task2, task3 , task4);
            return _essayScore;
        }


        public  Task ValidLenghtAsync(ref int score , in string[] words) 
        {
            
            if (words.Length < 500)
            {
                score -= 5;
            }
            return Task.FromResult(score);
        }

        public Task OneWordCountIsValidAsync(ref int score, string[] words)
        {
            var count = words.Length * 0.20F;
            Dictionary<string, int> countWord = new Dictionary<string, int>();
            foreach (var word in words)
            {
                if (!countWord.ContainsKey(word))
                    countWord.Add(word, 1);
                else
                    countWord[word]++;
            }

            foreach (var word in countWord)
            {
                if (word.Value > count)
                {
                    score -= 5;
                }
            }
            return Task.FromResult(score);
        }

        public Task SentenceOneWordIsCapitalAsync(ref int score, string[] sentences)
        {
            foreach (var sentence in sentences)
                if (!string.IsNullOrWhiteSpace(sentence) && !(sentence.Trim()[0] >= 'A' && sentence.Trim()[0] <= 'Z'))
                    score -= 5;
            return Task.FromResult(score);
        }

        public Task AllwordsIscapitalAsync(ref int score, string[] sentences)
        {
            foreach (var sentenc in sentences)
            {
                var sentence = sentenc.Trim().Split(',', ' ');

                for (var wordB = 1; wordB < sentence.Length; wordB++)
                    if (sentence[wordB] != sentence[wordB].ToLower())
                    {
                        score -= 10;
                        break;
                    }
            }
            return Task.FromResult(score);
        }

        public Task AnyWordInvalidAsync(ref  int score, string[] words)
        {
            foreach (var word in words)
                if(word.Length > 20)
                    score -= 20;
            return Task.FromResult(score);
        }
    }
}
