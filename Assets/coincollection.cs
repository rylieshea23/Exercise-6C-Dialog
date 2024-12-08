using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class coincollection : MonoBehaviour
{
  

    private int coin = 0;


    public TextMeshProUGUI cointext;


    private void OnTriggerEnter(Collider other)
    {
        
        if(other.transform.tag == "coin")
        {
            coin++;
            cointext.text = "coin: " + coin.ToString();
            Debug.Log(coin);
            Destroy(other.gameObject);
        }

             
    }

}
