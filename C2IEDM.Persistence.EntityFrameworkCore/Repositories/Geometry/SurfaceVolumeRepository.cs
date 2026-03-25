using C2IEDM.Domain.Entities.Geometry.Locations.GeometricVolumes;
using C2IEDM.Persistence.Repositories.Geometry;
using Craft.Persistence.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace C2IEDM.Persistence.EntityFrameworkCore.Repositories.Geometry;

public class SurfaceVolumeRepository : Repository<SurfaceVolume>, ISurfaceVolumeRepository
{
    public SurfaceVolumeRepository(DbContext context) : base(context)
    {
    }

    public override Task Clear()
    {
        throw new NotImplementedException();
    }

    public override Task Update(SurfaceVolume entity)
    {
        throw new NotImplementedException();
    }

    public override Task UpdateRange(IEnumerable<SurfaceVolume> entities)
    {
        throw new NotImplementedException();
    }
}