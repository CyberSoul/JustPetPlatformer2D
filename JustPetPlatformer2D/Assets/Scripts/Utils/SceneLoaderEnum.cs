using UnityEngine;

namespace JustPet
{
    public class SceneLoaderEnum : SceneLoaderBase
    {
        [SerializeField] private SceneEnum sceneEnum;

        public override void LoadScene()
        {
            LoadScene(sceneEnum.ToString());
        }
    }
}