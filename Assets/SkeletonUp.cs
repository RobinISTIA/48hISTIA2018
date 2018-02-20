using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonUp : MonoBehaviour {

    public GameObject skeleton1;
    public GameObject skeleton2;
    public GameObject skeleton3;
    Animator animator1;
    Animator animator2;
    Animator animator3;
    void Start() {
        animator1 = skeleton1.GetComponent<Animator>();
        animator2 = skeleton2.GetComponent<Animator>();
        animator3 = skeleton3.GetComponent<Animator>();
    }

    void OnTriggerEnter(Collider other) {
        if (other.name == "Cube") {


            animator1.SetBool("skeletonUp", true);
            animator2.SetBool("skeletonUp", true);
            animator3.SetBool("skeletonUp", true);
            animator1.SetBool("skeletonDown", false);
            animator2.SetBool("skeletonDown", false);
            animator3.SetBool("skeletonDown", false);
            Debug.Log("ca trigger");
        }
        if (other.name == "Cube2") {
            animator1.SetBool("skeletonDown", true);
            animator2.SetBool("skeletonDown", true);
            animator3.SetBool("skeletonDown", true);
            animator1.SetBool("skeletonUp", false);
            animator2.SetBool("skeletonUp", false);
            animator3.SetBool("skeletonUp", false);

        }
    }
}