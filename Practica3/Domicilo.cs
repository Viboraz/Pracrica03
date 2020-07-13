using System;
using System.Collections.Generic;
using System.Text;

namespace Practica03
{
    class Domicilio
    {
        // four fields:
        private string Calle;
        private string Poblacion;
        private string Provincia;
        private int CodigoPostal;
        private string Pais;

        // Constructor that takes two argument:
        public Domicilio(string Calle, string Poblacion, string Provincia, int CodigoPostal, string Pais)
        {
            this.Calle = Calle;
            this.Poblacion = Poblacion;
            this.Provincia = Provincia;
            this.CodigoPostal = CodigoPostal;
            this.Pais = Pais;
        }

        // methods, getters and setters:
        public void SetCalle(string Calle)
        {
            this.Calle = Calle;
        }
        public void SetPoblacion(string Poblacion)
        {
            this.Poblacion = Poblacion;
        }
        public void SetProvincia(string Provincia)
        {
            this.Provincia = Provincia;
        }
        public void SetCodigoPostal(int CodigoPostal)
        {
            this.CodigoPostal = CodigoPostal;
        }
        public void SetPais(string Pais)
        {
            this.Pais = Pais;
        }
        public string GetCalle()
        {
            return this.Calle;
        }
        public string GetPoblacion()
        {
            return this.Poblacion;
        }
        public string GetProvincia()
        {
            return this.Provincia;
        }
        public int GetCodigoPostal()
        {
            return this.CodigoPostal;
        }
        public string GetPais()
        {
            return this.Pais;
        }
        public void ChangeCalle(string newCalle)
        {
            this.Calle = newCalle;
        }
        public void ChangePoblacion(string newPoblacion)
        {
            this.Poblacion = newPoblacion;
        }
        public void ChangeProvincia(string newProvincia)
        {
            this.Provincia = newProvincia;
        }
        public void ChangeCodigoPostal(int newCodigoPostal)
        {
            this.CodigoPostal = newCodigoPostal;
        }
        public void ChangePais(string newPais)
        {
            this.Pais = newPais;
        }
    }
}