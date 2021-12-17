using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickGenerator : MonoBehaviour {

	public GameObject obj; //ChickBallPrefab 설정
	public float interval = 3.0f; //다음에 함수가 호출될 인터벌

	// Use this for initialization
	void Start () {
		InvokeRepeating ("SpawnObj", 0.1f, interval); //SpawnObj함수를 게임이 실행된 0.1초후에 호출, 이후 interval초 마다 호출 된다.
	}
	
	// Update is called once per frame

	//SpawnObj함수는 ChickBallPrefab을 생성한다.
	void SpawnObj () {
		Instantiate (obj,transform.position,transform.rotation);
	}
}
