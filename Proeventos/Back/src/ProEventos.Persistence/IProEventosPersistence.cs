﻿using ProEventos.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProEventos.Persistence
{
    internal interface IProEventosPersistence
    {
        //Geral
        void Add<T>(T entity) where T : class;
        void Update<T>(T entity) where T : class;
        void Delete<T>(T entity) where T : class;
        void DeleteRange<T>(T[] entityArray) where T: class;

        Task<bool> SaveChangesAsync();

        //Eventos
        Task<Evento[]>  GetAllEventosByTemaAsync(string tema, bool includePalestrantes);
        Task<Evento[]>  GetAllEventosAsync(bool includePalestrantes);
        Task<Evento>  GetEventoByIdAsync(int EventoId, bool includePalestrantes);

        //Palestrantes
        Task<Palestrante[]> GetAllPalestrantesByNomeAsync(string nome, bool includeEventos);
        Task<Palestrante[]> GetAllPalestrantesAsync(bool includeEventos);
        Task<Palestrante> GetPalestranteByIdAsync(int PalestranteId, bool includeEventos);
    }
}
