﻿namespace FlightSearch.Domain.Abstractions;
public abstract class Entity : IEntity<int>
{
    public int Id { get; set; }

}
