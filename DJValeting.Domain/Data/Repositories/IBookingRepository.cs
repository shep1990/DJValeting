using DJValeting.Domain.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DJValeting.Domain.Data.Repositories
{
    public interface IBookingRepository
    {
        Task<DJValetingBookingEntity> AddAsync(DJValetingBookingEntity entity);
        Task<ICollection<DJValetingBookingEntity>> GetAllAsync();
        Task<DJValetingBookingEntity> GetSingleAsync(Expression<Func<DJValetingBookingEntity, bool>> predicate);
        Task<DJValetingBookingEntity> UpdateAsync(DJValetingBookingEntity entity);
    }
}
