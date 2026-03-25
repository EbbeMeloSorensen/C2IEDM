using C2IEDM.Domain.Entities.Geometry.Locations.GeometricVolumes;
using C2IEDM.Persistence.Repositories.Geometry;
using Craft.Persistence.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace C2IEDM.Persistence.EntityFrameworkCore.Repositories.Geometry;

public class GeometricVolumeRepository : Repository<GeometricVolume>, IGeometricVolumeRepository
{
    public GeometricVolumeRepository(DbContext context) : base(context)
    {
    }

    public override Task Clear()
    {
        throw new NotImplementedException();
    }

    public override Task Update(GeometricVolume entity)
    {
        throw new NotImplementedException();
    }

    public override Task UpdateRange(IEnumerable<GeometricVolume> entities)
    {
        throw new NotImplementedException();
    }
}