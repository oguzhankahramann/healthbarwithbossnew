using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    
    public void PlayGame ()
    {
        // o an bulunulan levelin indexini alip 1 arttirarak bir sonraki levela yani siradaki scene e geciyoruz.
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // app quit unity editor icinde calismiyor ancak console ile islevini gorebiliyoruz
    public void QuitGame ()
    {
        Debug.Log("quit");
        Application.Quit();

    }

}
