using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Bonus : MonoBehaviour
{
    public TextMeshProUGUI Circacena;
    public TextMeshProUGUI Shesternacena;
    public TextMeshProUGUI Pricecena;
    
    void Start()
    {
        
        if (PlayerPrefs.HasKey("PriceCirca"))
        {
            global.PriceCirca = PlayerPrefs.GetInt("PriceCirca");
        }
        if (PlayerPrefs.HasKey("PriceShesterna"))
        {
            global.PriceShesterna = PlayerPrefs.GetInt("PriceShesterna");
        }
        if (PlayerPrefs.HasKey("PricePrice"))
        {
            global.PricePrice = PlayerPrefs.GetInt("PricePrice");
        }
        Circacena.text = global.PriceCirca + "$";
        Shesternacena.text = global.PriceShesterna + "$";
        Pricecena.text = global.PricePrice + "$";
    }


    public void Cirka()
    {
        if (global.score >= global.PriceCirca)
        {
            global.bonus += 1;
            global.score -= global.PriceCirca;
            global.PriceCirca *= 2;
            Circacena.text = global.PriceCirca + "$";
            
        }

    }
    public void Shesterna()
    {
        if(global.score >= global.PriceShesterna)
        {
            
            global.score -= global.PriceShesterna;
            global.PriceShesterna *= 2;
            global.dohod += 1;
            Shesternacena.text = global.PriceShesterna + "$";

        }
    }
    public void Price()
    {
        if (global.score >= global.PricePrice)
        {

            global.score -= global.PricePrice;
            global.PricePrice *= 2;
            Pricecena.text = global.PricePrice + "$";
            global.PriceShesterna /= 2;
            global.PriceCirca /= 2;
            Circacena.text = global.PriceCirca + "$";
            Shesternacena.text = global.PriceShesterna + "$";
        }
    }
    void Update()
    {
        
        PlayerPrefs.SetInt("PriceCirca", global.PriceCirca);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("PriceShesterna", global.PriceShesterna);
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("PricePrice", global.PricePrice);
        PlayerPrefs.Save();
        if (global.score >= global.PriceCirca)
        {
            Circacena.color = Color.yellow;
        }
        else
        {
            Circacena.color = Color.red;
        }
        if (global.score >= global.PriceShesterna)
        {
            Shesternacena.color = Color.yellow;
        }
        else
        {
            Shesternacena.color = Color.red;
        }
        if (global.score >= global.PricePrice)
        {
            Pricecena.color = Color.yellow;
        }
        else
        {
            Pricecena.color = Color.red;
        }
    }
}
