using Microsoft.EntityFrameworkCore;
using Craft.Persistence.EntityFrameworkCore;
using C2IEDM.Domain.Entities.WIGOS.AbstractEnvironmentalMonitoringFacilities;
using C2IEDM.Persistence.Repositories.WIGOS;

namespace C2IEDM.Persistence.EntityFrameworkCore.Repositories.WIGOS.AbstractEnvironmentalMonitoringFacilities;

public class AbstractEnvironmentalMonitoringFacilityRepository : Repository<AbstractEnvironmentalMonitoringFacility>, IAbstractEnvironmentalMonitoringFacilityRepository
{
    public AbstractEnvironmentalMonitoringFacilityRepository(DbContext context) : base(context)
    {
    }

    public override async Task Clear()
    {
        await Task.Run(() =>
        {
            var context = Context as C2IEDMDbContextBase;

            context.RemoveRange(context.AbstractEnvironmentalMonitoringFacilities);
            context.SaveChanges();
        });
    }

    public override Task Update(AbstractEnvironmentalMonitoringFacility entity)
    {
        throw new NotImplementedException();
    }

    public override Task UpdateRange(IEnumerable<AbstractEnvironmentalMonitoringFacility> entities)
    {
        throw new NotImplementedException();
    }
}
