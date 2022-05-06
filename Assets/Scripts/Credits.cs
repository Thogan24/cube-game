using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour { 


    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
        
    }


}
