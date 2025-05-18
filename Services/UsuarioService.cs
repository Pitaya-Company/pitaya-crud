using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using MongoDB.Driver;
using MongoDB.Driver.Linq;
using pitaya_crud.Data;
using pitaya_crud.Models;

namespace pitaya_crud.Services
{
    internal class UsuarioService
    {
        private readonly IMongoCollection<Usuario> _usuarios;

        public UsuarioService()
        {
            _usuarios = new MongoDbContext().Usuarios;
        }

        public bool Login(string email, string senha)
        {
            var user = _usuarios.Find(u => u.Email == email && u.Senha == senha).FirstOrDefault();
            return user != null;
        }

        public async Task<Usuario?> CreateUsuarioAsync(Usuario usuario)
        {
            var jaExiste = await _usuarios.Find(u => u.Email == usuario.Email).AnyAsync();
            if (jaExiste)
            {
                throw new ValidationException("Já existe um usuário com este e-mail");
            }

            if (!usuario.IsValid())
            {
                throw new ValidationException("Dados invalidos");
            }

            await _usuarios.InsertOneAsync(usuario);
            return usuario;
        }

        public async Task DeleteUsuarioAsync(string id)
        {
            var result = await _usuarios.DeleteOneAsync(u => u.Id == id);

            if (result.DeletedCount == 0)
                throw new KeyNotFoundException($"Usuario com ID {id} não encontrado.");
        }
    }
}
