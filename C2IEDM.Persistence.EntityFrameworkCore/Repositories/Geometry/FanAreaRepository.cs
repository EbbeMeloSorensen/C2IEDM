using Microsoft.EntityFrameworkCore;
using Craft.Persistence.EntityFrameworkCore;
using C2IEDM.Persistence.Repositories.Geometry;
using C2IEDM.Domain.Entities.Geometry.Locations.Surfaces;

namespace C2IEDM.Persistence.EntityFrameworkCore.Repositories.Geometry;

public class FanAreaRepository : Repository<FanArea>, IFanAreaRepository
{
    public FanAreaRepository(DbContext context) : base(context)
    {
    }

    public override Task Clear()
    {
        throw new NotImplementedException();
    }

    public override Task Update(FanArea entity)
    {
        throw new NotImplementedException();
    }

    public override Task UpdateRange(IEnumerable<FanArea> entities)
    {
        throw new NotImplementedException();
    }
}