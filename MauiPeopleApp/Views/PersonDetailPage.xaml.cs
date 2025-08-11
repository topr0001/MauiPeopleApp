using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiPeopleApp.Models;

namespace MauiPeopleApp.Views;

public partial class PersonDetailPage : ContentPage
{
    public PersonDetailPage(Person person)
    {
        InitializeComponent();
        BindingContext = person;
    }
}