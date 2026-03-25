using Microsoft.EntityFrameworkCore;
using Craft.Persistence.EntityFrameworkCore;
using C2IEDM.Domain.Entities.Geometry;
using C2IEDM.Persistence.Repositories.Geometry;

namespace C2IEDM.Persistence.EntityFrameworkCore.Repositories.Geometry;

public class VerticalDistanceRepository : Repository<VerticalDistance>, IVerticalDistanceRepository
{
    public VerticalDistanceRepository(DbContext context) : base(context)
    {
    }

    public override Task Clear()
    {
        throw new NotImplementedException();
    }

    public override Task Update(VerticalDistance entity)
    {
        throw new NotImplementedException();
    }

    public override Task UpdateRange(IEnumerable<VerticalDistance> entities)
    {
        throw new NotImplementedException();
    }
}