using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RE19V2_CristobalMC
{
public class Vehiculo
{
		// CONSTANTES
		const int TAM_MAX_MARCA = 20;
		const int TAM_MIN_MARCA = 3;
		const string MARCA_MODEL_DEF = "Desconocido";
		const int TAM_MAX_MODELO = 25;
		const int TAM_MIN_MODELO = 4;
		const string TIPOS_VEHICULOS = "TURISMO MOTO FURGONETA CAMIÓN";

		const float PRECIO_MIN = 1000f;
		const float PRECIO_MAX = 10000f;
		const float PRECIO_DEF = 0f;
		const float DESCUENTO = 0.1f;
		const int LIMITE_MATRICULACION = 10;
		// MIEMBROS / CAMPOS
		private string _marca;
		private string _modelo;
		private string _tipoVehiculo;
		private float _precioContado;
		private DateTime _fechaMatriculacion;
		// CONSTRUCTORES
		#region PROPIEDADES
		public string Marca
	{
		get
		{
				if (_marca == MARCA_MODEL_DEF)
				throw new Exception("ERROR: La marca del vehículo no se ha establecido");
			return _marca;
		}
		set
		{
				// Validación del dato a establecer
			ValidarDato(value, TAM_MAX_MARCA, TAM_MIN_MARCA);
				// TODO: Falta implementar la validación de dígitos y signos de puntuación
				ValidarEspecialMarca(value);
                _marca = value;
            }
        }
        public string Modelo
		{
			get {
				if (_modelo == MARCA_MODEL_DEF)
					throw new Exception("ERROR: Modelo del vehículo no establecido");
				return _modelo;}
			set {
				// Validación del dato a establecer
				ValidarDato(value, TAM_MAX_MODELO, TAM_MIN_MODELO);
				_modelo = value; }
		}
		public string TipoVehiculo
		{
			get
			{

				return _tipoVehiculo;
			}
			set
			{
				// Valdación del Tipo de Vehículo
				value = value.ToUpper();
				if (!TIPOS_VEHICULOS.Contains(value))
					throw new Exception("ERROR: No ha introducido un tipo de vehículo válido");
				_tipoVehiculo = value;
			}
		}
		public float PrecioContado
		{
			get
			{
				if (_precioContado == PRECIO_DEF)
					throw new Exception("ERROR: El precio del vehículo no se ha establecido");
				return _precioContado;
			}
			set
			{
				ValidarPrecio(value);
				_precioContado = value;
			}
		}
		public float PrecioFinanciado
		{
			get
			{
				return CalcularPrecioFinanciado();
			}
		}
		public DateTime FechaMatriculacion
		{
			get
			{
				return _fechaMatriculacion;
			}
			set
			{
				// Validación fecha Matriculación
				ValidarFechaMatriculacion(value);
                _fechaMatriculacion = value;
			}
		}
        #endregion
        #region MÉTODOS PRIVADOS
        // TODO: Implementación de ValidarMarca
        private void ValidarDato(string dato, int tamMax, int tamMin)
        {
			// 1.- Nulo o Vacío
			if (string.IsNullOrEmpty(dato))
				throw new Exception("ERROR: No se ha introducido el dato");
			// 2.- Tamaño
			if (dato.Length < tamMin || dato.Length > tamMax)
				throw new Exception("ERROR: Tamaño de la cadena incorrecto");
			// 3.- Caracteres Especiales
			for (int i = 0; i < dato.Length; i++)
			{
				if (char.IsSymbol(dato[i]))
					throw new Exception("ERROR: El dato contiene símbolos");
			}
        }
        private void ValidarEspecialMarca(string marca)
        {
            for (int i = 0; i < marca.Length; i++)
			{
				if (Char.IsDigit(marca[i]))
					throw new Exception("ERROR: Caracteres no permitidos");
				if (Char.IsPunctuation(marca[i]))
					throw new Exception("ERROR: No puede haber puntos");
			}
        }
        private void ValidarPrecio(float precio)
        {
            if (precio < PRECIO_MIN)
                throw new Exception($"ERROR: El precio no puede ser menor que {PRECIO_MIN}");
            if (precio > PRECIO_MAX)
                throw new Exception($"Error: El precio no puede ser mayor que {PRECIO_MAX}");
        }
        private void ValidarFechaMatriculacion(DateTime fecha)
        {
			// RECURSOS
			DateTime fechaActual = DateTime.Today;

			// 0.- Comprobar el parámetro
			//if (fecha == null)
			//	throw new Exception("ERROR: No se ha establecido una fecha ");
			// Nunca se ejecutará el throw porque un DateTime nunca será nulo
			// 1.- Fecha posterior a la actual
			if (fechaActual < fecha)
				throw new Exception("El coche no se ha podido matricular en el futuro");

			// 2.- Coche con una matriculación con un límite establecido
			fechaActual = fechaActual.AddYears(-LIMITE_MATRICULACION);
			if (fechaActual > fecha)
				throw new Exception($"ERROR: El coche tiene más de {LIMITE_MATRICULACION} años");

        }
        #endregion
        #region MÉTODOS PÚBLICOS
        public float CalcularPrecioFinanciado()
		{
			float precioF;
			precioF = PrecioContado - PrecioContado * DESCUENTO;
			return precioF;
		}
        #endregion
	}
}
