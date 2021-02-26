using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadcrumbsState : MonoBehaviour {
	public static BreadcrumbsState Instance;

  [Header("Menu Controllers")]
  [SerializeField] private MainMenuController mainMenu;
  [SerializeField] private CrumbMenuController crumbMenu;
  [SerializeField] private SettingsMenuController settingsMenu;

  public List<Crumb> Crumbs;

  public Crumb CurrentCrumb {
    get {
      if (currentCrumb == null) {
        currentCrumb = new Crumb();
        Crumbs.Add(currentCrumb);
      }
      return currentCrumb;
    }
  }
  private Crumb currentCrumb;

  public void Start() {
    if (Instance == null) { Instance = this; }
    Crumbs = new List<Crumb>();
  }

  public void SelectCrumb(Crumb c) {
    currentCrumb = Crumbs.Find(crumb => crumb.Equals(c));
    mainMenu.gameObject.SetActive(false);
    crumbMenu.gameObject.SetActive(true);
    crumbMenu.SetCrumb(c);
  }

  public void DeselectCrumb() {
    currentCrumb = null;
  }

  public bool CrumbSelected() {
    return currentCrumb != null;
  }

  // On quit, save to data path
  private void OnApplicationQuit() {

  }
}
