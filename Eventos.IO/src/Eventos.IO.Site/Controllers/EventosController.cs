﻿using System;
using Microsoft.AspNetCore.Mvc;
using Eventos.IO.Application.ViewModels;
using Eventos.IO.Application.Interfaces;
using Eventos.IO.Domain.Core.Notifications;
using Eventos.IO.Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace Eventos.IO.Site.Controllers
{
    public class EventosController : BaseController
    {
        private readonly IEventoAppService _eventoAppService;
        private readonly IUser _user;

        public EventosController(IEventoAppService eventoAppService,
                                IDomainNotificationHandler<DomainNotification> notifications,
                                IUser user) : base(notifications, user)
        {
            _eventoAppService = eventoAppService;
        }

        public IActionResult Index()
        {
            return View(_eventoAppService.ObterTodos());
        }

        [Authorize]
        public IActionResult MeusEventos()
        {
            return View(_eventoAppService.ObterEventoPorOrganizador(OrganizadorId));
        }

        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventoViewModel = _eventoAppService.ObterPorId(id.Value);

            if (eventoViewModel == null)
            {
                return NotFound();
            }

            return View(eventoViewModel);
        }

        [Authorize]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult Create(EventoViewModel eventoViewModel)
        {
            if (!ModelState.IsValid) return View(eventoViewModel);

            eventoViewModel.OrganizadorId = OrganizadorId;

            _eventoAppService.Register(eventoViewModel);

            ViewBag.RetornoPost  = OperacaoValida() ? "success,Evento registrado com sucesso!"
                                                    : "warning,Evento não registrado! Verifique as mensagens";


            return View(eventoViewModel);
        }

        [Authorize]
        public IActionResult Edit(Guid? id)
        {
            if (id == null) return NotFound();

            var eventoViewModel = _eventoAppService.ObterPorId(id.Value);

            if (eventoViewModel == null) return NotFound();

            if(ValidarAutoridadeEvento(eventoViewModel))
                return RedirectToAction("MeusEventos", _eventoAppService.ObterEventoPorOrganizador(OrganizadorId));

            return View(eventoViewModel);
        }

        [Authorize]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(EventoViewModel eventoViewModel)
        {
            if (ValidarAutoridadeEvento(eventoViewModel))
                return RedirectToAction("MeusEventos", _eventoAppService.ObterEventoPorOrganizador(OrganizadorId));

            if (!ModelState.IsValid) return View(eventoViewModel);

            eventoViewModel.OrganizadorId = OrganizadorId;
            _eventoAppService.Atualizar(eventoViewModel);

            ViewBag.RetornoPost = OperacaoValida() ? "success,Evento atualizado com sucesso!"
                            : "warning,Evento não atualizado! Verifique as mensagens";

            if (_eventoAppService.ObterPorId(eventoViewModel.Id).Online)
                eventoViewModel.Endereco = null;
            else
                eventoViewModel = _eventoAppService.ObterPorId(eventoViewModel.Id);

            return View(eventoViewModel);
        }

        [Authorize]
        public IActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var eventoViewModel = _eventoAppService.ObterPorId(id.Value);

            if (ValidarAutoridadeEvento(eventoViewModel))
                return RedirectToAction("MeusEventos", _eventoAppService.ObterEventoPorOrganizador(OrganizadorId));

            if (eventoViewModel == null)
            {
                return NotFound();
            }

            return View(eventoViewModel);
        }

        [Authorize]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(Guid id)
        {
            if (ValidarAutoridadeEvento(_eventoAppService.ObterPorId(id)))
                return RedirectToAction("MeusEventos", _eventoAppService.ObterEventoPorOrganizador(OrganizadorId));

            _eventoAppService.Excluir(id);
            return RedirectToAction("Index");
        }

        public IActionResult IncluirEndereco(Guid? Id)
        {
            if(Id == null)
            {
                return NotFound();
            }

            var eventoViewModel = _eventoAppService.ObterPorId(Id.Value);

            return PartialView("_IncluirEndereco", eventoViewModel);

        }

        public IActionResult AtualizarEndereco(Guid? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }

            var eventoViewModel = _eventoAppService.ObterPorId(Id.Value);

            return PartialView("_AtualizarEndereco", eventoViewModel);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult IncluirEndereco(EventoViewModel eventoViewModel)
        {
            ModelState.Clear();
            eventoViewModel.Endereco.EventoId = eventoViewModel.Id;
            _eventoAppService.AdicionarEndereco(eventoViewModel.Endereco);

            if(OperacaoValida())
            {
                //redirect nao ocorrendo - 2:10:17
                string url = Url.Action("ObterEndereco", "Eventos", new { id = eventoViewModel.Id });
                return Json(new { success = true, url = url });
            }

            return PartialView("_IncluirEndereco", eventoViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AtualizarEndereco(EventoViewModel eventoViewModel)
        {
            ModelState.Clear();
            _eventoAppService.AtualizarEndereco(eventoViewModel.Endereco);

            if (OperacaoValida())
            {
                //redirect nao ocorrendo - 2:10:17
                string url = Url.Action("ObterEndereco", "Eventos", new { id = eventoViewModel.Id });
                return Json(new { success = true, url = url });
            }

            return PartialView("_AtualizarEndereco", eventoViewModel);
        }

        public IActionResult ObterEndereco(Guid id)
        {
            return PartialView("_Detalhes", _eventoAppService.ObterPorId(id));
        }

        private bool ValidarAutoridadeEvento(EventoViewModel eventoViewModel)
        {
            return eventoViewModel.OrganizadorId != OrganizadorId;
        }
    }
}
