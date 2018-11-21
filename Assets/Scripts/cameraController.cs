using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour {
    private float x;
    private float y;
    private Vector3 rotateValue;

    Vector2 mouseLook;
    Vector2 smoothV;
    public float sensitivity = 1.0f;
    public float smoothing = 1.0f;
    GameObject character;
    public float speed = 180.0f;
 
    void Update()
    {
        //Mouse Controls
        if(Input.GetMouseButton(0)){
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;

            /*
            y = Input.GetAxis("Mouse X");
            x = Input.GetAxis("Mouse Y");

            Debug.Log(x + ":" + y);
            rotateValue = new Vector3(x, y * -1, 0);
            transform.eulerAngles = transform.eulerAngles - (rotateValue * 2);
            */

            var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

            md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
            smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f /smoothing);
            smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f /smoothing);
            mouseLook += smoothV;
            mouseLook.y = Mathf.Clamp(mouseLook.y,-90f,90f);

            transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        }else{
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }

        //Keyboard
        if(Input.GetKey(KeyCode.DownArrow))
        {
            transform.Rotate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Rotate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
        }

        //WASD
        if(Input.GetKey(KeyCode.S))
        {
            transform.Rotate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
        if(Input.GetKey(KeyCode.W))
        {
            transform.Rotate(new Vector3(-speed * Time.deltaTime, 0, 0));
        }
        if(Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -speed * Time.deltaTime, 0));
        }
        if(Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0, speed * Time.deltaTime, 0));
        }

        //Lock Z
        float z = transform.eulerAngles.z;
        transform.Rotate(0, 0, -z);
    }
}
