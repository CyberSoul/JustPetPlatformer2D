namespace JustPet
{
    public class ExitButton : CustomButton
    {
        protected override void OnClickAction()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
            Application.Quit();
#endif
        }

    }
}