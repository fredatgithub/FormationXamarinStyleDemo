using Xamarin.Forms;

namespace StyleDemo.Triggers
{
  public class DoubleValidation : TriggerAction<Entry>
  {
    protected override void Invoke(Entry sender)
    {
      if (sender == null) return;
      double result;
      var isValid = double.TryParse(sender.Text, out result);
      sender.TextColor = isValid ? Color.Black : Color.Red;
    }
  }
}