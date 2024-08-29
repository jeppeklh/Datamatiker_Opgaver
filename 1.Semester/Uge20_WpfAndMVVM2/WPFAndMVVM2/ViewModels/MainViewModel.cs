using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Input;
using WPFAndMVVM2.Commands;
using WPFAndMVVM2.Models;

namespace WPFAndMVVM2.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PersonViewModel selectedPerson;
        public PersonViewModel SelectedPerson
        {
            get
            {
                return selectedPerson;
            }
            set
            {
                selectedPerson = value;
                OnPropertyChanged("SelectedPerson");
            }
        }

        public ICommand DeleteCommand { get; } = new DeleteCommand();

        private PersonRepository personRepo = new PersonRepository();

        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<PersonViewModel> PersonsVM { get; set; }

        public MainViewModel()
        {
            PersonsVM = new ObservableCollection<PersonViewModel>();
            foreach (Person person in personRepo.GetAll())
            {
                PersonsVM.Add(new PersonViewModel(person));
            }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if (propertyChanged != null)
            {
                propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void AddDefaultPerson()
        {
            Person person = new Person();

            person.FirstName = "Specify FirstName";
            person.LastName = "Specify LastName";
            person.Age = 0;
            person.Phone = "Specify Phone";

            PersonViewModel pVM = new PersonViewModel(person);
            personRepo.Add(person.FirstName, person.LastName, person.Age, person.Phone);

            PersonsVM.Add(pVM);
            SelectedPerson = pVM;


        }
        public void DeleteSelectedPerson()
        {
            //MessageBox.Show(personRepo.GetAll().Count.ToString());
            SelectedPerson.DeletePerson(personRepo);
            PersonsVM.Remove(SelectedPerson);
            //MessageBox.Show(personRepo.GetAll().Count.ToString());
        }

        // Implement the rest of this MainViewModel class below to 
        // establish the foundation for data binding !

    }
}
