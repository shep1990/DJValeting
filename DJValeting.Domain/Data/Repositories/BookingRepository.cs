using DJValeting.Domain.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DJValeting.Domain.Data.Repositories
{
    public class BookingRepository : IBookingRepository
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookingRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<DJValetingBookingEntity> AddAsync(DJValetingBookingEntity entity)
        {
            _unitOfWork.Context.Set<DJValetingBookingEntity>().Add(entity);

            await _unitOfWork.CommitAsync();

            return entity;
        }

        public async Task<ICollection<DJValetingBookingEntity>> GetAllAsync()
        {
            return await _unitOfWork.Context.Set<DJValetingBookingEntity>().ToListAsync();
        }

        public async Task<DJValetingBookingEntity> GetSingleAsync(Expression<Func<DJValetingBookingEntity, bool>> predicate)
        {
            return await _unitOfWork.Context.Set<DJValetingBookingEntity>().SingleOrDefaultAsync(predicate);
        }

        public async Task<DJValetingBookingEntity> UpdateAsync(DJValetingBookingEntity entity)
        {
            _unitOfWork.Context.Entry(entity).State = EntityState.Modified;
            _unitOfWork.Context.Set<DJValetingBookingEntity>().Attach(entity);

            await _unitOfWork.CommitAsync();

            return entity;
        }
    }
}

