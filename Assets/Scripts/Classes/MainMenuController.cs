using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour {
  [SerializeField] private RectTransform crumbContainer;
  [SerializeField] private CrumbPreview crumbPreview;


  private Dictionary<string, CrumbPreview> notes;

  private void Start() {
    notes = new Dictionary<string, CrumbPreview>();
  }

  private void FixedUpdate() {
    if (notes.Count != BreadcrumbsState.Instance.Crumbs.Count) {
      var crumbs = BreadcrumbsState.Instance.Crumbs;
      foreach (var crumb in crumbs) {
        if (notes.ContainsKey(crumb.Key)) { continue; }
        CrumbPreview newPreview = Instantiate(crumbPreview, crumbContainer);
        newPreview.SetCrumb(crumb);
        notes.Add(crumb.Key, newPreview);
      }
    }

    if (enabled && BreadcrumbsState.Instance.CrumbSelected()) {

    }
  }


}
