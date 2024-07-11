namespace UDT.Timer
{
    public class TimerReusable : Timer
    {
        protected override void InvokeEvent()
        {
            ResetTimer();
            StartTimer();

            if (timerEvent != null)
            {
                timerEvent.Invoke();
            }
        }
    }
}