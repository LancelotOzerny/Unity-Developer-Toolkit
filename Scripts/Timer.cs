using UnityEngine;
using UnityEngine.Events;

namespace UDT.Timer
{
    public abstract class Timer : MonoBehaviour
    {
        [Header("Timer Params")]
        [SerializeField] protected float time = 2;
        [SerializeField] protected UnityEvent timerEvent = null;

        [Header("Additional")]
        [SerializeField] protected bool startOnAwake;


        protected float RemaingTime { get;  set; } = -100;
        protected bool TimerIsPlay { get; set; } = false;

        private void Awake()
        {
            if (startOnAwake)
            {
                TimerIsPlay = true;
            }
        }

        public void StartTimer()
        {
            TimerIsPlay = true;
        }

        public void ResetTimer()
        {
            TimerIsPlay = false;
            RemaingTime = time;
        }

        public void StopTimer()
        {
            TimerIsPlay = false;
        }

        protected abstract void InvokeEvent();

        private void Update()
        {
            if (TimerIsPlay)
            {
                RemaingTime -= Time.deltaTime;

                if (RemaingTime < 0)
                {
                    InvokeEvent();
                }
            }
        }
    }
}