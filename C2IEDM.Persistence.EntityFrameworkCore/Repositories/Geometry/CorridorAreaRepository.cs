using Microsoft.EntityFrameworkCore;
using Craft.Persistence.EntityFrameworkCore;
using C2IEDM.Persistence.Repositories.Geometry;
using C2IEDM.Domain.Entities.Geometry.Locations.Surfaces;

namespace C2IEDM.Persistence.EntityFrameworkCore.Repositories.Geometry;

public class CorridorAreaRepository : Repository<CorridorArea>, ICorridorAreaRepository
{
    public CorridorAreaRepository(DbContext context) : base(context)
    {
    }

    public override Task Clear()
    {
        throw new NotImplementedException();
    }

    public override Task Update(CorridorArea entity)
    {
        throw new NotImplementedException();
    }

    public override Task UpdateRange(IEnumerable<CorridorArea> entities)
    {
        throw new NotImplementedException();
    }
}