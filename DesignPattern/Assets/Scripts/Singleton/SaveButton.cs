using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveButton : MonoBehaviour
{
    public void OnSaveClick()
    {
        DataManager.Instance.Save();
        GameManager.Instance.Game();
        SceneManager.LoadScene("Sample");
    }
}
