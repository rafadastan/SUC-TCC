using MongoDB.Driver;
using SUC.Domain.Models.Perfil;
using SUC.Domain.Models.Usuario;
using SUC.Infra.Data.MongoDB.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUC.Infra.Data.MongoDB.Contexts
{
    public class MongoDBContext
    {
        private readonly MongoDBSettings _settings;
        private IMongoDatabase _mongoDatabase;

        public MongoDBContext(MongoDBSettings settings)
        {
            _settings = settings;
            Initialize();
        }

        //fazendo a conexão com o banco do MongoDB
        private void Initialize()
        {
            var client = MongoClientSettings.FromUrl(new MongoUrl(_settings.Host));

            if (_settings.IsSSL)
            {
                client.SslSettings = new SslSettings
                {
                    EnabledSslProtocols = System.Security.Authentication.SslProtocols.Tls12
                };
            }

            _mongoDatabase = new MongoClient(client).GetDatabase(_settings.Name);
        }

        //mapear as collections do mongodb
        public IMongoCollection<UsuarioModel> Usuario
            => _mongoDatabase.GetCollection<UsuarioModel>("Usuario");

        public IMongoCollection<PerfilModel> Perfil
            => _mongoDatabase.GetCollection<PerfilModel>("Perfil");
    }
}
