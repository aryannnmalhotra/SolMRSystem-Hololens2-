using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public int EntityIndex;
    public int RotationDirectionFactor;
    public GameObject Panel;
    void Start()
    {
        
    }
    void Update()
    {
        transform.Rotate(0, 30 * RotationDirectionFactor * Time.deltaTime, 0);
    }
    public void TogglePanel()
    {
        Panel.SetActive(!(Panel.activeSelf));
    }
    private void LateUpdate()
    {
        Panel.transform.rotation = Quaternion.Euler(gameObject.transform.rotation.x * -1.0f, 0, gameObject.transform.rotation.z * -1.0f);
    }
}
