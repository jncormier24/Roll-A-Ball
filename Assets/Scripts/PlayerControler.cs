using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	void Update (){

	}

	//for physics
	void FixedUpdate (){
		float moveHorizontal 	= Input.GetAxis ( "Horizontal" );
		float moveVertical 		= Input.GetAxis ( "Vertical" );

		//vector (x axis, y axis, z axis)
		Rigidbody.AddForce(  );
	}
}
