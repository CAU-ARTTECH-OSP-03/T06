using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public float speed = 8f;//Player의 이동 속도
	public float moveableRange = 5.5f; // 이동 가능한 범위
	public float power = 1000f; // CannonBall을 발사하는 힘
	public GameObject cannonBall; //Player에서 발사할 CannonBall
	public Transform spawnPoint; //Cannon 발사 지점
	
	// Update is called once per frame
	void Update () 
	{
		transform.Translate (Input.GetAxisRaw ("Horizontal") * speed * Time.deltaTime, 0, 0); //Player 이동
		transform.position = new Vector2 (Mathf.Clamp (transform.position.x, -moveableRange, moveableRange), transform.position.y); //이동 범위를 movableRange로 제한
		if (Input.GetKeyDown (KeyCode.Space))  //스페이스키 버튼 이벤트 처리
		{
			Shoot (); //Shoot함수 호출
		}
	}

	void Shoot()
	{
		GameObject newBullet = Instantiate (cannonBall, spawnPoint.position, Quaternion.identity) as GameObject; //새 cannonBall을 생성하여 newBullet에 할당
		newBullet.GetComponent<Rigidbody2D> ().AddForce (Vector3.up * power); //newBullet의 Rigidbody2D를 참조하여 AddForce 함수로 물리적으로 발사

	}
}
