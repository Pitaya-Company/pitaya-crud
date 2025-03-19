using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using MongoDB.Driver;
using pitaya_crud.Models;
using pitaya_crud.Data;

namespace pitaya_crud.Services
{
    public class AuthService
    {
        private readonly IMongoCollection<Usuario> _usuarios;

        public AuthService()
        {
            var db = new MongoDbContext();
            _usuarios = db.Usuarios;
        }

        public bool Login(string email, string senha)
        {
            var user = _usuarios.Find(u => u.Email == email && u.Senha == senha).FirstOrDefault();
            return user != null;
        }
    }
}
