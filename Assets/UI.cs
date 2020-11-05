using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{

    [SerializeField] RuntimeData _runtimeData;
    int _internalTotal = 0;
    int _internalScore = 0;
    int _internalDay = 0;

    TextMeshProUGUI _totalScoreText;
    TextMeshProUGUI _currentScoreText;
    TextMeshProUGUI _dayText;

    // Start is called before the first frame update
    void Start()
    {
        _totalScoreText = transform.Find("TotalScoreText").gameObject.GetComponent<TextMeshProUGUI>();
        _currentScoreText = transform.Find("ScoreText").gameObject.GetComponent<TextMeshProUGUI>();
        _dayText = transform.Find("DayText").gameObject.GetComponent<TextMeshProUGUI>();
        
        _totalScoreText.text = _internalScore.ToString();
        _currentScoreText.text = _internalScore.ToString();
        _dayText.text = _internalDay.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (_internalScore!=_runtimeData.currentScore)
        {
            _internalScore = _runtimeData.currentScore;
            _currentScoreText.text = _internalScore.ToString();
        }

        if (_internalTotal!=_runtimeData.totalScore)
        {
            _internalTotal = _runtimeData.totalScore;
            _totalScoreText.text = _internalTotal.ToString(); 
        }

        if (_internalDay!=_runtimeData.day)
        {
            _internalDay = _runtimeData.day;
            _dayText.text = _internalDay.ToString();
        }

    }

}
