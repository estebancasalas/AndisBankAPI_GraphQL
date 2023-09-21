using AndisbankAPI_GraphQL.Models;

namespace AndisbankAPI_GraphQL.GraphQL.Types
{
    public class LoanGraphQL : ObjectType<Loan>
    {
        protected override void Configure(IObjectTypeDescriptor<Loan> descriptor)
        {
            descriptor.BindFieldsImplicitly();
        }
    }
}
