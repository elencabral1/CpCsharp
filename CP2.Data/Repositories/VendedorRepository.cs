﻿using CP2.Data.AppData;
using CP2.Domain.Entities;
using CP2.Domain.Interfaces;

namespace CP2.Data.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ApplicationContext _context;

        public VendedorRepository(ApplicationContext context)
        {
            _context = context;
        }

        public IEnumerable<VendedorEntity> ObterTodosVendedores()
        {
            var vendedor = _context.Vendedor.ToList();

            return vendedor;

        }

        public VendedorEntity? ObterVendedorPorId(int id)
        {
            var vendedor = _context.Vendedor.Find(id);

            if (vendedor is not null)
            {
                return vendedor;
            }

            return null;
        }


        public VendedorEntity? SalvarDadosVendedor(VendedorEntity entity)
        {
            _context.Vendedor.Add(entity);
            _context.SaveChanges();

            return entity;
        }



        public VendedorEntity? EditarDadosVendedor(VendedorEntity entity)
        {
            var vendedor = _context.Vendedor.Find(entity.Id);

            if (vendedor is not null)
            {

                vendedor.Nome = entity.Nome;
                vendedor.DataNascimento = entity.DataNascimento;

                _context.Vendedor.Update(vendedor);
                _context.SaveChanges();

                return vendedor;
            }

            return null;
        }


        public VendedorEntity? DeletarDadosVendedor(int id)
        {
            var vendedor = _context.Vendedor.Find(id);

            if (vendedor is not null)
            {
                _context.Vendedor.Remove(vendedor);
                _context.SaveChanges();

                return vendedor;
            }

            return null;
        }
    }
}
