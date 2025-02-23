using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayBtnClicked()
    {
        //Load Level 1
        SceneManager.LoadScene("Level 1");
    }

    public void OptionsBtnClicked()
    {
        //Show Options
    }
}
