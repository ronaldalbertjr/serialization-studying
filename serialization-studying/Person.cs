using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace serialization_studying
{
    [Serializable]
    class Person
    {
        #region Variable Declaration
        private string name;
        public string Name
        {
            get
            {
                return name; 
            }
            set
            {
                name = Char.ToUpper(value[0]) + value.Substring(1);
            }
        }
        private string lastName;
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = Char.ToUpper(value[0]) + value.Substring(1);
            }
        }
        private string nickname;
        public string Nickname
        {
            get
            {
                return nickname;
            }
            set
            {
                nickname = value;
            }
        }
        private int age;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        private string gender;
        public string Gender
        {
            get
            {
                return gender;
            }
            set
            {
                gender = Char.ToUpper(value[0]) + value.Substring(1);
            }
        }
        private string ethnicity;
        public string Ethnicity
        {
            get
            {
                return ethnicity;
            }
            set
            {
               ethnicity = Char.ToUpper(value[0]) + value.Substring(1);
            }
        }
        #endregion

        public Person(string name, string lastName, string nickname, int age, string gender, string ethnicity)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Nickname = nickname;
            this.Age = age;
            this.Gender = gender;
            this.Ethnicity = ethnicity;
        }
    }
}
