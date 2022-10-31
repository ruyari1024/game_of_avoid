using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Jumsu : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI ScoreText;
    private float score = 0;
    public TextMeshProUGUI best_text;
    private string KeyName = "BestScore";
    private int best_score = 0;
    // Start is called before the first frame update
    private void Awake()
    {
        best_score = PlayerPrefs.GetInt(KeyName, 0);
        best_text.text = ((int)best_score).ToString();
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        ScoreText.text = ((int)Score()).ToString();
        if (score > best_score)
        {
            PlayerPrefs.SetInt(KeyName, ((int)Score()));
        }
    }

    public float Score()
    {
        score += Time.deltaTime * 5;
        return score;
    }
}
