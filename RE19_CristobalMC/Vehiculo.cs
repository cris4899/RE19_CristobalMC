using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RE19_CristobalMC
{
    public class Vehiculo
    {
        // CONSTANTES
            // LIMITADORES
                // MARCA
        const byte MARCA_MIN = 3;
        const byte MARCA_MAX = 20;
                // MODELO
        const byte MODELO_MIN = 4;
        const byte MODELO_MAX = 25;
                // TIPO
        const string TIPO1 = "TURISMO";
        const string TIPO2 = "FURGONETA";
        const string TIPO3 = "CAMIÓN";
                // COMBUSTIBLE
        const string COMBUSTIBLE1 = "DISEL";
        const string COMBUSTIBLE2 = "GASOLINA";
        const string COMBUSTIBLE3 = "HIBRIDO";
        const string COMBUSTIBLE4 = "ELECTRICO";
                // ESTADO
        const string ESTADO1 = "NUEVO";
        const string ESTADO2 = "OCASION";
        const string ESTADO3 = "SEGUNDA MANO";
                // PRECIO
        const float PRECIO_MIN = 1000f;
        const float PRECIO_MAX = 10000f;
        const float DESCUENTO = 0.10f;
            // POR DEFECTO
        const string MARCA_DEF = "Desconocido";
        const string MODELO_DEF = "Desconocido";
        const string TIPO_VEHICULO_DEF = "TURISMO";
        const string COMBUSTIBLE_DEF = "DIESEL";
        const string ESTADO_DEF = "NUEVO";
        const float PRECIO_DEF = 0f;

        // MIEMBROS/CAMPO
        private string _marca;
        private string _modelo;
        private string _tipo;
        private string _combustible;
        private string _estado;
        private float _precio;
        private float _preciofinanciado;
        private string _matriculacion;

        #region CONSTRUCTORES
        public Vehiculo()
        {
            _marca = MARCA_DEF;
            _modelo = MODELO_DEF;
            _tipo = TIPO_VEHICULO_DEF;
            _combustible = COMBUSTIBLE_DEF;
            _estado = ESTADO_DEF;
            _precio = PRECIO_DEF;
        }
        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
            _tipo = TIPO_VEHICULO_DEF;
            _combustible = COMBUSTIBLE_DEF;
            _estado = ESTADO_DEF;
            _precio = PRECIO_DEF;
        }
        #endregion

        #region PROPIEDADES
        public string Marca
        {
            get
            {
                return _marca;
            }
            set
            {
                ValidarMarca(value);

                _marca = value;
            }
        }
        public string Modelo
        {
            get
            {
                return _modelo;
            }
            set
            {
                ValidarModelo(value);
                _modelo = value;
            }
        }
        public string Tipo
        {
            get
            {
                return _tipo;
            }
            set
            {
                ValidarTipo(value);
                _tipo = value;
            }
        }
        public string Combustible
        {
            get
            {
                return _combustible;
            }
            set
            {
                ValidarCombustible(value);
                _combustible = value;
            }
        }
        public string Estado
        {
            get
            {
                return _estado;
            }
            set
            {
                ValidarEstado(value);
                _estado = value;
            }
        }
        public float Precio
        {
            get
            {
                //if (_precio == PRECIO_DEF)
                    //throw new ArgumentException("Precio del producto no establecido");
                return _precio;
            }
            set
            {
                ValidarPrecio(value);
                _precio = value;
            }
        }
        public float PrecioFinanciado
        {
            get
            {
                _preciofinanciado = _precio + (_precio * DESCUENTO);
                return _preciofinanciado;
            }
        }
        public string Matriculacion
        {
            get
            {
                return _matriculacion;
            }
            set
            {
                ValidarMatriculacion(value);
                _matriculacion = value;
            }
        }
        #endregion

        #region MÉTODOS PRIVADOS
        private void ValidarMarca(string marca)
        {
            if (marca.Length < MARCA_MIN)
                throw new ArgumentException($"La marca del coche no puede ser inferior a {MARCA_MIN}");
            if (marca.Length > MARCA_MAX)
                throw new ArgumentException($"La marca del coche no puede ser superior a {MARCA_MAX}");

            byte indice = 0;
            for (indice = 0; indice < marca.Length; indice++)
            {
                if (Char.IsDigit(marca[indice]))
                {
                    throw new ArgumentException("La marca del coche no puede contener dígitos");
                }
                if (Char.IsSymbol(marca[indice]))
                {
                    throw new ArgumentException("La marca del coche no puede contener caracteres especiales");
                }
            }
        }
        private void ValidarModelo(string modelo)
        {
            if (modelo.Length < MARCA_MIN)
                throw new ArgumentException($"El modelo del coche no puede ser inferior a {MODELO_MIN}");
            if (modelo.Length > MARCA_MAX)
                throw new ArgumentException($"El modelo del coche no puede ser superior a {MODELO_MAX}");

            byte indice = 0;
            for (indice = 0; indice < modelo.Length; indice++)
            {
                if (Char.IsSymbol(modelo[indice]))
                {
                    throw new ArgumentException("El modelo no puede contener símbolos");
                }
            }
        }
        private void ValidarTipo(string tipo)
        {
            tipo.ToUpper();
            if (tipo != TIPO1| 
                tipo != TIPO2|
                tipo != TIPO3)
            throw new ArgumentException($"El tipo del vehículo tiene que ser {TIPO1} o {TIPO2} o {TIPO3}");
        }
        private void ValidarCombustible(string combustible)
        {
            combustible.ToUpper();
            if (combustible != COMBUSTIBLE1|
                combustible != COMBUSTIBLE2|
                combustible != COMBUSTIBLE3|
                combustible != COMBUSTIBLE4)
                throw new ArgumentException($"El combustible del vehículo tiene que ser:\n {COMBUSTIBLE1}\n{COMBUSTIBLE2}\n{COMBUSTIBLE3}\n{COMBUSTIBLE4}");
        }
        private void ValidarEstado(string estado)
        {
            estado.ToUpper();
            if (estado != ESTADO1|
                estado != ESTADO2|
                estado != ESTADO3)
                throw new ArgumentException($"El estado del vehículo tiene que ser {ESTADO1} o {ESTADO2} o {ESTADO3}");
        }
        private void ValidarPrecio(float precio)
        {
            if (precio < PRECIO_MIN)
            {
                throw new ArgumentException($"El precio mínimo del vehículo ha de ser: {PRECIO_MIN}");
            }
            if (precio > PRECIO_MAX)
            {
                throw new ArgumentException($"El precio máximo del vehículo ha de ser: {PRECIO_MAX}");
            }
        }
        // TODO: IMPLEMENTAR MATRICULACIÓN
        private void ValidarMatriculacion(string value)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region MÉTODOS PÚBLICOS

        #endregion
    }
}
