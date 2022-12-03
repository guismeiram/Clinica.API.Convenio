using DevIO.Bussines.Interface;
using DevIO.Bussines.Models;
using DevIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(ClinicaDbContext db) : base(db)
        {
        }

        public async Task<Endereco> ObterEnderecoClinica(string id)
        {
            return await Db.Endereco.AsNoTracking()
                .Include(c => c.Clinica)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task<Endereco> ObterEnderecoMedico(string id)
        {
            return await Db.Endereco.AsNoTracking()
                .Include(c => c.Clinica)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
    }
}
