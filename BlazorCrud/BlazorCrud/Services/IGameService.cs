﻿using BlazorCrud.Entities;

namespace BlazorCrud.Services
{
    public interface IGameService
    {
        Task<List<Game>> GetAllGames();
    }
}