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
                CalculeMonAge();
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
    }
}
