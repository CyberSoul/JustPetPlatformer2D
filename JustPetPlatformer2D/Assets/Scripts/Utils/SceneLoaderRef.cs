using UnityEngine;
using UnityEngine.SceneManagement;

namespace JustPet
{
    public class SceneLoaderRef : SceneLoaderBase
    {
        [SerializeField] private Scene sceneRef;

        public override void LoadScene()
        {
            LoadScene(sceneRef.name);
        }
    }
}