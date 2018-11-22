﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Eventures.Models;
using Eventures.ViewModels;
using Eventures.ViewModels.Events;
using Microsoft.AspNetCore.Identity;

namespace Eventures.Services.EventsServices
{
    public interface IEventsService
    {
        EventsBindingModel[] GetAllEvents();

        void CreateEvent(EventsBindingModel model, ClaimsPrincipal user);

        void BuyTickets(string id, int count, ClaimsPrincipal user);

        SingleEventViewModel[] GetMyEvents(ClaimsPrincipal user);
    }
}