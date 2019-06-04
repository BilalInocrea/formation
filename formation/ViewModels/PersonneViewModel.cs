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
                CalculeMonAgeDansLeFutur();
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
            FuturBirthDay = Personne.Birthday;
        }

        private void CalculeMonAge()
        {
            var annee = Birthday;
            var today = DateTime.Now;
            today.AddYears(10);
            var age = today - annee;
            var date = Math.Round(age.TotalDays / 365)+10;
            TenYearLaters = date.ToString() + " ans";
        }
        private DateTime _futurBirthDay;
        public DateTime FuturBirthDay
        {
            get 
            {
                return _futurBirthDay;
            }
            set
            {
                if (value == _futurBirthDay) return;
                SetProperty(ref _futurBirthDay, value);
                CalculeMonAgeDansLeFutur();
            }
        }
        private string _monAgeDansXannee;
        public string MonAgeDansXannee
        {
            get
            {
                return _monAgeDansXannee;
            }
            set
            {
                if (value == _monAgeDansXannee) return;
                SetProperty(ref _monAgeDansXannee, value);
            }
        }
        public void CalculeMonAgeDansLeFutur()
        {
            TimeSpan diff1 = FuturBirthDay.Subtract(Birthday);
            double AllDay = diff1.Days;
            //double final = Math.Round(AllDay / 365);
            double final = 0;
            if (AllDay < 365)
            {
                final = 0;
                MonAgeDansXannee = final + " ans";

            }
            if (AllDay >= 365)
            {
                final = Math.Round(AllDay / 365);
                MonAgeDansXannee = final + " ans";
            }
            /*
            var anneeYear = FuturBirthDay.Year;
            var annifYear = Birthday.Year;
            var anneeMonth = FuturBirthDay.Month;
            var annifMonth = Birthday.Month;
            var anneeDay = FuturBirthDay.Day;
            var annifDay = Birthday.Day;
            var totalDay = (anneeDay - annifDay);
            var totalMonth = (anneeMonth - annifMonth) * 30;
            var totalYear = (anneeYear - annifYear) * 365;
            double totalFial = (totalDay + totalMonth + totalYear);

            if(totalFial < 365)
            {
                totalFial = 0;
                MonAgeDansXannee = Math.Round(totalFial) + " ans";
            }
            if(totalFial >= 365 )
            {
                MonAgeDansXannee = Math.Round(totalFial / 365) + " ans";
            
            }
            */
        }

    }
}
