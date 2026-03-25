using C2IEDM.Domain.Entities.Geometry.Locations.Surfaces;
using C2IEDM.Persistence.Repositories.Geometry;
using Craft.Persistence.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace C2IEDM.Persistence.EntityFrameworkCore.Repositories.Geometry;

public class OrbitAreaRepository : Repository<OrbitArea>, IOrbitAreaRepository
{
    public OrbitAreaRepository(DbContext context) : base(context)
    {
    }

    public override Task Clear()
    {
        throw new NotImplementedException();
    }

    public override Task Update(OrbitArea entity)
    {
        throw new NotImplementedException();
    }

    public override Task UpdateRange(IEnumerable<OrbitArea> entities)
    {
        throw new NotImplementedException();
    }
}