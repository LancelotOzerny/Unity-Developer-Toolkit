using UnityEngine;
using UnityEngine.Events;

namespace UDT.Event
{
    [System.Serializable]
    public class TagEventElement
    {
        public string tag;
        public UnityEvent doEvent;
        public bool destroyThis;
        public bool destroyCollision;
    }
}