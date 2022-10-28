using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Jumsu : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI ScoreText;
    private float score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime*5;
        ScoreText.text = ((int)score).ToString();
    }
}
