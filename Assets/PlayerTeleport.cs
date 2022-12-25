using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleport : MonoBehaviour
{

    [SerializeField] GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

       /* if (Input.GetMouseButtonDown(0))
        {
            gameObject.transform.position = new Vector3(138f, 30f, 0f);
        } */

    }

    void OnMouseDown()
    {
        player.transform.position = new Vector3(150f, 30f, 0f);
    }

}
