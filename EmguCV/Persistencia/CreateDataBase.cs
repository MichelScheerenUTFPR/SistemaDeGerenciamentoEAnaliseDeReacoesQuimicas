using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_EmguCV.Persistencia
{
    class CreateDataBase
    {
        private static SqLiteContext _context;

        public static void Verify()
        {
            using(_context = new SqLiteContext())
            {
                _context.Database.EnsureCreated();
            }
        }
    }
}
