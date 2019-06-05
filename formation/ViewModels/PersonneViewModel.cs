using System;
using formation.Models;
namespace formation.ViewModels
{
    public class PersonneViewModel : BaseViewModel
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

        public void CalculeMonAge()
        {
            var annee = Birthday;
            var today = DateTime.Now;
            today.AddYears(10);
            var age = today - annee;
            var date = Math.Round(age.TotalDays / 365) + 10;
            TenYearLaters = date.ToString();
        }
        public void CalculeMonAgeA()
        {
            //Je prends la date année introduite que je soustrais a la date année de l'anniversaire je soustrait en premier la comparatison de la date mois introduite si c'est égal a 1 alors 
            //TenYearLaters = ""+( UneDate.Year - Birthday.Year - (UneDate.Month < Birthday.Month ? 1 : (UneDate.Month == Birthday.Month && UneDate.Day < Birthday.Day) ? 1 : 0));
            /*
            if(Birthday != null || UneDate != null)
            {

            }
            */           
            var year = UneDate.Year - Birthday.Year;
            if (UneDate.Month < Birthday.Month)
            {
                year -= 1;
            }
            else if (UneDate.Month == Birthday.Month && UneDate.Day < Birthday.Day)
            {
                year -= 1;
            }
            TenYearLaters = year + " ans";
        }
    }
}
