using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    private Renderer rend;
    public Color[] colors;
    public float speed = 2.5f, radius;
    public Transform pointA, pointB;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        transform.position = Vector3.zero;
    }
    void OnMouseDrag()
    {
        rend.material.color = colors[Random.Range(0, colors.Length)];
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * speed * Time.time);
        //transform.position = Vector3.Lerp(pointA.position, pointB.position, speed * Time.time);
        //transform.position = Vector3.MoveTowards(transform.position, pointB.position, speed * Time.deltaTime);
        float distance = Vector3.Distance(transform.position, pointA.position);
        Debug.Log(distance);
    }
}


/* NOTES
 *  Unity Functions:
 *      START = Start()
 *      UPDATE = Update()
 *          - FIXED UPDATE = FixedUpdate()
 *          - LATE UPDATE = LateUpdate()
 *      ONENABLE = OnEnable()
 *      ONDISABLE = OnDisable()
 *      ONMOUSEDOWN = OnMouseDown()
 *      ONMOUSEUP = OnMouseUp()
 *      ONMOUSEENTER = OnMouseEnter()
 *      ONMOUSEEXIT = OnMouseExit()
 *      ONMOUSEDRAG = OnMouseDrag()
 *      
 *      ONDRAWGIZMOS = OnDrawGizmos() = for devs only
 *      
 *  Vector3(x,y,z);
 *  Vector3.position(x,y,z);
 *  ZERO (0, 0, 0) = Vector3.zero
 *  BACK (0, 0, -1) = Vector3.back
 *  FORWARD (0, 0, 1) = Vector3.forward
 *  LEFT (-1, 0, 0) = Vector3.left
 *  RIGHT (1, 0, 0) = Vector3.right
 *  UP (0, 1, 0) = Vector3.up
 *  DOWN (0, -1, 0) = Vector3.down
 *  
 *  transform.Translate() = moves the current transform and magnitude
 *  Time.deltaTime
 *  Time.time
 *  Lerp = set two positions, one as position, the other is the destination
 *  MoveTowards
 *  Distance = gets distance between two objects
 */