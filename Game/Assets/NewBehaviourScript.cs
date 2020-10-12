using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour

{
    public Transform white_tokenObj;
    public Transform black_tokenObj;

    public static int i = 0;




    // Start is called before the first frame update
    void Start()
    {
        GameObject g = GameObject.Find("square");
        Transform t;

       
        t = Instantiate(white_tokenObj, g.transform.position, white_tokenObj.rotation);
         Destroy(t.gameObject);
        Instantiate(black_tokenObj, g.transform.position, black_tokenObj.rotation);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnMouseDown()
    {
        if (i == 0)
        {
            Instantiate(black_tokenObj, transform.position, black_tokenObj.rotation);
            i = 1;

        }
        else if (i == 1)
        {
            Instantiate(white_tokenObj, transform.position, white_tokenObj.rotation);
            i = 0;
        }
    }
}
