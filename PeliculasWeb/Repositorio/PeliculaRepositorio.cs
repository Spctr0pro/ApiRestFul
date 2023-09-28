using PeliculasWeb.Models;
using PeliculasWeb.Repositorio.IRepositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace PeliculasWeb.Repositorio
{
    public class PeliculaRepositorio : Repositorio<Pelicula>, IPeliculaRepositorio
    {
        //Injección de dependencias se debe importar el IHttpClientFactory
        private readonly IHttpClientFactory _clientFactory;

        public PeliculaRepositorio(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

    }
}
