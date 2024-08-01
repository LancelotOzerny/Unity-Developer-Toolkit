using System.Collections.Generic;
using UnityEngine;

namespace UDT.Event
{
    public class EventTrigger2D : MonoBehaviour
    {
        [SerializeField] private List<TagEventElement> triggerEnter;
        [SerializeField] private List<TagEventElement> triggerExit;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            InvokeTriggerEvent(collision, triggerEnter);
        }

        private void OnTriggerExit2D(Collider2D collision)
        {
            InvokeTriggerEvent(collision, triggerExit);
        }

        private void InvokeTriggerEvent(Collider2D collision, List<TagEventElement> tagList)
        {
            for (int i = 0, count = tagList.Count; i < count; i++)
            {
                if (collision.tag == tagList[i].tag)
                {
                    if (tagList[i].doEvent != null)
                    {
                        tagList[i].doEvent.Invoke();
                    }

                    if (tagList[i].destroyThis)
                    {
                        Destroy(this.gameObject);
                    }

                    if (tagList[i].destroyCollision)
                    {
                        Destroy(collision.gameObject);
                    }
                }
            }
        }
    }
}