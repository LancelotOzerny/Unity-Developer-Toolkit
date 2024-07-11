using UnityEngine;

namespace UDT.Timer
{
    public class TimerDisposable : Timer
    {
        [SerializeField] private bool scriptDestroyAfterInvoke;
        [SerializeField] private bool gameObjectDestroyAfterInvoke;

        protected override void InvokeEvent()
        {
            ResetTimer();

            if (timerEvent != null)
            {
                timerEvent.Invoke();

                if (gameObjectDestroyAfterInvoke)
                {
                    Destroy(this.gameObject);
                }

                else if (scriptDestroyAfterInvoke)
                {
                    Destroy(this);
                }
            }
        }
    }
}