using C2IEDM.Domain.Entities.ObjectItems.Organisations;
using C2IEDM.Persistence.Repositories.ObjectItems;
using Craft.Persistence.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace C2IEDM.Persistence.EntityFrameworkCore.Repositories.ObjectItems;

public class OrganisationRepository : Repository<Organisation>, IOrganisationRepository
{
    public OrganisationRepository(DbContext context) : base(context)
    {
    }

    public override Task Clear()
    {
        throw new NotImplementedException();
    }

    public override Task Update(Organisation entity)
    {
        throw new NotImplementedException();
    }

    public override Task UpdateRange(IEnumerable<Organisation> entities)
    {
        throw new NotImplementedException();
    }
}