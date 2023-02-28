using Android;
using Android.Views;

namespace AndroidApp1
{
    [Activity(Label = "@string/app_name", MainLauncher = true)]
    public class MainActivity : Activity
    {
        TextView? textView;

        protected override void OnCreate(Bundle? savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            textView = FindViewById<TextView>(Resource.Id.textView1)!;
            textView.GenericMotion += (s, e) =>
            {
                var motionEvent = e.Event!;
                textView!.Text = $"" +
                $"Generic:\n" +
                $"    Action: {motionEvent.Action}\n" +
                $"    ButtonState: {motionEvent.ButtonState}\n" +
                $"    ActionButton: {motionEvent.ActionButton}\n" +
                $"    Source: {motionEvent.Source}\n" +
                $"    ToolType: {motionEvent.GetToolType(0)}\n" +
                $"    Pressure: {motionEvent.Pressure} \n" +
                $"    RawX: {motionEvent.RawX} \n" +
                $"    RawY: {motionEvent.RawY} \n" +
                $"    Flags: {motionEvent.Flags} \n" +
                $"    ActionIndex: {motionEvent.ActionIndex}\n" +
                $"    DeviceId: {motionEvent.DeviceId}\n" +
                $"    DownTime: {motionEvent.DownTime}\n" +
                textView.Text;
            };
            textView.Touch += (s, e) =>
            {
                var motionEvent = e.Event!;
                textView!.Text = $"Touch:\n" +
                $"    Pressure: {motionEvent.Pressure} \n" +
                $"    RawX: {motionEvent.RawX} \n" +
                $"    RawY: {motionEvent.RawY} \n" +
                $"    Size: {motionEvent.Size} \n" +
                $"    TouchMinor: {motionEvent.TouchMinor} \n" +
                $"    ToolMajor: {motionEvent.ToolMajor} \n" +
                $"    ToolMinor: {motionEvent.ToolMinor} \n" +
                $"    TouchMajor: {motionEvent.TouchMajor} \n" +
                $"    XPrecision: {motionEvent.XPrecision} \n" +
                $"    PointerCount: {motionEvent.PointerCount} \n" +
                $"    Source: {motionEvent.Source}\n" +
                $"    Orientation: {motionEvent.Orientation}\n" +
                $"    ButtonState: {motionEvent.ButtonState}\n" +
                $"    Flags: {motionEvent.Flags} \n" +
                $"    Action: {motionEvent.Action}\n" +
                $"    ActionButton: {motionEvent.ActionButton}\n" +
                $"    ActionIndex: {motionEvent.ActionIndex}\n" +
                $"    ActionMasked: {motionEvent.ActionMasked}\n" +
                $"    YPrecision: {motionEvent.YPrecision}\n" +
                $"    DeviceId: {motionEvent.DeviceId}\n" +
                $"    DownTime: {motionEvent.DownTime}\n" +
                $"    ToolType: {motionEvent.GetToolType(0)}\n" +
                textView.Text;
            };
        }
    }
}