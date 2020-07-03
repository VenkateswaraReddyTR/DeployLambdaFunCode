using TRTA.Diagnostics.Domain;

namespace TRTA.Diagnostics.Repository
{
    public interface ISchemaTypeService
    {
        EfileSchemaType GetSchemaType(string name);
    }
}