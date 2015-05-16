namespace Com.Jschiff.Tactics.Common.Model.Combat
{
  public abstract class EffectModifier {
    public EffectModifier() {
    }
    
    public abstract Effect Modify(Effect effect);
  }
}

