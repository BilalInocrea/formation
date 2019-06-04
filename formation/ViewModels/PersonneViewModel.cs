using System;
using formation.Models;
namespace formation.ViewModels
{
    public class PersonneViewModel:BaseViewModel
    {
        private DateTime _birthday;
        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                if (value == _birthday) return;
                SetProperty(ref _birthday, value);
                CalculeMonAgeA();
            }
        }

        private DateTime _uneDate;
        public DateTime UneDate
        {
            get
            {
                return _uneDate;
            }
            set
            {
                if (value == _uneDate) return;
                SetProperty(ref _uneDate, value);
                CalculeMonAgeA();
            }
        }

        private string _tenYearsLaters;
        public string TenYearLaters
        {
            get
            {
                return _tenYearsLaters;
            }
            set
            {
                if (value == _tenYearsLaters) return;
                SetProperty(ref _tenYearsLaters, value);
            }
        }

        public PersonneViewModel()
        {
            var Personne = new Personne();
            Birthday = Personne.Birthday;
            UneDate = DateTime.Today;
        }

        private void CalculeMonAge()
        {
            var annee = Birthday;
            var today = DateTime.Now;
            today.AddYears(10);
            var age = today - annee;
            var date = Math.Round(age.TotalDays / 365)+10;
            TenYearLaters = date.ToString();
        }

        private void CalculeMonAgeA()
        {

            var year = UneDate.Year - Birthday.Year;
            if(UneDate.Month < Birthday.Month)
            {
                year -= 1;
            }
            else if(UneDate.Month == Birthday.Month && UneDate.Day < Birthday.Day)
            {
                year -= 1;
            }
            TenYearLaters = year+"";
        }
    }
}
