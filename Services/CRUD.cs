using _10._3dbCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            throw new NotImplementedException();
        }

        public void DeleteRecord(int carId)
        {
            throw new NotImplementedException();
        }

        public Car FindCar(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Car> GetAllRecords()
        {
            throw new NotImplementedException();
        }

        public int GetMaxId()
        {
            throw new NotImplementedException();
        }

        public void UpdateRecord(int carId, Car car)
        {
            throw new NotImplementedException();
        }
    }
}
