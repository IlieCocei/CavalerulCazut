using Cinemachine;
using UnityEngine;

namespace CavalerulCazut
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField]
        CinemachineFreeLook freeLookCamera; 
        public KeyCode rotateButton = KeyCode.LeftAlt;


        public CinemachineFreeLook PlayerCam
        {
            get
            {
                return freeLookCamera;
            }
        }

        private void Awake()
        {
            Cursor.visible = false; // Ascunde cursorul la începutul jocului
            Cursor.lockState = CursorLockMode.Locked; // Blochează cursorul în centru ecranului
        }

        // Update is called once per frame
        void Update()
        {

            if (Input.GetKey(rotateButton))
            {
                freeLookCamera.m_XAxis.m_MaxSpeed = 0;
                freeLookCamera.m_YAxis.m_MaxSpeed = 0;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                freeLookCamera.m_XAxis.m_MaxSpeed = 400;
                freeLookCamera.m_YAxis.m_MaxSpeed = 10;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
        }
    }
}
