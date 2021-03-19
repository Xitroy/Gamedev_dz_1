using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class finish : MonoBehaviour
{ 
	private void OnTriggerEnter(Collider other)

	{
		Debug.Log("Finish");
		if (other.CompareTag("Player"))
		{
			Destroy(other.gameObject);
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
