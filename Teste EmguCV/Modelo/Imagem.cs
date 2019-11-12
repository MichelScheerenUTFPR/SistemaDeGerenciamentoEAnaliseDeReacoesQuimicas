﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_EmguCV.Modelo
{
    class Imagem
    {
        [Key]
        public int ID { get; set; }

        public string Nome { get; set; }

        public byte[] Dados { get; set; }

        //public string ContentType { get; set; }

        public Imagem()
        {
        }

        public Imagem(byte[] dados, string nome)
        {
            Dados = dados;
            Nome = nome;
        }
    }
}
