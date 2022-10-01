﻿using ExoApi.Contexts;
using ExoApi.Models;

namespace ExoApi.Repositories
{
    public class ProjetoRepository
    {
        private readonly dbExoAPIContext _context;

        public ProjetoRepository(dbExoAPIContext context)
        {
            _context = context;
        } 
        
        public List<Projeto> Listar()
        {
            return _context.Projetos.ToList();
        }

        public Projeto BuscarPorId(int id)
        {
            return _context.Projetos.Find(id);
        }

        public void Cadastrar(Projeto projeto)
        {
            _context.Projetos.Add(projeto);
            _context.SaveChanges();
        }

        public void Atualizar (int id, Projeto projeto)
        {
            Projeto projetoBuscado = _context.Projetos.Find(id);
            if(projetoBuscado != null)
            {
                projetoBuscado.Titulo = projeto.Titulo;
                projetoBuscado.Status = projeto.Status;
                projetoBuscado.Data_De_Inicio = projeto.Data_De_Inicio;
                projetoBuscado.Area = projeto.Area;
            }

            _context.Projetos.Update(projetoBuscado);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Projeto projeto = _context.Projetos.Find(id);
            _context.Projetos.Remove(projeto);
            _context.SaveChanges();
        }
    }
}
