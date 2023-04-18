using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BackToMaster : MonoBehaviour
{
    public Button button;
    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
     button.onClick.AddListener(loadScene);   
    }

    private void loadScene(){
        SceneManager.LoadScene(sceneName);
    }
}
