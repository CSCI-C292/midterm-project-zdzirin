using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{

    [SerializeField] RuntimeData _runtimeData;
    int _internalScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        GameObject textObj = transform.Find("ScoreText").gameObject;
        TextMeshProUGUI textComponent = textObj.GetComponent<TextMeshProUGUI>();
        textComponent.text = _internalScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (_internalScore!=_runtimeData.currentScore)
        {
            _internalScore = _runtimeData.currentScore;
            UpdateScore(_runtimeData.currentScore);
        }
    }

    void UpdateScore(int score)
    {
        GameObject textObj = transform.Find("ScoreText").gameObject;
        TextMeshProUGUI textComponent = textObj.GetComponent<TextMeshProUGUI>();
        textComponent.text = score.ToString();
    }


}
