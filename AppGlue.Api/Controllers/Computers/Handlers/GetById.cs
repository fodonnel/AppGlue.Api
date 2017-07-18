using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppGlue.Api.Database;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AppGlue.Api.Controllers.Computers.Handlers
{
    public class GetById
    {
        public class Query : IRequest<Result>
        {
            public int Id { get; set; }
        }

        public class Result
        {
            public bool NotFound { get; set; }
            public ComputerModel.Detail Model { get; set; }
        }

        public class Handler : IAsyncRequestHandler<Query, Result>
        {
            private readonly AppGlueDbContext _db;

            public Handler(AppGlueDbContext db)
            {
                _db = db;
            }

            public async Task<Result> Handle(Query message)
            {
                var computer = await _db.Computers.SingleOrDefaultAsync(t => t.Id == message.Id);
                if (computer == null)
                {
                    return new Result { NotFound = true };
                }

                return new Result
                {
                    Model = Mapper.Map<ComputerModel.Detail>(computer)
                };
            }
        }
    }
}
