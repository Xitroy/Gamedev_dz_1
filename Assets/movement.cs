using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
	public float Speed =1f;
	public Vector3 Directon1 = Vector3.forward;
	public Vector3 Directon2 = Vector3.left;
	private Rigidbody _rigidbody;
	private int _directionIndex = 0;

	private Vector3 GetDirection()
	{
		if (_directionIndex==0) return Directon1;
		return Directon2;
	}

	void Awake()
	{
		_rigidbody = GetComponent<Rigidbody>();

	}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    	if (Input.GetMouseButtonDown(0))
    	{
    		if(_directionIndex==0) _directionIndex=1;
    		else _directionIndex=0;
    	}
        //transform.position+=Vector3.forward*Time.deltaTime;
    }

    private void FixedUpdate()
    {
    	Vector3 velocity = GetDirection () * Speed;
    	velocity.y = _rigidbody.velocity.y;
    	_rigidbody.velocity=velocity;
    }
}
