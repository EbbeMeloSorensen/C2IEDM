using Microsoft.EntityFrameworkCore;
using Craft.Persistence.EntityFrameworkCore;
using C2IEDM.Persistence.Repositories.Geometry;
using C2IEDM.Domain.Entities.Geometry.Locations.Surfaces;

namespace C2IEDM.Persistence.EntityFrameworkCore.Repositories.Geometry
{
    public class EllipseRepository : Repository<Ellipse>, IEllipseRepository
    {
        public EllipseRepository(DbContext context) : base(context)
        {
        }

        public override Task Clear()
        {
            throw new NotImplementedException();
        }

        public override Task Update(Ellipse entity)
        {
            throw new NotImplementedException();
        }

        public override Task UpdateRange(IEnumerable<Ellipse> entities)
        {
            throw new NotImplementedException();
        }
    }
}
