﻿using AutoMapper;
using Eventos.IO.Domain.Eventos.Commands;
using Eventos.IO.Domain.Eventos.Repository;
using Eventos.IO.Application.Interfaces;
using Eventos.IO.Application.ViewModels;
using Eventos.IO.Domain.Core.Bus;
using System;
using System.Collections.Generic;
using Eventos.IO.Domain.Interfaces;

namespace Eventos.IO.Application.Services
{
    public class EventoAppService : IEventoAppService
    {
        private readonly IBus _bus;
        private readonly IMapper _mapper;

        private readonly IEventoRepository _eventoRepository;
        private readonly IUser _user;

        public EventoAppService(IBus bus, IMapper mapper, IEventoRepository eventoRepository, IUser user)
        {
            _bus = bus;
            _mapper = mapper;
            _eventoRepository = eventoRepository;
            _user = user;
        }

        public void Register(EventoViewModel eventoViewModel)
        {
            var registroCommand = _mapper.Map<RegistrarEventoCommand>(eventoViewModel);
            _bus.SendCommand(registroCommand);
        }

        public IEnumerable<EventoViewModel> ObterEventoPorOrganizador(Guid organizadorId)
        {
            return _mapper.Map<IEnumerable<EventoViewModel>>(_eventoRepository.ObterEventosPorOrganizador(organizadorId));
        }

        public EventoViewModel ObterPorId(Guid id)
        {
            return _mapper.Map<EventoViewModel>(_eventoRepository.ObterPorId(id));
        }

        public IEnumerable<EventoViewModel> ObterTodos()
        {
            return _mapper.Map<IEnumerable<EventoViewModel>>(_eventoRepository.ObterTodos());
        }

        public void Atualizar(EventoViewModel eventoViewModel)
        {
            //TODO: Validar se o organizador é dono do evento

            var atualizarEventoCommand = _mapper.Map<AtualizarEventoCommand>(eventoViewModel);
            _bus.SendCommand(atualizarEventoCommand);
        }

        public void Excluir(Guid id)
        {
            _bus.SendCommand(new ExcluirEventoCommand(id));
        }

        public void Dispose()
        {
            _eventoRepository.Dispose();
        }

        public void AdicionarEndereco(EnderecoViewModel enderecoViewModel)
        {
            var endrecoCommand = _mapper.Map<IncluirEnderecoEventoCommand>(enderecoViewModel);
            _bus.SendCommand(endrecoCommand);
        }

        public void AtualizarEndereco(EnderecoViewModel enderecoViewModel)
        {
            var endrecoCommand = _mapper.Map<AtualizarEnderecoEventoCommand>(enderecoViewModel);
            _bus.SendCommand(endrecoCommand);
        }

        public EnderecoViewModel ObterEnderecoPorId(Guid id)
        {
            return _mapper.Map<EnderecoViewModel>(_eventoRepository.ObterEnderecoPorId(id));
        }
    }
}
