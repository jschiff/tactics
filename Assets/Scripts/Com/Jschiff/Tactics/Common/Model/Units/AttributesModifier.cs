
namespace Com.Jschiff.Tactics.Common.Model.Units
{
  public abstract class AttributesModifier {
    public AttributesModifier() {
    }
    
    public abstract Attributes Modify(Attributes attributes);
  }
}

