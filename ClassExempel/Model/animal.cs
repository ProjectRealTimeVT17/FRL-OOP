using ClassExempel.Delegate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExempel.Model
{
    abstract class Animal
    {
        #region Fields
        public event WriteToConsoleDelegate OnValueChange;
        #endregion

        #region Properties

        public int LegCount { get; set; }

        protected DateTime _dateOfBirth;
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
            set
            {
                if (value != _name)
                {
                    WriteToConsoleEventArgs args = new WriteToConsoleEventArgs();
                    args.Message = value;
                    OnValueChange(this, args);
                    _name = value;
                }
            }
        }

        protected Gender _gender;
        public Gender Gender
        {
            get
            {
                return _gender;
            }
        }

        private string _color;
        public string Color
        {
            get
            {
                return _color;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    WriteToConsoleEventArgs args = new WriteToConsoleEventArgs();
                    args.Message = value;
                    OnValueChange(this, args);
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

        public virtual void MakeSound()
        {
            Console.WriteLine("What sound??");
        }
    }
}
