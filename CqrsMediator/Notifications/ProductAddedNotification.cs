using System;
using MediatR;

namespace CqrsMediator.Notifications
{
    public record ProductAddedNotification(Product Product) : INotification;
}

