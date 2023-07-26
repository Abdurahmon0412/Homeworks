using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HT12_2
{
    public class Email
    {
        private string _to;
        private string _from;
        private string _subject;
        private string _content;

        public string To
        {
            get => _to;

            set
            {
                string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
                var regex = new Regex(pattern);
                if (regex.IsMatch(value))
                {
                    _to = value;
                }
                else
                {
                    throw new FormatException("Manzil xato kiritildi.");
                }

            }
        }

        public string From
        {
            get => _from;
            
            set
            {
                string pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9]+\.[a-zA-Z0-9]+$";
                var regex = new Regex(pattern);
                if (regex.IsMatch(value))
                {
                    _from = value;
                }
                else
                {
                    throw new FormatException(" Sizning emailingiz xato kiritildi.");
                }


            }
        }

        public string Subject
        {
            get => _subject; 
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                    throw new FormatException("Uzur bu subject sifatida qabul qilinmaydi.");
                    
                _subject = value;
            }
        }

        public string Content
        {
            get => _content;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 5)
                    throw new FormatException("Uzur bu content sifatida qabul qilinmaydi.");

                _content = value;
            }
        }

        public override string ToString()
        {
            return $"To: {_to}\nFrom: {_from}\nSubject: {_subject}\nContent:{_content}";
        }

    }
}
