using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosivePotato : Potato
{
    public int range = 10;

    public override void Destroy()
    {
        Explosion();
        Debug.Log("Explosive Potato Destroy");
        Destroy(gameObject);
    }

    private void Explosion()
    {

        Collider[] hitColliders = Physics.OverlapSphere(transform.position, range);
        foreach (var hitCollider in hitColliders)
        {
            Body body = hitCollider.GetComponent<Body>();
            if (body != null)
            {
                body.HPChanger(damage);
            }
        }
    }
}
