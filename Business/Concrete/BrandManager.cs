using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concrete;

public class BrandManager : IBrandService
{
private readonly IBrandDal _brandDal;

    public CreatedBrandResponse Add(CreateBrandRequest createBrandRequest)
    {
        //Business Rules

        //mapping --> Automapper
        Brand brand = new()
        {
            Name = createBrandRequest.Name,
            CreatedDate = DateTime.Now
        };

        _brandDal.Add(brand);

        //mapping
        CreatedBrandResponse createdBrandResponse = new()
        {
            Id = 4,
            Name = brand.Name,
            CreatedDate = brand.CreatedDate
        };

        return createdBrandResponse;
    }

    public List<GetAllBrandResponse> GetAll()
    {
        throw new NotImplementedException();
    }
}
