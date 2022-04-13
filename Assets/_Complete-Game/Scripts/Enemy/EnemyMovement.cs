using UnityEngine;
using System.Collections;
using UnityEngine.AI;
namespace CompleteProject
{
    public class EnemyMovement : MonoBehaviour
    {
        Transform player;               // Reference to the player's position.
        PlayerHealth playerHealth;      // Reference to the player's health.
        EnemyHealth enemyHealth;        // Reference to this enemy's health.
        UnityEngine.AI.NavMeshAgent nav;               // Reference to the nav mesh agent.
        public float speedMove = 5f;
        //public float lookRadius = 10f;
        //public Transform target;
        //public NavMeshAgent agent;

        //private void Start()
        //{
        //    target = PlayerManager.instance.player.transform;
        //    agent = GetComponent<NavMeshAgent>();
        //}

        void Awake()
        {
            // Set up the references.
            player = GameObject.FindGameObjectWithTag("Player").transform;
            playerHealth = player.GetComponent<PlayerHealth>();
            enemyHealth = GetComponent<EnemyHealth>();
            nav = GetComponent<UnityEngine.AI.NavMeshAgent>();
        }


        void Update()
        {
            if (GameManager.Instance.mGameState == GameState.Playing)
            {
                //float distance = Vector3.Distance(target.position, transform.position);

                //if (distance <= lookRadius)
                //{
                //    agent.SetDestination(target.position);
                //}

                // If the enemy and the player have health left...
                //if (enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
                //{
                // ... set the destination of the nav mesh agent to the player.
                //nav.SetDestination(player.position);
                //}
                // Otherwise...
                //else
                //{
                //    // ... disable the nav mesh agent.
                //    nav.enabled = false;
                //    //}
                float x = player.transform.position.x - transform.position.x;
                float z = player.transform.position.z - transform.position.z - 0.5f;
                Vector3 direction = new Vector3(x, 0, z);

                transform.forward = direction;
                Vector3 poshere = transform.position;
                Vector3 posnext = transform.position + direction;
                transform.position = Vector3.MoveTowards(poshere, posnext, speedMove * Time.deltaTime);
                //}

                //private void OnDrawGizmosSelected()
                //{
                //    Gizmos.color = Color.red;
                //    Gizmos.DrawWireSphere(transform.position, lookRadius);
                //}
                faceEnemy();
            }
          
        }
        void faceEnemy()
        {
            Vector3 direction = (player.position - transform.position).normalized;
            Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
        }
    }
}
