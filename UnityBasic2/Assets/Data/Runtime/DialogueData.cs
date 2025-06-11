using UnityEngine;
using System.Collections;

///
/// !!! Machine generated code !!!
/// !!! DO NOT CHANGE Tabs to Spaces !!!
/// 
[System.Serializable]
public class DialogueData
{
  [SerializeField]
  int id;
  public int ID { get {return id; } set { this.id = value;} }
  
  [SerializeField]
  int character;
  public int Character { get {return character; } set { this.character = value;} }
  
  [SerializeField]
  int position;
  public int Position { get {return position; } set { this.position = value;} }
  
  [SerializeField]
  string bgimage;
  public string Bgimage { get {return bgimage; } set { this.bgimage = value;} }
  
  [SerializeField]
  string dialogue;
  public string Dialogue { get {return dialogue; } set { this.dialogue = value;} }
  
}