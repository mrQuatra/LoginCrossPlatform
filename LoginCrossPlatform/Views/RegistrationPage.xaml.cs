using System;
using System.Collections.Generic;
using System.IO;
using LoginCrossPlatform.Table;
using SQLite;
using Xamarin.Forms;

namespace LoginCrossPlatform.Views
{
    public partial class RegistrationPage : ContentPage
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDatabase.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<RegUserLog>();


            var item = new RegUserLog()
            {
                UserName = EntryUserName.Text,
                Password = EntryUserPassword.Text,
                Email = EntryUserEmail.Text,
                PhoneNumber = EntryUserPhoneNumber.Text
            };


            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
                {

                    var result = await this.DisplayAlert("Congratulation", "User Registred", "Yes", "Cancel");

                    if (result)
                        await Navigation.PushAsync(new LoginPage());

                });
        }
    }
}
