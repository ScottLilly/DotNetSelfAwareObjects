namespace SAO.Attributes.Interfaces
{
    public interface ISAOPropertyDefaultApplicator
    {
        bool NeedsDefaultApplied(object property);
        object DefaultValue { get; }
    }
}
