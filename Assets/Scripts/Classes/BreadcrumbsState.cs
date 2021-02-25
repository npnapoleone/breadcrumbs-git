using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadcrumbsState : MonoBehaviour {
	public static BreadcrumbsState Instance;

    public Crumb[] Crumbs;
    public Loaf[] Loafs;

    public void Start() {
    	if (Instance == null) { Instance = this; }
    }
}
