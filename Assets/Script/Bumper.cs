using UnityEngine;

public class Bumper : MonoBehaviour
{

    public float forceMagnitude = 5f;  //adjust this value to change the strength of the force

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //detecte collision avec la balle


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponent<Ball>() != null) //
        {
            Debug.Log("Bumper hit the ball");

            //add a force to the ball in the direction of  y axis of the bumper
            //declare une variable type rigidbody qui s'appelle ballrigidbody
            Rigidbody ballRigidbody = collision.gameObject.GetComponent<Rigidbody>();//donne moi le Rigidbody et stock la référence dans la variable ballrigidbody
            Vector3 forceDirection = transform.up;//y axis of the bumper //transform est aussi une variable de l'objet bumper
            //float est un type de varibale qui signifie un nombre entier
            //float forceMagnitude = 5f; //adjust this value to change the strength of the force 
            ballRigidbody.AddForce(forceDirection * forceMagnitude, ForceMode.Impulse);
            //ForceMode est une classe qui existe dans Unity 
        }
    }

}
