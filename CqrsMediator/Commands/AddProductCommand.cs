using System;
using MediatR;

namespace CqrsMediator.Commands
{
    // Use DTOs instead of Product in prod
    public record AddProductCommand(Product Product) : IRequest<Product>;
}

