using C2IEDM.Domain.Entities.Geometry.Locations.GeometricVolumes;
using C2IEDM.Persistence.Repositories.Geometry;
using Craft.Persistence.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace C2IEDM.Persistence.EntityFrameworkCore.Repositories.Geometry;

public class ConeVolumeRepository : Repository<ConeVolume>, IConeVolumeRepository
{
    public ConeVolumeRepository(DbContext context) : base(context)
    {
    }

    public override Task Clear()
    {
        throw new NotImplementedException();
    }

    public override Task Update(ConeVolume entity)
    {
        throw new NotImplementedException();
    }

    public override Task UpdateRange(IEnumerable<ConeVolume> entities)
    {
        throw new NotImplementedException();
    }
}