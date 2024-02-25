using DataAccess.Abstracts;
using Entities.Concretes;

namespace DataAccess.Concrete;

public class BrandDal : IBrandDal
{
    List<Brand> _brands;
    public BrandDal()
    {
        _brands = new List<Brand>
        {
            new Brand { Id = 1, Name = "BMW", CreatedDate = DateTime.Now },
            new Brand { Id = 2, Name = "Mercedes", CreatedDate = DateTime.Now },
            new Brand { Id = 3, Name = "Alfa Romeo", CreatedDate = DateTime.Now }
        };
    }

    public void Add(Brand brand)
    {
        _brands.Add(brand);
    }

    public List<Brand> GetAll()
    {
        return _brands;
    }
}