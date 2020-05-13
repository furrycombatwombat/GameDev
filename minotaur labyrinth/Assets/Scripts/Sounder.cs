    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using Pathfinding;

    public class Sounder : MonoBehaviour
    {
        public AudioSource sound;
        private float timer;
        public float timecap;
        public Movement player;
        public float distancemultiplier;
        private float distance;
        public AIPath path;
        // Start is called before the first frame update
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {

                distance = Mathf.Pow((Mathf.Pow((GetComponent<Transform>().position.x) - player.GetComponent<Transform>().position.x, 2f) + Mathf.Pow(GetComponent<Transform>().position.y - player.GetComponent<Transform>().position.y, 2f)), 0.5f);
                 if (timer > timecap)
                  {

            sound.volume = (Mathf.Pow(1 / (path.remainingDistance + 1), 0.6f));
                    sound.Play();
                       timer = 0;
                     }
                   else
                    {
            timer += Time.deltaTime / (path.remainingDistance + 1);
                    }
        
        }
    }
