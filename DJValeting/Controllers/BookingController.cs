using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DJValeting.Domain.Data.Entities;
using DJValeting.Domain.Data.Enum;
using DJValeting.Domain.Data.Repositories;
using DJValeting.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DJValeting.Controllers
{
    public class BookingController : Controller
    {
        private readonly IBookingRepository _bookingRepository;

        public BookingController(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }

        // GET: Booking
        public async Task<ActionResult> Index()
        {
            var bookingList = await _bookingRepository.GetAllAsync();
            var bookingViewModelList = new List<BookingViewModel>();

            foreach(var booking in bookingList)
            {
                var bookingViewModel = new BookingViewModel
                {  
                    Id = booking.Id, 
                    Name = booking.Name,
                    BookingDate = booking.BookingDate,
                    Flexibility = (FlexibilityEnum)booking.Flexibility,
                    VehicleSize = (CarSizeEnum)booking.VehicleSize,
                    ContactNumber = booking.ContactNumber,
                    EmailAddress = booking.EmailAddress
                };

                bookingViewModelList.Add(bookingViewModel);
            }

            return View(bookingViewModelList);
        }

        // GET: Booking/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Booking/Create
        public ActionResult Create()
        {
            var bookingViewModel = new BookingViewModel();
            return View(bookingViewModel);
        }

        // POST: Booking/Create
        [HttpPost]
        public async Task<ActionResult> Create(BookingViewModel booking)
        {
            if (ModelState.IsValid)
            {
                var bookingEntity = new DJValetingBookingEntity()
                {
                    Name = booking.Name,
                    BookingDate = booking.BookingDate.Value,
                    Flexibility = (int)booking.Flexibility,
                    VehicleSize = (int)booking.VehicleSize,
                    ContactNumber = booking.ContactNumber,
                    EmailAddress = booking.EmailAddress
                };

                await _bookingRepository.AddAsync(bookingEntity);

                return RedirectToAction("Index");
            }

            return View(booking);
        }

        // GET: Booking/Edit/5
        public async Task<ActionResult> Edit(Guid id)
        {
            var booking = await _bookingRepository.GetSingleAsync(p => p.Id == id);

            var bookingViewModel = new BookingViewModel
            {
                Id = booking.Id,
                Name = booking.Name,
                BookingDate = booking.BookingDate,
                Flexibility = (FlexibilityEnum)booking.Flexibility,
                VehicleSize = (CarSizeEnum)booking.VehicleSize,
                ContactNumber = booking.ContactNumber,
                EmailAddress = booking.EmailAddress
            };

            return View(bookingViewModel);
        }

        // POST: Booking/Edit/5
        [HttpPost]
        public async Task<ActionResult> Edit(BookingViewModel booking)
        {
            if (ModelState.IsValid)
            {
                var bookingEntity = new DJValetingBookingEntity()
                {
                    Id = booking.Id,
                    Name = booking.Name,
                    BookingDate = booking.BookingDate.Value,
                    Flexibility = (int)booking.Flexibility,
                    VehicleSize = (int)booking.VehicleSize,
                    ContactNumber = booking.ContactNumber,
                    EmailAddress = booking.EmailAddress
                };

                await _bookingRepository.UpdateAsync(bookingEntity);

                return RedirectToAction("Index");
            }

            return View(booking);
        }

        // GET: Booking/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Booking/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}