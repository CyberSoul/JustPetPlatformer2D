using UnityEngine;
using UnityEngine.SceneManagement;

namespace JustPet
{
    public class CloseSceneButton : CustomButton
    {
        protected override void OnClickAction()
        {
            AsyncOperation operation = SceneManager.UnloadSceneAsync(SceneManager.GetSceneAt(SceneManager.sceneCount-1));
        }
    }
}