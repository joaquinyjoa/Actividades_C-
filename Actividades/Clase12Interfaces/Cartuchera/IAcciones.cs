﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartuchera
{
    public interface IAcciones
    {
        ConsoleColor Color { get; set; }
        float UnidadesDeEscritura { get; set; }

        EscrituraWrapper Escribir(string texto);

        bool Recargar(int unidad);

    }
}
