using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Wall_one : MonoBehaviour
{
    int points1 = 0;
    public Text text;
    void Start()
    {
        text.text = points1.ToString();
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        points1++;
        text.text = points1.ToString();
    }
}
