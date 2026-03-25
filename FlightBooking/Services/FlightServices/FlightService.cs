using AutoMapper;
using FlightBooking.Dtos.FlightDto;
using FlightBooking.Entities;
using FlightBooking.Settings;
using MongoDB.Driver;

namespace FlightBooking.Services.FlightServices
{
    public class FlightService : IFlightService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Flight> _flightColllection;

        public FlightService(IMapper mapper,IDatabaseSettings _databaseSettings)
        {
            var client=new MongoClient(_databaseSettings.ConnectionString);
            
            _mapper = mapper;
            
        }

        public Task CreateFlightAsync(CreateFlightDto createFlightDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteFlightAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ResultFlightDto>> GetAllFlightsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GetFlightByIdDto> GetFlightByIdAsync(string id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateFlightAsync(UpdateFlightDto updateFlightDto)
        {
            throw new NotImplementedException();
        }
    }
}
