using asp_gpt.Models;
using Microsoft.EntityFrameworkCore;

namespace asp_gpt.Services
{
    public class CarService
    {
        private readonly ApplicationDbContext _context;

        public CarService(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task AddCar(string name, decimal price, string description)
        {
            var car = new Car
            {
                Name = name,
                Price = price,
                Description = description
            };

            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

        }

        public async Task AddCar(Car car)
        {
            _context.Cars.Add(car);
            await _context.SaveChangesAsync();

        }

        public async Task<List<Car>> GetAllCars()
        {
            return await _context.Cars.ToListAsync();
        }

        public async Task<Car> GetCarById(int id)
        {
            return await _context.Cars.FindAsync(id);
        }

        public async Task UpdateCar(int id, string newName, decimal newPrice, string newDescription)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car != null)
            {
                car.Name = newName;
                car.Price = newPrice;
                car.Description = newDescription;
                await _context.SaveChangesAsync();
            }
        }

        public async Task DeleteCar(int id)
        {
            var car = await _context.Cars.FindAsync(id);
            if (car != null)
            {
                _context.Cars.Remove(car);
                await _context.SaveChangesAsync();
            }
        }

    }
}
