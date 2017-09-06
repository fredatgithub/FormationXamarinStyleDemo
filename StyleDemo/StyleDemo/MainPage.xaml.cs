using System;
using Xamarin.Forms;

namespace StyleDemo
{
  public partial class MainPage : ContentPage
  {
    public MainPage()
    {
      InitializeComponent();
    }

    private  void Button_OnClicked(object sender, EventArgs e)
    {
      //async
      //imgLogo.Rotation = 0;
      //await imgLogo.RotateTo(360, 250);
    }

    private void VisualElement_OnFocused(object sender, FocusEventArgs e)
    {
      
    }
  }
}