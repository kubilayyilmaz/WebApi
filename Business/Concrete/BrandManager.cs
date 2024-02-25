using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concrete;

public class BrandManager : IBrandService
{
    private readonly IBrandDal _brandDal;

    public BrandManager(IBrandDal brandDal)
    {
        _brandDal = brandDal;
    }

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
        List<Brand> brands = _brandDal.GetAll();
        List<GetAllBrandResponse> getAllBrandResponses = new List<GetAllBrandResponse>();
        foreach (var brand in brands)
        {
            GetAllBrandResponse getAllBrandResponse = new()
            {
                Id = brand.Id,
                Name = brand.Name,
                CreatedDate = brand.CreatedDate
            };

            getAllBrandResponses.Add(getAllBrandResponse);
        }
        return getAllBrandResponses;
    }
}