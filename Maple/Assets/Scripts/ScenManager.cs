using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenManager : MonoBehaviour
{
  
        public static ScenManager Instance
        {
            get
            {
                return instance;
            }
        }
        private static ScenManager instance;

        void Start()
        {
            if (instance != null)
            {
                DestroyImmediate(this.gameObject);
                return;
            }
            instance = this;

            DontDestroyOnLoad(gameObject);
        }
    
}
