using UnityEngine;
using UnityEngine.SceneManagement;

namespace UDT.Tools
{
    public class SceneController : MonoBehaviour
    {
        public void OpenByIndex(int index)
        {
            if (SceneManager.sceneCountInBuildSettings <= index)
            {
                Debug.LogError("Open Scene: Count of scenes less then index of opening scene!");
                return;
            }

            SceneManager.LoadScene(index);
        }

        public void OpenByName(string name)
        {
            SceneManager.LoadScene(name);
        }

        public void Reload()
        {
            int index = GetCurrentBuildIndex();
            OpenByIndex(index);
        }

        public int GetCurrentBuildIndex()
        {
            return SceneManager.GetActiveScene().buildIndex;
        }

        public void LoadNext()
        {
            int index = GetCurrentBuildIndex();
            OpenByIndex(index + 1);
        }

        public void LoadPrev()
        {
            int index = GetCurrentBuildIndex();
            OpenByIndex(index + 1);
        }
    }
}