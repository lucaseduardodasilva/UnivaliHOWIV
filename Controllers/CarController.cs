using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjetoIntegradorADS.Context;
using ProjetoIntegradorADS.Models;
using System.Threading.Tasks;

namespace ProjetoIntegradorADS.Controllers
{
    public class CarController : Controller
    {
        private readonly CarContext _context;

        public CarController(CarContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Cars.ToListAsync());
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
            {
                return View(new Car());
            }
            else
            {
                return View(_context.Cars.Find(id));
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddOrEdit([Bind("CarId,Modelo,CodigoCarro,Ano,Kilometragem,Vendedor,Caracteristica,Marca,Cor")] Car car)
        {
            if (ModelState.IsValid)
            {
                if (car.CarId == 0)
                {
                    _context.Add(car);
                }
                else
                {
                    _context.Update(car);
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(car);
        }


        // GET: Employee/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            var employee = await _context.Cars.FindAsync(id);
            _context.Cars.Remove(employee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

    }
}
