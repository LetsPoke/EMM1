using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    [SerializeField] public GameObject menu;
    public bool paused = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape")){
            if(paused == false){
                Time.timeScale = 0;
                paused = true;
                menu.SetActive(true);
            }else{
                Time.timeScale = 1;
                paused = false;
                menu.SetActive(false);
            }
        }
    }


    public void Play(){
        Time.timeScale = 1;
        paused = false;
        menu.SetActive(false);
    }

    public void Reload(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        paused = false;
        menu.SetActive(false);
    }
}
