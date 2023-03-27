using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class click : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GameObject button;
    public GameObject prefab;
    public TextMeshProUGUI particl;
    // Update is called once per frame
    void Start()
    {
        if (PlayerPrefs.HasKey("bonus"))
        {
            global.bonus = PlayerPrefs.GetInt("bonus");
        }
        if (PlayerPrefs.HasKey("dohod"))
        {
            global.dohod = PlayerPrefs.GetInt("dohod");
        }
        if (PlayerPrefs.HasKey("score"))
        {
            global.score = PlayerPrefs.GetInt("score");
        }
        Invoke("dop", 1f);
    }
    public void clicked()
    {
        global.score += global.bonus;
        button.transform.localScale = new Vector3(0.9f, 0.9f, 0.9f);
        Invoke("Button", 0.1f);
        Instantiate(prefab, button.transform.position, Quaternion.identity);
        
    }
    void Button()
    {
        button.transform.localScale = new Vector3(1f, 1f, 1f);
    }
    void Update()
    {
        particl.text = "+" + global.bonus;
        text.text = "" + global.score;
        PlayerPrefs.SetInt("dohod", global.dohod);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("bonus", global.bonus);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("score", global.score);
        PlayerPrefs.Save();
    }
    public void dop()
    {
        global.score += global.dohod;
        Invoke("dop", 2f);
    }
}
