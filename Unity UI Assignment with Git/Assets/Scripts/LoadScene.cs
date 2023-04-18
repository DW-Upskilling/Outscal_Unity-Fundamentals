using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{

    public Button firstSceneButton, secondSceneButton, thirdSceneButton;
    public string firstScene, secondScene, thirdScene;

    // Start is called before the first frame update
    void Start()
    {
        firstSceneButton.onClick.AddListener(loadFirstScene);
        secondSceneButton.onClick.AddListener(loadSecondScene);
        thirdSceneButton.onClick.AddListener(loadThirdScene);
    }

    private void loadFirstScene(){
        SceneManager.LoadScene(firstScene);
    }
    private void loadSecondScene(){
        SceneManager.LoadScene(secondScene);
    }
    private void loadThirdScene(){
        SceneManager.LoadScene(thirdScene);
    }
}
