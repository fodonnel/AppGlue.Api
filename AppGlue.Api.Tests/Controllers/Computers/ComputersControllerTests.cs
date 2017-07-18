using AppGlue.Api.Controllers.Computers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AppGlue.Api.Controllers.Computers.Handlers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace AppGlue.Api.Tests.Controllers.Computers
{
    public class ComputersControllerTests
    {
        private readonly Mock<IMediator> _mediator;
        private readonly ComputersController _target;

        public ComputersControllerTests()
        {
            _mediator = new Mock<IMediator>();
            _target = new ComputersController(_mediator.Object);
        }

        [Fact]
        public async Task Get_With_Id_Should_Return_200_With_Model()
        {
            var message = new GetById.Query {Id = 1};
            var model = new ComputerModel.Detail {Name = "host1"};

            _mediator.Setup(t => t.Send(message, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new GetById.Result {Model = model});

            var result = await _target.GetById(message) as OkObjectResult;
            Assert.NotNull(result);

            var resultModel = result.Value as ComputerModel.Detail;
            Assert.NotNull(resultModel);

            Assert.Equal(model.Name, resultModel.Name);
        }

        [Fact]
        public async Task Get_With_Unknown_Id_Should_Return_404()
        {
            var message = new GetById.Query {Id = 999};
            _mediator.Setup(t => t.Send(message, It.IsAny<CancellationToken>()))
                .ReturnsAsync(new GetById.Result { NotFound = true });

            var result = await _target.GetById(message) as NotFoundResult;
            Assert.NotNull(result);
        }

    }
}
