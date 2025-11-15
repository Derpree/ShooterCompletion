using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    public float coinAmount;
    public TMP_Text TextOfCoin;
    private void Update()
    {
        TextOfCoin.text = coinAmount.ToString();
    }
}