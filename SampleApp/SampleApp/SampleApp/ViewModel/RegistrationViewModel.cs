using SampleApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.ViewModel
{
   public class RegistrationViewModel
    {
        public ObservableCollection<States> StateNames { get; set; } = new ObservableCollection<States>();
        public ObservableCollection<States> StateList { get; set; } = new ObservableCollection<States>();
        public ObservableCollection<Person> People { get; set; } = new ObservableCollection<Person>();
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
       public string State { get; set; }
        

        public RegistrationViewModel()
        {
           
            Person person = new Person();
            person.Name = "Aswani";

            person.Email= "Unni";
            person.Mobile = "452-785";
            person.Password = "dhjjkj";
            person.Country = "india";
            person.State = "kerala";

            People.Add(person);
            AddToStateNames();

        }
        public void AddToStateNames()
        {
            StateNames.Add(new States { country = "India", state = "Kerala" });
            StateNames.Add(new States { country = "India", state = "Tamilnadu" });
            StateNames.Add(new States { country = "India", state = "Goa" });
            StateNames.Add(new States { country = "USA", state = "California" });
            StateNames.Add(new States { country = "USA", state = "Hawaii" });
            StateNames.Add(new States { country = "China", state = "Beijing" });
            StateNames.Add(new States { country = "China", state = "Wuhan" });
            StateNames.Add(new States { country = "Malasia", state = "Kuching" });
            StateNames.Add(new States { country = "Malasia", state = "Malacca" });
            StateNames.Add(new States { country = "Malasia", state = "Miri" });

        }
        public void AddToList(string item)
        {
            int i;
            StateList.Clear();
            for( i=0; i < StateNames.Count; i++)
            {
                if(StateNames[i].country== item)
                {
                    StateList.Add(new States { country = StateNames[i].state, state = StateNames[i].state });
                }
            }
            
           
        }
        public void AddToLocalMemory() {
            Person person = new Person();
            
            person.Name = Name;
            person.Email = Email;
            person.Mobile = Mobile;
            person.Password = Password;
          person.Country = Country;
           person.State = State;
           // People.Add(person);
            App.Database.SavePersonAsync(person);
        }
        




    }
   
}
