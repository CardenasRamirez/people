using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;
using people.Models;

namespace people
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        void OnNewButtonClicked(object sender, EventArgs e)
        {
            //Obtener el Path
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "dbPeople.db");

            PersonRespositoryCRUD personRepo = new PersonRespositoryCRUD(dbPath);

            String name = EntryPersonName.Text;

            //crear un objeto person
            person newPerson = new person();
            newPerson.Name = name;

            personRepo.CreatePerson(newPerson);

            lblStatusMessage.Text = personRepo.StatusMessage;
        }
        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
