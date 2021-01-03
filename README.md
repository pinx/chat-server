# Live multi-user schedule board

This is a proof-of-concept and experiment for [SignalR](https://dotnet.microsoft.com/apps/aspnet/signalr) and a [Scheduler UI](https://www.bryntum.com/products/scheduler/).

It started out with cloning [Javier's chat server](https://github.com/javiergacrich/chat-server) and [chat UI](https://github.com/javiergacrich/chat-ui).

I extended the backend code with a 'schedule update event' that is simply broadcasted to other connected clients.

