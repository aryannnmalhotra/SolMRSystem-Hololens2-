using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Interactivity : MonoBehaviour
{
    private bool isReticleEnabled;
    private bool comparisonLoading;
    private float reticleFillAmount;
    private GameObject currentObject;
    private GameObject compareObject;
    private AudioSource soundPlayer;
    public int CurrentIndex;
    public GameObject MenuPanel;
    public GameObject CompareMenuPanel;
    public GameObject ResetButton;
    public GameObject CompareButton;
    public Vector3 PositionToRenderAt;
    public Image ReticleImage;
    public Camera FirstPersonCamera;
    public AudioClip MenuPop;
    public AudioClip RenderEntityCue;
    void Start()
    {
        soundPlayer = GetComponent<AudioSource>();
    }
    public void RenderEntity(GameObject objectToSpawn)
    {
        MenuPanel.SetActive(false);
        ResetButton.SetActive(true);
        CompareButton.SetActive(true);
        if (currentObject)
        {
            if (compareObject)
            {
                Destroy(compareObject);
            }
            compareObject = Instantiate(objectToSpawn) as GameObject;
            compareObject.transform.position = PositionToRenderAt;
            CompareMenuPanel.SetActive(false);
        }
        else
        currentObject = Instantiate(objectToSpawn) as GameObject;
        currentObject.transform.position = PositionToRenderAt;
        CurrentIndex = currentObject.GetComponent<Entity>().EntityIndex;
        soundPlayer.PlayOneShot(RenderEntityCue);

    }
    public GameObject GetCurrentEntity()
    {
        return currentObject;
    }
    public GameObject GetCompareEntity()
    {
        return compareObject;
    }
    public void Reset()
    {
        ResetButton.SetActive(false);
        CompareButton.SetActive(false);
        Destroy(currentObject);
        if (compareObject)
            Destroy(compareObject);
        if (isReticleEnabled)
        {
            ReticleImage.enabled = false;
            isReticleEnabled = false;
        }
        CompareMenuPanel.SetActive(false);
        MenuPanel.SetActive(true);
        soundPlayer.PlayOneShot(MenuPop);
    }
    public void CompareCall()
    {
        CompareButton.SetActive(false);
        ResetButton.SetActive(false);
        CompareMenuPanel.SetActive(true);
        soundPlayer.PlayOneShot(MenuPop);
    }
    void Update()
    {
        Ray ray = new Ray(FirstPersonCamera.transform.position, FirstPersonCamera.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.GetComponent<Entity>())
            {
                if (!isReticleEnabled)
                {
                    reticleFillAmount = 0;
                    ReticleImage.fillAmount = reticleFillAmount;
                    ReticleImage.enabled = true;
                    isReticleEnabled = true;
                }
                else
                {
                    reticleFillAmount = Mathf.Clamp(reticleFillAmount + Time.deltaTime / 2, 0, 1);
                    ReticleImage.fillAmount = reticleFillAmount;
                    if (reticleFillAmount >= 1)
                    {
                        ReticleImage.enabled = false;
                        isReticleEnabled = false;
                        hit.transform.gameObject.GetComponent<Entity>().TogglePanel();
                    }
                }
            }
            else
            {
                ReticleImage.enabled = false;
                isReticleEnabled = false;
            }
        }
        else
        {
            ReticleImage.enabled = false;
            isReticleEnabled = false;
        }
    }
}
