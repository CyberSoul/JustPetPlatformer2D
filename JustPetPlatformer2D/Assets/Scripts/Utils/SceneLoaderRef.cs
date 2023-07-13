using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace JustPet
{
    public class SceneLoaderRef : SceneLoaderBase
    {
        [SerializeField] private SceneAsset sceneRef;

        public override void LoadScene()
        {
            LoadScene(sceneRef.name);
        }
    }
}