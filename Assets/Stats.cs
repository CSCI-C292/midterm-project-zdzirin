using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Stats : MonoBehaviour
{
    [SerializeField] RuntimeData _runtimeData;
    TextMeshProUGUI _totalScoreText;
    TextMeshProUGUI _daysText;
    TextMeshProUGUI _avgScoreText;
    TextMeshProUGUI _blurbText;


    List<string> blurbs = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;


        blurbs.Add("you're not very good...");
        blurbs.Add("you were just spamming weren't you?");
        _totalScoreText = transform.Find("TotalScoreText").gameObject.GetComponent<TextMeshProUGUI>();
        _daysText = transform.Find("DaysText").gameObject.GetComponent<TextMeshProUGUI>();
        _avgScoreText = transform.Find("AvgScoreText").gameObject.GetComponent<TextMeshProUGUI>();
        _blurbText = transform.Find("BlurbText").gameObject.GetComponent<TextMeshProUGUI>();

        _totalScoreText.text = _runtimeData.totalScore.ToString();
        _daysText.text = _runtimeData.day.ToString();
        _avgScoreText.text = (_runtimeData.totalScore / _runtimeData.day).ToString();    
        
        _blurbText.text = "but " + blurbs[(_runtimeData.totalScore < 100) ? 0 : 1];

    }

    public void RestartGame() {
        SceneManager.LoadScene(1);
    }

}
