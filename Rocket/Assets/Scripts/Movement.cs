using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody myRigidbody;
    [SerializeField]float thrustSpeed=1;
    [SerializeField]float rotationSpeed=1;

    // Start is called before the first frame update
    void Start()
    {
        myRigidbody=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInput();
        ProcessThrust();
    }

    private void ProcessInput(){      

      if(Input.GetKey(KeyCode.A)){
        Rotate(rotationSpeed);
      }
      else if(Input.GetKey(KeyCode.D)){
          Rotate(-rotationSpeed);
      }

    }


    private void Rotate(float rotationThrust){
        
        myRigidbody.freezeRotation=true; 
        transform.Rotate(Vector3.forward*rotationThrust*Time.deltaTime);
        myRigidbody.freezeRotation=false;

    }
    private void ProcessThrust(){

        if(Input.GetKey(KeyCode.Space)){

          myRigidbody.AddRelativeForce(0,thrustSpeed*Time.deltaTime,0);

      }


    }





}
