using C2IEDM.Domain.Entities.Geometry.CoordinateSystems;
using C2IEDM.Persistence.Repositories.Geometry;
using Craft.Persistence.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace C2IEDM.Persistence.EntityFrameworkCore.Repositories.Geometry;

public class PointReferenceRepository : Repository<PointReference>, IPointReferenceRepository
{
    public PointReferenceRepository(DbContext context) : base(context)
    {
    }

    public override Task Clear()
    {
        throw new NotImplementedException();
    }

    public override Task Update(PointReference entity)
    {
        throw new NotImplementedException();
    }

    public override Task UpdateRange(IEnumerable<PointReference> entities)
    {
        throw new NotImplementedException();
    }
}