using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    private CharacterController con;
    private Vector3 direct;
    public float TheSpeed;
    public float jumpforc ;
    public float grav = -20;
    //public float jum;
    public float LeftRightSpeed = 5.0f;
    public float lane = 1;
    public float laneds = 3;
    private Rigidbody rb;
    
    
    
    void Start()
    {
        con = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //direct.z = TheSpeed;


        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    lane++;
        //    if (lane==3)
        //    {
        //        lane = 2;
        //    }
        //}

        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    lane--;
        //    if (lane == -1)
        //    {
        //        lane = 0;
        //    }
        //}

        //Vector3 newpos = transform.position.z * transform.forward + transform.position.y * transform.up;

        //if(lane==0)
        //{
        //    newpos += Vector3.left * laneds;
        //}
        //else if(lane==2)
        //{
        //    newpos += Vector3.right * laneds;
        //}
        //transform.position = newpos;

        
         transform.Translate(Vector3.forward * Time.deltaTime * TheSpeed, Space.World);
         if (Input.GetKey(KeyCode.LeftArrow))     //to  move left
         {
             if (this.gameObject.transform.position.x > LevelBound.LeftSide)
             {
                 transform.Translate(Vector3.left * Time.deltaTime * LeftRightSpeed);
             }
         }

         if (Input.GetKey(KeyCode.RightArrow))      /// to move right
         {

             if (this.gameObject.transform.position.x < LevelBound.RightSide)
             {
                 transform.Translate(Vector3.right * Time.deltaTime * LeftRightSpeed);
             }


         }
        TheSpeed += (0.1f * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.UpArrow) && con.isGrounded)
        {
            //direct.y = -1;
            //jump();
        }
        else
        {
            direct.y += grav * Time.deltaTime;
        }



    }
     private void jump()
    {
        //direct.y = jumpforc;
    }
    //private void FixedUpdate()
    //{
    //    con.Move(direct * Time.fixedDeltaTime);
    //}
    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    if(hit.transform.tag=="obes")
    //    {
    //        playermanager.go = true;
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "obes")
        {
            playermanager.go = true;
        }
    }


}
////

//

////direct.y += grav * Time.deltaTime;

//
//{
//    Lande--;
//    if (Lande == -1)
//    {
//        Lande = 0;
//    }

//    //

//}



//}
//Vector3 newpos = transform.position.z * transform.forward + transform.position.y * transform.up;
//if (Lande == 0)   //move to left
//{
//    newpos += Vector3.left * Landedes;
//}

//if (Lande == 2)   //move to right
//{
//    newpos += Vector3.right * Landedes;
//}

//transform.position = newpos;

//if (Input.GetKeyDown(KeyCode.UpArrow))
//{
//    //transform.Translate(Vector3.up * Time.deltaTime * jumpforc);
//    jump();
//}
//    }
//   
//private void jump()
//{
//    direct.y = grav;
//}
/*
private void FixedUpdate()
{
    con.Move(direct * Time.fixedDeltaTime);
}*/