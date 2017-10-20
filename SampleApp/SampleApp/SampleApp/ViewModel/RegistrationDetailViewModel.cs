using SampleApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.ViewModel
{
   public class RegistrationDetailViewModel
    {
        public ObservableCollection<Person> People { get; set; } =
         new ObservableCollection<Person>();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
      //  public string Country { get; set; }
      //  public string State { get; set; }
        public RegistrationDetailViewModel()
        {
            Person person = new Person();
            person.Name = "Aswani";

            person.Email = "Unni";
            person.Mobile = "452-785";
            person.Password = "dhjjkj";
            person.Country = "india";
            person.State = "kerala";

            People.Add(person);
            PopulatePeople();
        }
        private async void PopulatePeople()
        {
            int n = 5;
            List<Person> people = await App.Database.GetPersonAsync(n);
            foreach (Person person in people)
            {
                People.Add(person);
            }
        }

    }
}
