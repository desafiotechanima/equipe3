using AnimaTechAPI.Models;
using System.Data;

namespace AnimaTechAPI.Services
{
    public class Service
    {
        private DataBase _context;

        public Service()
        {
            _context = new DataBase();
        }

        public List<Usuario> GetByName(string name)
        {
            var objeto = new List<Usuario>();
            string query = string.Format($"{name}");
            DataTable data = _context.ConsultaQuery(query);
            foreach (var item in data.Rows)
            {
                objeto.Name = item[];
            }
        }
    }
}
