using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    void Start() {
        gameObject.SetActive(true);    
    }
    [SerializeField] GameObject _htpMenu;
    public void PlayGame() {
        SceneManager.LoadScene(1);
    }

    public void HowToPlayGame() {
        gameObject.SetActive(false);
        _htpMenu.SetActive(true);
    }
}
