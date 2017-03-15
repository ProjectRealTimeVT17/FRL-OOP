using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace ClassExempel.Model
{
    class Dog
    {
        public Dog(string name, string color, Gender gender, int age)
        {
            _name = name;
            Color = color;
            _gender = gender;
            _dateOfBirth = DateTime.Now.AddYears((-1 * age));
        }

        #region Properties
        private DateTime _dateOfBirth;
        public int DateofBirth
        {
            get
            {
                return _dateOfBirth.Year;
            }
        }

        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
        }

        private Gender _gender;
        public Gender Gender
        {
            get
            {
                return _gender;
            }
        }

        //public string Color { get; set; }
        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }

            private set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _color = value;
                }
            }
        }

        private int _age;
        public int Age
        {
            get
            {
                _age = (DateTime.Now.AddYears(1).Year - _dateOfBirth.Year);
                return _age;
            }

        }
        #endregion


        public string Bark()
        {
            string bark = "Woff!";
            SpeechSynthesizer synth = new SpeechSynthesizer() { };
            //synth.SelectVoiceByHints(VoiceGender.Female);
            synth.Speak(bark);
            return bark;
        }
    }
}
