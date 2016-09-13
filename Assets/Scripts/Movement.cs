using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {


	public GameObject pos1;
	public GameObject pos2;
	public float speed;
	GameObject target;
	// Use this for initialization
	void Start () {
		target = pos1;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector2.MoveTowards (transform.position,target.transform.position, speed * Time.deltaTime);
		if(Vector2.Distance(target.transform.position, transform.position) < 1f){
			if(target.tag == "pos1"){
				target = pos2;
			}
			else{
				target = pos1;
			}
		}
	}
}
