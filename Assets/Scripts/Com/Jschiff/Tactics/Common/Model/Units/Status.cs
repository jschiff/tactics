using System.Collections.Generic;

namespace Com.Jschiff.Tactics.Common.Model.Units
{
  public class Status {
    private IList<AttributesModifier> modifiers = new List<AttributesModifier>();
    
    public Status() {
    }
    
    public Status AddModifier(AttributesModifier modifier) {
      modifiers.Add(modifier);
      return this;
    }
  }
}