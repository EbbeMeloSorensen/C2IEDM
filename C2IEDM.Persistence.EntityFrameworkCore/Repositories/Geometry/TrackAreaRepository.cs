using C2IEDM.Domain.Entities.Geometry.Locations.Surfaces;
using C2IEDM.Persistence.Repositories.Geometry;
using Craft.Persistence.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace C2IEDM.Persistence.EntityFrameworkCore.Repositories.Geometry;

public class TrackAreaRepository : Repository<TrackArea>, ITrackAreaRepository
{
    public TrackAreaRepository(DbContext context) : base(context)
    {
    }

    public override Task Clear()
    {
        throw new NotImplementedException();
    }

    public override Task Update(TrackArea entity)
    {
        throw new NotImplementedException();
    }

    public override Task UpdateRange(IEnumerable<TrackArea> entities)
    {
        throw new NotImplementedException();
    }
}