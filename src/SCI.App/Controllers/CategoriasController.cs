using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SCI.App.ViewModels;
using SCI.Negocio.Interfaces;
using SCI.Negocio.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SCI.App.Controllers
{
    public class CategoriasController : BaseController
    {
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        private readonly IMapper _mapper;

        public CategoriasController(ICategoriaRepositorio categoriaRepositorio,
                                    IMapper mapper)
        {
            _categoriaRepositorio = categoriaRepositorio;
            _mapper = mapper;
        }

        // GET: Categorias
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<CategoriaViewModel>>(await _categoriaRepositorio.ObterTodos()));
        }

        // GET: Categorias/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var categoriaViewModel = await ObterCategoria(id);

            if (categoriaViewModel == null) return NotFound();

            return View(categoriaViewModel);
        }

        // GET: Categorias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Categorias/Create        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CategoriaViewModel categoriaViewModel)
        {
            if (!ModelState.IsValid) return View(categoriaViewModel);

            var categoria = _mapper.Map<Categoria>(categoriaViewModel);
            await _categoriaRepositorio.Adicionar(categoria);

            return RedirectToAction(nameof(Index));
        }

        // GET: Categorias/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var categoriaViewModel = await ObterCategoria(id);

            if (categoriaViewModel == null) return NotFound();

            return View(categoriaViewModel);
        }

        // POST: Categorias/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CategoriaViewModel categoriaViewModel)
        {
            if (id != categoriaViewModel.Id) return NotFound();

            if (!ModelState.IsValid) return View(categoriaViewModel);

            var categoria = _mapper.Map<Categoria>(categoriaViewModel);
            await _categoriaRepositorio.Atualizar(categoria);

            return RedirectToAction(nameof(Index));
        }

        // GET: Categorias/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var categoriaViewModel = await ObterCategoria(id);

            if (categoriaViewModel == null) return NotFound();

            return View(categoriaViewModel);
        }

        // POST: Categorias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoriaViewModel = await ObterCategoria(id);

            if (categoriaViewModel == null) return NotFound();

            await _categoriaRepositorio.Remover(id);

            return RedirectToAction(nameof(Index));
        }

        private async Task<CategoriaViewModel> ObterCategoria(int id)
        {
            return _mapper.Map<CategoriaViewModel>(await _categoriaRepositorio.ObterPorId(id));
        }
    }
}
