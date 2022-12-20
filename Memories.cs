using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace MauiApp1
{
    public class Memories : INotifyPropertyChanged
    {
        public string name;
        public string surname;
        public string patronymic;
        public string source;

        public Memories(string name, string surname, string patronymic, string source)
        {
            Name = name;
            Surname = surname;
            Patronymic = patronymic;
            Source = source;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
                OnPropertyChanged();
            }
        }

        public string Patronymic
        {
            get
            {
                return patronymic;
            }
            set
            {
                patronymic = value;
                OnPropertyChanged();
            }
        }

        public string Source
        {
            get
            {
                return source;
            }
            set
            {
                source = value;
                OnPropertyChanged();
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        //public string this[int index]
        //{
        //    get
        //    {
        //        if (index == 0)
        //            return this.text;
        //        else if (index == 1)
        //            return this.text1;
        //    }
        //}
    }
}
