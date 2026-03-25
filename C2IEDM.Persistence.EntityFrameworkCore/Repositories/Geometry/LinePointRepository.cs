using Microsoft.EntityFrameworkCore;
using Craft.Persistence.EntityFrameworkCore;
using C2IEDM.Persistence.Repositories.Geometry;
using C2IEDM.Domain.Entities.Geometry.Locations.Line;

namespace C2IEDM.Persistence.EntityFrameworkCore.Repositories.Geometry
{
    public class LinePointRepository : Repository<LinePoint>, ILinePointRepository
    {
        public LinePointRepository(DbContext context) : base(context)
        {
        }

        public override Task Clear()
        {
            throw new NotImplementedException();
        }

        public override Task Update(LinePoint entity)
        {
            throw new NotImplementedException();
        }

        public override Task UpdateRange(IEnumerable<LinePoint> entities)
        {
            throw new NotImplementedException();
        }
    }
}
