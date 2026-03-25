using C2IEDM.Domain.Entities.Geometry.Locations.Points;
using C2IEDM.Persistence.Repositories.Geometry;
using Craft.Persistence.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace C2IEDM.Persistence.EntityFrameworkCore.Repositories.Geometry;

public class RelativePointRepository : Repository<RelativePoint>, IRelativePointRepository
{
    public RelativePointRepository(DbContext context) : base(context)
    {
    }

    public override Task Clear()
    {
        throw new NotImplementedException();
    }

    public override Task Update(RelativePoint entity)
    {
        throw new NotImplementedException();
    }

    public override Task UpdateRange(IEnumerable<RelativePoint> entities)
    {
        throw new NotImplementedException();
    }
}