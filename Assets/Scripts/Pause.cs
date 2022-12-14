using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject PanelPause;
    [SerializeField] KeyCode keyMenu;
    public GameObject dialog;
    bool isPanel;

    void Start()
    {
        
    }

    
    void Update()
    {
        pause();
    }

    private void pause()
    {
        if (Input.GetKeyDown(keyMenu))
        {
            isPanel = !isPanel;
        }

        if (isPanel)
        {
            PanelPause.SetActive(true);
            Cursor.visible = true;
            dialog.SetActive(false);
            Time.timeScale = 0f;
        }
        else
        {
            PanelPause.SetActive(false);
            Cursor.visible = false;
            Time.timeScale = 1f;
        }
    }

    public void Play()
    {
        isPanel = false;
    }
    public void Exit()
    {
        SceneManager.LoadScene(0);
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
}

