﻿using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour 
{
	//speedを制御する
	public float speed = 10;
	void FixedUpdate ()
	{
		//xとyに代入
		float x =  Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");

		//同一のGameobjectが持つRigidbodyコンポーネントを取得
		Rigidbody rigidbody = GetComponent<Rigidbody>();

		// rigidbodyのx軸（横）とz軸（奥）に力を加える
		rigidbody.AddForce(x * 10, 0 , z * 10);
	}
}