using System.Collections;
using UnityEngine;

public class AutoDestroy : MonoBehaviour
{
    public float destroyTime = 10f;
   
    void Start()
    {
        StartCoroutine(DestroySelf());
    }

    IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(destroyTime);
        Destroy(this.gameObject);
    }
}
