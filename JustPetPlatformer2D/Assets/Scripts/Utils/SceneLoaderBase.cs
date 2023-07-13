using UnityEngine;
using UnityEngine.SceneManagement;

namespace JustPet
{
    public abstract class SceneLoaderBase : MonoBehaviour
    {
        [SerializeField] protected LoadSceneMode loadingMode = LoadSceneMode.Single;

        public abstract void LoadScene();
        protected void LoadScene(string sceneName)
        {
            SceneManager.LoadScene(sceneName, loadingMode);
        }
    }
}