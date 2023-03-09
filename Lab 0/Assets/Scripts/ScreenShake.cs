using System.Collections;
using System.Diagnostics.SymbolStore;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    private float duration = 1.0f;
    bool shakin = false;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && !shakin)
        {
            StartCoroutine(Shake());
        }
    }

    IEnumerator Shake()
    {
        Vector3 prevPos = transform.position;
        float timeTaken = 0.0f;
        shakin = true;

        while (timeTaken < duration)
        {
            timeTaken+= Time.deltaTime;
            transform.position = prevPos + (Random.insideUnitSphere * .5f);
            yield return null;
        }

        shakin = false;
    }
}
