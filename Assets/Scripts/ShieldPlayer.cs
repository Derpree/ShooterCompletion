using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShieldPlayer : MonoBehaviour
{
	public IEnumerator TurnOffShield(){
		yield return new WaitForSeconds(3f);
		gameObject.SetActive(false);
	}
}
