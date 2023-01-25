using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuScript : MonoBehaviour
{
    public GameObject menu;
    public TextMeshProUGUI testingText;
    public KeyCode testingKey;
    public bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
        Time.timeScale = 1f;
        if (GameManager.Instance != null)
        {
            GameManager.Instance.UnPauseMusic();


        }


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(testingKey))
        {
            //Debug.Log("Down");
            testingText.text = "Down";
        }
        else if (Input.GetKey(testingKey))
        {
            testingText.text = "Hold";
            //Debug.Log("Hold");
        }
        else if (Input.GetKeyUp(testingKey))
        {
            testingText.text = "Up";
            //Debug.Log("Up");
        }
        else
        {
            //Nothing Here
            //This is whenever the key is not pressed
        }

        if (Input.GetButtonDown("Cancel"))
        {
            TogglePauseGame();
        }
    }

    public void TogglePauseGame()
    {
        //Will only open
        //menu.SetActive(true);
        isPaused = !isPaused;


        //Will open menu if closed, closes menu if open
        // menu.SetActive(!menu.activeInHierarchy);
        menu.SetActive(isPaused);


        if (isPaused)
        {
            Time.timeScale = 0f;
            //GameManager.Instance.audio.pitch = 0f;
            GameManager.Instance.PauseMusic();
        }
        else
        {
            Time.timeScale = 1f;
            //GameManager.Instance.audio.pitch = 1f;
            GameManager.Instance.UnPauseMusic();
        }
    }
    public void LoadLevel(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void PlaySound(AudioClip clip)
    {
        GameManager.Instance.audio.PlayOneShot(clip);
    }
}
