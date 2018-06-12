namespace SAO.Attributes.Interfaces
{
    public interface ISAOPropertyValidator
    {
        void Validate(SAObject obj, object property);
    }
}