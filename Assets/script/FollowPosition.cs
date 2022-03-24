using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPosition : MonoBehaviour
{
    public Transform targetTransform = null;

    void Update()
    {
        // Nullcheck
        if (this.targetTransform != null)
        {
            // Affecte la position
            this.transform.position = new Vector3(this.targetTransform.position.x, this.targetTransform.position.y, this.transform.position.z);
        }
    }
}
