using Xamarin.Forms;

namespace StyleDemo.Behaviors
{
  public class NumericEntryBehavior : Behavior<Entry>
  {
    protected override void OnAttachedTo(Entry bindable)
    {
      base.OnAttachedTo(bindable);

      bindable.TextChanged += TextChanged_Handler;
    }

    protected override void OnDetachingFrom(Entry bindable)
    {
      base.OnDetachingFrom(bindable);
      bindable.TextChanged -= TextChanged_Handler;
    }

    void TextChanged_Handler(object sender, TextChangedEventArgs e)
    {
      if (string.IsNullOrEmpty(e.NewTextValue))
        return;
      double result;
      if (!double.TryParse(e.NewTextValue, out result))
        ((Entry)sender).Text = e.OldTextValue;
    }
  }
}