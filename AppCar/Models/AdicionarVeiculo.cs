﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppCar.Models {
    class AdicionarVeiculo {

        public string Placa { get; set; }
        public string Modelo { get; set; }
        public Double Kml { get; set; }

        public AdicionarVeiculo(string placa, string modelo, double kml) {
            Placa = placa;
            Modelo = modelo;
            Kml = kml;
        }

    }
}
