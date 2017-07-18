using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppGlue.Api.Database.Entities;
using AutoMapper;
using Microsoft.CodeAnalysis.Differencing;

namespace AppGlue.Api.Controllers.Computers
{
    public class ComputerModel
    {
        public class Detail
        {
            public string Name { get; set; }
            public string Status { get; set; }
            public string Description { get; set; }
            public string Notes { get; set; }
            public string Manufacturer { get; set; }
            public string Model { get; set; }
            public string SerialNumber { get; set; }
            public string Processor { get; set; }
            public long? MemoryInKb { get; set; }
            public DateTime? BiosDate { get; set; }
            public string BiosVersion { get; set; }
        }

        public class MapProfile : Profile
        {
            public MapProfile()
            {
                CreateMap<Computer, Detail>();
            }
        }
    }
}
