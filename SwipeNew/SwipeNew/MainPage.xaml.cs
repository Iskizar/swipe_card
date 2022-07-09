using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SwipeNew
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<UserProfile> _Profiles = new ObservableCollection<UserProfile>();
        public MainPage()
        {
            InitializeComponent();
            CardBinding();
            BindingContext = this;
        }

        public void CardBinding()
        {
            _Profiles.Add(new UserProfile() { Name = "Vova", Age = "18", Photo = "img1.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Vasya", Age = "19", Photo = "img2.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Anil", Age = "20", Photo = "img3.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Sonya", Age = "21", Photo = "img4.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Anus", Age = "22", Photo = "img5.jpg" });
            _Profiles.Add(new UserProfile() { Name = "Sus", Age = "23", Photo = "img6.jpg" });
        }
        public ObservableCollection<UserProfile> Profiles
        {
            get => _Profiles;
            set { _Profiles = value; }
        }
        public class UserProfile
        {
            public string Name { get; set; }
            public string Age { get; set; }
            public string Photo { get; set; }

        }

    }
}
