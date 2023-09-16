using UnityEngine;
using System.Collections;
using System;

namespace CavalerulCazut
{
    public class UniqueId : MonoBehaviour
    {
        [SerializeField]
        private string m_Uid = Guid.NewGuid().ToString();

        public string Uid { get { return m_Uid; } }
    }
}
