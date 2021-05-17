using UnityEngine;

public class playerDetection : MonoBehaviour
{

    public Rigidbody rb;
    public BoxCollider bc;
    public MeshRenderer mr;
    public int damage = 0;


    void OnCollisionStay (Collision col)
    {
        if (col.collider.tag == "Player")
        {   
            damage = damage + 1;


            // activate gravity
            if (damage == 40)
            {
                rb.constraints = RigidbodyConstraints.None;
                rb.constraints = RigidbodyConstraints.FreezePositionX;
                rb.constraints = RigidbodyConstraints.FreezePositionZ;

                Invoke("removePlatform", 2.0f);

            }
        }
    }

    private void removePlatform()
    {
        bc.enabled = !bc.enabled;
        mr.enabled = !mr.enabled;
    }
}
