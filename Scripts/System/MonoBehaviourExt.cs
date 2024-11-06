using UnityEngine;

public class MonoBehaviourExt : MonoBehaviour
{
    public void Destroy()
    {
        GameObject.Destroy(this.gameObject);
    }

    public void DestroyWithDelay(float time)
    {
        GameObject.Destroy(this.gameObject, time);
    }
}