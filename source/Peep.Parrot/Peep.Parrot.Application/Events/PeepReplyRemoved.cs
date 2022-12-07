﻿using Peep.EventBus.Events;
namespace Peep.Parrot.Application.Events;

public class PeepReplyRemoved : Event
{
    public PeepReplyRemoved(Guid repliedPeepId, Domain.Entities.Peep reply)
    {
        RepliedPeepId = repliedPeepId;
        Reply = reply;
    }

    public Guid RepliedPeepId { get; init; }
    public Domain.Entities.Peep Reply { get; init; }
}