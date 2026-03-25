using C2IEDM.Domain.Entities.Geometry.Locations.Surfaces;
using C2IEDM.Persistence.Repositories.Geometry;
using Craft.Persistence.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace C2IEDM.Persistence.EntityFrameworkCore.Repositories.Geometry;

public class PolyArcAreaRepository : Repository<PolyArcArea>, IPolyArcAreaRepository
{
    public PolyArcAreaRepository(DbContext context) : base(context)
    {
    }

    public override Task Clear()
    {
        throw new NotImplementedException();
    }

    public override Task Update(PolyArcArea entity)
    {
        throw new NotImplementedException();
    }

    public override Task UpdateRange(IEnumerable<PolyArcArea> entities)
    {
        throw new NotImplementedException();
    }
}