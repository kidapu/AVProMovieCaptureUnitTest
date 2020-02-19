using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCam : MonoBehaviour
{

	void Update()
	{
		var rot = Mathf.Sin(Time.time * 2.5f) * 15f;
		var rot2 = Mathf.Sin(Time.time * 1.5f) * 10f;
		gameObject.transform.localEulerAngles = new Vector3(rot2,rot,0);
	}
}
