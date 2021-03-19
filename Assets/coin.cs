using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{ 
	private void OnTriggerEnter(Collider other)

	{
		Debug.Log("+1 coin");
		if (other.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
	}
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
