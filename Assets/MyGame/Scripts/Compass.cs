using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Compass : MonoBehaviour
{
    public PGManager manager;
    public GameObject camera;
    private GameObject player;
    public Image img;

    private void Start()
    {
        player = camera.transform.parent.parent.gameObject;
    }
    private void Update()
    {
        GameObject nextButton = manager.GetNextButton();

        Vector3 dir = player.transform.InverseTransformDirection(nextButton.transform.position - player.transform.position);
        float angle = Mathf.Atan2(-dir.x, dir.z) * Mathf.Rad2Deg;
        transform.localEulerAngles = new Vector3(0, 0, angle + camera.transform.localEulerAngles.y);
    }
}
