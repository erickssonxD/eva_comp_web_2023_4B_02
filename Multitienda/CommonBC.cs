using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Multitienda.Negocio
{
    public class CommonBC
    {
        private static MultitiendaEntities _modeloMultitienda;

        public static MultitiendaEntities ModeloMultitienda
        {
            get
            {
                if (_modeloMultitienda == null)
                {
                    _modeloMultitienda = new MultitiendaEntities();
                }
                return _modeloMultitienda;
            }
        }

        public CommonBC()
        {

        }
    }
}