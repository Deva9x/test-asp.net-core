using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Services;

namespace WebApplication1.ViewComponents
{
    public class PaisesViewComponent : ViewComponent
    {
        public PaisesViewComponent(IRepositorioPais repositorioPais) {
            RepositorioPais = repositorioPais;
        }

        public IRepositorioPais RepositorioPais { get; }

        public IViewComponentResult Invoke() {
            var paises = RepositorioPais.obtenerPaises();
            return View(paises);
        }
    }
}
