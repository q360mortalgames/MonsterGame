using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchControl : MonoBehaviour
{
    Vector3 desiredPos, offset, touchPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(0);
        }
        if(Input.GetMouseButtonDown(0))
        {
            touchPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            touchPos = Camera.main.ScreenToWorldPoint(touchPos);
            offset = transform.position - touchPos /*new Vector3(touchPos.x, touchPos.y, 0)*/;
            print(touchPos + "touchPos");
            print(offset + "offset");
        }
        if (Input.GetMouseButton(0))
        {
            touchPos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10);
            touchPos = Camera.main.ScreenToWorldPoint(touchPos);
            desiredPos = new Vector3(touchPos.x,touchPos.y,transform.position.z) + new Vector3(offset.x, offset.y, 0);
            transform.position = Vector3.Lerp(transform.position, desiredPos, Time.deltaTime * 10);
        }

    }
}
