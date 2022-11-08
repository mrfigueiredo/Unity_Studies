using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Screens
{
    public class Typper : MonoBehaviour
    {
        public TextMeshProUGUI textMesh;

        public float timeBetweenLetters = .1f;

        public bool typeOnStart = true;

        private string _nullString = "";

        public string text;

        private void Awake()
        {
            textMesh.text = _nullString;
        }

        private void Start()
        {
            if (typeOnStart)
                StartType();
        }

        [Button]
        private void StartType()
        {
            StartCoroutine(Type(text));
        }

        IEnumerator Type(string s)
        {
            textMesh.text = _nullString;

            foreach(char c in s.ToCharArray())
            {
                textMesh.text += c;

                yield return new WaitForSeconds(timeBetweenLetters);
            }
        }
    }
}