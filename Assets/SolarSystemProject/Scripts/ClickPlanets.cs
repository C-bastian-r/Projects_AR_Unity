using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ClickPlanets : MonoBehaviour
{
    [SerializeField]
    private Vector3 offset_follow;
    [SerializeField]
    private TMP_Text m_textMeshPro;
    [SerializeField]
    private string _description;
    private CinemachineVirtualCamera _virtualCamera;
    private GameObject obj;
    private void Start()
    {
        _virtualCamera = FindObjectOfType<CinemachineVirtualCamera>();
        obj = this.gameObject;
        var transposer = _virtualCamera.GetCinemachineComponent<CinemachineTransposer>();
        transposer.m_FollowOffset = new Vector3(-0.04f, 0.68f, 0.16f);
    }
    private void HandleClick()
    {
        m_textMeshPro.text = _description;
        if(_virtualCamera != null)
        {   
            //modificar los targets de follow y lookAt del cinemachine
            _virtualCamera.Follow = obj.transform;
            _virtualCamera.LookAt = obj.transform;

            //acceso a componentes bases de cinemachine
            var transposer = _virtualCamera.GetCinemachineComponent<CinemachineTransposer>();
            if (transposer != null) { 
                //modificación del Follow offset de los componentes del cinemachine (offset_follow -> Vector 3)
                transposer.m_FollowOffset = offset_follow;
            }
        }
        
    }

    private void OnMouseDown()
    {
        HandleClick();
    }

    public void OnButtonClick()
    {
        HandleClick();
    }

}
