using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crumb
{
  public string Key {
    get {
      return key;
    }
  }
  public string Title;
  public string Description;
  public int EstimatedStartTime;
  public int EstimatedEndTime;

  private string key;
  private DateTime createdAt;
  private DateTime updatedAt;

  public Crumb() {
    createdAt = updatedAt = DateTime.UtcNow;
    key = updatedAt.ToString();
  }

  public bool Equals(Crumb other) {
    return this.Key == other.Key;
  }

  public override string ToString() {
    return "";
  }
}
