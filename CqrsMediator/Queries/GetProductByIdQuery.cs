using System;
using MediatR;

namespace CqrsMediator.Queries
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}

