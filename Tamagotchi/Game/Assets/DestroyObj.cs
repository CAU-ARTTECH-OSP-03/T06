using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObj : MonoBehaviour {

	public float deleteTime = 2.0f;//오브젝트를 제거하는 인터벌 

	// Use this for initialization
	void Start () {
		Destroy (gameObject, deleteTime);//오브젝트를 생성한 후 deleteTime 만큼 시간이 경과하면 제거
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
