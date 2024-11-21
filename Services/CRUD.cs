using _10._3dbCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _10._3dbCRUD.Services
{
    public interface ICRUD
    {
        void AddRecord(Car car);
        void DeleteRecord(int carId);
        void UpdateRecord(int carId, Car car);
        ICollection<Car> GetAllRecords();
        Car FindCar(int id);
        int GetMaxId();
    }

    internal class CRUD : ICRUD
    {
        public void AddRecord(Car car)
        {
            Data.Data.carContext.Cars.Add(car);
            Data.Data.carContext.SaveChanges();
        }

        public void DeleteRecord(int carId)
        {
            var car = Data.Data.carContext.Cars.Find(carId);
            Data.Data.carContext.Cars.Remove(car);
            Data.Data.carContext.SaveChanges();
        }

        public Car FindCar(int id)
        {
            return Data.Data.carContext.Cars.Find(id);
        }

        public ICollection<Car> GetAllRecords()
        {
            return Data.Data.carContext.Cars.ToList();
        }

        public int GetMaxId()
        {
            return Data.Data.carContext.Cars.Max(e => e.CarId);
        }

        public void UpdateRecord(int carId, Car car)
        {
            var carToUpdate = Data.Data.carContext.Cars.Find(carId);
            carToUpdate.CarId = car.CarId;
            carToUpdate.VIN = car.VIN;
            carToUpdate.Make = car.Make;
            carToUpdate.Model = car.Model;
            carToUpdate.Year = car.Year;
            carToUpdate.Price = car.Price;
            Data.Data.carContext.SaveChanges();
        }
    }
}
