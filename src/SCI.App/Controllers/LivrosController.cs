using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SCI.App.ViewModels;
using SCI.Negocio.Interfaces;
using SCI.Negocio.Modelos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SCI.App.Controllers
{
    public class LivrosController : BaseController
    {
        private readonly ILivroRepositorio _livroRepositorio;
        private readonly IMapper _mapper;
        private readonly ICategoriaRepositorio _categoriaRepositorio;
        public LivrosController(ILivroRepositorio livroRepositorio,
                                IMapper mapper,
                                ICategoriaRepositorio categoriaRepositorio)
        {
            _livroRepositorio = livroRepositorio;
            _mapper = mapper;
            _categoriaRepositorio = categoriaRepositorio;
        }

        // GET: Livros
        public async Task<IActionResult> Index()
        {
            return View(_mapper.Map<IEnumerable<LivroViewModel>>(await _livroRepositorio.ObterLivrosCategorias()));
        }

        // GET: Livros/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var livroViewModel = await ObterLivro(id);
            
            if (livroViewModel == null) return NotFound();

            return View(livroViewModel);
        }

        // GET: Livros/Create
        public async Task<IActionResult> Create()
        {
            var livroViewModel = await PopularCategorias(new LivroViewModel());
            
            return View(livroViewModel);
        }

        // POST: Livros/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(LivroViewModel livroViewModel)
        {
            livroViewModel = await PopularCategorias(livroViewModel);

            if (!ModelState.IsValid) return View(livroViewModel);

            await _livroRepositorio.Adicionar(_mapper.Map<Livro>(livroViewModel));

            return RedirectToAction(nameof(Index));
        }

        // GET: Livros/Edit/5
        public async Task<IActionResult> Edit(int id)
        {
            var livroViewModel = await ObterLivro(id);

            if (livroViewModel == null) return NotFound();

            return View(livroViewModel);
        }

        // POST: Livros/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, LivroViewModel livroViewModel)
        {
            if (id != livroViewModel.Id) return NotFound();

            if (!ModelState.IsValid) return View(livroViewModel);

            var livro = _mapper.Map<Livro>(livroViewModel);
            await _livroRepositorio.Atualizar(livro);

            return RedirectToAction(nameof(Index));
        }

        // GET: Livros/Delete/5
        public async Task<IActionResult> Delete(int id)
        {
            var livroViewModel = await ObterLivro(id);

            if (livroViewModel == null) return NotFound();

            return View(livroViewModel);
        }

        // POST: Livros/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var livroViewModel = await ObterLivro(id);

            if (livroViewModel == null) return NotFound();

            await _livroRepositorio.Remover(id);

            return RedirectToAction(nameof(Index));
        }

        private async Task<LivroViewModel> ObterLivro(int id)
        {
            var livro = _mapper.Map<LivroViewModel>(await _livroRepositorio.ObterLivroCategoria(id));
            livro.Categorias = _mapper.Map<IEnumerable<CategoriaViewModel>>(await _categoriaRepositorio.ObterTodos());

            return livro;
        }

        private async Task<LivroViewModel> PopularCategorias(LivroViewModel livro)
        {
            livro.Categorias = _mapper.Map<IEnumerable<CategoriaViewModel>>(await _categoriaRepositorio.ObterTodos());

            return livro;
        }
    }
}
