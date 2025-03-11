using System.Collections;
using System.Collections.Generic;
using System.Drawing.Text;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using TMPro;


public class Scanner1 : XRGrabInteractable
{
    [Header("Scanner Data")]
    public Animator animator;
    public LineRenderer laserRenderer;
    public TextMeshProUGUI targetName;
    public TextMeshProUGUI targetPosition;
    // Start is called before the first frame update

    private void Start()
    {
        
    }
    protected override void Awake()
    {
        base.Awake();
        laserRenderer.gameObject.SetActive(false);
        targetName.gameObject.SetActive(false);
        targetPosition.gameObject.SetActive(false);
    }

    protected override void OnSelectEntered(SelectEnterEventArgs args)
    {
        base.OnSelectEntered(args);
        animator.SetBool("Opened", true);
    }

    protected override void OnSelectExited(SelectExitEventArgs args)
    {
        base.OnSelectExited(args);
        animator.SetBool("Opened", false);
    }

    

    protected override void OnActivated(ActivateEventArgs args) 
    {
        base.OnActivated(args);
        laserRenderer.gameObject.SetActive(true);
        targetName.gameObject.SetActive(false);
        targetPosition.gameObject.SetActive(false);
    }

    protected override void OnDeactivated(DeactivateEventArgs args)
    {
        base.OnDeactivated(args);
        laserRenderer.gameObject.SetActive(false);
        targetName.gameObject.SetActive(false);
        targetPosition.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
